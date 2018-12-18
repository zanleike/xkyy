using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HursingManage.DBModel;

namespace HursingManage.AL.ZhiLiangKongZhi
{
    public class ALVZhiKongWenTiHuiZong : ALBase
    {
        public DataTable GetZhiKongJiHua()
        {
            var query = DB.QueryWhere<T_ZHIKONGJIHUA>(s => s.SHIFOUFUCHA != "是");
            return query.ToDataTable();
        }

        public DataTable GetData(string[] jiHuaIds)
        {
            var sql = DB.CreateSqlBuilder();
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            foreach (var item in jiHuaIds)
            {
                sb.AppendFormat("{0},", sql.AddParam(item));
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append(")");

            sql.AddSQLText(@"select t.BiaoZhunLeiBie,t.LeiXing1,t.LeiXing2,t.BiaoZhun,count(1) as WenTiShu,Dense_rank() over(order by count(1) desc) as PaiMing
From T_zhikongjihua_JieGuo t
Inner join T_zhikongjihua_KeShi a on t.JiHuaId = a.JiHuaId and t.KeShiId = a.KeShiId
Where a.ShiFouJianCha='是' and a.JiHuaId in {0}
Group by  BiaoZhunLeiBie,LeiXing1,LeiXing2,BiaoZhun
Order by PaiMing", sb.ToString());

            var r = DB.QueryWhere(sql);
            return r.ToDataTable();
        }


    }
}