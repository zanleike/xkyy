/*
    创建日期: 2013.6.4
    创建者:张存
    邮箱:zhangcunliang@126.com
    修改记录:
        2015.7.3 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Framework.WinCommon.Controls;
using System.Threading;

namespace Framework.WinCommon.Forms
{
    public partial class FrmBase : DockContent // Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }
        private void FrmBase_Load(object sender, EventArgs e)
        {
            #region 初始化窗体属性

            //“HideOnClose”属性很重要，该属性一般设置为True，
            //就是指你关闭窗口时，窗体只是隐藏而不是真的关闭。
            this.HideOnClose = false;

            #endregion
        }
        #region 显示LabelMessage的方法

        /// <summary>
        /// 设置label消息控件的显示位置
        /// </summary>
        /// <param name="ctrPosition"></param>
        protected void SetLabelMessagePPosition(ControlPosition ctrPosition)
        {
            lbMessage.ViewPosition = ctrPosition;
        }

        /// <summary>
        /// 显示LabelMessage提示消息
        /// </summary>
        protected void ShowMessage(string msg, params object[] args)
        {
            if (this.InvokeRequired)
            {
                Action<object> action = s => ShowMessage(msg, args);
                this.Invoke(action, msg);
            }
            else
            {
                string msgText = string.Empty;
                if (args == null || args.Length == 0)
                    msgText = msg;
                else msgText = string.Format(msg, args);
                lbMessage.ShowMessage(msgText);
            }
        }
        /// <summary>
        /// 显示LabelMessage指定显示时间(单位:秒)
        /// </summary>
        public void ShowMessage(string msgText, int time)
        {
            if (this.InvokeRequired)
            {
                Action<object> action = s => ShowMessage(msgText, time);
                this.Invoke(action, "");
            }
            else
            {
                lbMessage.ShowMessage(msgText, time);
            }
        }
        /// <summary>
        /// 显示LabelMessage指定显示时间(单位秒)及显示一定时间后的处理事件
        /// </summary>
        public void ShowMessage(string msgText, int showSec, EventHandler msgAfterEvent)
        {
            if (this.InvokeRequired)
            {
                Action<object> action = s => ShowMessage(msgText, showSec, msgAfterEvent);
                this.Invoke(action, "");
            }
            else
            {
                lbMessage.ShowMessage(msgText, showSec, msgAfterEvent);
            }
        }

        #endregion
        #region 常用询问框

        /// <summary>
        /// 询问提示框,点击OK 返回true
        /// </summary>
        public bool ShowQuestion(string msg, string caption, params object[] msgArgs)
        {
            string msgText = string.Format(msg, msgArgs);
            DialogResult r = MessageBox.Show(msgText, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);
            return r == System.Windows.Forms.DialogResult.OK ? true : false;
        }

        #endregion
        #region 关闭,关闭其它,关闭所有窗体
        /// <summary>
        /// 关闭当前窗体
        /// </summary>
        private void tsmiCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 关闭其它窗体
        /// </summary>
        private void tsmiColeOtherForm_Click(object sender, EventArgs e)
        {
            IDockContent[] documents = DockPanel.DocumentsToArray();
            foreach (IDockContent content in documents)
            {
                if (!content.Equals(this))
                {
                    content.DockHandler.Close();
                }
            }
        }
        /// <summary>
        /// 关闭所有窗体
        /// </summary>
        private void tsmiCloseAllForm_Click(object sender, EventArgs e)
        {
            IDockContent[] documents = DockPanel.DocumentsToArray();
            foreach (IDockContent content in documents)
            {
                content.DockHandler.Close();
            }
        }

        #endregion
        #region 透明层遮罩等待

        #region 使用示例

        //StartRunWork(
        //        () =>
        //        {
        //            //要执行的方法
        //        },
        //        () =>
        //        {
        //            //执行完方法之后
        //        });

        #endregion

        OpaqueLayer opaqueLayer = null;
        ThreadStart _WorkFunction, _WorkAfterFunction;
        /// <summary>
        /// 使用后台开始执行工作
        /// </summary>
        /// <param name="workFun">要长时间执行的方法(加入跨线程等待防止假死),此方法内不能有操作UI控件的方法</param>
        /// <param name="workAfterFun">执行完之后的方法,(通常是绑定数据源,统计信息的方法)</param>
        protected void StartRunWork(ThreadStart workFun, ThreadStart workAfterFun)
        {
            if (_WorkFunction == null && _WorkAfterFunction == null)
            {
                _WorkFunction = workFun;
                _WorkAfterFunction = workAfterFun;
                ShowOpaqueLayer();
                bw.RunWorkerAsync();
            }
        }
        protected void StartRunWork(ThreadStart workFun)
        {
            StartRunWork(workFun, null);
        }
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideOpaqueLayer();
            if (_WorkAfterFunction != null)
            {
                _WorkAfterFunction();
            }
            _WorkAfterFunction = null;
            _WorkFunction = null;
        }
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_WorkFunction != null)
            {
                _WorkFunction();
            }
        }
        /// <summary>
        /// 显示透明层
        /// </summary>
        protected void ShowOpaqueLayer()
        {
            if (opaqueLayer == null)
            {
                opaqueLayer = new OpaqueLayer();
                //opaqueLayer.TransparentBG = true;
                //opaqueLayer.Alpha = 255;
            }
            opaqueLayer.ShowOpaqueLayer(this);
        }
        /// <summary>
        /// 隐藏透明层
        /// </summary>
        protected void HideOpaqueLayer()
        {
            opaqueLayer.HideOpaqueLayer();
        }

        #endregion
    }
}
