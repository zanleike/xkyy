using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HursingManage.DBModel;

namespace HursingManage.AL.ZhiLiangKongZhi
{
    public class ALZhiKongJianChaQueRen : ALBase
    {
        /// <summary>
        /// get V_ZHIKONGJIHUA_KESHI data
        /// </summary>
        public DataTable GetDataByJiHua(string serValue)
        {
            var query = DB.CreateQueryCondition<V_ZHIKONGJIHUA_KESHI>();
            if (!string.IsNullOrWhiteSpace(serValue))
            {
                serValue = string.Format("%{0}%", serValue);
                query.WhereAnd(s => s.WEx_Like(s.JIHUAMINGCHENG, serValue));
            }
            query.WhereAnd(s => s.KESHIID == CurrentLoginUser.KESHIID);
            var result = DB.QueryWhere<V_ZHIKONGJIHUA_KESHI>(query);
            return result.ToDataTable();
        }        
        /// <summary>
        /// get T_ZHIKONGJIHUA_JIEGUO data
        /// </summary>
        public DataTable GetJieGuoData(V_ZHIKONGJIHUA_KESHI model)
        {
            var query = DB.QueryWhere<T_ZHIKONGJIHUA_JIEGUO>(s => s.JIHUAID == model.JIHUAID && s.KESHIID == model.KESHIID);
            return query.ToDataTable();
        }
        /// <summary>
        /// 质控检查科室确认
        /// </summary>
        public bool SaveJianChaShuoMing(V_ZHIKONGJIHUA_KESHI vModel,out string errMsg)
        {
            if (vModel.KESHIID != CurrentLoginUser.KESHIID)
            {
                errMsg = "非本科室用户不能确认。";
                return false;
            }
            T_ZHIKONGJIHUA_KESHI model = new T_ZHIKONGJIHUA_KESHI();
            model.ID = vModel.ID;
            model.GAIJINSHUOMING = vModel.GAIJINSHUOMING;
            model.QUERENSHIJIAN = GetNowTime();
            model.GAIJINSHIJIAN = GetNowTime();
            model.GAIJINSHANGBAOREN = CurrentLoginUser.USER_NAME;
            model.SHIFOUQUEREN = "是";
            DB.Update(model);
            errMsg = null;
            return true;
        }
    }
}