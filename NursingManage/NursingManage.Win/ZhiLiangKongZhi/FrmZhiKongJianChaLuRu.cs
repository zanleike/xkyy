using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;
using NursingManage.Win.PeiXunGuanLi;
using HursingManage.AL;
using NursingManage.Win.XiTongGuanLi;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    public partial class FrmZhiKongJianChaLuRu : BaseEditForm
    {
        public FrmZhiKongJianChaLuRu(EditModelHandle<T_ZHIKONGJIHUA_KESHI> SaveJianChaHandle, Func<DataTable> GetJianChaRenYuanHandle, T_ZHIKONGJIHUA_KESHI model = null)
        {
            InitializeComponent();
            this.SaveJianChaHandle = SaveJianChaHandle;
            this._Model = model;
            this.GetJianChaRenYuanHandle = GetJianChaRenYuanHandle;
        }
        T_ZHIKONGJIHUA_KESHI _Model;
        EditModelHandle<T_ZHIKONGJIHUA_KESHI> SaveJianChaHandle;
        Func<DataTable> GetJianChaRenYuanHandle;

        private void FrmZhiKongJianChaLuRu_Load(object sender, EventArgs e)
        {
            dcm1.SetControlValue(_Model);
            dtpXianQiZhengGai.Value = dtpJianChaJieShu.Value.AddDays(7);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (SaveJianChaHandle(_Model, out errMsg))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }
        private void btnXuanZeRenYuan_Click(object sender, EventArgs e)
        {
            DataTable dt = GetJianChaRenYuanHandle();
            FrmYongHuXuanZe frm = new FrmYongHuXuanZe(dt);
            frm.Text = string.Format("选择 质控检查人员 ");
            frm.OnSelectedHandle += (datas) =>
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in datas)
                {
                    sb.AppendFormat("{0},", item.USER_NAME);
                }
                if (sb.Length > 0)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                if (txtJianChaRenYuan.Text.Length > 0 && sb.Length > 0)
                {
                    txtJianChaRenYuan.AppendText(",");
                }
                txtJianChaRenYuan.AppendText( sb.ToString());
                //txtJianChaRenYuan.Text = sb.ToString();
            };
            frm.ShowDialog();
        }
    }
}