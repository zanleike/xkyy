using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using HursingManage.AL.PeiXuNGuanLi;
using HursingManage.DBModel;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmShiTiMuBan : BaseListForm
    {
        public FrmShiTiMuBan()
        {
            InitializeComponent();
        }
        ALShiTiMuBan _AL;
        void BindDataByMuBan()
        {
            var dt = _AL.GetDataByMuBan(tsTxtUserSearch.Text);
            dgvMuBan.DataSource = dt;
            dgvShiTi.DataSource = null;
            //dgvShiTiLeiBie.DataSource = null;
        }
        void BindDataByShiTi()
        {
            var muBanModel = dgvMuBan.GetSelectedClassData<T_SHITI_MUBAN>();
            if (muBanModel != null)
            {
                DataTable dt = _AL.GetDataByMuBanShiTi(muBanModel, txtSearchByShiTi.Text);
                dgvShiTi.DataSource = dt;
            }
        }
        void BindDataByShiTiLeiBie()
        {
            var muBanModel = dgvMuBan.GetSelectedClassData<T_SHITI_MUBAN>();
            if (muBanModel != null)
            {
                var dt = _AL.GetDataByShiTiLeiBie(muBanModel);
                dgvShiTiLeiBie.DataSource = dt;
            }
        }

        private void FrmShiTiMuBan_Load(object sender, EventArgs e)
        {
            _AL = new ALShiTiMuBan();
            BindDataByMuBan();
        }
        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmShiTiMuBanEdit(_AL.AddByMuBan);
            frm.Text = "试题模板 新增";
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("生成模板成功！");
                BindDataByMuBan();
            }
        }
        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            var model = dgvMuBan.GetSelectedClassData<T_SHITI_MUBAN>();
            if (model == null)
            {
                ShowMessage("没有选中任何要修改的记录!");
                return;
            }
            var frm = new FrmShiTiMuBanEdit(_AL.UpdateByMuBan, model);
            frm.Text = "试题模板 修改";
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改完成!");
                //int seletedIndex = dgvMuBan.SelectedRows[0].Index;
                BindDataByMuBan();
                BindDataByShiTi();      //dgvMuBan.Rows[seletedIndex].Selected = true;
            }
        }
        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            var model = dgvMuBan.GetSelectedClassData<T_SHITI_MUBAN>();
            if (model == null)
            {
                ShowMessage("没有选中任何要修改的记录!");
                return;
            }
            if (!ShowQuestion("确实要删除当前选中记录吗?", "删除确认")) return;
            if (_AL.MuBanUsed(model))
            {
                ShowMessage("模板已使用，不允许删除");
                return;
            }
            string errMsg;
            if (_AL.DeleteByMuBan(model, out errMsg))
            {
                ShowMessage("删除完成");
                BindDataByMuBan();
            }
            else
            {
                ShowMessage("删除失败," + errMsg);
            }
        }
        private void tsTxtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsBtnSearch_Click(sender, e);
            }
        }
        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            BindDataByMuBan();
        }
        private void btnShiTiShengCheng_Click(object sender, EventArgs e)
        {
            var model = dgvMuBan.GetSelectedClassData<T_SHITI_MUBAN>();
            if (model == null)
            {
                ShowMessage("没有选中任何记录!");
                return;
            }
            if (_AL.MuBanUsed(model))
            {
                ShowMessage("模板已使用，不允许重新生成");
                return;
            }
            if (dgvShiTi.Rows.Count > 0)
            {
                if (!ShowQuestion("当前模板已经存在试题，重新生成将清空已生成的所有试题，确定操作吗？", "重新生成确认"))
                {
                    return;
                }
            }
            if (dgvShiTiLeiBie.DataSource == null)
            {
                ShowMessage("请先添加试题类别！");
                return;
            }
            //2017.5.8 生成试题 由试题模板创建时录入生成参数，该方法来将支持人员随机出题的实现
            if (!ShowQuestion("确实要生成模板试题吗？该过程将持续较长时间，请耐心等待", "生成确认"))
            {
                return;
            }
            bool shengChengJieGuo = false;
            string errMsg = "生成失败，未知错误";
            StartRunWork(
                    () =>
                    {
                        //要执行的方法
                        shengChengJieGuo = _AL.ShengChengShiTi(model, out errMsg);
                    },
                    () =>
                    {
                        //执行完方法之后
                        if (!shengChengJieGuo)
                        {
                            ShowMessage(errMsg);
                        }
                        else
                        {
                            ShowMessage("生成模板试题成功。");
                            BindDataByShiTi();
                        }
                    });

            //2017.5.8 注释
            //FrmShiTiMuBanShengCheng frm = new FrmShiTiMuBanShengCheng(ShengChengShiTi);
            //frm.ShowDialog();
        }
        bool ShengChengShiTi(ALShiTiMuBan.ShengChengCanShu model, out string errMsg)
        {
            var muBan = dgvMuBan.GetSelectedClassData<T_SHITI_MUBAN>();
            if (_AL.ShengChengShiTi(muBan, model, out errMsg))
            {
                ShowMessage("生成模板试题成功。");
                BindDataByShiTi();
                return true;
            }
            return false;
        }
        private void btnShiTiDaoRu_Click(object sender, EventArgs e)
        {
            var muBanModel = dgvMuBan.GetSelectedClassData<T_SHITI_MUBAN>();
            if (muBanModel == null)
            {
                ShowMessage("没有选中任何记录!");
                return;
            }
            if (_AL.MuBanUsed(muBanModel))
            {
                ShowMessage("模板已使用，不允许导入");
                return;
            }
            var dt = _AL.GetDataByShiTi(muBanModel);
            FrmTiKuXuanZe frm = new FrmTiKuXuanZe(dt);
            frm.Text = string.Format("选择要导入的题库");
            frm.OnSelectedHandle += (datas) =>
            {
                if (datas != null && datas.Count > 0)
                {
                    _AL.AddByMuBanShiTi(muBanModel, datas);
                    ShowMessage(string.Format("导入成功，共计导入：{0} 个", datas.Count));
                    BindDataByShiTi();
                }
                else
                {
                    ShowMessage("未选中任何分类。");
                }
            };
            frm.ShowDialog();
        }
        private void btnSearchByShiTi_Click(object sender, EventArgs e)
        {
            BindDataByShiTi();
        }
        private void txtSearchByShiTi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchByShiTi_Click(sender, e);
            }
        }
        private void dgvMuBan_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataByShiTi();
            BindDataByShiTiLeiBie();
        }
        private void btnShiTiShanChu_Click(object sender, EventArgs e)
        {
            var model = dgvShiTi.GetSelectedClassData<V_SHITI_MUBAN_MINGXI>();
            if (model == null)
            {
                ShowMessage("没有选中任何记录!");
                return;
            }
            var modelMuBan = dgvMuBan.GetSelectedClassData<T_SHITI_MUBAN>();
            if (_AL.MuBanUsed(modelMuBan))
            {
                ShowMessage("模板已使用，不允许删除模板试题");
                return;
            }
            if (ShowQuestion("确实要删除当前选中记录吗？", "删除确认"))
            {
                if (_AL.DeleteMuBanMingXi(model))
                {
                    ShowMessage("删除成功！");
                    BindDataByShiTi();
                }
            }
        }
        private void tsbtnPrint_Click(object sender, EventArgs e)
        {   
            var muBanModel = dgvMuBan.GetSelectedClassData<T_SHITI_MUBAN>();
            List<V_SHITI_MUBAN_MINGXI> muBanMingXi = null;
            if (muBanModel != null)
            {
                muBanMingXi = _AL.GetListDataByShiTi(muBanModel);
            }
            if (muBanMingXi == null || muBanMingXi.Count == 0)
            {
                ShowMessage("没有要打印的数据。");
            }
            else
            {
                bool isDisplayAnswer;
                if (MessageBox.Show("打印试题是否显示答案", "显示答案选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    isDisplayAnswer = true;
                }
                else
                {
                    isDisplayAnswer = false;
                }
                PrintHelper.ShiTi(muBanModel.MINGCHENG, muBanMingXi, isDisplayAnswer);
            }
        }
        private void btnSelectLeiBie_Click(object sender, EventArgs e)
        {
            var muBanModel = dgvMuBan.GetSelectedClassData<T_SHITI_MUBAN>();
            if (muBanModel == null)
            {
                ShowMessage("请选择试题模板.");
                return;
            }
            DataTable dt = _AL.GetMuBanFenLeiData(muBanModel);
            FrmTiKuFenLeiXuanZe frm = new FrmTiKuFenLeiXuanZe(dt, false);
            frm.OnSelectedHandle += new Action<List<T_SHITI_FENLEI>>(frm_OnSelectedHandle);
            frm.ShowDialog();
        }
        void frm_OnSelectedHandle(List<T_SHITI_FENLEI> fenLeiList)
        {
            var muBanModel = dgvMuBan.GetSelectedClassData<T_SHITI_MUBAN>();
            foreach (var item in fenLeiList)
            {
                _AL.AddMuBanFenLei(muBanModel, item);
            }
            BindDataByShiTiLeiBie();
        }
        private void btnRemoveFenLei_Click(object sender, EventArgs e)
        {
            if (ShowQuestion("确实要移除当前模板中的试题分类吗？对应的试题也将删除", "删除确认"))
            {
                var fenLeiModel = dgvShiTiLeiBie.GetSelectedClassData<T_SHITI_MUBAN_FENLEI>();
                string msg;
                if (_AL.RemoveMuBanFenLei(fenLeiModel, out msg))
                {
                    BindDataByShiTiLeiBie();
                    ShowMessage("移除完成。");
                }
                else
                {
                    ShowMessage(msg);
                }
            }
        }
        private void tsbtnBuKao_Click(object sender, EventArgs e)
        {
            DataTable jiHuaData = _AL.GetJiHuHuaData();
            T_PEIXUNJIHUA jihuaModel = null;
            FrmJiHuaXuanZe frmJiHuaXuanZe = new FrmJiHuaXuanZe(jiHuaData);
            frmJiHuaXuanZe.OnSelectedHandle += (jihua) =>
            {
                if (jihua != null && jihua.Count == 1)
                {
                    jihuaModel = jihua[0];
                }
            };
            if (frmJiHuaXuanZe.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (jihuaModel == null)
                {
                    ShowMessage("选择计划为空，操作取消！");
                    return;
                }
                T_SHITI_MUBAN defaultMuBan = _AL.GetBuKaoMuBan(jihuaModel);
                defaultMuBan.JiHuaModel = jihuaModel;
                FrmShiTiMuBanEdit frmMuBanEdit = new FrmShiTiMuBanEdit(_AL.SaveBuKaoMuBan, defaultMuBan);
                frmMuBanEdit.Text = string.Format("原题补考，计划：{0}", jihuaModel.NEIRONG);
                if (frmMuBanEdit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ShowMessage("创建补考试题成功");
                    BindDataByMuBan();
                }
            }
        }
        private void tsbtnChongXinPingFen_Click(object sender, EventArgs e)
        {
            //TODO:重新评分
            var model = dgvMuBan.GetSelectedClassData<T_SHITI_MUBAN>();
            if (model == null)
            {
                ShowMessage("没有选中重新评分的模板!");
                return;
            }
            if (ShowQuestion("确实要对该模板的所有试题进行重新评分吗？该过程可能将持续较长时间。", "重新评分确认"))
            {
                int r = _AL.ChongXinPingFen(model);
                ShowMessage("重新评分完成，重新评分影响人数：" + r);
            }
        }
        private void tsbtnEditShiTi_Click(object sender, EventArgs e)
        {
            var mingXi = dgvShiTi.GetSelectedClassData<V_SHITI_MUBAN_MINGXI>();
            if (mingXi == null)
            {
                ShowMessage("未选中任何记录。");
                return;
            }
            T_SHITI shiTi = _AL.GetShiTiModel(mingXi);

            FrmTiKuEdit frm = new FrmTiKuEdit(_AL.UpdateShiTi, shiTi);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("更新试题成功。");
                BindDataByShiTi();
            }

        }

        private void tsbtnOutExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = dgvShiTi.DataSource as DataTable;
            if (dt.Rows.Count == 0)
            {
                ShowMessage("导出记录为空。");
                return;
            }
            string mingCheng = dt.Rows[0][V_SHITI_MUBAN_MINGXI.CNMUBANMINGCHENG].ToString();
            if (!ExcelOut.OutExcelByMuBanShiTi(dt, mingCheng))
            {
                ShowMessage("导出失败。");
            }
            else
            {
                ShowMessage("导出成功");
            }
        }

        private void tsbtnOutWord_Click(object sender, EventArgs e)
        {
            var muBanModel = dgvMuBan.GetSelectedClassData<T_SHITI_MUBAN>();
            List<V_SHITI_MUBAN_MINGXI> muBanMingXi = null;
            if (muBanModel != null)
            {
                muBanMingXi = _AL.GetListDataByShiTi(muBanModel);
            }
            if (muBanMingXi == null || muBanMingXi.Count == 0)
            {
                ShowMessage("没有要导出的数据。");
            }
            else
            {
                bool isDisplayAnswer;
                if (MessageBox.Show("导出试题是否显示答案", "显示答案选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    isDisplayAnswer = true;
                }
                else
                {
                    isDisplayAnswer = false;
                }
                bool isSuccess;

                isSuccess = WordImportOut.ShiTi(muBanModel.MINGCHENG, muBanMingXi, isDisplayAnswer);

                if (isSuccess)
                {
                    ShowMessage("导出成功");
                }
     
            }
        }
    }
}