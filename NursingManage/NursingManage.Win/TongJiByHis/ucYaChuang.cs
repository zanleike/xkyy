using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;
using Framework.Entitys;

namespace NursingManage.Win.TongJiByHis
{
    /// <summary>
    /// 跌倒统计上报表
    /// </summary>
    public partial class ucYaChuang : UserControl, IProcParamControl
    {
        public ucYaChuang()
        {
            InitializeComponent();
        }

        private void ucYaChuang_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            dtpStartDate.Value = new DateTime(now.Year, now.Month, 1);
            dtpEndDate.Value = dtpStartDate.Value.AddMonths(1).AddDays(-1);
        }

        public UserControl GetSearchParamControl()
        {
            return this;
        }

        protected virtual P_YaChuangTongJi GetProcedureParamThis()
        {   
            P_YaChuangTongJi param = new P_YaChuangTongJi();
            param.EvaluationId = "78";
            param.EvaluationScore = 10;
            param.StartDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            param.EndDate = dtpEndDate.Value.AddDays(1).ToString("yyyy-MM-dd");
            return param;
        }

        public ProcedureEntiryBase GetProcedureModel()
        {
            return GetProcedureParamThis();
        }
    }
}