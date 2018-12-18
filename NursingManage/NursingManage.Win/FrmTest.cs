using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.Common.Helpers;

namespace NursingManage.Win
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void FrmTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                var a = this.ActiveControl.Name;
                SendKeys.Send("{Tab}");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                SendKeys.Send("{Tab}");
            }
        }

        private void btnJiaMi_Click(object sender, EventArgs e)
        {
            txtResult.Text = DEncrypt.Encrypt(txtSource.Text);
        }

        private void btnJieMi_Click(object sender, EventArgs e)
        {
            txtResult.Text = DEncrypt.Decrypt(txtSource.Text);
        }
    }
}
