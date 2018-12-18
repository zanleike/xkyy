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
    public partial class FrmWeiKaoMingXi : BaseListForm
    {
        public FrmWeiKaoMingXi()
        {
            InitializeComponent();
        }

        ALVWeiKaoMingXi _AL;
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

        private void FrmWeiKaoMingXi_Load(object sender, EventArgs e)
        {
            _AL = new ALVWeiKaoMingXi();
            ucPage.PageChangedEvent += new Framework.WinCommon.Controls.PadeChangedHandle(ucPage_PageChangedEvent);
        }

        void ucPage_PageChangedEvent(int pageNo, int onePageCount, out int recordCount)
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
            AdvanceSearchConfig.ShowAdvanceSearchForm<V_PEIXUNJIHUA_MINGXI_WEIKAO>(this, _AL,
            () =>
            {
                _IsAdSearch = true;
                BindDataSource();
            });
        }

        private void tsbtnOutExcel_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                ShowMessage("要导出的记录为空。");
                return;
            }
            if (!ExcelOut.OutExcelByGridView(dgv, "未考人员明细"))
            {
                ShowMessage("导出失败。");
            }
            else
            {
                ShowMessage("导出成功");
            }
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}