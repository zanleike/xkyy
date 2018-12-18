using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;

namespace NursingManage.Win.XiTongGuanLi
{
    class FrmYongHuXuanZe : BaseSelectForm<T_USER_INFO>
    {
        public FrmYongHuXuanZe(DataTable dataSource, bool isSingle = false)
            : base(dataSource, isSingle)
        { }
        protected override Dictionary<string, string> GetGridViewColumnInfo()
        {
            Dictionary<string, string> columnDict = new Dictionary<string, string>();
            columnDict.Add(T_USER_INFO.CNUSER_NO, "编号");
            columnDict.Add(T_USER_INFO.CNUSER_NAME, "姓名");
            columnDict.Add(T_USER_INFO.CNUSER_NAME_PY, "助记码");
            columnDict.Add(T_USER_INFO.CNUSER_TYPE, "用户角色");
            return columnDict;
        }
        protected override void SearchDataView(DataView dv, string serValue)
        {
            dv.RowFilter = string.Format("USER_NO like '%{0}%' or USER_NAME_PY like '%{0}%' or USER_NAME like '%{0}%'", serValue);
        }
    }
}