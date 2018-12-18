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
using ZhCun.Framework.WinCommon.AdvanceSearch;
using ZhCun.Framework.Common.CommonFunction;

namespace ZCJH.NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmTiKu : BaseListForm
    {
        public FrmTiKu()
        {
            InitializeComponent();
        }

        ALTiKu _AL;
        ALTiKu.SearchParam _SearchParam;

        void BindDataSource()
        {
            var rList = _AL.GetData(_SearchParam);
            dgv.DataSource = rList;
        }
        //void BindADSearchData()
        //{
        //    var rList = _AL.GetADSearchData();
        //    dgv.DataSource = rList;
        //}

        private void FrmTiKu_Load(object sender, EventArgs e)
        {
            _AL = new ALTiKu();
            _SearchParam = new ALTiKu.SearchParam();

        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            FrmTiKuEdit2 frm = new FrmTiKuEdit2(_AL.Add);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("增加试题完成!");
                BindDataSource();
            }
        }

        private void tsBtnEditor_Click(object sender, EventArgs e)
        {
            var model = dgv.GetSelectedClassData<T_QUESTIONS>();
            if (model == null)
            {
                ShowMessage("没有选中任何要修改的记录!");
                return;
            }
            FrmTiKuEdit2 frm = new FrmTiKuEdit2(_AL.Update, model);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改试题信息完成!");
                BindDataSource();
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            var model = dgv.GetSelectedClassData<T_QUESTIONS>();
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

        bool ImportAdd(DataRow dr, out string errMsg)
        {
            string optionIsStr = "是";
            T_QUESTIONS model = new T_QUESTIONS();
            model.QUESTIONS_NO = Utils.ConvertType<string>(dr[0]);
            model.QUESTIONS_TYPE = Utils.ConvertType<string>(dr[1]);
            model.SIMPLE_LEVEL = Utils.ConvertType<string>(dr[2]);
            model.PURPOSE = Utils.ConvertType<string>(dr[3]);
            model.CONTENT = Utils.ConvertType<string>(dr[4]);
            model.OPTION_A = Utils.ConvertType<string>(dr[5]);
            model.OPTION_A_IS = Utils.ConvertType<string>(dr[6]) == optionIsStr ? 1 : 0;
            model.OPTION_B = Utils.ConvertType<string>(dr[7]);
            model.OPTION_B_IS = Utils.ConvertType<string>(dr[8]) == optionIsStr ? 1 : 0;
            model.OPTION_C = Utils.ConvertType<string>(dr[9]);
            model.OPTION_C_IS = Utils.ConvertType<string>(dr[10]) == optionIsStr ? 1 : 0;
            model.OPTION_D = Utils.ConvertType<string>(dr[11]);
            model.OPTION_D_IS = Utils.ConvertType<string>(dr[12]) == optionIsStr ? 1 : 0;
            model.OPTION_E = Utils.ConvertType<string>(dr[13]);
            model.OPTION_E_IS = Utils.ConvertType<string>(dr[14]) == optionIsStr ? 1 : 0;
            model.OPTION_F = Utils.ConvertType<string>(dr[15]);
            model.OPTION_F_IS = Utils.ConvertType<string>(dr[16]) == optionIsStr ? 1 : 0;
            model.OPTION_G = Utils.ConvertType<string>(dr[17]);
            model.OPTION_G_IS = Utils.ConvertType<string>(dr[18]) == optionIsStr ? 1 : 0;
            errMsg = null;
            return _AL.Add(model, out errMsg);
        }

        private void tsBtnImport_Click(object sender, EventArgs e)
        {
            FrmExcelImport frm = new FrmExcelImport(ImportAdd);
            frm.ShowDialog();
        }

        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            BindDataSource();
        }

        private void tsbtnADSearch_Click(object sender, EventArgs e)
        {
            AdvanceSearchConfig.ShowAdvanceSearchForm<T_QUESTIONS>(this, _AL, dgv);
        }
    }
}