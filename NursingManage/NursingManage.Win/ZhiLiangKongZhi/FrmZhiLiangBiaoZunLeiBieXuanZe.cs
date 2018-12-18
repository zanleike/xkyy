using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    /// <summary>
    /// 质量标准类别选择，用于科室检查标准类别添加
    /// </summary>
    class FrmZhiLiangBiaoZunLeiBieXuanZe : BaseSelectForm<T_ZHILIANGBIAOZHUN_LEIBIE>
    {
        public FrmZhiLiangBiaoZunLeiBieXuanZe(DataTable dataSource)
            : base(dataSource)
        { }
        protected override Dictionary<string, string> GetGridViewColumnInfo()
        {
            Dictionary<string, string> columnDict = new Dictionary<string, string>();
            columnDict.Add(T_ZHILIANGBIAOZHUN_LEIBIE.CNMINGCHENG, "标准类别名称");
            columnDict.Add(T_ZHILIANGBIAOZHUN_LEIBIE.CNBIAOZHUNSHU, "标准数");
            return columnDict;
        }
        protected override void SearchDataView(DataView dv, string serValue)
        {
            dv.RowFilter = string.Format("MINGCHENG like '%{0}%'", serValue);
        }
    }
}
