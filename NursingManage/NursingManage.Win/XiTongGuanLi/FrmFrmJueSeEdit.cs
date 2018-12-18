using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;
using Framework.Common.Helpers;

namespace NursingManage.Win.XiTongGuanLi
{
    public partial class FrmFrmJueSeEdit : BaseEditForm
    {
        public FrmFrmJueSeEdit(EditModelHandle<T_ROLE> SaveHandle, T_ROLE model = null)
        {
            InitializeComponent();
            this._Model = model;
            this.SaveHandle = SaveHandle;
        }
        T_ROLE _Model;
        EditModelHandle<T_ROLE> SaveHandle;

        private void FrmFrmJueSeEdit_Load(object sender, EventArgs e)
        {
            if (_Model == null)
            {
                this.Text = "角色 新增";
                _Model = new T_ROLE();
            }
            else
            {
                this.Text = "角色 修改";
                dcm1.SetControlValue(_Model);
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (SaveHandle(_Model, out errMsg))
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

        private void txtRoleName_Leave(object sender, EventArgs e)
        {
            txtRoleNamePY.Text = StringHelper.GetPinYin(txtRoleName.Text);
        }
    }
}