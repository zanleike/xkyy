using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    public partial class FrmZhiLiangBiaoZhunEdit : BaseEditForm
    {
        public FrmZhiLiangBiaoZhunEdit(EditModelHandle<T_ZHILIANGBIAOZHUN> SaveHandle,
            T_ZHILIANGBIAOZHUN model)
        {
            InitializeComponent();
            this._Model = model;
            this.SaveBiaoZhunHandle = SaveHandle;
        }
        EditModelHandle<T_ZHILIANGBIAOZHUN> SaveBiaoZhunHandle;
        T_ZHILIANGBIAOZHUN _Model;

        private void FrmZhiLiangBiaoZhunEdit_Load(object sender, EventArgs e)
        {
            if (_Model != null)
            {
                dcm1.SetControlValue(_Model);
            }
            else
            {
                _Model = new T_ZHILIANGBIAOZHUN();                
            }

            if (string.IsNullOrWhiteSpace(_Model.ID))
            {
                this.Text += " 新增";
            }
            else
            {
                this.Text += " 编辑";
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (SaveBiaoZhunHandle(_Model, out errMsg))
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
        protected override void SaveHandle(object sender, EventArgs e)
        {
            btnOK_Click(sender, e);
        }
    }
}
