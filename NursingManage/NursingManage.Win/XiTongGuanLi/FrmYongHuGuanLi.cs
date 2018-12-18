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
    public partial class FrmYongHuGuanLi : BaseListForm
    {
        public FrmYongHuGuanLi()
        {
            InitializeComponent();
        }

        ALYongHuGuanLi _AL;
        void BindDataSource()
        {
            dgv.DataSource = _AL.GetData(tsTxtSearchValue.Text);
        }

        private void FrmYongHuGuanLi_Load(object sender, EventArgs e)
        {
            _AL = new ALYongHuGuanLi();
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            FrmYongHuEdit frm = new FrmYongHuEdit(_AL.Add);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("增加用户信息完成!");
                BindDataSource();
            }
        }

        private void tsBtnEditor_Click(object sender, EventArgs e)
        {
            var model = dgv.GetSelectedClassData<T_USER_INFO>();
            if (model == null)
            {
                ShowMessage("没有选中任何要修改的记录!");
                return;
            }
            FrmYongHuEdit frm = new FrmYongHuEdit(_AL.Update, model);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改用户信息完成!");
                BindDataSource();
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            var model = dgv.GetSelectedClassData<T_USER_INFO>();
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

        private void tsBtnKeShiFenPei_Click(object sender, EventArgs e)
        {
            T_USER_INFO model = dgv.GetSelectedClassData<T_USER_INFO>();
            DataTable dt = _AL.GetKeShiByUserId(model);
            FrmKeShiXuanZe frm = new FrmKeShiXuanZe(dt);
            frm.Text = string.Format("{0} 分配科室", model.USER_NAME);
            frm.OnSelectedHandle += (datas) =>
            {
                _AL.SaveKeShiByUser(model, datas);
                ShowMessage("分配成功!");
            };
            frm.ShowDialog();
        }
    }
}
