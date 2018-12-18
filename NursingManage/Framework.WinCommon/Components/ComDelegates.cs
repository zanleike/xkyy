using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Framework.WinCommon.Components
{
    /// <summary>
    /// 当选中行后事件所传入的参数
    /// </summary>
    public class SelectRowEventArgs : EventArgs
    {
        /// <summary>
        /// 当前选中的行数据
        /// </summary>
        public DataRow SelectedRow { set; get; }
        public TextBox BindControl { set; get; }
    }

    /// <summary>
    /// CoboxList选中行后触发事件的委托类型
    /// </summary>
    /// <param name="sender">所触发的文本框</param>
    /// <param name="e">当前选中的行数据等</param>
    public delegate void ComboxListSelectedRowAfterDeleate(object sender, SelectRowEventArgs e);
    /// <summary>
    /// 在显示GridView之前所出发事件的委托类型
    /// </summary>
    /// <param name="sender">所出发的文本框对象</param>
    /// <param name="e">事件参数</param>
    public delegate void ComboxListShowBeforeDeleate(object sender, EventArgs e);

}
