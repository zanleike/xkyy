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
    public partial class ucHuLiGuanLuTongJiKeShi : UserControl, IProcParamControl
    {
        public ucHuLiGuanLuTongJiKeShi()
        {
            InitializeComponent();
        }

        public Framework.Entitys.ProcedureEntiryBase GetProcedureModel()
        {
            P_HuLiGuanLuTongJiKeShi param = new P_HuLiGuanLuTongJiKeShi();
            param.StartDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            param.EndDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
            toJson tJ = new toJson();
            string deptCode = tJ.strJson(txtBox.Text.Trim());
            param.DeptCode = deptCode;
            param.dType = "11";
            return param;
        }

        public UserControl GetSearchParamControl()
        {
            return this;
        }
    }
}
