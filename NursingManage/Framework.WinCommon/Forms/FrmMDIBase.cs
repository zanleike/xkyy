using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.WinCommon.TreeData;
using WeifenLuo.WinFormsUI.Docking;

namespace Framework.WinCommon.Forms
{
    public partial class FrmMDIBase : FrmBase
    {
        public FrmMDIBase()
        {
            InitializeComponent();
        }
        #region DockPanel文件控件说明

        //“HideOnClose”属性很重要，该属性一般设置为True，就是指你关闭窗口时，窗体只是隐藏而不是真的关闭。

        #endregion

        /// <summary>
        /// 在dockPanl中打开单例窗体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        protected void ShowMDISubForm<T>() where T : FrmBase, new()
        {
            FrmBase frm = FormsCommon.CreateSingletonForm<T>();
            frm.Show(this.dockPanel1);            
        }

        protected virtual List<TreeDataModel> GetMenuList()
        {
            return null;
        }
        protected void ShowSubForm(DockPanel dockPanel)
        {
            this.Show(dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.Document);
            DockContent dc = new DockContent();
        }
        /// <summary>
        /// 设置状态栏文本
        /// </summary>        
        protected void SetToolStatus(string operatorName)
        {
            tsStripStatus1.Text = string.Format("欢迎 {0} 登录", operatorName);
            tsStripStatus2.Text = string.Format("登录时间: {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
        /// <summary>
        /// 设置子窗体工具栏
        /// </summary>
        protected void SetToolStrip(ToolStrip ts)
        {
            ts.Parent = this.panelToolStrip;
        }

        ToolStrip _ToolStrip;

        protected ToolStrip ToolStrip
        {
            get
            {
                return _ToolStrip;
            }
            set 
            {
                value = _ToolStrip;
                _ToolStrip.Parent = this.panelToolStrip;
            }
        }

        private void FrmMDIBase_Load(object sender, EventArgs e)
        {
            List<TreeDataModel> menuItemList = GetMenuList();
            if (menuItemList != null)
            {
                MenuItemHeler.AddToMenu(menuItemList, menuStrip);
            }
            HideOnClose = true;
        }
    }
}
