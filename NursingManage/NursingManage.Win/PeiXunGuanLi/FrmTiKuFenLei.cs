using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZCJH.HursingManage.AL.PeiXuNGuanLi;
using ZCJH.HursingManage.DBModel;

namespace ZCJH.NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmTiKuFenLei : BaseListForm
    {
        public FrmTiKuFenLei()
        {
            InitializeComponent();
        }

        ALTiKuFenLei _AL;
        void BindDataSource()
        {
            dgv.DataSource = _AL.GetData(tsTxtSearchValue.Text);
        }

        private void FrmTiKuFenLei_Load(object sender, EventArgs e)
        {
            _AL = new ALTiKuFenLei();
        }
        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            FrmTiKuFenLeiEdit frm = new FrmTiKuFenLeiEdit(_AL.Add, null);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindDataSource();
            }
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            var model = dgv.GetSelectedClassData<T_SHITI_FENLEI>();
            if (model == null)
            {
                ShowMessage("没有选中任何要修改的记录!");
                return;
            }
            FrmTiKuFenLeiEdit frm = new FrmTiKuFenLeiEdit(_AL.Update, model);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改完成!");
                BindDataSource();
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            var model = dgv.GetSelectedClassData<T_SHITI_FENLEI>();
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
                tsBtnSearch_Click(sender, e);
            }
        }
    }
}
