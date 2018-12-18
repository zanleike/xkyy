using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HursingManage.DBModel;

namespace HursingManage.AL.ZhiLiangKongZhi
{
    public class ALVZhiKongKeShiHeGeLv : ALBase
    {
        public DataTable GetData(string serValue)
        {
            var queryCondition = DB.CreateQueryCondition<V_ZHIKONG_HEGELV>();
            if (!string.IsNullOrWhiteSpace(serValue))
            {
                string likeStr = string.Format("%{0}%", serValue);
                queryCondition.WhereAnd(s =>
                    s.WEx_Like(s.KESHI, likeStr) ||
                    s.WEx_Like(s.JIHUA, likeStr) ||
                    s.WEx_Like(s.BIAOZHUNLEIBIE, likeStr)
                    );
            }
            if (IsHuShiZhangLogin)
            {
                queryCondition.WhereAnd(s => s.KESHIID == CurrentLoginUser.KESHIID);
            }
            var r = DB.QueryWhere<V_ZHIKONG_HEGELV>(queryCondition);
            var r2 = r.ToDataTable();
            return r2;
        }
        public override DataTable GetADSearchData<TModel>()
        {
            if (IsHuShiZhangLogin)
            {
                ADSqlBuilder.AddSqlTextByGroup("KeShiId={0}", ADSqlBuilder.AddParam(CurrentLoginUser.KESHIID));
            }
            return base.GetADSearchData<TModel>();
        }
    }
}
