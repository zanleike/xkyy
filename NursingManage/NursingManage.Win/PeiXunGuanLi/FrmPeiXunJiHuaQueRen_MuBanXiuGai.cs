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
    public partial class FrmPeiXunJiHuaQueRen_MuBanXiuGai : BaseEditForm
    {
        public FrmPeiXunJiHuaQueRen_MuBanXiuGai(List<T_PEIXUNJIHUA_MUBAN> muBanLieBiao)
        {
            InitializeComponent();
            this._MuBanLieBiao = muBanLieBiao;
        }

        T_PEIXUNJIHUA_MUBAN _SelectedMuBan;
        public T_PEIXUNJIHUA_MUBAN SelectedMuBan
        {
            get
            {
                return _SelectedMuBan;
            }
        }
        List<T_PEIXUNJIHUA_MUBAN> _MuBanLieBiao;

        private void FrmPeiXunJiHuaQueRen_MuBanXiuGai_Load(object sender, EventArgs e)
        {
            if (_MuBanLieBiao == null || _MuBanLieBiao.Count == 0)
            {
                MessageBox.Show("没有可用的模板。");
                this.Close();
                return;
            }
            coBoxMuBan.DataSource = _MuBanLieBiao;
            coBoxMuBan.DisplayMember = T_PEIXUNJIHUA_MUBAN.CNMUBAN;
            coBoxMuBan.ValueMember = T_PEIXUNJIHUA_MUBAN.CNID;
            coBoxMuBan.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _SelectedMuBan = coBoxMuBan.SelectedItem as T_PEIXUNJIHUA_MUBAN;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}