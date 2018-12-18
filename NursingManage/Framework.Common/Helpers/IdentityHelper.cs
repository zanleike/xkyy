using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Common.Helpers
{
    /// <summary>
    /// 身份证信息
    /// </summary>
    public class IdentityHelper
    {
        static int[] modulus = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 }; //系数要与17位身份相乘
        static char[] checkNo = { '1', '0', 'X', '9', '8', '7', '6', '5', '4', '3', '2' };  //被11整出计算出的数字 0-10(且只有可能是0-10 ,11个数字) 以此 对应 的数组 0-10元素值
        /// <summary>
        /// 检查身份证是否合法
        /// </summary>
        public static bool CheckID(string idStr, out string errMsg)
        {
            idStr = idStr.Trim().ToUpper();
            if (idStr.Length != 18)
            {
                errMsg = "长度不等于18";
                return false;
            }
            if (!RegexHelper.Check(idStr, @"^[\dX]{18}$"))
            {
                errMsg = "身份证号格式错误，代码1001";
                return false;
            }
            int tmpNo;
            int sumCHKNo = 0;
            for (int i = 0; i < idStr.Length - 1; i++)
            {
                tmpNo = int.Parse(idStr[i].ToString());
                sumCHKNo += modulus[i] * tmpNo;
            }
            if (idStr[idStr.Length - 1] != checkNo[sumCHKNo % 11])
            {
                errMsg = "身份证号格式错误，代码1002";
                return false;
            }
            errMsg = null;
            return true;
        }
        public static IdentityInfo GetIdentityInfo(string idStr)
        {
            string errMsg;
            if (!CheckID(idStr, out errMsg))
            {
                return null;
            }
            IdentityInfo idInfo = new IdentityInfo();
            string birthdayId = idStr.Substring(6, 8);
            idInfo.Birthday = DateTime.ParseExact(birthdayId, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
            idInfo.Sex = Convert.ToInt32(idStr.Substring(14, 3)) % 2 == 0 ? "女" : "男";
            idInfo.Area = "无数据";
            return idInfo;
        }

        public class IdentityInfo
        {
            public string Area { set; get; }
            public string Sex { set; get; }
            public DateTime Birthday { set; get; }

        }
    }
}