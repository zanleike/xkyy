using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.WinCommon.Components;

namespace NursingManage.Win
{
    public partial class BaseEditForm : BaseForm
    {
        public BaseEditForm()
        {
            InitializeComponent();
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(BaseEditForm_KeyDown);
            if (_UseSaveShortcutkey)
            {
                this.KeyPreview = true;
            }
        }

        //bool _UseEnterisTab = true;

        //public bool UseEnterisTag
        //{
        //    get { return _UseEnterisTab; }
        //    set { _UseEnterisTab = value; }
        //}

        bool _UseSaveShortcutkey = true;
        /// <summary>
        /// 是否启用保存快捷键
        /// </summary>
        public bool UseSaveShortcutkey
        {
            get { return _UseSaveShortcutkey; }
            set { _UseSaveShortcutkey = value; }
        }

        void BaseEditForm_KeyDown(object sender, KeyEventArgs e)
        {   
            if (_UseSaveShortcutkey)
            {
                if (e.Alt && e.KeyCode == Keys.S)
                {
                    SaveHandle(sender, e);
                }
            }
        }
        protected virtual void SaveHandle(object sender, EventArgs e)
        {

        }
    }
}
