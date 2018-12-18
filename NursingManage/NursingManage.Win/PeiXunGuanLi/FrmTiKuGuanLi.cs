using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL.PeiXuNGuanLi;
using HursingManage.DBModel;
using Framework.Common.CommonFunction;
using Framework.Common.Helpers;
using System.Collections.Generic;


namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmTiKuGuanLi : BaseListForm
    {
        public FrmTiKuGuanLi()
        {
            InitializeComponent();

        }
        ALTiKuGuanLi _AL;
        void BindDataSource()
        {
            var fenLeiModel = dgvFenLei.GetSelectedClassData<T_SHITI_FENLEI>();
            if (fenLeiModel == null)
            {
                return;
            }
            var r = _AL.GetData(fenLeiModel, tsTxtSearchValue.Text);
            dgvShiTi.DataSource = r;
            //dgvFenLei.Rows[0].Cells[0].
        }
        void BindDataSourceByFenLei()
        {

            var r = _AL.GetDataByFenLei(txtSearchFenlei.Text);
            dgvFenLei.DataSource = r;
            dgvShiTi.DataSource = null;
        }
        string GetSelectedFenLei()
        {

            var fenLei = dgvFenLei.GetFirstSelectItem<string>(col_MINGCHENG.Name);
            return fenLei;
        }
        private void FrmTiKuGuanLi_Load(object sender, EventArgs e)
        {
            _AL = new ALTiKuGuanLi(GetSelectedFenLei);
            BindDataSourceByFenLei();
            if (_AL.CurrentLoginUser.ROLE_NAME == "护士")
            {
                btnAddFenLei.Enabled = false;
                btnDeleteFenLei.Enabled = false;
                btnEditFenLei.Enabled = false;
                tsbtnChangeFenLei.Enabled = false;
                tsBtnImport.Enabled = false;
                tsBtnAdd.Enabled = false;
                tsBtnEditor.Enabled = false;
                tsBtnDelete.Enabled = false;
                tsbtnShiTiZhengLi.Enabled = false;
            }
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool AddTiKu(T_SHITI mdoel, out string errMsg)
        {
            var fenLeiModel = dgvFenLei.GetSelectedClassData<T_SHITI_FENLEI>();
            if (fenLeiModel == null)
            {
                errMsg = "试题分类为空";
                return false;
            }
            return _AL.Add(fenLeiModel, mdoel, out errMsg);
        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            string selectedFenlei = GetSelectedFenLei();
            if (string.IsNullOrWhiteSpace(selectedFenlei))
            {
                ShowMessage("请先选择题库类别");
                return;
            }
            FrmTiKuEdit frm = new FrmTiKuEdit(AddTiKu, null);
            frm.ShowDialog();
        }

        private void tsBtnEditor_Click(object sender, EventArgs e)
        {
            var fenLeiModel = dgvFenLei.GetSelectedClassData<T_SHITI_FENLEI>();
            if (fenLeiModel == null)
            {
                ShowMessage("请先选择题库类别");
                return;
            }
            var model = dgvShiTi.GetSelectedClassData<T_SHITI>();
            if (model == null)
            {
                ShowMessage("没有选中任何要修改的记录!");
                return;
            }
            FrmTiKuEdit frm = new FrmTiKuEdit(_AL.Update, model);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改试题信息完成!");
                BindDataSource();
            }
        }

        private void tsbtnADSearch_Click(object sender, EventArgs e)
        {
            AdvanceSearchConfig.ShowAdvanceSearchForm<T_SHITI>(this, _AL, dgvShiTi);
        }

        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            BindDataSource();
        }

        private void tsTxtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsBtnSearch_Click(sender, e);
            }
        }

        private void tsBtnImport_Click(object sender, EventArgs e)
        {
            var fenLeiModel = dgvFenLei.GetSelectedClassData<T_SHITI_FENLEI>();
            if (fenLeiModel == null)
            {
                ShowMessage("请先选择题库类别");
                return;
            }
            FrmExcelImport impFrm = new FrmExcelImport(ImportAdd);
            impFrm.Text = string.Format("分类：{0} 中导入题库", fenLeiModel.MINGCHENG);
            impFrm.ShowDialog();
        }

        T ConvertDataRow<T>(DataRow dr, string colName)
        {
            if (!dr.Table.Columns.Contains(colName))
            {
                return default(T);
            }
            var r = Utils.ConvertType<T>(dr[colName]);
            return r;
        }

        bool ImportAdd(DataRow item, out string errMsg)
        {
            T_SHITI model = new T_SHITI();
            var fenLeiModel = dgvFenLei.GetSelectedClassData<T_SHITI_FENLEI>();
            if (fenLeiModel == null)
            {
                errMsg = "没有选择对应的试题类别。";
                return false;
            }
            model.BIANHAO = Utils.ConvertType<string>(item["试题编号"]);
            model.FENLEI = fenLeiModel.MINGCHENG;
            model.FENLEIID = fenLeiModel.ID;
            if (item.Table.Columns.Contains("难易程度"))
                model.NANYICHENGDU = Utils.ConvertType<string>(item["难易程度"]);
            model.NEIRONG = Utils.ConvertType<string>(item["试题内容"]);
            model.LEIXING = Utils.ConvertType<string>(item["试题类型"]);
            model.DAAN = ConvertDataRow<string>(item, "答案");
            model.XIANGMUA = ConvertDataRow<string>(item, "选项A");
            model.XIANGMUB = ConvertDataRow<string>(item, "选项B");
            model.XIANGMUC = ConvertDataRow<string>(item, "选项C");
            model.XIANGMUD = ConvertDataRow<string>(item, "选项D");
            model.XIANGMUE = ConvertDataRow<string>(item, "选项E");
            model.XIANGMUF = ConvertDataRow<string>(item, "选项F");

            if (string.IsNullOrWhiteSpace(model.DAAN))
            {
                errMsg = "答案为空，导入失败。";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.XIANGMUA) || string.IsNullOrWhiteSpace(model.XIANGMUB))
            {
                errMsg = "选项A与选项B不能为空。";
                return false;
            }

            if (model.LEIXING != "问答题" && model.LEIXING != "名词解释")
            {
                if (string.IsNullOrWhiteSpace(model.DAAN))
                {
                    string optionIsStr = "是";
                    StringBuilder sb = new StringBuilder();
                    if (StringHelper.StringEquals(ConvertDataRow<string>(item, "答案A"), optionIsStr))
                        sb.Append("A");
                    if (StringHelper.StringEquals(ConvertDataRow<string>(item, "答案B"), optionIsStr))
                        sb.Append("B");
                    if (StringHelper.StringEquals(ConvertDataRow<string>(item, "答案C"), optionIsStr))
                        sb.Append("C");
                    if (StringHelper.StringEquals(ConvertDataRow<string>(item, "答案D"), optionIsStr))
                        sb.Append("D");
                    if (StringHelper.StringEquals(ConvertDataRow<string>(item, "答案E"), optionIsStr))
                        sb.Append("E");
                    if (StringHelper.StringEquals(ConvertDataRow<string>(item, "答案F"), optionIsStr))
                        sb.Append("F");
                    model.DAAN = sb.ToString();
                }
            }
            return _AL.Add(fenLeiModel, model, out errMsg);
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            var shiTi = dgvShiTi.GetSelectedClassData<T_SHITI>();
            if (shiTi == null)
            {
                ShowMessage("未选中任何试题记录。");
                return;
            }
            string errMsg;
            if (_AL.Delete(shiTi, out errMsg))
            {
                ShowMessage("删除试题成功。");
                BindDataSource();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void btnAddFenLei_Click(object sender, EventArgs e)
        {
            FrmTiKuFenLeiEdit frm = new FrmTiKuFenLeiEdit(_AL.AddByFenLei, null);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindDataSourceByFenLei();
            }
        }

        private void dgvFenLei_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataSource();
        }

        private void btnEditFenLei_Click(object sender, EventArgs e)
        {
            var model = dgvFenLei.GetSelectedClassData<T_SHITI_FENLEI>();
            if (model == null)
            {
                ShowMessage("没有选中任何要修改的记录!");
                return;
            }
            FrmTiKuFenLeiEdit frm = new FrmTiKuFenLeiEdit(_AL.UpdateByFenLei, model);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改完成!");
                BindDataSourceByFenLei();
            }
        }

        private void btnDeleteFenLei_Click(object sender, EventArgs e)
        {
            var model = dgvFenLei.GetSelectedClassData<T_SHITI_FENLEI>();
            if (model == null)
            {
                ShowMessage("没有选中任何要修改的记录!");
                return;
            }
            if (!ShowQuestion("确实要删除当前选中记录吗?", "删除确认")) return;
            string errMsg;
            if (_AL.DeleteByFenLei(model, out errMsg))
            {
                ShowMessage("删除完成");
                BindDataSourceByFenLei();
            }
            else
            {
                ShowMessage("删除失败," + errMsg);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataSourceByFenLei();
        }

        private void txtSearchFenlei_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void tsbtnChangeFenLei_Click(object sender, EventArgs e)
        {
            var dt = _AL.GetDataByFenLei(null);
            FrmTiKuFenLeiXuanZe frm = new FrmTiKuFenLeiXuanZe(dt);
            frm.Text = string.Format("选择要修改到的题库分类");
            frm.OnSelectedHandle += (datas) =>
            {
                if (datas != null && datas.Count == 1)
                {
                    var model = dgvShiTi.GetSelectedClassData<T_SHITI>();
                    if (ShowQuestion("确实要将当前试题分类修改为：{0} 吗？", "更改分类确认", datas[0].MINGCHENG))
                    {
                        string errMsg;
                        if (_AL.ChangeFenLei(model, datas[0], out errMsg))
                        {
                            ShowMessage("修改分类成功！");
                            BindDataSource();
                        }
                    }
                }
                else
                {
                    ShowMessage("未选中分类或选择了多个。");
                }
            };
            frm.ShowDialog();
        }

        private void tsbtnShiTiZhengLi_Click(object sender, EventArgs e)
        {
            //试题整理
            FrmTiKuGuanLi_ShiTiZhengLi frm = new FrmTiKuGuanLi_ShiTiZhengLi();
            frm.ShowDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            //var muBanModel = dgvMuBan.GetSelectedClassData<T_SHITI_MUBAN>();
            //List<V_SHITI_MUBAN_MINGXI> muBanMingXi = null;
            //if (muBanModel != null)
            //{
                //muBanMingXi = _AL.GetListDataByShiTi(muBanModel);
            //}
            //if (muBanMingXi == null || muBanMingXi.Count == 0)
            //{
            //    ShowMessage("没有要打印的数据。");
            //}
            //else
            //{
            //    bool isDisplayAnswer;
            //    if (MessageBox.Show("打印试题是否显示答案", "显示答案选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            //    {
            //        isDisplayAnswer = true;
            //    }
            //    else
            //    {
            //        isDisplayAnswer = false;
            //    }
            //    PrintHelper.ShiTi(muBanModel.MINGCHENG, muBanMingXi, isDisplayAnswer);
            //}
        }

        private void tsbtnOutWord_Click(object sender, EventArgs e)
        {
            var shiTiFenLei = dgvFenLei.GetSelectedClassData<T_SHITI_FENLEI>();
            List<T_SHITI> shiTi = null;
            if (shiTiFenLei != null)
            {
                shiTi = _AL.GetListDataByShiTi(shiTiFenLei);
            }
            if (shiTi == null || shiTi.Count == 0)
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

                isSuccess = WordImportOut.TiKu(shiTiFenLei.MINGCHENG, shiTi, isDisplayAnswer);

                if (isSuccess)
                {
                    ShowMessage("导出成功");
                }

            }
        }
    }
}