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
    public partial class FrmChangePassword : BaseEditForm
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string errMsg;
            bool r = _AL.ChangePassword(txtOldPwd.Text, txtNewPwd.Text, txtRNewPwd.Text, out errMsg);
            if (r)
            {
                MessageBox.Show("修改密码成功!");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }
        ALLogin _AL;
        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            _AL = new ALLogin();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
