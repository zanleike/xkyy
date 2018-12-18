using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using Framework.Common.Helpers;
using Framework.Common;
using System.Data;

namespace HursingManage.AL.ZhiLiangKongZhi
{
    public class ALZhiKongJiHua : ALBase
    {
        bool VerifyModel(T_ZHIKONGJIHUA model, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(model.MINGCHENG))
            {
                errMsg = "计划名称不能为空";
                return false;
            }
            if (model.SHIFOUFUCHA == "是" && string.IsNullOrWhiteSpace(model.FUCHAJIHUAID))
            {
                errMsg = "复查计划必须选择原计划";
                return false;
            }
            errMsg = null;
            return true;
        }
        public bool AddJiHua(T_ZHIKONGJIHUA model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            DB.Insert(model);
            return true;
        }
        public bool UpdateJiHua(T_ZHIKONGJIHUA model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            DB.Update(model);
            return true;
        }
        public bool DeleteJiHua(T_ZHIKONGJIHUA model, out string errMsg)
        {
            try
            {
                if (DB.QueryExist<T_ZHIKONGJIHUA_KESHI>(s => s.JIHUAID == model.ID && s.SHIFOUQUEREN == "是"))
                {
                    errMsg = "当前计划已有科室确认不允许删除。";
                    return false;
                }
                if (DB.QueryExist<T_ZHIKONGJIHUA_NEIRONG>(s => s.JIHUAID == model.ID && s.SHIFOUJIANCHA == "是"))
                {
                    errMsg = "当前计划已有内容已检查不允许删除。";
                    return false;
                }
                DB.TransStart();
                DB.Delete<T_ZHIKONGJIHUA_NEIRONG>(s => s.JIHUAID == model.ID);
                DB.Delete<T_ZHIKONGJIHUA_JIEGUO>(s => s.JIHUAID == model.ID);
                DB.Delete<T_ZHIKONGJIHUA_KESHI>(s => s.JIHUAID == model.ID);
                DB.Delete(model);
                DB.TransCommit();
                errMsg = null;
                return true;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                LogHelper.LogObj.Error("删除质控计划异常", ex);
                DB.TransRollback();
                return false;
            }
        }
        public DataTable GetDataByJiHua(string serValue)
        {
            var query = DB.CreateQueryCondition<T_ZHIKONGJIHUA>();
            if (!string.IsNullOrWhiteSpace(serValue))
            {
                serValue = string.Format("%{0}%", serValue);
                query.WhereAnd(s => s.WEx_Like(s.MINGCHENG, serValue));
            }
            query.OrderBy(s => s.ADDTIME, Framework.EmOrderByType.Desc);
            var result = DB.QueryWhere<T_ZHIKONGJIHUA>(query);
            return result.ToDataTable();
        }

        public DataTable GetDataByBiaoZhunLeiBie(T_ZHIKONGJIHUA jiHuaModel)
        {
            var sql = DB.CreateSqlBuilder();
            sql.AddSQLText(@" IsKeShiZhiKong=0 and Id not in ( select BIAOZHUNLEIBIEID from T_ZHIKONGJIHUA_NEIRONG where JIHUAID = {0})",
                sql.AddParam(jiHuaModel.ID));
            var ret = DB.QueryWhere<T_ZHILIANGBIAOZHUN_LEIBIE>(sql);
            return ret.ToDataTable();
        }
        public DataTable GetDataByNeiRong(T_ZHIKONGJIHUA model)
        {
            var query = DB.QueryWhere<V_ZHIKONGJIHUA_BIAOZHUN>(s => s.JIHUAID == model.ID);
            return query.ToDataTable();
        }
        public void DaoRuBiaoZhunLeiBie(T_ZHIKONGJIHUA jiHuaModel, List<T_ZHILIANGBIAOZHUN_LEIBIE> leiBieList)
        {
            //2017.6.1 T_ZHIKONGJIHUA_NEIRONG 包含科室信息，来适应单个标准来确定检查操作的需求
            foreach (var item in leiBieList)
            {
                var query = DB.QueryWhere<T_ZHIKONGJIHUA_KESHI>(s => s.JIHUAID == jiHuaModel.ID);
                var jiHuaKeShiList = query.ToList();
                foreach (var jiHuaKeShi in jiHuaKeShiList)
                {
                    T_ZHIKONGJIHUA_NEIRONG neiRong = new T_ZHIKONGJIHUA_NEIRONG();
                    neiRong.JIHUAID = jiHuaModel.ID;
                    neiRong.BIAOZHUNLEIBIE = item.MINGCHENG;
                    neiRong.BIAOZHUNLEIBIEID = item.ID;
                    neiRong.BIAOZHUNSHU = item.BIAOZHUNSHU;
                    neiRong.KESHIID = jiHuaKeShi.KESHIID;
                    DB.Insert(neiRong);
                }
            }
        }
        public bool YiChuNeiRong(V_ZHIKONGJIHUA_BIAOZHUN model, out string errMsg)
        {
            if (DB.QueryExist<T_ZHIKONGJIHUA_NEIRONG>(s => s.JIHUAID == model.JIHUAID && s.BIAOZHUNLEIBIEID == model.BIAOZHUNLEIBIEID && s.SHIFOUJIANCHA == "是"))
            {
                errMsg = "该标准类别已经检查不允许移除。";
                return false;
            }
            var query = DB.Delete<T_ZHIKONGJIHUA_NEIRONG>(s => s.BIAOZHUNLEIBIEID == model.BIAOZHUNLEIBIEID && s.JIHUAID == model.JIHUAID);
            WriteDBLog("移除质控计划内容,移除数：{0}", query.Count);
            errMsg = null;
            return true;
        }

        public List<T_KESHI> GetDataByKeShi(T_ZHIKONGJIHUA jiHuaModel)
        {
            var sql = DB.CreateSqlBuilder();
            sql.AddSQLText(@"Id not in ( select KESHIID from T_ZHIKONGJIHUA_KESHI where JIHUAID = {0}) order by LeiXing1,Leixing2",
                sql.AddParam(jiHuaModel.ID));
            var ret = DB.QueryWhere<T_KESHI>(sql);
            return ret.ToList();
        }
        public DataTable GetDataByJiHuakeShi(T_ZHIKONGJIHUA model)
        {
            var query = DB.QueryWhere<V_ZHIKONGJIHUA_KESHI>(s => s.JIHUAID == model.ID);
            return query.ToDataTable();
        }
        public void DaoRuJiHuaKeShi(T_ZHIKONGJIHUA jiHuaModel, List<T_KESHI> keShiList)
        {
            foreach (var item in keShiList)
            {
                T_ZHIKONGJIHUA_KESHI jiHuakeShi = new T_ZHIKONGJIHUA_KESHI();
                jiHuakeShi.JIHUAID = jiHuaModel.ID;
                jiHuakeShi.KESHI = item.MINGCHENG;
                jiHuakeShi.KESHIID = item.ID;
                jiHuakeShi.KESHILEIBIE = item.KESHILEIBIE;
                DB.Insert(jiHuakeShi);
                var query = DB.QueryWhere<V_ZHIKONGJIHUA_BIAOZHUN>(s => s.JIHUAID == jiHuaModel.ID);
                var biaoZhunList = query.ToList();
                if (biaoZhunList == null)
                {
                    continue;
                }
                foreach (var biaoZhunNeiRong in biaoZhunList)
                {
                    T_ZHIKONGJIHUA_NEIRONG neiRong = new T_ZHIKONGJIHUA_NEIRONG();
                    neiRong.BIAOZHUNLEIBIEID = biaoZhunNeiRong.BIAOZHUNLEIBIEID;
                    neiRong.BIAOZHUNLEIBIE = biaoZhunNeiRong.BIAOZHUNLEIBIE;
                    neiRong.BIAOZHUNSHU = biaoZhunNeiRong.BIAOZHUNSHU;
                    neiRong.KESHIID = item.ID;
                    neiRong.JIHUAID = jiHuaModel.ID;
                    DB.Insert(neiRong);
                }
            }
        }
        public bool YiChuJiHuaKeshi(T_ZHIKONGJIHUA_KESHI model, out string errMsg)
        {
            if (DB.QueryExist<T_ZHIKONGJIHUA_NEIRONG>(s => s.JIHUAID == model.JIHUAID && s.KESHIID == model.KESHIID && s.SHIFOUJIANCHA == "是"))
            {
                errMsg = "该科室已有确认项目不允许移除。";
                return false;
            }
            var query = DB.Delete<T_ZHIKONGJIHUA_NEIRONG>(s => s.JIHUAID == model.JIHUAID && s.KESHIID == model.KESHIID);
            WriteDBLog("移除质控计划科室内容,移除数：{0}", query.Count);
            DB.Delete(model);
            errMsg = null;
            return true;
        }
    }
}