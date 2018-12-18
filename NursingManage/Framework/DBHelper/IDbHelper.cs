using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Framework.DBHelper
{
    public interface IDbHelper
    {
        /// <summary>
        /// 当执行数据库操作发生异常时触发
        /// </summary>
        event Action<Exception, string> OnDbExceptionHandle;
        /// <summary>
        /// 将参数对象转换为数据DbParameter参数格式
        /// </summary>
        /// <param name="paramObj"></param>
        /// <returns></returns>
        DbParameter[] ConvertDbParameter(Dictionary<string, object> paramObj);
        /// <summary>
        /// 创建一个dbparam对象
        /// </summary>
        DbParameter CreateDbParameter(string paramName, object paramValue);
        /// <summary>
        /// 开始事务
        /// </summary>
        void TransStart();
        /// <summary>
        /// 提交事务
        /// </summary>
        void TransCommit();
        /// <summary>
        /// 回滚事务
        /// </summary>
        void TransRollback();
        /// <summary>
        /// 执行一条指定命令类型(SQL语句或存储过程等)的SQL语句,返回所影响行数
        /// </summary>
        int ExecNonQuery(string sqlText, CommandType cmdType, params DbParameter[] param);
        /// <summary>
        /// 执行一条普通SQL语句的命令,返回所影响行数
        /// </summary>
        int ExecNonQuery(string sqlText, params DbParameter[] param);
        /// <summary>
        /// 指定命令类型,执行sql语句或存储过程返回DataReader对象
        /// </summary>
        DbDataReader GetDataReader(string sqlText, CommandType cmdType, params DbParameter[] param);
        /// <summary>
        /// 执行sql语句返回DataReader对象
        /// </summary>
        DbDataReader GetDataReader(string sqlText, params DbParameter[] param);
        /// <summary>
        /// 指定命令类型(或存储过程)的SQL语句,返回首行首列
        /// </summary>
        object GetScalar(string sqlText, CommandType cmdType, params DbParameter[] param);
        /// <summary>
        /// 执行SQL语句,返回首行首列
        /// </summary>
        object GetScalar(string sqlText, params DbParameter[] param);
        /// <summary>
        ///指定命令类型,执行一条SQL语句或存储过程,返回DataSet对象
        /// </summary>        
        DataSet GetDataSet(string sqlText, CommandType cmdType, params DbParameter[] param);
        /// <summary>
        /// 执行一条SQL语句返回DataSet对象
        /// </summary>        
        DataSet GetDataSet(string sqlText, params DbParameter[] param);
        /// <summary>
        /// 指定命令类型,执行一条SQL语句或存储过程,返回DataTable对象(调用GetDataSet)
        /// </summary>        
        DataTable GetDataTable(string sqlText, CommandType cmdType, params DbParameter[] param);
        /// <summary>
        /// 执行一条SQL语句返回DataTable对象(调用GetDataSet)
        /// </summary>        
        DataTable GetDataTable(string sqlText, params DbParameter[] param);        
    }
}
