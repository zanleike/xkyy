using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HursingManage.DBModel;
using Framework.Entitys;

namespace HursingManage.AL
{
    public class ALTongJiByHis : ALBase
    {
        public DataTable GetProcedureData(ProcedureEntiryBase model)
        {
            var r = DB.ExecProcedure(model);
            var dt = r.ToDataTable();
            return dt;

            //var dt = DB.ExecProcedureGetDataTable(model);
            //return dt;
        }
        public DataTable GetYaChangTongJi(P_YaChuangTongJi model)
        {
            var r = DB.ExecProcedure(model);
            var dt = r.ToDataTable();
            return dt;

            //var dt = DB.ExecProcedureGetDataTable(model);
            //return dt;
        }
    }
}
