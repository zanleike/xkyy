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
    public partial class FrmZhiKongJianCha_KeShi_WenTiBianJi : BaseEditForm
    {
        public FrmZhiKongJianCha_KeShi_WenTiBianJi(EditModelHandle<T_ZHIKONG_KESHI_WENTI> SaveWenTiHandle, T_ZHIKONG_KESHI_WENTI model)
        {
            InitializeComponent();
            this.SaveWenTiHandle = SaveWenTiHandle;
            this._Model = model;
        }

        T_ZHIKONG_KESHI_WENTI _Model;
        EditModelHandle<T_ZHIKONG_KESHI_WENTI> SaveWenTiHandle;

        private void FrmZhiKongJianCha_KeShi_WenTiBianJi_Load(object sender, EventArgs e)
        {
            if (_Model != null)
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
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (SaveWenTiHandle(_Model, out errMsg))
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
