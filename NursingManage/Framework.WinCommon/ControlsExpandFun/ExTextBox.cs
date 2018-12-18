//扩展方法需要 .net 3.5支持
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework.WinCommon.ControlsExpandFun
{
    ///// <summary>
    ///// 文本框的扩展方法
    ///// </summary>
    //public static class ExTextBox
    //{
    //    /// <summary>
    //    /// 获取文本框的内容转换为int型,转换失败返回0
    //    /// </summary>
    //    public static int ToInt(this TextBox txtBox)
    //    {
    //        int r = 0;
    //        int.TryParse(txtBox.Text, out r);
    //        return r;
    //    }
    //    /// <summary>
    //    /// 获取文本框Tag属性转换为int型,转换失败返回0
    //    /// </summary>
    //    public static int ToIntByTag(this TextBox txtBox)
    //    {
    //        if (txtBox.Tag == null) return 0;
    //        int r = 0;
    //        int.TryParse(txtBox.Tag.ToString(), out r);
    //        return r;
    //    }
    //    /// <summary>
    //    /// 获取文本框的内容转换为decimal型,转换失败返回0
    //    /// </summary>
    //    public static decimal ToDecimal(this TextBox txtBox)
    //    {
    //        decimal r = 0;
    //        decimal.TryParse(txtBox.Text, out r);
    //        return r;
    //    }
    //    /// <summary>
    //    /// 清除文本框的text为空,tag属性为Null
    //    /// </summary>
    //    public static void ClearValue(this TextBox txtBox)
    //    {
    //        txtBox.Text = string.Empty;
    //        txtBox.Tag = null;
    //    }
    //}
}
