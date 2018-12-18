/*
    2017.4.6    clear方法增加设置tag 为null的方法
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Framework.WinCommon.Controls
{
    public class ZCTextBox : TextBox
    {
        public ZCTextBox()
        {
            _emptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
        }

        #region 变量

        /// <summary>
        /// 空字符提示文本
        /// </summary>
        string _emptyTextTip;
        /// <summary>
        /// 空字符提示文本颜色
        /// </summary>
        Color _emptyTextTipColor;
        /// <summary>
        /// 回车是否当tag键使用
        /// </summary>
        bool _EnterisTab;

        const int WM_PAINT = 0xF;

        #endregion

        /// <summary>
        /// 清空文本内容，并将tag设置为null
        /// </summary>
        public new void Clear()
        {

            base.Clear();
            this.Tag = null;
        }

        #region 空文本显示文字的设置

        /// <summary>
        /// 空字符提示文本
        /// </summary>
        public string EmptyTextTip
        {
            get { return _emptyTextTip; }
            set { _emptyTextTip = value; }
        }
        /// <summary>
        /// 空字符提示文本颜色
        /// </summary>
        public Color EmptyTextTipColor
        {
            get { return _emptyTextTipColor; }
            set { _emptyTextTipColor = value; }
        }
        [Description("是否将回车键当做tab键使用")]
        public bool EnterIsTab
        {
            get { return _EnterisTab; }
            set { _EnterisTab = value; }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                WmPaint(ref m);
            }
        }

        private void WmPaint(ref Message m)
        {
            Rectangle rectangle = new Rectangle(0, 0, Width, Height);
            using (Graphics graphics = Graphics.FromHwnd(base.Handle))
            {
                if (Text.Length == 0
                   && !string.IsNullOrEmpty(_emptyTextTip)
                   && !Focused)
                {
                    TextFormatFlags format =
                         TextFormatFlags.EndEllipsis |
                         TextFormatFlags.VerticalCenter;
                    if (RightToLeft == RightToLeft.Yes)
                    {
                        format |= TextFormatFlags.RightToLeft | TextFormatFlags.Right;
                    }
                    TextRenderer.DrawText(
                        graphics,
                        _emptyTextTip,
                        Font,
                        base.ClientRectangle,
                        _emptyTextTipColor,
                          format);
                }
            }
        }

        #endregion

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (_EnterisTab)
            {
                if (!this.FindForm().KeyPreview)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        SendKeys.Send("{Tab}");
                    }
                }
                else
                {
                    _EnterisTab = false;
                }
            }
        }
    }
}