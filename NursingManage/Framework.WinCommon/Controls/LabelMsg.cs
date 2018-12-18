/*
    创建日期: 2013.6.4
    创建者:张存
    邮箱:zhangcunliang@126.com
    修改记录:
        2015.7.3 增加控件的显示位置,取值,上,中,下
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Framework.WinCommon.Controls
{
    /// <summary>
    /// 控件显示的位置枚举
    /// </summary>
    public enum ControlPosition
    {
        /// <summary>
        /// 上
        /// </summary>
        Top,
        /// <summary>
        /// 中
        /// </summary>
        Middle,
        /// <summary>
        /// 下
        /// </summary>
        Bottom
    }

    /// <summary>
    /// 此控件用于显示消息,替换MessageBox的普通对话框提示
    /// </summary>
    public class LabelMsg : Label
    {
        public LabelMsg()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Padding = new System.Windows.Forms.Padding(5);
            //this.Size = new System.Drawing.Size(127, 38);

            this.Text = "显示信息";
            this.Visible = false;
            this.ResumeLayout(false);
            this.Click += new EventHandler(LabelMsg_Click);
            this.MouseHover += new EventHandler(LabelMsg_MouseHover);
            this.MouseLeave += new EventHandler(LabelMsg_MouseLeave);
            _ShowTime = new System.Timers.Timer();
            _ShowTime.Elapsed += new System.Timers.ElapsedEventHandler(_ShowTime_Elapsed);
        }
        /// <summary>
        /// 鼠标点击消息框,立即消失
        /// </summary>
        void LabelMsg_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (_MsgAfterEventObj != null)
            {
                _MsgAfterEventObj(this, e);
                _MsgAfterEventObj = null;
            }
        }
        /// <summary>
        /// 鼠标放到控件上保持一致显示状态
        /// </summary>
        void LabelMsg_MouseHover(object sender, EventArgs e)
        {
            _ShowTime.Stop();
        }
        /// <summary>
        /// 鼠标离开提示框,重新开始计时,计时结束隐藏
        /// </summary>
        void LabelMsg_MouseLeave(object sender, EventArgs e)
        {
            _ShowTime.Start();
        }
        /// <summary>
        /// 设置的时间间隔到时间后触发的事件
        /// </summary>
        void _ShowTime_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Visible = false;
            if (_MsgAfterEventObj != null)
            {
                _MsgAfterEventObj(this, e);
                _MsgAfterEventObj = null;
            }
        }
        /// <summary>
        /// 显示消息的时间控件
        /// </summary>
        System.Timers.Timer _ShowTime;
        /// <summary>
        /// 处理显示完消息后的委托对象
        /// </summary>
        EventHandler _MsgAfterEventObj;
        /// <summary>
        /// 控件的显示位置,取值:上,中,下
        /// </summary>
        public ControlPosition ViewPosition { set; get; }


        #region 显示消息的方法
        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="msgText">消息字符串</param>
        /// <param name="showSec">显示的时间(秒)</param>
        /// <param name="msgAfterEvent">显示完消息后的处理事件</param>
        public void ShowMessage(string msgText, int showSec, EventHandler msgAfterEvent)
        {
            _ShowTime.Interval = showSec * 1000;
            this.Parent = this.FindForm();
            this.BringToFront(); //置顶
            this.Text = msgText;
            this.Visible = true;
            this.AutoSize = true;
            int calcThisWidth = this.Parent.Width - this.Left;

            //如果文本超出,进行换行
            if (this.Width > calcThisWidth)
            {
                int initailWidth = this.Width;
                //超出的宽度是计算出宽度的多少倍,超出多少倍,高度就*多少
                int duoShaoBei = this.Width / calcThisWidth + 1;
                int initialHeight = this.Height;
                this.AutoSize = false;
                this.Width = calcThisWidth;
                this.Height = initialHeight * duoShaoBei;
                this.Text = msgText;
            }
            #region 控件位置

            int pointX = (this.Parent.Width - this.Width) / 2;
            int pointY = (this.Parent.Height - this.Height) / 2;
            switch (ViewPosition)
            {
                case ControlPosition.Top:
                    pointY = 0;
                    break;
                case ControlPosition.Bottom:
                    pointY = this.Parent.Height;
                    break;
                case ControlPosition.Middle:
                default:
                    pointY = (this.Parent.Height - this.Height) / 2;
                    break;
            }

            //高在父控件(窗体)中间
            Point newPoint = new Point(pointX, pointY);


            this.Location = newPoint;


            #endregion


            

            _ShowTime.AutoReset = false;
            _ShowTime.Start();
            _MsgAfterEventObj = msgAfterEvent;
        }
        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="msgText">消息文本</param>
        /// <param name="time">显示消息的时间</param>
        public void ShowMessage(string msgText, int time)
        {
            ShowMessage(msgText, time, null);
        }
        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="msgText">消息文本</param>
        public void ShowMessage(string msgText)
        {
            ShowMessage(msgText, 3);
        }

        #endregion

    }
}
