using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Common
{
    /// <summary>
    /// 高效字符串处理,封装了StringBuilder的几个方法
    /// </summary>
    public class StringPlus
    {
        private StringBuilder str;

        public StringPlus()
        {
            this.str = new StringBuilder();
        }
        /// <summary>
        /// 清空文本所有内容
        /// </summary>
        public void Clear()
        {
            str.Remove(0, str.Length);
        }
        /// <summary>
        /// 正常增加文本
        /// </summary>        
        public string Append(string Text, params object[] agrs)
        {
            if (agrs == null || agrs.Length <= 0)
            {
                this.str.Append(Text);
            }
            else
            {
                this.str.AppendFormat(Text, agrs);
            }
            return this.str.ToString();

        }
        /// <summary>
        /// 增加一个换行
        /// </summary>        
        public string AppendLine()
        {
            this.str.Append("\r\n");
            return this.str.ToString();

        }
        /// <summary>
        /// 增加文本+换行
        /// </summary>
        public string AppendLine(string Text, params object[] agrs)
        {
            if (agrs == null || agrs.Length <= 0)
            {
                this.str.Append(Text + "\r\n");
            }
            else
            {
                this.str.AppendFormat(Text + "\r\n", agrs);
            }
            return this.str.ToString();
        }
        /// <summary>
        /// 增加指定数量的TAB+文本
        /// </summary>        
        public string AppendSpace(int SpaceNum, string Text, params object[] agrs)
        {
            if (agrs == null || agrs.Length <= 0)
            {
                this.str.Append(this.Space(SpaceNum));
                this.str.Append(Text);
            }
            else
            {
                this.str.AppendFormat(this.Space(SpaceNum));
                this.str.AppendFormat(Text, agrs);
            }
            return this.str.ToString();
        }
        /// <summary>
        /// 增加指定数量的TAB+文本+换行
        /// </summary>        
        public string AppendSpaceLine(int SpaceNum, string Text, params object[] agrs)
        {
            this.str.Append(this.Space(SpaceNum));
            if (agrs == null || agrs.Length <= 0)
            {
                this.str.Append(Text);
                this.str.Append("\r\n");
            }
            else
            {
                this.str.AppendFormat(Text, agrs);
                this.str.Append("\r\n");
            }
            return this.str.ToString();
        }
        /// <summary>
        /// 删除最后一个指定字符
        /// </summary>
        /// <param name="strchar">要删除的字符</param>
        /// <param name="isOnlyLast">是否仅删除最后一个字符，中间位置的指定字符不删除</param>
        public void DelLastChar(string strchar, bool isOnlyLast = true)
        {
            string str = this.str.ToString();
            int length = str.LastIndexOf(strchar);
            if (length > 0)
            {
                if (isOnlyLast && length != str.Length - 1)
                {
                    return;
                }
                this.str = new StringBuilder();
                this.str.Append(str.Substring(0, length));
            }
        }
        /// <summary>
        /// 去除最后一个逗号
        /// </summary>
        public void DelLastComma()
        {
            string str = this.str.ToString();
            int length = str.LastIndexOf(",");
            if (length > 0)
            {
                this.str = new StringBuilder();
                this.str.Append(str.Substring(0, length));
            }
        }
        /// <summary>
        /// 删除指定字符 
        /// </summary>
        public void Remove(int Start, int Num)
        {
            this.str.Remove(Start, Num);
        }
        /// <summary>
        /// 增加指定数量TAB
        /// </summary>
        public string Space(int SpaceNum)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < SpaceNum; i++)
            {
                builder.Append("\t");
            }
            return builder.ToString();

        }
        public override string ToString()
        {
            return this.str.ToString();
        }
        public string Value
        {
            get
            {
                return this.str.ToString();
            }
        }
    }
}
