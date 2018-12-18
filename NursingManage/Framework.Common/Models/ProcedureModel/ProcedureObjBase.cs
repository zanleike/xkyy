using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

namespace Framework.Common.Models.ProcedureModel
{
    /// <summary>
    /// 存储过程使用的基类,继承类名必须以"Proc_"开头
    /// </summary>
    public abstract class ProcedureObjBase
    {
        /// <summary>
        /// 重新父类的ToString,返回存储过程名,不包含前缀"Proc_"
        /// </summary>
        public override string ToString()
        {
            string className = this.GetType().Name;
            string qianZhui = "Proc_";
            string procName = className.Substring(qianZhui.Length, className.Length - qianZhui.Length);
            return procName;
        }
        /// <summary>
        /// 输出参数的属性字典,key包含@
        /// </summary>
        Dictionary<object, ProcedureOutParamAttribute> _OutAttrParamDict;
        /// <summary>
        /// 获得存储过程参数集合
        /// </summary>
        public virtual Dictionary<string, object> GetProcParamObj()
        {
            var procParam = new Dictionary<string, object>();
            Type t = this.GetType();
            System.Reflection.PropertyInfo[] pros = t.GetProperties();
            foreach (System.Reflection.PropertyInfo item in pros)
            {
                string paramName = string.Format("@{0}", item.Name);
                object paramValue = item.GetValue(this, null);
                procParam.Add(paramName, paramValue);
                //处理属性特性,并保存至字典"_OutAttrParamDict"中
                Attribute attr = ProcedureOutParamAttribute.GetCustomAttribute(item, typeof(ProcedureOutParamAttribute));
                if (attr != null)
                {
                    ProcedureOutParamAttribute outParamAttr = ((ProcedureOutParamAttribute)attr);
                    if (_OutAttrParamDict == null) _OutAttrParamDict = new Dictionary<object, ProcedureOutParamAttribute>();
                    if (!_OutAttrParamDict.ContainsKey(paramName))
                        _OutAttrParamDict.Add(paramName, outParamAttr);                    
                }
            }
            return procParam;
        }
        /// <summary>
        /// 根据数据库参数,设置参数的输出选项
        /// </summary>
        public virtual void SetOutParam(ref DbParameter[] dbParam)
        {
            if (dbParam == null || dbParam.Length == 0) return;
            if (_OutAttrParamDict != null)
            {
                for (int i = 0; i < dbParam.Length; i++)
                {
                    if (_OutAttrParamDict.ContainsKey(dbParam[i].ParameterName))
                    {
                        dbParam[i].Direction = _OutAttrParamDict[dbParam[i].ParameterName].ParamDirection;
                        dbParam[i].Size = _OutAttrParamDict[dbParam[i].ParameterName].OutSize;
                    }
                }
            }
        }
        /// <summary>
        /// 给当前对象设置输出参数的值
        /// </summary>
        public virtual void SetOutParamValue(DbParameter[] dbParam)
        {
            if (dbParam == null || dbParam.Length == 0) return;
            if (_OutAttrParamDict != null && _OutAttrParamDict.Count > 0)
            {
                Type t = this.GetType();
                foreach (string item in _OutAttrParamDict.Keys)
                {
                    string propName = item.Substring(1);
                    System.Reflection.PropertyInfo pro = t.GetProperty(propName);
                    for (int i = 0; i < dbParam.Length; i++)
                    {
                        if (dbParam[i].ParameterName.Equals(item, StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (dbParam[i] != null)
                            {
                                pro.SetValue(this, dbParam[i].Value, null);
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}
