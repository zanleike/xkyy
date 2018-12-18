using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL.PeiXuNGuanLi;
using Framework.BuildSQLText;
using HursingManage.DBModel;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmVPingFenMingXiChaKan : BaseListForm
    {
        public FrmVPingFenMingXiChaKan()
        {
            InitializeComponent();
        }
        ALVPingFenMingXiChaKan _AL;
        bool _IsAdSearch = false;
        string _LastSearchValue = null;

        void BindDataSource()
        {
            int recordCount;
            _LastSearchValue = tsTxtSearchValue.Text;
            var dt = _AL.GetData(ucPage.OnePageCount, 1, out recordCount, _IsAdSearch, _LastSearchValue);
            dgv.DataSource = dt;
            ucPage.InitiControl(recordCount);
        }
        private void FrmVPingFenMingXiChaKan_Load(object sender, EventArgs e)
        {
            _AL = new ALVPingFenMingXiChaKan();
            ucPage.InitiControl(0);
        }
        private void ucPage_PageChangedEvent(int pageNo, int onePageCount, out int recordCount)
        {
            var dt = _AL.GetData(onePageCount, pageNo, out recordCount, _IsAdSearch, _LastSearchValue);
            dgv.DataSource = dt;
        }
        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            _IsAdSearch = false;
            BindDataSource();
        }
        private void tsTxtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsBtnSearch_Click(sender, e);
            }
        }
        private void tsbtnADSearch_Click(object sender, EventArgs e)
        {
            AdvanceSearchConfig.ShowAdvanceSearchForm<V_PEIXUNJIHUA_MINGXI>(this, _AL,
            () =>
            {
                _IsAdSearch = true;
                BindDataSource();
            });
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnChaKanMingXi_Click(object sender, EventArgs e)
        {
            var model = dgv.GetSelectedClassData<V_PEIXUNJIHUA_MINGXI>();
            if (model == null)
            {
                ShowMessage("未选中任何记录。");
                return;
            }
            List<V_SHITI_MUBAN_MINGXI> muBanMingXi = _AL.GetPingFenJieGuo(model);
            if (muBanMingXi == null)
            {
                ShowMessage("当前人员未评分或模板题库为空!");
                return;
            }
            FrmVPingFenJieGuo frm = new FrmVPingFenJieGuo(muBanMingXi);
            frm.Text = string.Format("姓名：{0} ，试卷查看", model.XINGMING);
            frm.ShowDialog();
        }

        private void tsbtnOutExcel_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                ShowMessage("要导出的记录为空。");
                return;
            }
            if (!ExcelOut.OutExcelByGridView(dgv, "评分明细导出"))
            {
                ShowMessage("导出失败。");
            }
            else
            {
                ShowMessage("导出成功");
            }
        }
    }
}