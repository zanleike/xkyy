using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;

namespace NursingManage.Win.PeiXunGuanLi
{
    /// <summary>
    /// 题库选择导入
    /// </summary>
    class FrmTiKuXuanZe: BaseSelectForm<T_SHITI>
    {
        public FrmTiKuXuanZe(DataTable dataSource)
            : base(dataSource)
        { }
        protected override Dictionary<string, string> GetGridViewColumnInfo()
        {
            Dictionary<string, string> columnDict = new Dictionary<string, string>();
            columnDict.Add(T_SHITI.CNFENLEI, "试题分类");
            columnDict.Add(T_SHITI.CNLEIXING, "试题类型");
            columnDict.Add(T_SHITI.CNNANYICHENGDU, "难易程度");            
            columnDict.Add(T_SHITI.CNBIANHAO, "试题编号");
            columnDict.Add(T_SHITI.CNNEIRONG, "内容");
            columnDict.Add(T_SHITI.CNADDTIME, "增加时间");
            return columnDict;
        }
        protected override void SearchDataView(DataView dv, string serValue)
        {
            dv.RowFilter = string.Format("{1} = '{0}' or {2} = '{0}' or {3} like '{0}%' or {4} like '%{0}%'",
                serValue, 
                T_SHITI.CNLEIXING, 
                T_SHITI.CNNANYICHENGDU,
                T_SHITI.CNBIANHAO,
                T_SHITI.CNNEIRONG
                );
        }
    
    }
}
