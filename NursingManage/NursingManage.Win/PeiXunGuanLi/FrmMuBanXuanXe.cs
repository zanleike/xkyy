using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;

namespace NursingManage.Win.PeiXunGuanLi
{
    /// <summary>
    /// 试题模板（分类）选择
    /// </summary>
    class FrmMuBanXuanXe : BaseSelectForm<T_SHITI_MUBAN>
    {
        public FrmMuBanXuanXe(DataTable dataSource)
            : base(dataSource)
        { }
        protected override Dictionary<string, string> GetGridViewColumnInfo()
        {
            Dictionary<string, string> columnDict = new Dictionary<string, string>();
            columnDict.Add(T_SHITI_MUBAN.CNMINGCHENG, "模板名称");
            columnDict.Add(T_SHITI_MUBAN.CNMINGCHENG_PY, "助记码");
            columnDict.Add(T_SHITI_MUBAN.CNADDTIME, "创建时间");
            return columnDict;
        }
        protected override void SearchDataView(DataView dv, string serValue)
        {
            dv.RowFilter = string.Format("{1} like '%{0}%' or {2} like '%{0}%'",
                serValue,
                T_SHITI_MUBAN.CNMINGCHENG,
                T_SHITI_MUBAN.CNMINGCHENG_PY);
        }
    }
}
