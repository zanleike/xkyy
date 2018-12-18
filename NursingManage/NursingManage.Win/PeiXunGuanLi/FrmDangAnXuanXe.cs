using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;

namespace NursingManage.Win.PeiXunGuanLi
{
    class FrmDangAnXuanXe : BaseSelectForm<T_DANGAN>
    {
        public FrmDangAnXuanXe(DataTable dataSource, bool isSingle = false)
            : base(dataSource, isSingle)
        { }
        protected override Dictionary<string, string> GetGridViewColumnInfo()
        {
            Dictionary<string, string> columnDict = new Dictionary<string, string>();
            columnDict.Add(T_DANGAN.CNBIANHAO, "编号");
            columnDict.Add(T_DANGAN.CNXINGMING, "姓名");
            columnDict.Add(T_DANGAN.CNXINGMING_PY, "姓名");
            columnDict.Add(T_DANGAN.CNNENGJI, "能级");
            columnDict.Add(T_DANGAN.CNZHICHENG, "岗位");
            columnDict.Add(T_DANGAN.CNKESHI, "科室");
            
            return columnDict;
        }
        protected override void SearchDataView(DataView dv, string serValue)
        {
            dv.RowFilter = string.Format("{1} like '%{0}%' or {2} like '%{0}%' or {3} like '{0}%' or {4} like '%{0}%'",
                serValue,
                T_DANGAN.CNBIANHAO,
                T_DANGAN.CNXINGMING,
                T_DANGAN.CNXINGMING_PY,
                T_DANGAN.CNNENGJI);
        }
    }
}