using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NursingManage.Win.TongJiByHis
{
    class FrmRiDongTaiHuiZong: FrmTongJiBase
    {
        public FrmRiDongTaiHuiZong()
            : base()
        {
            this.Text = "病房一日动态项目汇总";
        }
        IProcParamControl _ProcParamControl;

        protected override IProcParamControl ProcParamControl
        {
            get
            {
                if (_ProcParamControl == null)
                {
                    _ProcParamControl = new ucRiDongTaiHuiZong();
                }
                return _ProcParamControl;
            }
        }
    }
}
