using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
using HursingManage.DBModel;

namespace HursingManage.AL
{
    class BNoHelper
    {
        /// <summary>
        /// 根据配置获取业务单据号
        /// </summary>
        /// <param name="da"></param>
        /// <param name="configId"></param>
        /// <returns></returns>
        public static string GetBNoStr(IDBContext da, int configId)
        {
            var query = da.QueryWhere<T_NUMBER_CONFIG>(s => s.Id == configId);
            T_NUMBER_CONFIG model = query.ToEntity();
            StringBuilder sb = new StringBuilder();
            sb.Append(model.FrontStr);
            if (!string.IsNullOrEmpty(model.DateFormat))
            {
                if (model.LastDate.ToString(model.DateFormat) != DateTime.Now.ToString(model.DateFormat))
                {
                    model.MaxValue = 0;
                }
                sb.Append(DateTime.Now.ToString(model.DateFormat));
            }
            model.MaxValue++;
            for (int i = 0; i < model.MaxValueLength - model.MaxValue.ToString().Length; i++)
            {
                sb.Append("0");
            }
            sb.Append(model.MaxValue);
            sb.Append(model.BackStr);
            model.LastDate = DateTime.Now;
            da.Update(model, s => s.Id == configId);
            return sb.ToString();
        }

        public static string GetStockInNo(IDBContext da)
        {
            return GetBNoStr(da, 1);
        }
        public static string GetStockInCancelNo(IDBContext da)
        {
            return GetBNoStr(da, 4);
        }
        public static string GetStockOutNo(IDBContext da)
        {
            return GetBNoStr(da, 2);
        }
        public static string GetStockOutCancelNo(IDBContext da)
        {
            return GetBNoStr(da, 5);
        }

        public static string GetStockOtherIn(IDBContext da)
        {
            return GetBNoStr(da, 6);
        }
        public static string GetStockOtherOut(IDBContext da)
        {
            return GetBNoStr(da, 7);
        }

        public static string GetCommodityNo(IDBContext da)
        {
            return GetBNoStr(da, 3);
        }
        public static string GetCommodityNo()
        {
            return GetBNoStr(ALCommon.Instance.DB, 3);
        }
    }
}
