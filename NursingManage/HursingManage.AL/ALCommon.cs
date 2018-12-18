using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
using System.Linq.Expressions;
using System.Data;
using Framework.Entitys;
using HursingManage.DBModel;

namespace HursingManage.AL
{
    public class ALCommon : ALBase
    {
        #region 临时放置，回头将放入共通中；

        /// <summary>
        /// 军卫系统的加密算法
        /// </summary>
        /// <param name="src">明文</param>
        /// <returns>密文</returns>
        public static string Encrypt_JW(string src)
        {
            string oneChar = string.Empty;
            string result = string.Empty;
            string result2;
            if (src.Length == 0)
            {
                result2 = string.Empty;
            }
            else
            {
                src = src.Trim();
                for (int i = 0; i < src.Length; i++)
                {
                    oneChar = src.Substring(i, 1);
                    char[] arrChar = oneChar.ToCharArray();
                    int j;
                    if (i % 2 == 0)
                    {
                        j = (int)arrChar[0] - i + 8 - 1;
                    }
                    else
                    {
                        j = (int)arrChar[0] + i - 32 + 1;
                    }
                    result += (char)j;
                }
                result2 = result;
            }
            return result2;
        }
        /// <summary>
        /// 军卫系统的解密算法
        /// </summary>
        /// <param name="src">明文</param>
        /// <returns>密文</returns>
        public static string Decrypt_JW(string src)
        {
            string oneChar = string.Empty;
            string result = string.Empty;
            string result2;
            if (src.Length == 0)
            {
                result2 = string.Empty;
            }
            else
            {
                src = src.Trim();
                for (int i = 0; i < src.Length; i++)
                {
                    oneChar = src.Substring(i, 1);
                    char[] arrChar = oneChar.ToCharArray();
                    int j;
                    if (i % 2 == 0)
                    {
                        j = (int)arrChar[0] + i - 8 + 1;
                    }
                    else
                    {
                        j = (int)arrChar[0] - i + 32 - 1;
                    }
                    result += (char)j;
                }
                result2 = result;
            }
            return result2;
        }
        
        #endregion

        static ALCommon _Instance;
        public static ALCommon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ALCommon();
                }
                return _Instance;
            }
        }
        public static bool LoginOut()
        {
            return Instance.WriteDBLog("系统退出");
        }
        public static IQueryResult GetQueryResult<TEntity>(Expression<Func<TEntity, bool>> whereExpress) where TEntity : EntityBase, new()
        {
            var result = Instance.DB.QueryWhere<TEntity>(whereExpress);
            return result;
        }
        public static List<TEntity> GetList<TEntity>(Expression<Func<TEntity, bool>> whereExpress) where TEntity : EntityBase, new()
        {
            var result = Instance.DB.QueryWhere<TEntity>(whereExpress);
            return result.ToList();
        }
        public static DataTable GetDataTable<TEntity>(Expression<Func<TEntity, bool>> whereExpress) where TEntity : EntityBase, new()
        {
            var result = GetQueryResult<TEntity>(whereExpress);
            return result.ToDataTable();
        }
        public static int ExecSQLScript(string sql)
        {
            var sqlBuilder = Instance.DB.CreateSqlBuilder();
            sqlBuilder.AddSQLText(sql);
            var execResult = Instance.DB.ExecSql(sqlBuilder);
            return execResult.Count;
        }
        
        public static DataTable TestProc()
        {
            P_GetWeiKaoShiRenYuan p = new P_GetWeiKaoShiRenYuan();
            p.pJiHuaId = "E815F429F6B740F288D5C57DBB7604CE";
            p.pKeShiId = "DA5537BFD49442B4AAAC4057907F9CC4";
            var r = Instance.DB.ExecProcedure(p);
            var rList = r.ToList<T_DANGAN>();


            return null;
            //throw new NotImplementedException();
            //P_Test p = new P_Test();
            //p.Number = 234;
            //DataTable dt = Instance.DB.ExecProcedureGetDataTable(p);
            //return dt;
        }
    }
}
