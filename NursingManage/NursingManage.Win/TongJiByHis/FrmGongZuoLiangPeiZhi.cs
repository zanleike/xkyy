using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL;
using HursingManage.DBModel;

namespace NursingManage.Win.TongJiByHis
{
    public partial class FrmGongZuoLiangPeiZhi : BaseListForm
    {
        public FrmGongZuoLiangPeiZhi()
        {
            InitializeComponent();
        }
        ALGongZuoLiangPeiZhi _AL;

        void BindDataSource()
        {
            var r = _AL.GetData();
            dgv.DataSource = r;
        }

        private void FrmGongZuoLiangPeiZhi_Load(object sender, EventArgs e)
        {
            _AL = new ALGongZuoLiangPeiZhi();
            BindDataSource();
        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            FrmGongZuoLiangPeiZhiEdit frm = new FrmGongZuoLiangPeiZhiEdit(_AL.Add, null);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("新增完成");
                BindDataSource();
            }
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            var model = dgv.GetSelectedClassData<T_GONGZUOLIANG_PEIZHI>();
            if (model == null)
            {
                ShowMessage("未选中任何行");
                return;
            }
            var frm = new FrmGongZuoLiangPeiZhiEdit(_AL.Update, model);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改完成");
                BindDataSource();
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            var model = dgv.GetSelectedClassData<T_GONGZUOLIANG_PEIZHI>();
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
    }
}
