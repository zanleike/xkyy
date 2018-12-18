using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NursingManage.Win
{
    public delegate bool EditModelHandle<TEntity>(TEntity model, out string errMsg);// where TEntity : Framework.Entitys.EntityBase, new();

    class CommonForm
    {
        //public static void InitUserType(
    }
}
