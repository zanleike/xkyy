using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;
using Framework.Core;
using Framework.Common.Helpers;

namespace HursingManage.AL.PeiXuNGuanLi
{
    public class ALVPingFenMingXiChaKan : ALBase
    {
        public DataTable GetData(int onePage, int pageNo, out int recordCount, bool isAdSearch = false, string serValue = null)
        {
            var query = DB.CreateQueryCondition<V_PEIXUNJIHUA_MINGXI>();
            if (IsHuShiZhangLogin)
            {
                query.WhereAnd(s => s.KESHIID == CurrentLoginUser.KESHIID);
            }
            query.OnePage = onePage;
            query.PageNo = pageNo;
            query.OrderBy(s => s.KESHI).OrderBy(s => s.JIHUAMINGCHENG).OrderBy(s => s.MUBAN).OrderBy(s => s.BIANHAO);
            DataTable dt;
            IQueryResult result;
            if (isAdSearch)
            {
                result = DB.QueryWhere<V_PEIXUNJIHUA_MINGXI>(query, ADSqlBuilder);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(serValue))
                {
                    serValue = string.Format("%{0}%", serValue);
                    query.WhereAnd(s =>
                        s.WEx_Like(s.KESHI, serValue) ||
                        s.WEx_Like(s.BIANHAO, serValue) ||
                        s.WEx_Like(s.XINGMING, serValue) ||
                        s.WEx_Like(s.XINGMING_PY, serValue));

                }
                result = DB.QueryWhere<V_PEIXUNJIHUA_MINGXI>(query);
            }
            dt = result.ToDataTable();
            if (query.OnePage == 0 || query.PageNo == 0)
            {
                recordCount = result.Count;
            }
            else
            {
                recordCount = query.RecordCount;
            }
            return dt;
        }

        public List<V_SHITI_MUBAN_MINGXI> GetPingFenJieGuo(V_PEIXUNJIHUA_MINGXI model)
        {
            var query = DB.CreateQueryCondition<V_SHITI_MUBAN_MINGXI>();
            query.WhereAnd(s => s.MUBANID == model.MUBANID);
            query.OrderBy(s => s.SHITIXUHAO);
            var mingXiModel = DB.QueryWhere<V_SHITI_MUBAN_MINGXI>(query);
            var rList = mingXiModel.ToList();
            string[] daTiList = null;
            if (string.IsNullOrWhiteSpace(model.DATI))
            {
                return null;
            }
            daTiList = model.DATI.Split(',');
            if (daTiList.Length > rList.Count)
            {
                throw new Exception("答题数量大于试题数量不符！");
            }
            for (int i = 0; i < rList.Count; i++)
            {
                if (i >= daTiList.Length)
                {
                    rList[i].DaTi = string.Empty;
                }
                else
                {
                    rList[i].DaTi = daTiList[i];
                }
                rList[i].ShiFouZhengQue = StringHelper.StringEquals(rList[i].DaTi, rList[i].DAAN);
            }
            return rList;
        }
    }
}