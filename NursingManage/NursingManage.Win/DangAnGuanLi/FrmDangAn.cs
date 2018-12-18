using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZCJH.HursingManage.AL.DangAnGuanLi;
using ZCJH.HursingManage.DBModel;

namespace ZCJH.NursingManage.Win.DangAnGuanLi
{
    public partial class FrmDangAn : BaseForm
    {
        public FrmDangAn()
        {
            InitializeComponent();
        }

        ALDangAn _AL;
        void BindDataSource()
        {
            string serValue = tsTxtSearchValue.Text;
            var r = _AL.GetDangAnData(serValue);
            dgv.DataSource = r;
            tslbRecordCount.Text = dgv.Rows.Count.ToString();
        }

        private void FrmDangAn_Load(object sender, EventArgs e)
        {
            _AL = new ALDangAn();
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
        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            BindDataSource();
        }
        private void tsTxtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindDataSource();
            }
        }
        private void tsbtnADSearch_Click(object sender, EventArgs e)
        {
            AdvanceSearchConfig.ShowAdvanceSearchForm<T_DANGAN>(this, _AL, dgv);
        }
    }
}