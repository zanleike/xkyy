using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Entitys;
using System.Data;

namespace HursingManage.DBModel
{
    /// <summary>
    /// 护理各类管路统计
    /// </summary>
    public class P_HuLiGuanLuTongJi : ProcedureEntiryBase
    {
        /// <summary>
        /// 要查询的起始时间
        /// </summary>
        public string StartDate { set; get; }
        /// <summary>
        /// 要查询的结束时间
        /// </summary>
        public string EndDate { set; get; }

        [ProcedureParam(IsOracleCursor = true, ParamDirection = ParameterDirection.Output)]
        public object p_ref { set; get; }

        
    }
}
