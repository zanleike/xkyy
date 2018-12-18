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
    public partial class FrmZhiLiangBiaoZhunEditByLeiBie : BaseEditForm
    {
        public FrmZhiLiangBiaoZhunEditByLeiBie(
            EditModelHandle<T_ZHILIANGBIAOZHUN_LEIBIE> SaveHandle,
            T_ZHILIANGBIAOZHUN_LEIBIE model = null)
        {
            InitializeComponent();
            this._Model = model;
            this.SaveHandle = SaveHandle;
        }
        EditModelHandle<T_ZHILIANGBIAOZHUN_LEIBIE> SaveHandle;
        T_ZHILIANGBIAOZHUN_LEIBIE _Model;

        private void FrmZhiLiangBiaoZhunEditByLeiBie_Load(object sender, EventArgs e)
        {
            if (_Model == null)
            {
                this.Text += " 新增";
                _Model = new T_ZHILIANGBIAOZHUN_LEIBIE();
            }
            else
            {
                this.Text += " 修改";
                dcm1.SetControlValue(_Model);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}