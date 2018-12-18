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
    public partial class FrmDepartEdit : BaseEditForm
    {
        public FrmDepartEdit(T_DEPART model, EditModelHandle<T_DEPART> SaveDepartHandle)
        {
            InitializeComponent();
            this._Model = model;
            this.SaveDepartHandle = SaveDepartHandle;
        }

        T_DEPART _Model;
        EditModelHandle<T_DEPART> SaveDepartHandle;

        private void FrmDepartEdit_Load(object sender, EventArgs e)
        {           
            if (string.IsNullOrWhiteSpace(_Model.MINGCHENG))
            {
                this.Text = "科室 新增";
            }
            else
            {
                this.Text = "科室 编辑";
            }
            dcm1.SetControlValue(_Model);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (SaveDepartHandle(_Model, out errMsg))
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

        private void txtMingCheng_Leave(object sender, EventArgs e)
        {
            string py = StringHelper.GetPinYin(txtMingCheng.Text);
            txtMINGCHENG_PY.Text = py;
        }
    }
}