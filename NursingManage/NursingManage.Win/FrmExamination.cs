using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using NursingManage.Win.XiTongGuanLi;
using HursingManage.AL;
using HursingManage.DBModel;
using NursingManage.Win.XiTongGuanLi;
using NursingManage.Win.PeiXunGuanLi;

namespace NursingManage.Win
{
    public partial class FrmExamination : BaseForm
    {
        public FrmExamination()
        {
            InitializeComponent();
        }
        ALExamination _AL;

        private void FrmExamination_Load(object sender, EventArgs e)
        {
            _AL = new ALExamination();
        }
        private void btnKeShiXuanZe_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            var query = ALCommon.GetQueryResult<T_KESHI>(s => s.ISDEL == 0);
            dt = query.ToDataTable();
            FrmKeShiXuanZe frm = new FrmKeShiXuanZe(dt, true);
            frm.OnSelectedHandle += new Action<List<T_KESHI>>(frm_OnSelectedKeShiHandle);
            frm.ShowDialog();
        }
        void frm_OnSelectedKeShiHandle(List<T_KESHI> keShi)
        {
            if (keShi != null && keShi.Count == 1)
            {
                txtKeShi.Tag = keShi[0].ID;
                txtKeShi.Text = keShi[0].MINGCHENG;
            }
        }
        private void btnKaoShiRenXuanZe_Click(object sender, EventArgs e)
        {
            if (txtKeShi.Tag == null)
            {
                ShowMessage("请先选择科室！");
                return;
            }
            string keShiId = txtKeShi.Tag.ToString();
            var query = ALCommon.GetQueryResult<T_DANGAN>(s => s.ISDEL == 0 && s.KESHIID ==keShiId );
            DataTable dt = query.ToDataTable();
            FrmDangAnXuanXe frm = new FrmDangAnXuanXe(dt, true);
            frm.OnSelectedHandle += new Action<List<T_DANGAN>>(frm_OnSelectedDangAnHandle);
            frm.ShowDialog();
        }
        void frm_OnSelectedDangAnHandle(List<T_DANGAN> dangAn)
        {
            if (dangAn != null && dangAn.Count == 1)
            {
                txtKaoShiRen.Tag = dangAn[0].ID;
                txtKaoShiRen.Text = dangAn[0].XINGMING;
            }
        }
        T_PEIXUNJIHUA_MINGXI _MingXiModel;
        private void btnQianDao_Click(object sender, EventArgs e)
        {
            if (txtKeShi.Tag==null || txtKaoShiRen.Tag==null)
            {
                ShowMessage("请选择科室和考试人员。");
                return;
            }
            string errMsg;
            if (_AL.KaoShiQianDao(txtKeShi.Tag.ToString(), txtKaoShiRen.Tag.ToString(), out _MingXiModel, out errMsg))
            {
                ShowMessage("签到成功，点击开始答题进入考试。");
                var jiHuaModel = _AL.GetJiHuaModel(_MingXiModel.JIHUAID);
                txtJiHuaNeiRong.Text = jiHuaModel.NEIRONG;
                btnKaiShiDaTi.Enabled = true;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void btnKaiShiDaTi_Click(object sender, EventArgs e)
        {   
            List<V_SHITI_MUBAN_MINGXI> muBanMingXi = _AL.GetMBanMingXiData(_MingXiModel.MUBANID);
            string errMsg;
            if (!_AL.KaiShiDaTi(_MingXiModel, out errMsg))
            {
                ShowMessage(errMsg);
                return;
            }
            FrmDaTiLieBiao frm = new FrmDaTiLieBiao(muBanMingXi, _MingXiModel, _AL.SaveDaTi);
            frm.Text = string.Format("考试人员：{0}，考试时间：{1}",txtKaoShiRen.Text,_AL.GetNowTime().ToString());
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("考试完毕");
            }
        }
    }
}