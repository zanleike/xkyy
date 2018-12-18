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
    public partial class FrmShiTiPingFen : BaseListForm
    {
        public FrmShiTiPingFen()
        {
            InitializeComponent();
        }
        ALShiTiPingFen _AL;

        private void FrmShiTiPingFen_Load(object sender, EventArgs e)
        {
            _AL = new ALShiTiPingFen();
        }
        void BindDataByJiHua()
        {
            DataTable dt = _AL.GetDataByJiHuaKeShi(txtJiHuaSouSuo.Text);
            dgvJiHuaKeShi.DataSource = dt;
            dgvRenYuan.DataSource = null;
        }
        void BindDataByRenYuan()
        {
            var model = dgvJiHuaKeShi.GetSelectedClassData<V_PEIXUNJIHUA_KESHI>();
            if (model != null)
            {
                DataTable dt = _AL.GetDataByRenYuan(model, txtRenYuanSouSuo.Text);
                dgvRenYuan.DataSource = dt;
            }
        }
        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            BindDataByJiHua();
        }
        private void txtJiHuaSouSuo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsBtnSearch_Click(sender, e);
            }
        }
        private void dgvJiHuaKeShi_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataByRenYuan();
        }
        private void btnShiTiPingFen_Click(object sender, EventArgs e)
        {
            var jiHuaModel = dgvJiHuaKeShi.GetSelectedClassData<V_PEIXUNJIHUA_KESHI>();
            if (jiHuaModel == null)
            {
                ShowMessage("当前选择计划为空.");
                return;
            }
            var jiHuaXimu = dgvRenYuan.GetSelectedClassData<V_PEIXUNJIHUA_MINGXI>();
            if (jiHuaXimu == null)
            {
                ShowMessage("当前选择人员为空.");
                return;
            }
            var muBanMingXiData = _AL.GetMuBanMingXiData(jiHuaXimu);
            FrmShiTiPingFenLuRu frm = new FrmShiTiPingFenLuRu(_AL.SavePingFeng, muBanMingXiData, jiHuaXimu);
            frm.Text = string.Format("考试人员：{0}", jiHuaXimu.XINGMING);
            frm.WindowState = FormWindowState.Maximized;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("评分完成");
                BindDataByRenYuan();
            }
        }

        private void btnRenYuanSouSuo_Click(object sender, EventArgs e)
        {
            BindDataByRenYuan();
        }

        private void txtRenYuanSouSuo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRenYuanSouSuo_Click(sender, e);
            }
        }

        private void tsbtnADSearch_Click(object sender, EventArgs e)
        {
            AdvanceSearchConfig.ShowAdvanceSearchForm<V_PEIXUNJIHUA_KESHI>(this, _AL, dgvJiHuaKeShi);
        }

        private void tsbtnChongKao_Click(object sender, EventArgs e)
        {
            var jiHuaXimu = dgvRenYuan.GetSelectedClassData<V_PEIXUNJIHUA_MINGXI>();
            if (jiHuaXimu == null)
            {
                ShowMessage("当前选择人员为空.");
                return;
            }
            if (!ShowQuestion("确实要重置考试人员状态吗？此操作将重新考试", "重置确认"))
            {
                return;
            }
            string errMsg;
            if (!_AL.ChongZhiZhuangTai(jiHuaXimu, out errMsg))
            {
                ShowMessage(errMsg);
            }
            else
            {
                ShowMessage("重置状态成功，可重新考试。");
                BindDataByRenYuan();
            }
        }
    }
}