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
    public partial class FrmYongHuEdit : BaseEditForm
    {
        public FrmYongHuEdit(EditModelHandle<T_USER_INFO> EditHandle)
            : this(EditHandle, null)
        { }
        public FrmYongHuEdit(EditModelHandle<T_USER_INFO> EditHandle, T_USER_INFO model)
        {
            InitializeComponent();
            this.EditHandle = EditHandle;
            this._Model = model;
        }
        EditModelHandle<T_USER_INFO> EditHandle;
        T_USER_INFO _Model;

        private void FrmYongHuEdit_Load(object sender, EventArgs e)
        {
            if (_Model != null)
            {
                this.Text += " - 更新";
                dcm1.SetControlValue(_Model);
                //txtUserType.Text = txtUserType.Tag != null ? txtUserType.Tag.ToString() : string.Empty;
            }
            else
            {
                _Model = new T_USER_INFO();
                this.Text += " - 新增";
            }
            ComboxListHelper.SetRole(comboxList1, txtRole);
            ComboxListHelper.SetKeShi(comboxList1, txtKeShi);
            //ComboxListHelper.SetUserType(comboxList1, txtUserType);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _Model.ClearChangedState();
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (EditHandle(_Model, out errMsg))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void txtUSER_NAME_Leave(object sender, EventArgs e)
        {
            var py = StringHelper.GetPinYin(txtUSER_NAME.Text);
            txtUSER_NAME_PY.Text = py;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}