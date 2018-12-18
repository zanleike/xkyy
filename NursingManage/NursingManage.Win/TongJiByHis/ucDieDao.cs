using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NursingManage.Win.TongJiByHis
{
    class ucDieDao : ucYaChuang
    {
        protected override HursingManage.DBModel.P_YaChuangTongJi GetProcedureParamThis()
        {
            var param = base.GetProcedureParamThis();
            param.EvaluationId = "79";
            param.EvaluationScore = 8;
            return param;
        }
    }
}
