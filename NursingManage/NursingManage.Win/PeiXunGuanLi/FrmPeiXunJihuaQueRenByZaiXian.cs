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
    //再先考试中的，培训计划确认，只加入计划不设置模板，模板在线考试时随机分配
    public partial class FrmPeiXunJihuaQueRenByZaiXian : BaseListForm
    {
        public FrmPeiXunJihuaQueRenByZaiXian()
        {
            InitializeComponent();
        }

        ALPeiXunJiHuaQueRen _AL;

        void BindDataSource()
        {
            string shiFouQueRen = null;
            switch (coBoxQueRenZhuangTai.SelectedIndex)
            {
                case 1:
                    shiFouQueRen = "否";
                    break;
                case 2:
                    shiFouQueRen = "是";
                    break;
                default:
                    break;
            }
            string searchValue = tsTxtSearchJiHua.Text;
            DataTable dt = _AL.GetDataByJiHua(shiFouQueRen, searchValue);
            dgv.DataSource = dt;
            dgvRenYuan.DataSource = null;
        }
        void BindDataSourceByRenYuan()
        {
            var jiHuaKeShiModel = dgv.GetSelectedClassData<V_PEIXUNJIHUA_KESHI>();
            if (jiHuaKeShiModel != null)
            {
                DataTable dt = _AL.GetDataByRenYuan(jiHuaKeShiModel, tsTxtSearchRenYuan.Text);
                dgvRenYuan.DataSource = dt;
            }
        }
        
        private void FrmPeiXunJihuaQueRenByZaiXian_Load(object sender, EventArgs e)
        {
            coBoxQueRenZhuangTai.SelectedIndex = 1;
            _AL = new ALPeiXunJiHuaQueRen();
            tsBtnSearchJiHua_Click(sender, e);
        }

        private void tsBtnSearchJiHua_Click(object sender, EventArgs e)
        {
            BindDataSource();
        }
        private void tsTxtSearchJiHua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsBtnSearchJiHua_Click(sender, e);
            }
        }
        private void tsBtnJiHuaQueRen_Click(object sender, EventArgs e)
        {
            var jiHusKeShi = dgv.GetSelectedClassData<V_PEIXUNJIHUA_KESHI>();
            if (jiHusKeShi.SHIFOUQUEREN == "是")
            {
                ShowMessage("该计划已确认，无需确认。");
                return;
            }
            if (jiHusKeShi == null)
            {
                ShowMessage("未选中要确认的计划！");
                return;
            }
            if (!ShowQuestion("要对所选计划记录进行确认吗？", "确认提示")) return;
            string errMsg;
            if (_AL.JiHuaQueRen(jiHusKeShi, out errMsg))
            {
                ShowMessage("计划确认成功！");
                BindDataSource();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataSourceByRenYuan();
        }

        private void tsBtnSearchRenYuan_Click(object sender, EventArgs e)
        {
            BindDataSourceByRenYuan();
        }

        private void tsTxtSearchRenYuan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsBtnSearchRenYuan_Click(sender, e);
            }
        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            //增加计划人员
            var model = dgv.GetSelectedClassData<V_PEIXUNJIHUA_KESHI>();
            if (model == null)
            {
                ShowMessage("没有选中任何计划记录！");
                return;
            }
            var dt = _AL.GetDataByAddRenYuan(model);
            FrmDangAnXuanXe frm = new FrmDangAnXuanXe(dt);
            frm.Text = string.Format("选择 添加计划确认人员 ");
            frm.OnSelectedHandle += (datas) =>
            {
                string msg;
                if (_AL.AddRenYuanToJiHua(model, datas, out msg))
                {
                    BindDataSourceByRenYuan();
                }
                ShowMessage(msg);
            };
            frm.ShowDialog();
        }

        private void tsBtnRemove_Click(object sender, EventArgs e)
        {
            //移除计划人员
            var model = dgvRenYuan.GetSelectedClassData<V_PEIXUNJIHUA_MINGXI>();
            if (model == null)
            {
                ShowMessage("没有选中任何行！");
                return;
            }
            if (!ShowQuestion("确认是要移除当前选中人员吗？", "移除人员确认")) return;
            string errMsg;
            if (_AL.RemoveJiaHuaRenYuan(model, out errMsg))
            {
                ShowMessage("移除计划人员完成。");
                BindDataSourceByRenYuan();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }
    }
}