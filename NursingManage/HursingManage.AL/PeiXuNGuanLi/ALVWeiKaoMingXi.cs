using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HursingManage.DBModel;
using Framework.Core;

namespace HursingManage.AL.PeiXuNGuanLi
{
    public class ALVWeiKaoMingXi : ALBase
    {
        public DataTable GetData(int onePage, int pageNo, out int recordCount, bool isAdSearch = false, string serValue = null)
        {
            var query = DB.CreateQueryCondition<V_PEIXUNJIHUA_MINGXI_WEIKAO>();
            if (IsHuShiZhangLogin)
            {
                query.WhereAnd(s => s.KESHIID == CurrentLoginUser.KESHIID);
            }
            query.OnePage = onePage;
            query.PageNo = pageNo;
            query.OrderBy(s => s.KESHI).OrderBy(s => s.NEIRONG).OrderBy(s => s.BIANHAO);
            DataTable dt;
            IQueryResult result;
            if (isAdSearch)
            {
                result = DB.QueryWhere<V_PEIXUNJIHUA_MINGXI_WEIKAO>(query, ADSqlBuilder);
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
                result = DB.QueryWhere<V_PEIXUNJIHUA_MINGXI_WEIKAO>(query);
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
    }
}