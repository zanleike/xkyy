using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Framework.Common.Validation
{
    public class Validation
    {
        static Validation _thisModel;
        public static Validation ThisModel
        {
            get
            {
                if (_thisModel == null)
                {
                    _thisModel = new Validation();
                }
                return _thisModel;
            }
        }

        public bool Validating(ValidationModel validModel)
        {
            //validation
            switch (validModel.ValidType)
            {
                case ValidTypeEnum.None:
                    break;
                case ValidTypeEnum.NotNull:
                    return !IsNullOrEmpty(validModel.ValidObject);
                case ValidTypeEnum.DataType:
                    return CheckDataType(validModel.DataType, validModel.ValidObject, validModel.MaxValue, validModel.MinValue);
                case ValidTypeEnum.EqualToRegex:
                    //正则表达式
                    return IsMatching(validModel.ValidObject, validModel.CompareValue);
                case ValidTypeEnum.EqualNotRegex:
                    //正则表达式非
                    return !IsMatching(validModel.ValidObject, validModel.CompareValue);
                default:
                    break;
            }
            return true;
        }
        bool IsNullOrEmpty(object obj)
        {
            if (obj == null || obj.ToString().Trim() == string.Empty) return true;
            return false;
        }

        #region 正则表达式验证

        bool IsMatching(object obj, string regexStr)
        {
            if (IsNullOrEmpty(obj)) return false;
            Regex re = new Regex(regexStr);
            Match mc = re.Match(obj.ToString());
            return mc.Success;
        }

        #endregion

        #region 数据类型校验

        bool CheckDataType(DataTypeEnum dataType, object obj, string maxValue, string minValue)
        {
            switch (dataType)
            {
                case DataTypeEnum._String:
                    return CheckString(obj, maxValue, minValue);
                case DataTypeEnum._Integer:
                    return CheckInteger(obj, maxValue, minValue);
                case DataTypeEnum._Boolean:
                    return CheckBoolean(obj);
                case DataTypeEnum._DateTime:
                    return CheckDateTime(obj, maxValue, minValue);
                case DataTypeEnum._Double:
                    return CheckDouble(obj, maxValue, minValue);
                case DataTypeEnum._Decimal:
                    return CheckDecimal(obj, maxValue, minValue);
                default:
                    return false;
            }
        }
        int GetInteger(string str)
        {
            int strNum = 0;
            if (int.TryParse(str, out strNum))
            {
                return strNum;
            }
            return 0;
        }
        bool CheckInteger(object obj, string maxValue, string minValue)
        {
            if (IsNullOrEmpty(obj)) return false;
            int objValue;
            if (int.TryParse(obj.ToString(), out objValue))
            {
                int maxV;
                if (int.TryParse(maxValue, out maxV) && objValue > maxV) return false;
                int minV;
                if (int.TryParse(minValue, out minV) && objValue < minV) return false;
                return true;
            }
            else
            {
                return false;
            }
        }
        bool CheckString(object obj, string maxValue, string minValue)
        {
            if (obj == null) return false;
            //if (IsNullOrEmpty(obj)) return false;
            string objValue = obj.ToString();
            int maxV;
            if (int.TryParse(maxValue, out maxV) && objValue.Length > maxV) return false;
            int minV;
            if (int.TryParse(minValue, out minV) && objValue.Length < minV) return false;
            return true;
        }
        bool IsDateTime(object obj, out DateTime dt)
        {
            dt = DateTime.Now;
            if (IsNullOrEmpty(obj)) return false;
            if (DateTime.TryParse(obj.ToString(), out dt))
            {
                return true;
            }
            return false;
        }
        bool CheckDateTime(object obj, string maxValue, string minValue)
        {
            if (IsNullOrEmpty(obj)) return false;
            DateTime dt;
            if (!IsDateTime(obj, out dt)) return false;
            DateTime dtMax, dtMin;
            if (IsDateTime(maxValue, out dtMax) && dt > dtMax) return false;
            if (IsDateTime(minValue, out dtMin) && dt < dtMin) return false;
            //如果最大值或最小值不是日期类型那么不进行比较,输入值是日期则返回true

            return true;
        }
        bool CheckDouble(object obj, string maxValue, string minValue)
        {
            if (IsNullOrEmpty(obj)) return false;
            double dbValue;
            double maxV, minV;
            if (!double.TryParse(obj.ToString(), out dbValue)) return false;
            if (double.TryParse(maxValue, out maxV) && dbValue > maxV) return false;
            if (double.TryParse(minValue, out minV) && dbValue < minV) return false;
            return true;
        }
        bool CheckDecimal(object obj, string maxValue, string minValue)
        {
            if (IsNullOrEmpty(obj)) return false;
            decimal deValue;
            if (!decimal.TryParse(obj.ToString(), out deValue)) return false;
            decimal maxV, minV;
            if (decimal.TryParse(maxValue, out maxV) && deValue > maxV) return false;
            if (decimal.TryParse(minValue, out minV) && deValue < minV) return false;

            return true;
        }
        bool CheckBoolean(object obj)
        {
            if (IsNullOrEmpty(obj)) return false;
            bool b;
            return bool.TryParse(obj.ToString(), out b);

            //return false;
        }

        #endregion
    }
}
