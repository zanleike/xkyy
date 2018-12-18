using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZCJH.HursingManage.AL.ZhiLiangKongZhi;
using ZCJH.HursingManage.DBModel;

namespace ZCJH.NursingManage.Win.ZhiLiangKongZhi
{
    public partial class FrmZhiKongJianChaQueRen : BaseListForm
    {
        public FrmZhiKongJianChaQueRen()
        {
            InitializeComponent();
        }
        ALZhiKongJianChaQueRen _AL;
        void BindDataByJihua()
        {
            DataTable dt = _AL.GetDataByJiHua(txtSearch.Text);
            dgvJiHuaKeShi.DataSource = dt;
            dgvJieGuo.DataSource = null;
        }
        void BindDataByJieGuo()
        {
            var model = dgvJiHuaKeShi.GetSelectedClassData<V_ZHIKONGJIHUA_KESHI>();
            if (model != null)
            {
                DataTable dt = _AL.GetJieGuoData(model);
                dgvJieGuo.DataSource = dt;
            }
        }

        private void FrmZhiKongJianChaQueRen_Load(object sender, EventArgs e)
        {
            _AL = new ALZhiKongJianChaQueRen();
            dgvJieGuo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            col_JIANCHAJIEGUO.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataByJihua();
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }
        private void dgvJiHuaKeShi_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataByJieGuo();
        }

        private void btnJianChaLuRu_Click(object sender, EventArgs e)
        {
            V_ZHIKONGJIHUA_KESHI jiHuaKeShi = dgvJiHuaKeShi.GetSelectedClassData<V_ZHIKONGJIHUA_KESHI>();
            if (jiHuaKeShi == null)
            {
                ShowMessage("当前选中记录为空。");
                return;
            }
            if (jiHuaKeShi.SHIFOUJIANCHA != "是")
            {
                ShowMessage("未检查项目不可确认。");
                return;
            }
            DataTable jianChaJieGuo = dgvJieGuo.DataSource as DataTable;
            FrmZhiKongJianChaQueRenEdit frm = new FrmZhiKongJianChaQueRenEdit(_AL.SaveJianChaShuoMing, jianChaJieGuo, jiHuaKeShi);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindDataByJihua();
            }
        }
    }
}