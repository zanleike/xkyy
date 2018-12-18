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
    public partial class FrmTiKuFenLeiEdit : BaseEditForm
    {
        public FrmTiKuFenLeiEdit(EditModelHandle<T_SHITI_FENLEI> SaveHandle,T_SHITI_FENLEI model)
        {
            InitializeComponent();
            this._Model = model;
            this.SaveHandle = SaveHandle;
        }

        T_SHITI_FENLEI _Model;
        EditModelHandle<T_SHITI_FENLEI> SaveHandle;

        private void FrmTiKuFenLeiEdit_Load(object sender, EventArgs e)
        {
            if (_Model == null)
            {
                this.Text = "试题分类 新增";
            }
            else
            {
                this.Text = "试题分类 编辑";
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
                _Model = new T_SHITI_FENLEI();
            }
            dcm1.SetValueToClassObj(_Model);
            string err;
            if (!SaveHandle(_Model, out err))
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
