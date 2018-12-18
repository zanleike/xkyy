using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Data;

namespace Framework.Common.CommonFunction
{
    public class Utils
    {
        /// <summary>
        /// 获取主机名
        /// </summary>
        public static string GetHostName()
        {
            return Dns.GetHostName();
        }
        /// <summary>
        /// 获取主机IP
        /// </summary>
        public static string GetHostIP()
        {
            IPHostEntry ipe = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipa = ipe.AddressList[0];
            return ipa.ToString();
        }
        /// <summary>
        /// 获得16为GUID
        /// </summary>
        /// <returns></returns>
        public static string GetGUID16()
        {
            long i = 1;
            Guid guid = Guid.NewGuid();
            foreach (byte b in guid.ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks).ToUpper();
        }
        /// <summary>
        /// 将一个object类型转换成指定类型
        /// </summary>
        public static T ConvertType<T>(object obj)
        {
            T tObj = default(T);
            if (obj != null && obj != DBNull.Value)
            {
                Type t = typeof(T);
                string typeName = t.Name.ToLower();
                switch (typeName)
                {
                    default:
                        tObj = (T)Convert.ChangeType(obj, t);
                        break;
                }
            }
            return tObj;
        }
        /// <summary>
        /// 将datarow制定列转换成强类型，如果不存在则返回缺省值或null
        /// </summary>
        public static T ConvertDataRow<T>(DataRow dr, string colName)
        {
            if (!dr.Table.Columns.Contains(colName))
            {
                return default(T);
            }
            return Utils.ConvertType<T>(dr[colName]);
        }
    }
}
