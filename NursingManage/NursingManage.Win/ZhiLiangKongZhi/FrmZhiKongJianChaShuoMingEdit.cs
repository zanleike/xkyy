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
    public partial class FrmZhiKongJianChaShuoMingEdit : BaseEditForm
    {
        public FrmZhiKongJianChaShuoMingEdit(T_ZHIKONGJIHUA_JIEGUO jieGuoModel, EditModelHandle<T_ZHIKONGJIHUA_JIEGUO> SaveJieGuoShuoMingHandel)
        {
            InitializeComponent();
            this._JieGuoModel = jieGuoModel;
            this.SaveJieGuoShuoMingHandel = SaveJieGuoShuoMingHandel;
        }
        T_ZHIKONGJIHUA_JIEGUO _JieGuoModel;
        EditModelHandle<T_ZHIKONGJIHUA_JIEGUO> SaveJieGuoShuoMingHandel;

        private void FrmZhiKongJianChaShuoMingEdit_Load(object sender, EventArgs e)
        {
            if (_JieGuoModel == null)
            {
                MessageBox.Show("所选问题项记录为空！");
                this.Close();
                return;
            }
            dcm1.SetControlValue(_JieGuoModel);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string errMsg;
            _JieGuoModel.JIANCHAJIEGUO = txtJianChaJieGuo.Text;
            if (SaveJieGuoShuoMingHandel(_JieGuoModel, out errMsg))
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
    }
}