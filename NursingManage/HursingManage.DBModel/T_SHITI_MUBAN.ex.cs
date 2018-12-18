using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Entitys;

namespace HursingManage.DBModel
{
    partial class T_SHITI_MUBAN
    {
        [EntityAttribute(IsNotField = true)]
        public T_PEIXUNJIHUA JiHuaModel { set; get; }  //重新生成为了少查询一次
    }
}
