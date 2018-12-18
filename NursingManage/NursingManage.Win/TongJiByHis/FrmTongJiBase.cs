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
using Framework.Entitys;
using Framework.Common.Helpers;

namespace NursingManage.Win.TongJiByHis
{
    public abstract partial class FrmTongJiBase : BaseListForm
    {
        public FrmTongJiBase()
        {
            InitializeComponent();
        }

        ALTongJiByHis _AL;
        P_YaChuangTongJi _Model;

        protected abstract IProcParamControl ProcParamControl { get; }

        private void FrmTongJiBase_Load(object sender, EventArgs e)
        {
            _AL = new ALTongJiByHis();
            _Model = new P_YaChuangTongJi();
            dgv.AutoGenerateColumns = true;
            var paramControl = ProcParamControl.GetSearchParamControl();

            paramControl.Dock = DockStyle.Fill;
            panelTop.Height = paramControl.Height;
            panelTop.Controls.Add(paramControl);
        }
        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            dcm1.SetValueToClassObj(_Model);
            DataTable dt = _AL.GetYaChangTongJi(_Model);
            dgv.DataSource = dt;
        }
        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbtnSearchProc_Click(object sender, EventArgs e)
        {
            this.dgv.Focus();
            var param = ProcParamControl.GetProcedureModel();
            DataTable dt = null;
            StartRunWork(
                    () =>
                    {
                        dt = _AL.GetProcedureData(param);
                    },
                    () =>
                    {
                        dgv.DataSource = dt;
                    });
        }

        private void tsBtnExcelOut_Click(object sender, EventArgs e)
        {
            if (ExcelOut.OutExcelByGridView(dgv, this.Text))
            {
                ShowMessage("导出成功。");
            }
        }
        #region 模拟效果 用于演示
        
        private void button1_Click(object sender, EventArgs e)
        {
            SerializesHelper sh = new SerializesHelper();
            DataTable dt = dgv.DataSource as DataTable;
            byte[] bs = sh.SerializeByXml<DataTable>(dt);
            string fullFileName = System.AppDomain.CurrentDomain.BaseDirectory + @"\" + this.GetType().Name + ".mnData";
            FileHelper.WriteBytesToFile(bs, fullFileName);
            MessageBox.Show("OK");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fullFileName = System.AppDomain.CurrentDomain.BaseDirectory + @"\" + this.GetType().Name + ".mnData";
            var rBytes = FileHelper.ReadBytes4File(fullFileName);
            SerializesHelper sh = new SerializesHelper();
            DataTable dt = sh.DeSerializeByXml<DataTable>(rBytes);
            dgv.DataSource = dt;
        }

        #endregion
    }
}