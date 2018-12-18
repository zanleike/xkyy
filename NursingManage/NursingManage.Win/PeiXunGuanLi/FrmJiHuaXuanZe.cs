using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;

namespace NursingManage.Win.PeiXunGuanLi
{
    class FrmJiHuaXuanZe: BaseSelectForm<T_PEIXUNJIHUA>
    {
        public FrmJiHuaXuanZe(DataTable dataSource)
            : base(dataSource, true)
        { }
        protected override Dictionary<string, string> GetGridViewColumnInfo()
        {
            Dictionary<string, string> columnDict = new Dictionary<string, string>();
            columnDict.Add(T_PEIXUNJIHUA.CNNEIRONG, "计划内容");
            columnDict.Add(T_PEIXUNJIHUA.CNNEIRONGSHUOMING, "内容说明");
            columnDict.Add(T_PEIXUNJIHUA.CNCANJIARENYUAN, "参加人员");
            columnDict.Add(T_PEIXUNJIHUA.CNCHUANGJIANREN, "创建人");
            columnDict.Add(T_PEIXUNJIHUA.CNKAOHEKAISHI, "考核开始时间");
            columnDict.Add(T_PEIXUNJIHUA.CNKAOHEJIESHU, "考核结束时间");
            return columnDict;
        }
        protected override void SearchDataView(DataView dv, string serValue)
        {
            dv.RowFilter = string.Format("{1} like '%{0}%' or {2} like '%{0}%' or {3} like '{0}%' or {4} like '%{0}%'",
                serValue,
                T_PEIXUNJIHUA.CNNEIRONG,
                T_PEIXUNJIHUA.CNNEIRONGSHUOMING,
                T_PEIXUNJIHUA.CNCHUANGJIANREN);
        }
    }
}