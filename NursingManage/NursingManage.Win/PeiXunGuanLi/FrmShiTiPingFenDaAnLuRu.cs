using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmShiTiPingFenDaAnLuRu : BaseEditForm
    {
        public FrmShiTiPingFenDaAnLuRu(EditModelHandle<String> SaveDaAnHandle)
        {
            InitializeComponent();
            this.SaveDaAnHandle = SaveDaAnHandle;            
        }
        EditModelHandle<String> SaveDaAnHandle;

        private void FrmShiTiPingFenDaAnLuRu_Load(object sender, EventArgs e)
        {
            txtDaAn.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string errMsg;
            if (SaveDaAnHandle(txtDaAn.Text.Trim(), out errMsg))
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