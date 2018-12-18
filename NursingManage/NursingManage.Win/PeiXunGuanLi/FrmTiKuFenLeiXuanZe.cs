using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;

namespace NursingManage.Win.PeiXunGuanLi
{
    class FrmTiKuFenLeiXuanZe : BaseSelectForm<T_SHITI_FENLEI>
    {
        public FrmTiKuFenLeiXuanZe(DataTable dataSource, bool isSingle = true)
            : base(dataSource, isSingle)
        { }
        protected override Dictionary<string, string> GetGridViewColumnInfo()
        {
            Dictionary<string, string> columnDict = new Dictionary<string, string>();
            columnDict.Add(T_SHITI_FENLEI.CNMINGCHENG, "名称");
            columnDict.Add(T_SHITI_FENLEI.CNMINGCHENG_PY, "助记码");
            columnDict.Add(T_SHITI_FENLEI.CNADDTIME, "增加时间");
            return columnDict;
        }
        protected override void SearchDataView(DataView dv, string serValue)
        {
            dv.RowFilter = string.Format("MINGCHENG like '%{0}%' or MINGCHENG_PY like '%{0}%'", serValue);
        }
    }
}
