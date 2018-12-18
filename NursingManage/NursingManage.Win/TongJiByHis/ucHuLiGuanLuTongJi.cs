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
    public partial class ucHuLiGuanLuTongJi : UserControl, IProcParamControl
    {
        public ucHuLiGuanLuTongJi()
        {
            InitializeComponent();
        }

        public Framework.Entitys.ProcedureEntiryBase GetProcedureModel()
        {
            P_HuLiGuanLuTongJi param = new P_HuLiGuanLuTongJi();
            param.StartDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            param.EndDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
            return param;
        }

        public UserControl GetSearchParamControl()
        {
            return this;
        }

    }
}