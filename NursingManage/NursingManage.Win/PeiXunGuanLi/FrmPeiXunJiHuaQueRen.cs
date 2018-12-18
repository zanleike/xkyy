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
    public partial class FrmPeiXunJiHuaQueRen : BaseListForm
    {
        public FrmPeiXunJiHuaQueRen()
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
            dgvJiHuaMuBan.DataSource = null;
        }
        void BindDataByJiHuaMuBan()
        {
            var model = dgv.GetSelectedClassData<V_PEIXUNJIHUA_KESHI>();
            if (model != null)
            {
                dgvJiHuaMuBan.DataSource = _AL.GetJiHuaMuBanData(model);
            }
        }
        void BindDataSourceByRenYuan()
        {
            var jiHuaKeShiModel = dgv.GetSelectedClassData<V_PEIXUNJIHUA_KESHI>();
            var jiHuaMuBanModel = dgvJiHuaMuBan.GetSelectedClassData<T_PEIXUNJIHUA_MUBAN>();
            if (jiHuaKeShiModel != null && jiHuaMuBanModel != null)
            {
                DataTable dt = _AL.GetDataByRenYuan(jiHuaKeShiModel, jiHuaMuBanModel, tsTxtSearchRenYuan.Text);
                dgvRenYuan.DataSource = dt;
            }
        }

        private void FrmPeiXunJiHuaQueRen_Load(object sender, EventArgs e)
        {
            coBoxQueRenZhuangTai.SelectedIndex = 1;
            _AL = new ALPeiXunJiHuaQueRen();
            tsBtnSearchJiHua_Click(sender, e);
            tsbtnQueRenQuXiao.Visible = !IsHuShiZhangLogin;
        }
        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsTxtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindDataSourceByRenYuan();
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
            if (model.SHIFOUQUEREN == "是")
            {
                ShowMessage("该计划已经确认，不允许对人员进行更改。");
                return;
            }
            var muBanModel = dgvJiHuaMuBan.GetSelectedClassData<T_PEIXUNJIHUA_MUBAN>();
            if (muBanModel == null)
            {
                ShowMessage("没有选中任何模板记录！");
                return;
            }
            var dt = _AL.GetDataByAddRenYuan(model);
            FrmDangAnXuanXe frm = new FrmDangAnXuanXe(dt);
            frm.Text = string.Format("选择 添加计划确认人员 ");
            frm.OnSelectedHandle += (datas) =>
            {
                string msg;
                if (_AL.AddRenYuanToJiHua(model, muBanModel, datas, out msg))
                {
                    BindDataSourceByRenYuan();
                }
                ShowMessage(msg);
            };
            frm.ShowDialog();
        }
        private void tsBtnRemove_Click(object sender, EventArgs e)
        {
            var JiHuaKeShiModel = dgv.GetSelectedClassData<V_PEIXUNJIHUA_KESHI>();
            if (JiHuaKeShiModel == null)
            {
                ShowMessage("没有选中任何培训计划。");
                return;
            }
            if (JiHuaKeShiModel.SHIFOUQUEREN == "是")
            {
                ShowMessage("该计划已经确认，不允许对人员进行更改。");
                return;
            }
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
        private void dgv_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataByJiHuaMuBan();
            BindDataSourceByRenYuan();
        }
        private void tsBtnSearchJiHua_Click(object sender, EventArgs e)
        {
            BindDataSource();
        }
        private void tsTxtSearchJiHua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindDataSource();
            }
        }
        private void tsBtnJiHuaQueRen_Click(object sender, EventArgs e)
        {
            var jiHuaKeShi = dgv.GetSelectedClassData<V_PEIXUNJIHUA_KESHI>();
            if (jiHuaKeShi == null)
            {
                ShowMessage("没有选中任何要确认的记录。");
                return;
            }
            if (jiHuaKeShi.SHIFOUQUEREN == "是")
            {
                ShowMessage("该计划已确认，无需确认。");
                return;
            }
            if (!ShowQuestion("要对所选计划记录进行确认吗？请确保对考试人员添加正确，确认后不可对人员进行更改。", "确认提示")) return;
            string errMsg;

            FrmPeiXunJiHuaQueRen_WeiKaoLuRu frm = new FrmPeiXunJiHuaQueRen_WeiKaoLuRu(jiHuaKeShi);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (_AL.JiHuaQueRen(jiHuaKeShi, out errMsg))
                {
                    ShowMessage("计划确认成功！");
                    BindDataSource();
                }
                else
                {
                    ShowMessage(errMsg);
                }
            }
        }
        private void tsbtnFenPeiByRenYuan_Click(object sender, EventArgs e)
        {
            var JiHuaKeShiModel = dgv.GetSelectedClassData<V_PEIXUNJIHUA_KESHI>();
            if (JiHuaKeShiModel == null)
            {
                ShowMessage("没有选中任何培训计划。");
                return;
            }
            if (JiHuaKeShiModel.SHIFOUQUEREN == "是")
            {
                ShowMessage("该计划已经确认，不允许对人员进行更改。");
                return;
            }
            var muBanModel = dgvJiHuaMuBan.GetSelectedClassData<T_PEIXUNJIHUA_MUBAN>();
            if (muBanModel == null)
            {
                ShowMessage("没有选中任何模板记录。");
                return;
            }
            var dt = _AL.GetDataByAddRenYuan(JiHuaKeShiModel);
            FrmDangAnXuanXe frm = new FrmDangAnXuanXe(dt);
            frm.Text = string.Format("选择计划确认人员 ");
            frm.OnSelectedHandle += (datas) =>
            {
                string msg;
                if (_AL.AddRenYuanToJiHua(JiHuaKeShiModel, muBanModel, datas, out msg))
                {
                    BindDataSourceByRenYuan();
                }
                ShowMessage(msg);
            };
            frm.ShowDialog();
        }
        private void tsBtnSearchRenYuan_Click(object sender, EventArgs e)
        {
            BindDataSourceByRenYuan();
        }
        private void dgvJiHuaMuBan_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataSourceByRenYuan();
        }
        private void tsbtnQueRenQuXiao_Click(object sender, EventArgs e)
        {
            var JiHuaKeShiModel = dgv.GetSelectedClassData<V_PEIXUNJIHUA_KESHI>();
            if (JiHuaKeShiModel == null)
            {
                ShowMessage("没有选中任何计划记录。");
                return;
            }
            if (!ShowQuestion("确认要对该计划进行取消确认吗？取消确认后不可对人员进行评分", "确认提示"))
            {
                return;
            }
            string errMsg;
            if (_AL.QuXiaoQuRen(JiHuaKeShiModel, out errMsg))
            {
                ShowMessage("取消计划成功");
            }
            else
            {
                ShowMessage(errMsg);
            }
        }
        private void tsmiXiuGaiMuBan_Click(object sender, EventArgs e)
        {
            var renYuanModel = dgvRenYuan.GetSelectedClassData<T_PEIXUNJIHUA_MINGXI>();
            if (renYuanModel == null)
            {
                ShowMessage("没有选中任何行！");
                return;
            }
            var muBanList = dgvJiHuaMuBan.DataSource as List<T_PEIXUNJIHUA_MUBAN>;
            if (!ShowQuestion("确认是要将当前选中人员转移到其它模板种吗？如果已经评分则会重新对该人员试题进行评分", "改变模板确认")) return;
            FrmPeiXunJiHuaQueRen_MuBanXiuGai frm = new FrmPeiXunJiHuaQueRen_MuBanXiuGai(muBanList);
            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            var newMuBan = frm.SelectedMuBan;
            string errMsg;
            if (_AL.ChangeJiaHuaRenYuan(renYuanModel, newMuBan, out errMsg))
            {
                ShowMessage("转移计划人员完成。");
                BindDataSource();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void tsbtnJiHuaQueRen2_Click(object sender, EventArgs e)
        {
            //TOOD:已不用，改到计划确认中
            var keShiModel = dgv.GetSelectedClassData<V_PEIXUNJIHUA_KESHI>();
            if (keShiModel == null)
            {
                ShowMessage("未选中任何科室计划记录。");
                return;
            }
            FrmPeiXunJiHuaQueRen_WeiKaoLuRu frm = new FrmPeiXunJiHuaQueRen_WeiKaoLuRu(keShiModel);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("科室确认完毕。");
            }
        }
    }
}