using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    class FrmZhiKongJiHuaXuanZe: BaseSelectForm<T_ZHIKONGJIHUA>
    {
        public FrmZhiKongJiHuaXuanZe(DataTable dataSource)
            : base(dataSource)
        { }
        protected override Dictionary<string, string> GetGridViewColumnInfo()
        {
            Dictionary<string, string> columnDict = new Dictionary<string, string>();
            columnDict.Add(T_ZHIKONGJIHUA.CNMINGCHENG, "计划名称");
            columnDict.Add(T_ZHIKONGJIHUA.CNKAISHISHIJIAN, "检查开始时间");
            columnDict.Add(T_ZHIKONGJIHUA.CNJIESHUSHIJIAN, "检查结束时间");
            return columnDict;
        }
        protected override void SearchDataView(DataView dv, string serValue)
        {
            dv.RowFilter = string.Format("MINGCHENG like '%{0}%'", serValue);
        }    
    }
}