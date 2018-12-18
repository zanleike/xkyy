using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Common.Delegates
{
    /// <summary>
    /// DbDataReaderhandle读出一行数据的一个字段值后的处理委托
    /// </summary>
    /// <param name="fieldName">字段名</param>
    /// <param name="fieldValue">字段值</param>
    /// <param name="isNewRow">是否新行,true:新行,false不是新行</param>
    public delegate void DbDataReaderHandle(string fieldName, object fieldValue, bool isNewRow);

    public delegate void Action();
    public delegate void Action<T>(T t);
    public delegate void Action<T1, T2>(T1 t1, T2 t2);
    public delegate void Action<T1, T2, T3>(T1 t1, T2 t2, T3 t3);
    public delegate void Action<T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4);
    public delegate void Action<T1, T2, T3, T4, T5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
    public delegate void Action<T1, T2, T3, T4, T5, T6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6);

}
