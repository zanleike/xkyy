using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL.PeiXuNGuanLi;
using HursingManage.DBModel;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmVPingFenHuiZong : BaseListForm
    {
        public FrmVPingFenHuiZong()
        {
            InitializeComponent();
        }

        ALVPingFenHuiZong _AL;
        void BindDataSource()
        {
            var dt = _AL.GetData(tsTxtSearchValue.Text);
            dgv.DataSource = dt;
            tslbRecordCount.Text = dgv.Rows.Count.ToString();
        }
        private void FrmVPingFenHuiZong_Load(object sender, EventArgs e)
        {
            _AL = new ALVPingFenHuiZong();
        }
        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            BindDataSource();
        }

        private void tsTxtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsBtnSearch_Click(sender, e);
            }
        }

        private void tsbtnADSearch_Click(object sender, EventArgs e)
        {
            if (AdvanceSearchConfig.ShowAdvanceSearchForm<V_PEIXUNJIEGUO_HUIZONG>(this, _AL, dgv) == System.Windows.Forms.DialogResult.OK)
            {
                tslbRecordCount.Text = dgv.Rows.Count.ToString();    
            }
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}