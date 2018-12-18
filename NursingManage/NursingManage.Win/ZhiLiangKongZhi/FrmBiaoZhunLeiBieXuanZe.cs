using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    class FrmBiaoZhunLeiBieXuanZe: BaseSelectForm<T_ZHILIANGBIAOZHUN_LEIBIE>
    {
        public FrmBiaoZhunLeiBieXuanZe(DataTable dataSource)
            : base(dataSource)
        { }
        protected override Dictionary<string, string> GetGridViewColumnInfo()
        {
            Dictionary<string, string> columnDict = new Dictionary<string, string>();
            columnDict.Add(T_ZHILIANGBIAOZHUN_LEIBIE.CNMINGCHENG, "类别名称");
            return columnDict;
        }
        protected override void SearchDataView(DataView dv, string serValue)
        {
            dv.RowFilter = string.Format("MINGCHENG like '%{0}%' or MINGCHENG_PY like '%{0}%' ", serValue);
        }
    }
}
