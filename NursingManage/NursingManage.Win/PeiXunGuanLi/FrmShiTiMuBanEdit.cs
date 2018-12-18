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

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmShiTiMuBanEdit : BaseEditForm
    {
        public FrmShiTiMuBanEdit(EditModelHandle<T_SHITI_MUBAN> SaveHandle, T_SHITI_MUBAN model = null)
        {
            InitializeComponent();
            this.SaveMuBanHandle = SaveHandle;
            this._Model = model;
        }

        T_SHITI_MUBAN _Model;
        EditModelHandle<T_SHITI_MUBAN> SaveMuBanHandle;

        private void FrmShiTiMuBanEdit_Load(object sender, EventArgs e)
        {
            if (_Model == null)
            {
                _Model = new T_SHITI_MUBAN();
            }
            else
            {
                dcm1.SetControlValue(_Model);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_Model == null)
            {
                _Model = new T_SHITI_MUBAN();
            }
            dcm1.SetValueToClassObj(_Model);
            string err;
            if (!SaveMuBanHandle(_Model, out err))
            {
                ShowMessage(err);
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void txtMingCheng_Leave(object sender, EventArgs e)
        {
            txtMingChengPY.Text = StringHelper.GetPinYin(txtMingCheng.Text);
        }
    }
}
