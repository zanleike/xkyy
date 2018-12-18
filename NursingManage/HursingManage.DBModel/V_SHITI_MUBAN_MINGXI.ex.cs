using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Entitys;

namespace HursingManage.DBModel
{
    partial class V_SHITI_MUBAN_MINGXI
    {
        [EntityAttribute(IsNotField = true)]
        public string DaTi { set; get; }

        [EntityAttribute(IsNotField = true)]
        public bool ShiFouZhengQue { set; get; }
    }
}
