using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NursingManage.Win
{
    public partial class FrmHomePage : BaseForm
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }

        private void FrmHomePage_Load(object sender, EventArgs e)
        {

        }
        private void FrmHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FrmMain.IsApplicationExit)
            {
                e.Cancel = true;
            }
        }
    }
}