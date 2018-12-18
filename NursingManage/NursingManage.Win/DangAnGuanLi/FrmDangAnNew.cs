using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL.DangAnGuanLi;
using HursingManage.DBModel;

namespace NursingManage.Win.DangAnGuanLi
{
    public partial class FrmDangAnNew : BaseListForm
    {
        public FrmDangAnNew()
        {
            InitializeComponent();
           
        }
        ALDangAn _AL;
        bool _IsAdSearch = false;
        string _LastSearchValue = null;
        ALDangAnExConfig _ExConfigAL;
        
        void BindDataSource()
        {
            int recordCount;
            _LastSearchValue = tsTxtSearchValue.Text;
            var dt = _AL.GetData(ucPage.OnePageCount, 1, out recordCount, _IsAdSearch, _LastSearchValue);
            dgv.DataSource = dt;
            ucPage.InitiControl(recordCount);
        }

        private void FrmDangAnNew_Load(object sender, EventArgs e)
        {
            _ExConfigAL = new ALDangAnExConfig();
            _AL = new ALDangAn();
            ucPage.InitiControl(0);

            var exGroups = _ExConfigAL.GetExGroupInfo();
            foreach (var item in exGroups)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Text = item.GroupCaption;
                tsmi.Name = item.GroupName;
                tsmi.Tag = item;
                tsmi.Click += new EventHandler(tsmiExTable_Click);
                cMenuExTable.Items.Add(tsmi);
            }
            tsBtnSearch_Click(sender, e);
        }

        void tsmiExTable_Click(object sender, EventArgs e)
        {
            var model = dgv.GetSelectedClassData<T_DANGAN>();
            if (model == null)
            {
                ShowMessage("未选中任何档案记录。");
                return;
            }
            var tsmi = sender as ToolStripMenuItem;
            ExGroupInfo groupInfo = tsmi.Tag as ExGroupInfo;
            FrmDangAnSubTable frm = new FrmDangAnSubTable(model, groupInfo);
            frm.ShowDialog();
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
            AdvanceSearchConfig.ShowAdvanceSearchForm<V_DANGAN>(this, _AL,
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

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            FrmDangAnEdit frm = new FrmDangAnEdit(_AL.Add, null);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindDataSource();
            }
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            var model = dgv.GetSelectedClassData<T_DANGAN>();
            if (model == null)
            {
                ShowMessage("没有选中任何要修改的记录!");
                return;
            }
            model.ExDangAn = _AL.GetDangAnEx(model);
            FrmDangAnEdit frm = new FrmDangAnEdit(_AL.Update, model);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改用户信息完成!");
                BindDataSource();
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            var model = dgv.GetSelectedClassData<T_DANGAN>();
            if (model == null)
            {
                ShowMessage("没有选中任何要修改的记录!");
                return;
            }
            if (!ShowQuestion("确实要删除当前选中记录吗?", "删除确认")) return;
            string errMsg;
            if (_AL.Delete(model, out errMsg))
            {
                ShowMessage("删除完成");
                BindDataSource();
            }
            else
            {
                ShowMessage("删除失败," + errMsg);
            }
        }

        private void tsbtnOutExcel_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                ShowMessage("要导出的记录为空。");
                return;
            }
            var dt = dgv.DataSource as DataTable;
            if (!ExcelOut.OutDangAn(dt, "档案信息导出"))
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