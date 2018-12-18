using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Entitys;
using System.Data;

namespace HursingManage.DBModel
{
    public class ProcedureBase : ProcedureEntiryBase
    {
        /// <summary>
        /// 存储过程执行返回的代码，0：成功
        /// </summary>
        [ProcedureParam(ParamDirection = ParameterDirection.Output)]
        public int RetCode { set; get; }
        /// <summary>
        /// 存储过程执行返回的消息（通常为错误消息）
        /// </summary>
        [ProcedureParam(ParamDirection = ParameterDirection.Output)]
        public int RetMessage { set; get; }
    }
}
