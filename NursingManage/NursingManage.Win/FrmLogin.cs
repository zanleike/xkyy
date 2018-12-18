using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL;

namespace NursingManage.Win
{
    public partial class FrmLogin : BaseForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        } 

        ALLogin _AL;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            _AL = new ALLogin();
            version.Text = ProductVersion;
        }

        private void txtGongHao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMiMa.Focus();
            }
        }

        private void txtMiMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string gongHao = txtGongHao.Text;
            string pwd = txtMiMa.Text;
            ViewResultBase r = _AL.Login(gongHao, pwd);
            if (r.IsSuccess)
            {
                ShowMessage("登录成功");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(r.ErrMessage);
            }
        }

        private void txtGongHao_Leave(object sender, EventArgs e)
        {
             
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}