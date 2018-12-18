using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NursingManage.Win.TongJiByHis
{
    class FrmDieDaoTongJi : FrmTongJiBase
    {
        public FrmDieDaoTongJi()
            : base()
        {
            this.Text = "跌倒坠床高危上报表";
            //跌倒坠床评分
        }
        IProcParamControl _ProcParamControl;

        protected override IProcParamControl ProcParamControl
        {
            get
            {
                if (_ProcParamControl == null)
                {
                    _ProcParamControl = new ucDieDao();
                }
                return _ProcParamControl;
            }
        }
    }
}
