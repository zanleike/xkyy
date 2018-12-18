using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HursingManage.DBModel;

namespace HursingManage.AL.ZhiLiangKongZhi
{
    public class ALZhiKongJianCha : ALBase
    {
        /// <summary>
        /// get V_ZHIKONGJIHUA_KESHI data
        /// </summary>
        public DataTable GetDataByJiHua(string serValue, bool isJianChaQueRen = false)
        {
            var query = DB.CreateQueryCondition<V_ZHIKONGJIHUA_KESHI>();
            if (isJianChaQueRen)
            {
                if (!IsHuLiBuLogin && !IsAdminLogin)
                {
                    query.WhereAnd(s => s.KESHIID == CurrentLoginUser.KESHIID);
                }
            }
            if (!string.IsNullOrWhiteSpace(serValue))
            {
                serValue = string.Format("%{0}%", serValue);
                query.WhereAnd(s =>
                    s.WEx_Like(s.JIHUAMINGCHENG, serValue) ||
                    s.WEx_Like(s.KESHI, serValue)
                    );
            }
            query.OrderBy(s => s.ADDTIME, Framework.EmOrderByType.Desc);
            var result = DB.QueryWhere<V_ZHIKONGJIHUA_KESHI>(query);
            return result.ToDataTable();
        }
        bool VerifyModel(T_ZHIKONGJIHUA_KESHI model, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(model.JIANCHARENYUAN))
            {
                errMsg = "检查人员不能为空。";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.JIANCHAKAISHISHIJIAN))
            {
                errMsg = "检查开始时间不能为空。";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.JIANCHAJIESHUSHIJIAN))
            {
                errMsg = "检查结束时间不能为空。";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.GAIJINSHIJIAN_XIANQI))
            {
                errMsg = "限制整改时间不能为空。";
                return false;
            }
            errMsg = null;
            return true;
        }
        public T_ZHIKONGJIHUA_KESHI GetJiHuaKeShiData(string id)
        {
            var query = DB.QueryWhere<T_ZHIKONGJIHUA_KESHI>(s => s.ID == id);
            return query.ToEntity();
        }
        public bool JianChaChuangJian(T_ZHIKONGJIHUA_KESHI model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            model.SHIFOUJIANCHA = "是";
            var q = DB.QuerySum<T_ZHIKONGJIHUA_NEIRONG>(s => s.BIAOZHUNSHU, s => s.JIHUAID == model.JIHUAID);
            model.BIAOZHUNSHU = q.ToObject<int>();
            V_ZHIKONGJIHUA_KESHI vModel = new V_ZHIKONGJIHUA_KESHI();
            vModel.KESHIID = model.KESHIID;

            model.WENTISHU = GetWenTiShu(model.JIHUAID, model.KESHIID);
            DB.Update(model);
            return true;
        }
        /// <summary>
        /// get T_ZHIKONGJIHUA_JIEGUO data
        /// </summary>
        public List<T_ZHIKONGJIHUA_JIEGUO> GetJieGuoData(V_ZHIKONGJIHUA_KESHI model)
        {
            var query = DB.QueryWhere<T_ZHIKONGJIHUA_JIEGUO>(s => s.JIHUAID == model.JIHUAID && s.KESHIID == model.KESHIID);
            return query.ToList();
        }
        public List<T_ZHILIANGBIAOZHUN> GetBiaoZhunData(V_ZHIKONGJIHUA_KESHI model)
        {
            var sqlBuilder = DB.CreateSqlBuilder();
            sqlBuilder.AddSQLText(@"LeiBieId in (
select BiaoZhunLeiBieId from T_ZHIKONGJIHUA_NEIRONG where JiHuaId={0} 
 ) and Id not in (select BiaoZhunid from T_ZhiKongJihua_JieGuo where JiHuaId={1}  and KeShiId = {2}) 
and LeiBieId in (select LeiBieId from T_ZhiLiangBiaoZhun_QuanXian where RenYuanId = {3} )"
            , sqlBuilder.AddParam(model.JIHUAID),
            sqlBuilder.AddParam(model.JIHUAID),
            sqlBuilder.AddParam(model.KESHIID),
            sqlBuilder.AddParam(CurrentLoginUser.ID));
            var query = DB.QueryWhere<T_ZHILIANGBIAOZHUN>(sqlBuilder);
            return query.ToList();
        }
        /// <summary>
        /// 获得 问题数
        /// </summary>
        public int GetWenTiShu(string jiHuaid, string keShiId)
        {
            var q = DB.QueryCount<T_ZHIKONGJIHUA_JIEGUO>(s => s.JIHUAID == jiHuaid && s.KESHIID == keShiId);
            int r = q.ToObject<int>();
            return r;
        }
        /// <summary>
        /// 更新问题数
        /// </summary>
        public void GengXinWenTiShu(V_ZHIKONGJIHUA_KESHI jiHuaModel)
        {
            T_ZHIKONGJIHUA_KESHI jiHuaKeShiModel = new T_ZHIKONGJIHUA_KESHI();
            jiHuaKeShiModel.ID = jiHuaModel.ID;
            jiHuaKeShiModel.WENTISHU = GetWenTiShu(jiHuaModel.JIHUAID, jiHuaModel.KESHIID);
            DB.Update(jiHuaKeShiModel);
        }
        /// <summary>
        /// 保存问题项，并更新问题数
        /// </summary>
        public bool BaoCunWenTiXiang(V_ZHIKONGJIHUA_KESHI jiHuaModel, List<T_ZHILIANGBIAOZHUN> wenTiXiang, out string errMsg)
        {
            //DB.Delete<T_ZHIKONGJIHUA_JIEGUO>(s => s.JIHUAID == jiHuaModel.JIHUAID && s.KESHIID == jiHuaModel.KESHIID);
            foreach (var jieGuo in wenTiXiang)
            {
                T_ZHIKONGJIHUA_JIEGUO model = new T_ZHIKONGJIHUA_JIEGUO();
                model.JIHUAID = jiHuaModel.JIHUAID;
                model.KESHIID = jiHuaModel.KESHIID;
                model.KESHI = jiHuaModel.KESHI;
                model.LEIXING1 = jieGuo.LEIXING1;
                model.LEIXING2 = jieGuo.LEIXING2;
                //model.NEIRONGID = jieGuo.ID; //没用
                model.BIAOZHUNID = jieGuo.ID;
                model.BIAOZHUN = jieGuo.NEIRONG;
                model.BIAOZHUNLEIBIE = jieGuo.LEIBIE;
                model.BIAOZHUNLEIBIEID = jieGuo.LEIBIEID;
                model.OPERATOR = CurrentLoginUser.USER_NAME;
                DB.Insert(model);
            }
            GengXinWenTiShu(jiHuaModel);
            errMsg = null;
            return true;
        }
        /// <summary>
        /// 保存问题项说明
        /// </summary>
        public bool BaoCunWenTiXiangShuoMing(T_ZHIKONGJIHUA_JIEGUO jieGuoModel, out string errMsg)
        {
            jieGuoModel.ClearChangedState();
            jieGuoModel.SetFieldChanged(T_ZHIKONGJIHUA_JIEGUO.CNJIANCHAJIEGUO);
            DB.Update(jieGuoModel);
            errMsg = null;
            return true;
        }
        /// <summary>
        /// 移除问题项，并更新问题数
        /// </summary>
        public bool YiChuWenTi(V_ZHIKONGJIHUA_KESHI jiHuaModel, T_ZHIKONGJIHUA_JIEGUO jieGuo, out string errMsg)
        {
            if (DB.QueryExist<T_ZHIKONGJIHUA_NEIRONG>(s =>
                s.JIHUAID == jieGuo.JIHUAID &&
                s.BIAOZHUNLEIBIEID == jieGuo.BIAOZHUNLEIBIEID &&
                s.KESHIID == jieGuo.KESHIID && s.SHIFOUJIANCHA == "是"))
            {
                errMsg = "当前检查项目已经确认，请先取消确认后再移除；";
                return false;
            }
            DB.Delete(jieGuo);
            GengXinWenTiShu(jiHuaModel);
            errMsg = null;
            return true;
        }
        /// <summary>
        /// 统计合格率查询
        /// </summary>
        public List<V_ZHIKONGJIHUA_NEIRONG> GetJiHuaNeiRong(V_ZHIKONGJIHUA_KESHI jiHuaModel)
        {
            var query = DB.QueryWhere<V_ZHIKONGJIHUA_NEIRONG>(s => s.JIHUAID == jiHuaModel.JIHUAID && s.KESHIID == jiHuaModel.KESHIID);
            return query.ToList();
        }
        /// <summary>
        /// 质控检查科室确认
        /// </summary>
        public bool SaveJianChaShuoMing(V_ZHIKONGJIHUA_KESHI vModel, out string errMsg)
        {
            if (vModel.KESHIID != CurrentLoginUser.KESHIID)
            {
                errMsg = "非本科室用户不能确认。";
                return false;
            }
            T_ZHIKONGJIHUA_KESHI model = new T_ZHIKONGJIHUA_KESHI();
            model.ID = vModel.ID;
            model.GAIJINSHUOMING = vModel.GAIJINSHUOMING;
            model.YUANYINFENXI = vModel.YUANYINFENXI;
            model.ZHENGGAIQINGKUANG = vModel.ZHENGGAIQINGKUANG;
            model.QUERENSHIJIAN = GetNowTime();
            model.GAIJINSHIJIAN = GetNowTime();
            model.GAIJINSHANGBAOREN = CurrentLoginUser.USER_NAME;
            model.SHIFOUQUEREN = "是";
            DB.Update(model);
            errMsg = null;
            return true;
        }
        /// <summary>
        /// 获取检查人员列表，T_User_Info
        /// </summary>
        public DataTable GetJianChaRenYuan()
        {
            var sql = DB.CreateSqlBuilder();
            sql.AddSQLText(" Role_Id in (select DictValue from T_Dictionary where DictType ='1001' )");
            var result = DB.QueryWhere<T_USER_INFO>(sql);
            return result.ToDataTable();
        }
        /// <summary>
        /// 获取检查结果内容，赋值 问题数，合格率；
        /// </summary>
        /// <returns></returns>
        public V_ZHIKONGJIHUA_NEIRONG GetJianChaJieGuo(V_ZHIKONGJIHUA_NEIRONG model)
        {
            var wenTiShu = DB.QueryCount<T_ZHIKONGJIHUA_JIEGUO>(s => s.JIHUAID == model.JIHUAID && s.KESHIID == model.KESHIID && s.BIAOZHUNLEIBIEID == model.BIAOZHUNLEIBIEID);
            model.WENTISHU = wenTiShu.ToObject<int>();
            if (model.BIAOZHUNSHU != 0)
            {
                model.HEGELV = Math.Round((1 - model.WENTISHU / model.BIAOZHUNSHU) * 100, 2);
            }
            return model;
        }
        /// <summary>
        /// 检查项目确认
        /// </summary>
        public bool JianChaNeiRongQueRen(T_ZHIKONGJIHUA_NEIRONG model, out string errMsg)
        {
            if (!DB.QueryExist<T_ZHILIANGBIAOZHUN_QUANXIAN>(s => s.LEIBIEID == model.BIAOZHUNLEIBIEID && s.RENYUANID == CurrentLoginUser.ID))
            {
                errMsg = string.Format("当前操作员无操作【{0}】的权限。", model.BIAOZHUNLEIBIE);
                return false;
            }
            model.ClearChangedState();
            model.SHIFOUJIANCHA = "是";            
            model.JIANCHARENID = CurrentLoginUser.ID;
            model.JIANCHASHIJIAN = GetNowTime();
            var wenTiShu = DB.QueryCount<T_ZHIKONGJIHUA_JIEGUO>(s => s.JIHUAID == model.JIHUAID && s.KESHIID == model.KESHIID && s.BIAOZHUNLEIBIEID == model.BIAOZHUNLEIBIEID);
            model.WENTISHU = wenTiShu.ToObject<int>();
            if (model.BIAOZHUNSHU != 0)
            {
                model.HEGELV = Math.Round((1 - model.WENTISHU / model.BIAOZHUNSHU) * 100, 2);
            }
            model.SetFieldChanged(T_ZHIKONGJIHUA_NEIRONG.CNJIANCHAREN);
            
            //model.JIANCHAREN = CurrentLoginUser.USER_NAME;
            //var wenTiShu = DB.QueryCount<T_ZHIKONGJIHUA_JIEGUO>(s => s.JIHUAID == model.JIHUAID && s.KESHIID == model.KESHIID && s.BIAOZHUNLEIBIEID == model.BIAOZHUNLEIBIEID);
            //model.WENTISHU = wenTiShu.ToObject<int>();
            //if (model.BIAOZHUNSHU != 0)
            //{
            //    model.HEGELV = Math.Round((1 - model.WENTISHU / model.BIAOZHUNSHU) * 100, 2);
            //}
            DB.Update(model);
            errMsg = null;
            return true;
        }
        /// <summary>
        /// 检查项目确认-取消
        /// </summary>
        public bool JianChaNeiRongQueRenQuXiao(T_ZHIKONGJIHUA_NEIRONG model, out string errMsg)
        {
            if (model.JIANCHARENID != CurrentLoginUser.ID)
            {
                errMsg = "只能取消当前操作员的检查项目。";
                return false;
            }
            if (DB.QueryExist<T_ZHIKONGJIHUA_KESHI>(s => s.KESHIID == model.KESHIID && s.JIHUAID == model.JIHUAID && (s.SHIFOUJIANCHA == "是" || s.SHIFOUQUEREN == "是")))
            {
                errMsg = "当前检查项目计划已经确认，不允许取消";
                return false;
            }
            model.SHIFOUJIANCHA = "否";
            model.JIANCHAREN = string.Empty;
            model.JIANCHARENID = string.Empty;
            model.WENTISHU = 0;
            model.HEGELV = 0;

            DB.Update(model);
            errMsg = null;
            return true;
        }

        public bool JiHuaQenRenQuXiao(V_ZHIKONGJIHUA_KESHI model, out string errMsg)
        {
            var query = DB.QueryWhere<T_ZHIKONGJIHUA_KESHI>(s => s.KESHIID == model.KESHIID && s.JIHUAID == model.JIHUAID);
            T_ZHIKONGJIHUA_KESHI upModel = query.ToEntity();
            if (upModel.SHIFOUQUEREN == "是")
            {
                errMsg = "当前计划科室已经确认，不允许取消。";
                return false;
            }
            upModel.JIANCHARENYUAN = string.Empty;
            upModel.GAIJINSHIJIAN_XIANQI = string.Empty;
            upModel.SHIFOUJIANCHA = "否";
            DB.Update(upModel);
            //T_ZHIKONGJIHUA_KESHI model = new T_ZHIKONGJIHUA_KESHI();
            //model.SHIFOUJIANCHA = "否";
            errMsg = null;
            return true;
        }
        public bool ManYiDuLuRu(V_ZHIKONGJIHUA_KESHI vModel, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(vModel.MANYIDUSHUOMING))
            {
                errMsg = "满意度调查结果不能为空。";
                return false;
            }
            T_ZHIKONGJIHUA_KESHI model = new T_ZHIKONGJIHUA_KESHI();
            model.ID = vModel.ID;
            model.MANYIDUSHUOMING = vModel.MANYIDUSHUOMING;
            DB.Update(model);
            errMsg = null;
            return true;
        }
    }
}