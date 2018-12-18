using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;
using HursingManage.AL.PeiXuNGuanLi;
using Framework.Common.CommonFunction;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmJiNengBiaoZhun : BaseListForm
    {
        public FrmJiNengBiaoZhun()
        {
            InitializeComponent();
        }

        ALJiNengBiaoZhun _AL;
        void BindDataByLeiBie()
        {
            var dt = _AL.GetDataByLeiBie(txtSearchByLeiBie.Text);
            dgvLeiBie.DataSource = dt;
            dgvNeiRong.DataSource = null;
        }
        void BindDataByNeiRong()
        {
            var leiBie = dgvLeiBie.GetSelectedClassData<T_JINENGLEIBIE>();
            if (leiBie != null)
            {
                var dt = _AL.GetDataByBiaoZhun(leiBie, txtSearchByNeiRong.Text);
                dgvNeiRong.DataSource = dt;
            }
        }

        private void FrmJiNengBiaoZhun_Load(object sender, EventArgs e)
        {
            _AL = new ALJiNengBiaoZhun();
        }
        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddByLeiBie_Click(object sender, EventArgs e)
        {
            FrmJiNengBiaoZhunLeiBieEdit frm = new FrmJiNengBiaoZhunLeiBieEdit(_AL.AddLeiBie, null);
            frm.Text = "新增 技能标准类别";
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("新增类别成功。");
                BindDataByLeiBie();
            }
        }
        private void btnEditByLeiBie_Click(object sender, EventArgs e)
        {
            var leiBie = dgvLeiBie.GetSelectedClassData<T_JINENGLEIBIE>();
            if (leiBie == null)
            {
                ShowMessage("未选中任何记录。");
                return;
            }
            FrmJiNengBiaoZhunLeiBieEdit frm = new FrmJiNengBiaoZhunLeiBieEdit(_AL.UpdateLeiBie, leiBie);
            frm.Text = "修改 技能标准类别";
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改类别成功。");
                BindDataByLeiBie();
            }
        }
        private void btnDeleteByLeiBie_Click(object sender, EventArgs e)
        {
            var leiBie = dgvLeiBie.GetSelectedClassData<T_JINENGLEIBIE>();
            if (leiBie == null)
            {
                ShowMessage("未选中任何记录。");
                return;
            }
            if (ShowQuestion("确定要删除当前选中记录吗？", "删除确认"))
            {
                string errMsg;
                if (_AL.DeleteLeiBie(leiBie, out errMsg))
                {
                    ShowMessage("删除成功！");
                    BindDataByLeiBie();
                }
                else
                {
                    ShowMessage(errMsg);
                }
            }
        }
        private void dgvLeiBie_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataByNeiRong();
        }
        private void txtSearchByLeiBie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchByLeiBie_Click(sender, e);
            }
        }
        private void btnSearchByLeiBie_Click(object sender, EventArgs e)
        {
            BindDataByLeiBie();
        }
        private void btnAddByNeiRong_Click(object sender, EventArgs e)
        {
            var leiBie = dgvLeiBie.GetSelectedClassData<T_JINENGLEIBIE>();
            if (leiBie == null)
            {
                ShowMessage("请先选中一个类别。");
                return;
            }
            T_JINENGBIAOZHUN model = new T_JINENGBIAOZHUN();
            model.LEIBIEID = leiBie.ID;
            model.LEIBIE = leiBie.MINGCHENG;
            FrmJiNengBiaoZhunEdit frm = new FrmJiNengBiaoZhunEdit(_AL.AddBiaoZhun, model);
            frm.Text = "新增 技能标准";
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("新增技能标准成功！");
                BindDataByNeiRong();
            }
        }
        private void btnEditByNeiRong_Click(object sender, EventArgs e)
        {
            var biaoZhun = dgvNeiRong.GetSelectedClassData<T_JINENGBIAOZHUN>();
            if (biaoZhun == null)
            {
                ShowMessage("未选中任何记录。");
                return;
            }
            FrmJiNengBiaoZhunEdit frm = new FrmJiNengBiaoZhunEdit(_AL.UpdateBiaoZhun, biaoZhun);
            frm.Text = "修改 技能标准";
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改技能标准成功！");
                BindDataByNeiRong();
            }
        }
        private void btnDeleteByNeiRong_Click(object sender, EventArgs e)
        {
            var biaoZhun = dgvNeiRong.GetSelectedClassData<T_JINENGBIAOZHUN>();
            if (biaoZhun == null)
            {
                ShowMessage("未选中任何记录。");
                return;
            }
            if (ShowQuestion("确定要删除当前选中记录吗？", "删除确认"))
            {
                string errMsg;
                if (_AL.DeleteBiaoZhun(biaoZhun, out errMsg))
                {
                    ShowMessage("删除成功！");
                    BindDataByNeiRong();
                }
                else
                {
                    ShowMessage(errMsg);
                }
            }
        }

        T_JINENGLEIBIE _SelectedLeiBie; //已选中的类别对象
        private void btnDaoRuBiaoZhun_Click(object sender, EventArgs e)
        {
            _SelectedLeiBie = dgvLeiBie.GetSelectedClassData<T_JINENGLEIBIE>();
            if (_SelectedLeiBie == null)
            {
                ShowMessage("请先选中一个类别。");
                return;
            }
            FrmExcelImport impFrm = new FrmExcelImport(ImportAdd);
            impFrm.Text = string.Format("向类别：{0} 中导入技能标准", _SelectedLeiBie.MINGCHENG);
            impFrm.ShowDialog();
        }
        bool ImportAdd(DataRow item, out string errMsg)
        {
            T_JINENGBIAOZHUN model = new T_JINENGBIAOZHUN();
            model.LEIBIE = _SelectedLeiBie.MINGCHENG;
            model.LEIBIEID = _SelectedLeiBie.ID;
            model.XUHAO = Utils.ConvertDataRow<int>(item, "序号");
            model.XIANGMU = Utils.ConvertDataRow<string>(item, "项目");
            model.CAOZUOYAODIAN = Utils.ConvertDataRow<string>(item, "操作要点");
            model.PINGJIAYAODIAN = Utils.ConvertDataRow<string>(item, "评价要点");
            model.FENZHI = Utils.ConvertDataRow<int>(item, "分值");
            return _AL.AddBiaoZhun(model, out errMsg);
        }
        private void txtSearchByNeiRong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchByNeiRong_Click(sender, e);
            }
        }
        private void btnSearchByNeiRong_Click(object sender, EventArgs e)
        {
            BindDataByNeiRong();
        }
    }
}
