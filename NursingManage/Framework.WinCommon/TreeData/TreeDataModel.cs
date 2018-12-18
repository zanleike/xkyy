using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Framework.WinCommon.TreeData
{
    /// <summary>
    /// 此类的存在是为了所有树型结构实体,为了递归条件
    /// </summary>
    public class TreeDataModel
    {
        #region 构造函数
        
        public TreeDataModel(string cId, string pId, string text, EventHandler onClick)
        {
            this.CId = cId;
            this.PId = pId;
            this.Text = text;
            this.OnClickEvent = onClick;
        }
        public TreeDataModel(string cId, string pId, string text)
            : this(cId, pId, text, null)
        { }
        public TreeDataModel(string cId, string text, EventHandler onClick)
            : this(cId, null, text, onClick)
        { }
        public TreeDataModel(string cId, string text)
            : this(cId, null, text, null)
        { }
        public TreeDataModel() { }

        #endregion

        /// <summary>
        /// 当前Id
        /// </summary>
        public string CId { set; get; }
        /// <summary>
        /// 父级Id
        /// </summary>
        public string PId { set; get; }
        /// <summary>
        /// 是否跟节点,和Pid==null,或者Pid=="0" 等效
        /// </summary>
        public bool IsRoot { set; get; }
        /// <summary>
        /// 要显示的文本
        /// </summary>
        public string Text { set; get; }
        /// <summary>
        /// 点击事件
        /// </summary>
        public EventHandler OnClickEvent;
        /// <summary>
        /// 返回当前TreeDataModel对象的Text
        /// </summary>
        public override string ToString()
        {
            return Text;
        }
    }
}
