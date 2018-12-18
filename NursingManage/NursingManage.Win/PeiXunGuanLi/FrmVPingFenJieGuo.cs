using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmVPingFenJieGuo : BaseEditForm
    {
        public FrmVPingFenJieGuo(List<V_SHITI_MUBAN_MINGXI> muBanMingXi)
        {
            InitializeComponent();
            this._MuBanMingXi = muBanMingXi;
        }
        List<V_SHITI_MUBAN_MINGXI> _MuBanMingXi;

        private void FrmVPingFenJieGuo_Load(object sender, EventArgs e)
        {
            //col_NEIRONG.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv.DataSource = _MuBanMingXi;            
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}