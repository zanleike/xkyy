using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Common.Models.TableModel
{
    public abstract class ModelBase
    {
        public ModelBase()
        { }
        /// <summary>
        /// 重写了ToString获得类的名称,不含命名空间
        /// </summary>
        public override string ToString()
        {
            string str = base.ToString();
            int a = str.LastIndexOf('.');
            string rStr = str.Substring(a + 1);
            return rStr;
        }
    }
}
