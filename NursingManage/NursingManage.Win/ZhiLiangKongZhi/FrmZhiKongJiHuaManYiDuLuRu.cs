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
    public partial class FrmZhiKongJiHuaManYiDuLuRu : BaseEditForm
    {
        public FrmZhiKongJiHuaManYiDuLuRu(V_ZHIKONGJIHUA_KESHI model,EditModelHandle<V_ZHIKONGJIHUA_KESHI> SaveManYiDuHandle)
        {
            InitializeComponent();
            this._Model = model;
            this.SaveManYiDuHandle = SaveManYiDuHandle;
        }
        V_ZHIKONGJIHUA_KESHI _Model;
        EditModelHandle<V_ZHIKONGJIHUA_KESHI> SaveManYiDuHandle;

        private void FrmZhiKongJiHuaManYiDuLuRu_Load(object sender, EventArgs e)
        {
            dcm1.SetControlValue(_Model);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (!SaveManYiDuHandle(_Model, out errMsg))
            {
                ShowMessage(errMsg);
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
