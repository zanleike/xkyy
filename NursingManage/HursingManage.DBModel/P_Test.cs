using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Entitys;
using System.Data;

namespace HursingManage.DBModel
{
    public class P_Test : ProcedureEntiryBase
    {
        [ProcedureParam(ParameterName = "n")]
        public int Number { set; get; }

        [ProcedureParam(ParamDirection = ParameterDirection.Output)]
        public int isSuccess { set; get; }

        [ProcedureParam(ParamDirection = ParameterDirection.Output,
            ParameterName = "param2")]
        public string Param2 { set; get; }

        [ProcedureParam(
            IsOracleCursor = true,
            ParamDirection = ParameterDirection.Output,
            ParameterName = "p_ref")]
        public object p_ref { set; get; }

        protected override string ProcedureName
        {
            get
            {
                return "P_Test";
            }
        }
    }
}