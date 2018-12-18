using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Entitys;
using System.Data;

namespace HursingManage.DBModel
{
    /// <summary>
    /// 病房日动态汇总查询
    /// </summary>
    public class P_RiDongTaiHuiZong: ProcedureEntiryBase
    {
        /// <summary>
        /// 查询日期字符串，格式：yyyy-MM-dd
        /// </summary>
        public string SearchDate { set; get; }

        [ProcedureParam(IsOracleCursor = true, ParamDirection = ParameterDirection.Output)]
        public object p_ref { set; get; }
    }
}
