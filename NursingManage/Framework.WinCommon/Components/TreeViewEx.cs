using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace Framework.WinCommon.Components
{
    [ProvideProperty("ActionsHandle", typeof(TreeView))]
    public class TreeViewEx : Component, IExtenderProvider
    {
        public bool CanExtend(object extendee)
        {
            return
                extendee is TreeView;
        }
        #region 系统生成

        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            //errorProvider.Dispose();
        }
        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();            
        }

        #endregion
        #region 构造方法

        public TreeViewEx(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        #endregion

        [Category("DataTable控件映射")]
        [Description("是否启用控件映射DataTable")]
        public event Action<string> ActionsHandle;
    }
}
