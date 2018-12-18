using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;

namespace NursingManage.Win.TongJiByHis
{
    /// <summary>
    /// 病房日动态
    /// </summary>
    public partial class ucRiDongTaiHuiZong : UserControl,IProcParamControl
    {
        public ucRiDongTaiHuiZong()
        {
            InitializeComponent();
        }

        public UserControl GetSearchParamControl()
        {
            return this;
        }
        public Framework.Entitys.ProcedureEntiryBase GetProcedureModel()
        {
            P_RiDongTaiHuiZong param = new P_RiDongTaiHuiZong();
            param.SearchDate = dtpSearchDate.Value.ToString("yyyy-MM-dd");
            return param;
        }
        private void ucPingFangRiDongTai_Load(object sender, EventArgs e)
        {
            dtpSearchDate.Value= DateTime.Now;
        }
    }
}
