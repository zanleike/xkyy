using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;

namespace HursingManage.AL.PeiXuNGuanLi
{
    public class ALVPingFenHuiZong : ALBase
    {
        public DataTable GetData(string serValue)
        {
            var query = DB.CreateQueryCondition<V_PEIXUNJIEGUO_HUIZONG>();
            if (!string.IsNullOrWhiteSpace(serValue))
            {
                serValue = string.Format("%{0}%", serValue);
                query.WhereAnd(s =>
                    s.WEx_Like(s.KESHI, serValue) ||
                    s.WEx_Like(s.NEIRONG, serValue));
            }
            var r = DB.QueryWhere<V_PEIXUNJIEGUO_HUIZONG>(query);
            return r.ToDataTable();
        }
    }
}