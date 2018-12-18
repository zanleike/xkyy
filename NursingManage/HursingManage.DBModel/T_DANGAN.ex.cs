using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Entitys;

namespace HursingManage.DBModel
{
    partial class T_DANGAN
    {
        public T_DANGAN()
        {
            //_DIANZIYOUJIAN = "";
        }

        [EntityAttribute(IsNotField=true)]
        public T_DANGAN_EX ExDangAn { set; get; }
    }
}