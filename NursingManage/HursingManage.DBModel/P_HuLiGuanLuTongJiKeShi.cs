using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Entitys;
using System.Data;

namespace HursingManage.DBModel
{
    public class P_HuLiGuanLuTongJiKeShi : ProcedureEntiryBase
    {
        /// <summary>
        /// 要查询的起始时间
        /// </summary>
        public string StartDate { set; get; }
        /// <summary>
        /// 要查询的结束时间
        /// </summary>
        public string EndDate { set; get; }

        public string DeptCode { set; get; }

        public string dType { set; get; }


        [ProcedureParam(IsOracleCursor = true, ParamDirection = ParameterDirection.Output)]
        public object p_ref { set; get; }
    }
}
