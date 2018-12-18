using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.Common.Helpers;
using HursingManage.DBModel;

namespace NursingManage.Win.XiTongGuanLi
{
    public partial class FrmKeShiEdit : BaseEditForm
    {
        public FrmKeShiEdit(EditModelHandle<T_KESHI> SaveHandle,T_KESHI model)
        {
            InitializeComponent();
            this.SaveHandle = SaveHandle;
            this._Model = model;
        }

        EditModelHandle<T_KESHI> SaveHandle;
        T_KESHI _Model;

        private void txtMINGCHENG_Leave(object sender, EventArgs e)
        {
            string py = StringHelper.GetPinYin(txtMINGCHENG.Text);
            txtMINGCHENG_PY.Text = py;
        }

        private void FrmKeShiEdit_Load(object sender, EventArgs e)
        {
            if (_Model == null)
            {
                _Model = new T_KESHI();
                this.Text = "科室信息 新增";
            }
            else
            {
                this.Text = "科室信息 修改";
                dcm1.SetControlValue(_Model);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _Model.ClearChangedState();
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
    }
}
