using System;
using System.Collections.Generic;
namespace Framework.BuildSQLText
{
    public interface ISqlBuilder
    {
        /// <summary>
        /// 拼接sql增加一个值并返回参数值变量名称
        /// </summary>
        /// <param name="dbParam">参数值</param>
        /// <returns>返回sql参数话查询的参数名</returns>
        string AddParam(object dbParam);
        /// <summary>
        /// 增加sql文本,提供占位符方法,同string.Format()用法
        /// </summary>
        /// <param name="sql">增加的sql文本</param>
        /// <param name="args">占位符值</param>
        void AddSQLText(string sql, params object[] args);
        /// <summary>
        /// 追加sql文本，支持string.format 方法，同时会把所有已有条件加上括号，并加上and符号
        /// </summary>
        void AddSqlTextByGroup(string sql, params object[] args);
        /// <summary>
        /// 清除当前拼接sql的全部内容
        /// </summary>
        void ClearResult();
        /// <summary>
        /// 清楚当前拼接sql的sql文本,但不清除参数对象
        /// </summary>
        void ClearSQL();
        /// <summary>
        /// 返回sql参数值的字典列表,key:参数名,value参数值
        /// </summary>
        Dictionary<string, object> DbParam { get; }
        /// <summary>
        /// 返回sql文本
        /// </summary>
        string SQLText { get; }
        /// <summary>
        /// 批量增加一个参数对象
        /// </summary>
        /// <param name="dbParam"></param>
        void AppendDbParam(Dictionary<string, object> dbParam);
    }
}
