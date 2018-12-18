using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmJiNengBiaoZhunEdit : BaseEditForm
    {
        public FrmJiNengBiaoZhunEdit(
            EditModelHandle<T_JINENGBIAOZHUN> SaveLeiBieHandle, 
            T_JINENGBIAOZHUN model)
        {
            InitializeComponent();
            this.SaveLeiBieHandle = SaveLeiBieHandle;
            this._Model = model;
        }

        T_JINENGBIAOZHUN _Model;
        EditModelHandle<T_JINENGBIAOZHUN> SaveLeiBieHandle;

        private void FrmJiNengBiaoZhunEdit_Load(object sender, EventArgs e)
        {
            if (_Model == null)
            {
                MessageBox.Show("发生程序内部错误；");
                this.Close();
                return;
            }
            dcm1.SetControlValue(_Model);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (SaveLeiBieHandle(_Model, out errMsg))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
