using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL.XiTongGuanLi;
using HursingManage.DBModel;

namespace NursingManage.Win.XiTongGuanLi
{
    public partial class FrmKeShi : BaseListForm
    {
        public FrmKeShi()
        {
            InitializeComponent();
        }

        ALKeShi _AL;

        void BindDataSource()
        {
            string serValue = tsTxtSearchValue.Text;
            var r = _AL.GetData(serValue);
            dgvKeShi.DataSource = r;
        }
        
        private void FrmKeShi_Load(object sender, EventArgs e)
        {
            _AL = new ALKeShi();
        }
        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            FrmKeShiEdit frm = new FrmKeShiEdit(_AL.Add, null);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("新增完成");
                BindDataSource();
            }
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            var model = dgvKeShi.GetSelectedClassData<T_KESHI>();
            if (model == null)
            {
                ShowMessage("未选中任何行");
                return;
            }
            FrmKeShiEdit frm = new FrmKeShiEdit(_AL.Update, model);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改完成");
                BindDataSource();
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            var model = dgvKeShi.GetSelectedClassData<T_KESHI>();
            if (model == null)
            {
                ShowMessage("没有选中任何要删除的记录!");
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
                tsBtnSearch_Click(sender, e);
            }
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKeShi_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //BindDataSourceUses();
        }
    }
}