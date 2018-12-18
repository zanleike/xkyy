using System.Collections.Generic;
using System.Data;
using HursingManage.DBModel;

namespace NursingManage.Win.XiTongGuanLi
{
    class FrmKeShiXuanZe : BaseSelectForm<T_KESHI>
    {
        public FrmKeShiXuanZe(DataTable dataSource, bool isSingle = false)
            : base(dataSource, isSingle)
        { }
        protected override Dictionary<string, string> GetGridViewColumnInfo()
        {
            Dictionary<string, string> columnDict = new Dictionary<string, string>();
            //columnDict.Add(T_KESHI.CNKESHILEIBIE, "科室类别");
            columnDict.Add(T_KESHI.CNLEIXING1, "一级类型");
            columnDict.Add(T_KESHI.CNLEIXING2, "二级类型");
            columnDict.Add(T_KESHI.CNBIANMA, "科室编码");
            columnDict.Add(T_KESHI.CNMINGCHENG, "科室名称");
            columnDict.Add(T_KESHI.CNMINGCHENG_PY, "助记码");
            return columnDict;
        }
        protected override void SearchDataView(DataView dv, string serValue)
        {
            dv.RowFilter = string.Format("BIANMA like '%{0}%' or MINGCHENG_PY like '%{0}%' or MINGCHENG like '%{0}%'", serValue);
        }
    }
}
