using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Entitys;

namespace HursingManage.DBModel
{
    partial class T_DEPART
    {
        [EntityAttribute(IsNotField = true)]
        public string ParentName { set; get; }
    }
}
