using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;
using NursingManage.Win.XiTongGuanLi;
using HursingManage.AL;
using Framework.Common.Helpers;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    public partial class FrmZhiKongJianChaQueRenNeiRong : BaseEditForm
    {
        public FrmZhiKongJianChaQueRenNeiRong(V_ZHIKONGJIHUA_NEIRONG model, Func<DataTable> GetJianChaRenYuanHandle, EditModelHandle<T_ZHIKONGJIHUA_NEIRONG> SaveNeiRongHandle)
        {
            InitializeComponent();
            this._Model = model;
            this.GetJianChaRenYuanHandle = GetJianChaRenYuanHandle;
            this.SaveNeiRongHandle = SaveNeiRongHandle;
        }

        V_ZHIKONGJIHUA_NEIRONG _Model;
        Func<DataTable> GetJianChaRenYuanHandle;
        EditModelHandle<T_ZHIKONGJIHUA_NEIRONG> SaveNeiRongHandle;

        private void FrmZhiKongJianChaQueRenNeiRong_Load(object sender, EventArgs e)
        {
            dtpJIANCHASHIJIAN.Value = DateTime.Now;
            dcm1.SetControlValue(_Model);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dcm1.SetValueToClassObj(_Model);
            T_ZHIKONGJIHUA_NEIRONG model = new T_ZHIKONGJIHUA_NEIRONG();
            ReflectionHelper.SetPropertyValue(model, _Model);
            string errMsg;
            if (SaveNeiRongHandle(model, out errMsg))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataTable dt = GetJianChaRenYuanHandle();
            FrmYongHuXuanZe frm = new FrmYongHuXuanZe(dt);
            frm.Text = string.Format("选择 质控检查人员 ");
            frm.OnSelectedHandle += (datas) =>
            {
                txtJianChaRenYuan.Clear();
                StringBuilder sb = new StringBuilder();                
                if (!datas.Exists(s => s.ID == ALCommon.Instance.CurrentLoginUser.ID))
                {   
                    datas.Insert(0, ALCommon.Instance.CurrentLoginUser);
                }
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
                txtJianChaRenYuan.AppendText(sb.ToString());
            };
            frm.ShowDialog();
        }
    }
}
