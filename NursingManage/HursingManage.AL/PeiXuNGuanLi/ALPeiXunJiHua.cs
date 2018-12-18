using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;
using Framework.Common;

namespace HursingManage.AL.PeiXuNGuanLi
{
    public class ALPeiXunJiHua : ALBase
    {
        bool VerifyModel(T_PEIXUNJIHUA model, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(model.NEIRONG))
            {
                errMsg = "培训内容不能为空。";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.CANJIARENYUAN))
            {
                errMsg = "参加人员描述不能为空。";
                return false;
            }
            errMsg = null;
            return true;
        }
        public bool Add(T_PEIXUNJIHUA model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }

            model.CHUANGJIANREN = CurrentLoginUser.USER_NAME;
            DB.Insert(model);
            return true;
        }
        public bool Update(T_PEIXUNJIHUA model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            DB.Update(model);
            errMsg = null;
            return true;
        }
        public bool Delete(T_PEIXUNJIHUA model, out string errMsg)
        {
            if (ShiFouQueRen(model.ID))
            {
                errMsg = "该计划已经被确认，不允许删除";
                return false;
            }
            DB.Delete(model);
            errMsg = null;
            return true;
        }
        public DataTable GetData(string searchValue)
        {
            var query = DB.CreateQueryCondition<T_PEIXUNJIHUA>();
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                searchValue = string.Format("%{0}%", searchValue);
                query.WhereAnd(s =>
                    s.WEx_Like(s.NEIRONG, searchValue)
                    );
            }
            query.OrderBy(s => s.ADDTIME, Framework.EmOrderByType.Desc);
            var ret = DB.QueryWhere<T_PEIXUNJIHUA>(query);
            return ret.ToDataTable();
        }

        public bool ShiFouQueRen(string jiHuaId)
        {
            bool r = DB.QueryExist<T_PEIXUNJIHUA_KESHI>(s => s.JIHUAID == jiHuaId && s.SHIFOUQUEREN == "是");
            return r;
        }

        public DataTable GetXuanZeMuBanData(T_PEIXUNJIHUA jiHuaModel)
        {
            var sql = DB.CreateSqlBuilder();
            sql.AddSQLText(@"Id not in ( select {0} from T_PEIXUNJIHUA_MUBAN  where JiHuaid = {1} )",
                T_PEIXUNJIHUA_MUBAN.CNMUBANID, sql.AddParam(jiHuaModel.ID));
            var ret = DB.QueryWhere<T_SHITI_MUBAN>(sql);
            return ret.ToDataTable();
        }
        public bool YiChuMuBan(T_PEIXUNJIHUA_MUBAN jiHuaMuBanModel, out string errMsg)
        {
            if (ShiFouQueRen(jiHuaMuBanModel.JIHUAID))
            {
                errMsg = "该计划已经被确认，不允许移除模板";
                return false;
            }
            DB.Delete<T_PEIXUNJIHUA_MUBAN>(jiHuaMuBanModel);
            errMsg = null;
            return true;
        }
        public bool SaveMuBanToJiHua(T_PEIXUNJIHUA jiHuaModel, List<T_SHITI_MUBAN> muBanList, out string errMsg)
        {
            foreach (var item in muBanList)
            {
                T_PEIXUNJIHUA_MUBAN peiXunMuBan = new T_PEIXUNJIHUA_MUBAN();
                peiXunMuBan.JIHUAID = jiHuaModel.ID;
                peiXunMuBan.MUBAN = item.MINGCHENG;
                peiXunMuBan.MUBANID = item.ID;
                DB.Insert(peiXunMuBan);
            }
            errMsg = null;
            return true;
        }
        public DataTable GetMuBanData(T_PEIXUNJIHUA jiHuaModel)
        {
            var query = DB.QueryWhere<V_PEIXUNJIHUA_MUBAN>(s => s.JIHUAID == jiHuaModel.ID);
            return query.ToDataTable();
        }

        public DataTable GetPeiXunKeShiData(T_PEIXUNJIHUA jiHuaModel)
        {
            var query = DB.QueryWhere<T_PEIXUNJIHUA_KESHI>(s => s.JIHUAID == jiHuaModel.ID);
            return query.ToDataTable();
        }
        public bool SaveKeShiToJiHua(T_PEIXUNJIHUA jiHuaModel, List<T_KESHI> keShiList, out string errMsg)
        {
            foreach (var item in keShiList)
            {
                T_PEIXUNJIHUA_KESHI jiHuaKeShi = new T_PEIXUNJIHUA_KESHI();
                jiHuaKeShi.JIHUAID = jiHuaModel.ID;
                jiHuaKeShi.KESHI = item.MINGCHENG;
                jiHuaKeShi.KESHIID = item.ID;
                DB.Insert(jiHuaKeShi);
            }
            errMsg = null;
            return true;
        }
        public bool YiChuKeShi(T_PEIXUNJIHUA_KESHI keShiModel, out string errMsg)
        {
            //if (ShiFouQueRen(keShiModel.JIHUAID))
            //{
            //    errMsg = "该计划已经被确认，不允许移除科室";
            //    return false;
            //}
            if (DB.QueryExist<V_PEIXUNJIHUA_MINGXI>(s => s.KESHIID == keShiModel.KESHIID && s.JIHUAID == keShiModel.JIHUAID))
            {
                errMsg = "当前计划中的的科室已经添加人员，请先移除人员后再移除科室。";
                return false;
            }
            DB.Delete(keShiModel);
            errMsg = null;
            return true;
        }

        public List<T_KESHI> GetXuanZeKeShiData(T_PEIXUNJIHUA jiHuaModel)
        {
            var sql = DB.CreateSqlBuilder();
            sql.AddSQLText(@"Id not in ( select {0} from T_PEIXUNJIHUA_KESHI  where JiHuaid = {1} )",
                T_PEIXUNJIHUA_KESHI.CNKESHIID, sql.AddParam(jiHuaModel.ID));
            var ret = DB.QueryWhere<T_KESHI>(sql);
            return ret.ToList();
        }

        public bool KaiQiKaoShi(T_PEIXUNJIHUA_MUBAN muBanModel, out string errMsg)
        {
            muBanModel.ClearChangedState();
            muBanModel.KAIQIKAOSHI = "是";
            DB.Update(muBanModel);
            errMsg = null;
            return true;
        }

        public bool GuanBiKaoShi(T_PEIXUNJIHUA_MUBAN muBanModel, out string errMsg)
        {
            muBanModel.ClearChangedState();
            muBanModel.KAIQIKAOSHI = "否";
            DB.Update(muBanModel);
            errMsg = null;
            return true;
        }
    }
}