using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NursingManage.Win.TongJiByHis
{
    class FrmHuLiGuanLuTongJi: FrmTongJiBase
    {
        public FrmHuLiGuanLuTongJi()
            : base()
        {
            this.Text = "护理各类管路统计";
        }
        IProcParamControl _ProcParamControl;

        protected override IProcParamControl ProcParamControl
        {
            get
            {
                if (_ProcParamControl == null)
                {
                    _ProcParamControl = new ucHuLiGuanLuTongJi();
                }
                return _ProcParamControl;
            }
        }
    }
}
