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
    public partial class FrmZhiKongJianCha_KeShi_QueRen : BaseEditForm
    {
        public FrmZhiKongJianCha_KeShi_QueRen(T_ZHIKONG_KESHI model, object jieGuoData,EditModelHandle<T_ZHIKONG_KESHI> ShangBaoZhiKongHandle)
        {
            InitializeComponent();
            this._JieGuoData = jieGuoData;
            this._Model = model;
            this.ShangBaoZhiKongHandle = ShangBaoZhiKongHandle;
        }
        object _JieGuoData;
        T_ZHIKONG_KESHI _Model;
        EditModelHandle<T_ZHIKONG_KESHI> ShangBaoZhiKongHandle;

        private void FrmZhiKongJianCha_KeShi_QueRen_Load(object sender, EventArgs e)
        {
            dgvJieGuo.DataSource = _JieGuoData;
            dcm1.SetControlValue(_Model);
        }

        void ShangBaoZhiKong()
        {
            
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (ShangBaoZhiKongHandle(_Model, out errMsg))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ShowQuestion("确定要上报质控记录吗？该操作不可撤销", "上报质控记录确认"))
            {
                return;
            }
            _Model.SHANGBAOZHUANGTAI = "是";
            ShangBaoZhiKong();
        }
        private void btnOnlySave_Click(object sender, EventArgs e)
        {
            _Model.SHANGBAOZHUANGTAI = "否";
            ShangBaoZhiKong();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}