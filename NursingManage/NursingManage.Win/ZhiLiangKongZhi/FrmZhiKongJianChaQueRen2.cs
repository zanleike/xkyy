using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    class FrmZhiKongJianChaQueRen2 : FrmZhiKongJianCha
    {
        public FrmZhiKongJianChaQueRen2()
            : base(true)
        { }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Text = "检查确认";
        }
    }
}
