using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Framework.Common.Models.TableModel;

namespace Framework.WinCommon.Forms
{
    public enum EditFormType
    {
        Insert, Edit, View
    }
    public partial class FrmEditorBase : FrmBase
    {
        public FrmEditorBase()
        {
            InitializeComponent();
        }
        public FrmEditorBase(EditFormType frmType)
            : this()
        {
            this.FrmType = frmType;
        }
        protected EditFormType FrmType;
        protected virtual void Insert() { }
        protected virtual void Edit() { }
        protected virtual void View() { }
        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (FrmType)
            {
                case EditFormType.Insert:
                    Insert();
                    break;
                case EditFormType.Edit:
                    Edit();
                    break;
                case EditFormType.View:
                    break;
                default:
                    break;
            }
        }

        private void FrmEditorBase_Load(object sender, EventArgs e)
        {
            if (FrmType == EditFormType.View || FrmType== EditFormType.Edit)
            {
                btnOK.Visible = false;
                View();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //public FrmEditorBase(OperatorHandle opHandle)
        //    : this()
        //{
        //    this.OpHandle = opHandle;
        //}
        //protected OperatorHandle OpHandle;
        //public delegate bool OperatorHandle(ModelBase model);
    }
}
