using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NursingManage.Win.TongJiByHis
{
    class FrmYaChuangTongJi : FrmTongJiBase
    {
        public FrmYaChuangTongJi()
            : base()
        {
            this.Text = "压疮统计上报表";
        }

        IProcParamControl _ProcParamControl;

        protected override IProcParamControl ProcParamControl
        {
            get
            {
                if (_ProcParamControl == null)
                {
                    _ProcParamControl = new ucYaChuang();
                }
                return _ProcParamControl;
            }
        }
    }
}
