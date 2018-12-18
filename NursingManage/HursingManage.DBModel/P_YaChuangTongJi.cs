using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Entitys;
using System.Data;

namespace HursingManage.DBModel
{
    public class P_YaChuangTongJi : ProcedureEntiryBase
    {
        public string StartDate { set; get; }
        public string EndDate { set; get; }
        /// <summary>
        /// 评估单id，78:压疮，79:跌倒坠床
        /// </summary>
        public string EvaluationId { set; get; }
        /// <summary>
        /// 评估单分数,压疮为 10分，跌倒为8分
        /// </summary>
        public int EvaluationScore { set; get; }

        [ProcedureParam(IsOracleCursor = true, ParamDirection = ParameterDirection.Output)]
        public object p_ref { set; get; }
    }
}
