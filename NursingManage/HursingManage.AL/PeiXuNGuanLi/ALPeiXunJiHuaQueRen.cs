using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;
using Framework.Common;
using Framework;
using Framework.Common.Helpers;

namespace HursingManage.AL.PeiXuNGuanLi
{
    public class ALPeiXunJiHuaQueRen : ALBase
    {
        public DataTable GetDataByJiHua(string shiFouQueRen, string searchValue)
        {
            var query = DB.CreateQueryCondition<V_PEIXUNJIHUA_KESHI>();
            if (IsHuShiZhangLogin)
            {
                query.WhereAnd(s => s.KESHIID == CurrentLoginUser.KESHIID);
            }
            if (!string.IsNullOrWhiteSpace(shiFouQueRen))
            {
                query.WhereAnd(s => s.SHIFOUQUEREN == shiFouQueRen);
            }
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                searchValue = string.Format("%{0}%", searchValue);
                query.WhereOr(s => s.WEx_Like(s.NEIRONG, searchValue));
            }
            query.OrderBy(s => s.KESHI).OrderBy(s => s.ADDTIME, EmOrderByType.Desc);
            var ret = DB.QueryWhere<V_PEIXUNJIHUA_KESHI>(query);
            return ret.ToDataTable();
        }
        public DataTable GetDataByRenYuan(V_PEIXUNJIHUA_KESHI jiHuaKeShiModel, T_PEIXUNJIHUA_MUBAN jiHuaMuBanModel, string serValue)
        {
            var query = DB.CreateQueryCondition<V_PEIXUNJIHUA_MINGXI>();
            query.WhereAnd(s => s.JIHUAID == jiHuaKeShiModel.JIHUAID && s.KESHIID == jiHuaKeShiModel.KESHIID);
            if (jiHuaMuBanModel != null)
            {
                query.WhereAnd(s => s.MUBANID == jiHuaMuBanModel.MUBANID);
            }
            if (!string.IsNullOrWhiteSpace(serValue))
            {
                serValue = string.Format("%{0}%", serValue);
                query.WhereAnd(s =>
                    s.WEx_Like(s.XINGMING, serValue) ||
                    s.WEx_Like(s.XINGMING_PY, serValue) ||
                    s.WEx_Like(s.BIANHAO, serValue));
            }
            query.OrderBy(s => s.BIANHAO);
            var ret = DB.QueryWhere<V_PEIXUNJIHUA_MINGXI>(query);
            return ret.ToDataTable();
        }
        /// <summary>
        /// 属于只当计划的人员，在线考试未分配模板的人员明细
        /// </summary>
        public DataTable GetDataByRenYuan(V_PEIXUNJIHUA_KESHI jiHuaKeShiModel, string serValue)
        {
            return GetDataByRenYuan(jiHuaKeShiModel, null, serValue);
        }
        public DataTable GetDataByAddRenYuan(V_PEIXUNJIHUA_KESHI model)
        {
            var sql = DB.CreateSqlBuilder();
            sql.AddSQLText(" {0}={1} and {2}={3} and ID not in (select {4} from T_PeiXunJihua_MingXi where {5} = {6})",
                T_DANGAN.CNISDEL, sql.AddParam(0),
                T_DANGAN.CNKESHIID, sql.AddParam(model.KESHIID),
                T_PEIXUNJIHUA_MINGXI.CNRENYUANID,
                T_PEIXUNJIHUA_MINGXI.CNJIHUAID, sql.AddParam(model.JIHUAID));
            var ret = DB.QueryWhere<T_DANGAN>(sql);
            return ret.ToDataTable();
        }
        /// <summary>
        /// 增加人员到培训计划
        /// </summary>
        public bool AddRenYuanToJiHua(V_PEIXUNJIHUA_KESHI jiHuaKeShiModel, T_PEIXUNJIHUA_MUBAN muBanModel, List<T_DANGAN> dangAnList, out string msg)
        {
            try
            {
                DB.TransStart();
                foreach (var dangAnModel in dangAnList)
                {
                    T_PEIXUNJIHUA_MINGXI model = new T_PEIXUNJIHUA_MINGXI();
                    model.KESHIID = jiHuaKeShiModel.KESHIID;
                    model.RENYUANID = dangAnModel.ID;
                    model.JIHUAID = jiHuaKeShiModel.JIHUAID;
                    if (muBanModel != null)
                    {
                        model.JIHUAMUBANID = muBanModel.ID;
                        model.MUBAN = muBanModel.MUBAN;
                        model.MUBANID = muBanModel.MUBANID; //可以获得考题
                        model.KAOHAO = StringHelper.GetRoamdNumberStr(dangAnModel.BIANHAO, 7);
                    }
                    DB.Insert(model);
                }
                msg = string.Format("确认计划完成，共计增加人员：{0} 个", dangAnList.Count);
                DB.TransCommit();
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.LogObj.Error("导入培训计划人员时发生异常", ex);
                DB.TransRollback();
                msg = ex.Message;
                return false;
            }
        }
        /// <summary>
        /// 添加人员到计划（在线考试，无模板）
        /// </summary>
        public bool AddRenYuanToJiHua(V_PEIXUNJIHUA_KESHI jiHuaKeShiModel, List<T_DANGAN> dangAnList, out string msg)
        {
            return AddRenYuanToJiHua(jiHuaKeShiModel, null, dangAnList, out msg);
        }

        public bool RemoveJiaHuaRenYuan(V_PEIXUNJIHUA_MINGXI model, out string errMsg)
        {
            if (model.DATIBIAOZHI == "是")
            {
                errMsg = "该人员已经评分不允许移除";
                return false;
            }
            DB.Delete<T_PEIXUNJIHUA_MINGXI>(s => s.ID == model.ID);
            errMsg = null;
            return true;
        }

        public List<T_PEIXUNJIHUA_MUBAN> GetJiHuaMuBanData(V_PEIXUNJIHUA_KESHI model)
        {
            var query = DB.QueryWhere<T_PEIXUNJIHUA_MUBAN>(s => s.JIHUAID == model.JIHUAID);
            return query.ToList();
        }

        public bool JiHuaQueRen(V_PEIXUNJIHUA_KESHI jiHusKeShi, out string errMsg)
        {
            if (jiHusKeShi.SHIFOUQUEREN == "是")
            {
                errMsg = "该计划已确认，无需确认。";
                return false;
            }
            var queryExist = DB.CreateQueryCondition<T_PEIXUNJIHUA_MINGXI_WEIKAO>();
            queryExist.WhereAnd(s => s.KESHIID == jiHusKeShi.KESHIID && s.JIHUAID == jiHusKeShi.JIHUAID);
            queryExist.WhereAnd(s => s.YUANYIN == null || s.YUANYIN == "");
            if (DB.QueryExist<T_PEIXUNJIHUA_MINGXI_WEIKAO>(queryExist))
            {
                errMsg = "未考人员未全部填写原因。";
                return false;
            }
            var sqlBuilder = DB.CreateSqlBuilder();
            sqlBuilder.AddSQLText("select count(1) from T_PeiXunJiHua_MuBan where JiHuaId = {0} and Id not in (select JiHuaMuBanId from T_Peixunjihua_Mingxi where JiHuaId={0})",
                sqlBuilder.AddParam(jiHusKeShi.JIHUAID));
            var query = DB.QueryWhereScalar(sqlBuilder);
            var weiQueRenShu = query.ToObject<int>(); //未确认数
            T_PEIXUNJIHUA_KESHI jiHuaKeShi = new T_PEIXUNJIHUA_KESHI();
            jiHuaKeShi.ID = jiHusKeShi.ID;
            //加入判断未考人数必须填写原因说明，否则不允许确认；
            if (weiQueRenShu == 0)
            {
                jiHuaKeShi.QUERENREN = CurrentLoginUser.USER_NAME;
                jiHuaKeShi.QUERENRENID = CurrentLoginUser.ID;
                jiHuaKeShi.QUERENSHIJIAN = GetNowTime();
                jiHuaKeShi.SHIFOUQUEREN = "是";
                jiHuaKeShi.BEIZHU = "已确认";
                DB.Update(jiHuaKeShi);
                errMsg = null;
                return true;
            }
            else
            {
                jiHuaKeShi.BEIZHU = string.Format("未确认模板数：{0}", weiQueRenShu);
                errMsg = string.Format("{0}个试题模板未添加人员", weiQueRenShu);
                return false;
            }
        }

        public bool QuXiaoQuRen(V_PEIXUNJIHUA_KESHI JiHuaKeShiModel, out string errMsg)
        {
            T_PEIXUNJIHUA_KESHI jiHuaKeShi = new T_PEIXUNJIHUA_KESHI();
            jiHuaKeShi.ID = JiHuaKeShiModel.ID;
            jiHuaKeShi.SHIFOUQUEREN = "否";
            jiHuaKeShi.QUERENRENID = null;
            jiHuaKeShi.QUERENREN = string.Empty;
            DB.Update(jiHuaKeShi);
            errMsg = null;
            return true;
        }

        public bool ChangeJiaHuaRenYuan(T_PEIXUNJIHUA_MINGXI renYuan, T_PEIXUNJIHUA_MUBAN newMuBan, out string errMsg)
        {
            if (renYuan.MUBANID == newMuBan.MUBANID)
            {
                errMsg = "原模板与要更改的模板相同，修改取消。";
                return false;
            }
            renYuan.ClearChangedState();
            renYuan.MUBANID = newMuBan.MUBANID;
            renYuan.MUBAN = newMuBan.MUBAN;
            if (renYuan.DATIBIAOZHI == "是")
            {
                return ALShiTiPingFen.ChongXinPingFen(renYuan, out errMsg);
            }
            else
            {
                DB.Update(renYuan);
                errMsg = null;
                return true;
            }
        }
    }
}