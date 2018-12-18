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

namespace NursingManage.Win.ZhiLiangKongZhi
{
    public partial class FrmZhiKongJianCha_KeShi_ChuangJian : BaseEditForm
    {
        public FrmZhiKongJianCha_KeShi_ChuangJian(EditModelHandle<T_ZHIKONG_KESHI> SaveKeShiJianCha, T_ZHIKONG_KESHI model, Func<DataTable> GetRenYuanByKeShi)
        {
            InitializeComponent();
            this.SaveKeShiJianCha = SaveKeShiJianCha;
            this._Model = model;
            this.GetRenYuanByKeShi = GetRenYuanByKeShi;
        }

        EditModelHandle<T_ZHIKONG_KESHI> SaveKeShiJianCha;
        T_ZHIKONG_KESHI _Model;
        Func<DataTable> GetRenYuanByKeShi;

        private void FrmZhiKongJianCha_KeShi_ChuangJian_Load(object sender, EventArgs e)
        {
            if (_Model != null)
            {
                dcm1.SetControlValue(_Model);
            }
            else
            {
                _Model = new T_ZHIKONG_KESHI();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (SaveKeShiJianCha(_Model, out errMsg))
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

        private void btnZhiKongRenYuanXuanZe_Click(object sender, EventArgs e)
        {
            var dt = GetRenYuanByKeShi();
            FrmDangAnXuanXe frm = new FrmDangAnXuanXe(dt);
            frm.Text = string.Format("选择计划确认人员 ");
            frm.OnSelectedHandle += (datas) =>
            {
                if (datas != null && datas.Count > 0)
                {
                    var renYuanXingMing = datas.Select(s => s.XINGMING).ToArray();
                    txtZHIKONGRENYUAN.Text = string.Join(",", renYuanXingMing);
                }
                else
                {
                    txtZHIKONGRENYUAN.Text = string.Empty;
                }
            };
            frm.ShowDialog();
        }

        private void btnCanJiaRenYuanXuanZe_Click(object sender, EventArgs e)
        {
            var dt = GetRenYuanByKeShi();
            FrmDangAnXuanXe frm = new FrmDangAnXuanXe(dt);
            frm.Text = string.Format("选择计划确认人员 ");
            frm.OnSelectedHandle += (datas) =>
            {
                if (datas != null && datas.Count > 0)
                {
                    var renYuanXingMing = datas.Select(s => s.XINGMING).ToArray();
                    txtCANJIARENYUAN.Text = string.Join(",", renYuanXingMing);
                }
                else
                {
                    txtCANJIARENYUAN.Text = string.Empty;
                }
            };
            frm.ShowDialog();
        }
    }
}