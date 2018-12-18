using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HursingManage.DBModel;

namespace HursingManage.AL
{
    public class ALComboxListHelper : ALBase
    {
        public DataTable GetUserData(string searchValue, string keShiid = null)
        {
            var queryCond = DB.CreateQueryCondition<T_USER_INFO>();
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                searchValue = string.Format("%{0}%", searchValue);
                var query = queryCond.WhereAnd(s =>
                      s.WEx_Like(s.USER_NO, searchValue) ||
                      s.WEx_Like(s.USER_NAME, searchValue) ||
                      s.WEx_Like(s.USER_NAME_PY, searchValue));
            }
            if (!string.IsNullOrWhiteSpace(keShiid))
            {
                queryCond.WhereAnd(s => s.KESHIID == keShiid);
            }
            queryCond.OrderBy(s => s.USER_NO);
            queryCond.WhereAnd(s => s.ISDEL == 0);
            var r = DB.QueryWhere<T_USER_INFO>(queryCond);
            return r.ToDataTable();
        }

        public DataTable GetRoleData(string serValue)
        {
            serValue = string.Format("%{0}%", serValue);
            var query = DB.QueryWhere<T_ROLE>(s => s.WEx_Like(s.ROLE_NAME, serValue) || s.WEx_Like(s.ROLE_NAME_PY, serValue));
            return query.ToDataTable();
        }

        public DataTable GetKeShiData(string serValue)
        {
            serValue = string.Format("%{0}%", serValue);
            var query = DB.QueryWhere<T_KESHI>(s =>
                s.WEx_Like(s.MINGCHENG, serValue) ||
                s.WEx_Like(s.MINGCHENG_PY, serValue) ||
                s.WEx_Like(s.BIANMA, serValue)
                );
            return query.ToDataTable();
        }
        public DataTable GetDictData(DictType dictTypeEm, string serValue)
        {
            int dictType = (int)dictTypeEm;
            return GetDictData(dictType, serValue);
        }
        public DataTable GetDictData(int dictType, string serValue)
        {
            var queryCond = DB.CreateQueryCondition<T_DICTIONARY>();
            queryCond.WhereAnd(s => s.DICTTYPE == dictType && s.ISDELETE == 0);
            if (!string.IsNullOrWhiteSpace(serValue))
            {
                serValue = string.Format("%{0}%", serValue);
                queryCond.WhereAnd(s =>
                    s.WEx_Like(s.DICTVALUE, serValue) ||
                    s.WEx_Like(s.DICTVALUE_PY, serValue));
            }
            queryCond.OrderBy(s => s.DICTVALUEORDER);
            var dictQuery = DB.QueryWhere<T_DICTIONARY>(queryCond);
            return dictQuery.ToDataTable();
        }

        public DataTable GetShiTiLeiBieData(string serValue)
        {
            serValue = string.Format("%{0}%", serValue);
            var query = DB.CreateQueryCondition<T_SHITI_FENLEI>();
            query.WhereAnd(
                s =>
                s.WEx_Like(s.MINGCHENG, serValue) ||
                s.WEx_Like(s.MINGCHENG_PY, serValue)
                );
            query.OrderBy(s => s.ADDTIME, Framework.EmOrderByType.Desc);
            var ret = DB.QueryWhere<T_SHITI_FENLEI>(query);
            return ret.ToDataTable();
        }

        public DataTable GetShiTiMuBanData(string serValue)
        {
            var query = DB.CreateQueryCondition<T_SHITI_MUBAN>();

            if (!string.IsNullOrWhiteSpace(serValue))
            {
                serValue = string.Format("%{0}%", serValue);
                query.WhereAnd(s =>
                    s.WEx_Like(s.MINGCHENG, serValue) ||
                    s.WEx_Like(s.MINGCHENG_PY, serValue));
            }
            query.OrderBy(s => s.ADDTIME, Framework.EmOrderByType.Desc);
            var ret = DB.QueryWhere<T_SHITI_MUBAN>(query);
            return ret.ToDataTable();
        }

        public DataTable GetZhiKongJiHuaByFuCha(string serValue)
        {
            var query = DB.CreateQueryCondition<T_ZHIKONGJIHUA>();
            if (!string.IsNullOrWhiteSpace(serValue))
            {
                serValue = string.Format("%{0}%", serValue);
                query.WhereAnd(s =>
                    s.WEx_Like(s.MINGCHENG, serValue));
            }
            query.WhereAnd(s => s.SHIFOUFUCHA == "否");
            query.OrderBy(s => s.ADDTIME, Framework.EmOrderByType.Desc);
            var ret = DB.QueryWhere<T_ZHIKONGJIHUA>(query);
            return ret.ToDataTable();
        }
    }
}