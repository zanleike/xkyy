using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.WinCommon.AdvanceSearch;
using HursingManage.AL;
using HursingManage.DBModel;
using System.Windows.Forms;
using Framework.Entitys;
using Framework.BuildSQLText;

namespace NursingManage.Win
{
    public class AdvanceSearchConfig : ISearchConfig
    {
        public static DialogResult ShowAdvanceSearchForm<TModel>(BaseForm ownerForm, ALBase al, Action SearchHandle) where TModel : EntityBase, new()
        {
            string className = typeof(TModel).ToString();
            AdvanceSearchConfig searchConfig = new AdvanceSearchConfig(ownerForm, className);
            FrmADSearch search = new FrmADSearch(searchConfig);
            search.OnSearchClickHandle += (arg) =>
            {
                GetAdvanceSearchBuilder(al.ADSqlBuilder, arg.SearchRecord);
                SearchHandle();
                //dgv.DataSource = al.GetADSearchData<TModel>();                
            };
            return search.ShowDialog(ownerForm);
        }

        public static DialogResult ShowAdvanceSearchForm<TModel>(BaseForm ownerForm, ALBase al, DataGridView dgv) where TModel : EntityBase, new()
        {
            string className = typeof(TModel).ToString();
            AdvanceSearchConfig searchConfig = new AdvanceSearchConfig(ownerForm, className);
            FrmADSearch search = new FrmADSearch(searchConfig);
            search.OnSearchClickHandle += (arg) =>
            {
                GetAdvanceSearchBuilder(al.ADSqlBuilder, arg.SearchRecord);
                dgv.DataSource = al.GetADSearchData<TModel>();
            };
            return search.ShowDialog(ownerForm);
        }

        public static void GetAdvanceSearchBuilder(ISqlBuilder sqlBuilder, List<ISearchRecord_Detail> searchRecord)
        {
            sqlBuilder.ClearResult();
            foreach (var record in searchRecord)
            {
                CompareSignEnum cse = (CompareSignEnum)Enum.Parse(typeof(CompareSignEnum), record.CompareSignStr, true);
                string CompareSignStr = null;
                switch (cse)
                {
                    case CompareSignEnum.EqualTo:
                        CompareSignStr = "=";
                        break;
                    case CompareSignEnum.GreaterThan:
                        CompareSignStr = ">";
                        break;
                    case CompareSignEnum.GreaterThanOrEqual:
                        CompareSignStr = ">=";
                        break;
                    case CompareSignEnum.LessThan:
                        CompareSignStr = "<";
                        break;
                    case CompareSignEnum.LessThanOrEqual:
                        CompareSignStr = "<=";
                        break;
                    case CompareSignEnum.NotEqualTo:
                        CompareSignStr = "<>";
                        break;
                    case CompareSignEnum.Like:
                        CompareSignStr = "like";
                        break;
                    case CompareSignEnum.NotLike:
                        CompareSignStr = "not like";
                        break;
                    default:
                        break;
                }
                if (string.IsNullOrWhiteSpace(CompareSignStr))
                {
                    return;
                }
                if (!string.IsNullOrWhiteSpace(record.ConnectorSignStr))
                {
                    sqlBuilder.AddSQLText(record.ConnectorSignStr);
                }
                sqlBuilder.AddSQLText(" {0} {1} {2} ", record.FieldName, CompareSignStr, sqlBuilder.AddParam(record.SearchValue));
            }
        }

        public AdvanceSearchConfig(BaseForm ownerForm, string className)
        {
            _AL = new ALAdvanceSearch();
            string a = ownerForm.ToString();
            int lastIndex = a.IndexOf(',');
            _ownerForm = a.Substring(0, lastIndex);
            this._className = className;
        }
        string _className; //已保存的列,从类(表)名获取,来实现多窗口用同一个类
        string _ownerForm;
        ALAdvanceSearch _AL;
        public string OwnerForm
        {
            get { return _ownerForm; }
        }
        ISearchRecord_Detail DbModelToRecordDetail(T_SEARCH_RECORD_DETAIL model)
        {
            if (model == null) return null;
            ISearchRecord_Detail r = new ISearchRecord_Detail();
            r.CompareSignStr = model.COMPARESIGN;
            r.ConnectorSignStr = model.CONNECTORSIGN;
            r.FieldName = model.FIELDNAME;
            r.SearchValue = model.SEARCHVALUE;
            r.DataTypeStr = model.DATATYPE;
            return r;
        }
        List<ISearchRecord_Detail> DbModelToRecordDetail(List<T_SEARCH_RECORD_DETAIL> modelList)
        {
            if (modelList == null) return null;
            List<ISearchRecord_Detail> r = new List<ISearchRecord_Detail>();
            foreach (var item in modelList)
            {
                r.Add(DbModelToRecordDetail(item));
            }
            return r;
        }

        T_SEARCH_RECORD_DETAIL RecordDetailToDbModel(ISearchRecord_Detail model)
        {
            if (model == null) return null;
            T_SEARCH_RECORD_DETAIL r = new T_SEARCH_RECORD_DETAIL();
            r.COMPARESIGN = model.CompareSignStr;
            r.CONNECTORSIGN = model.ConnectorSignStr;
            r.FIELDNAME = model.FieldName;
            r.SEARCHVALUE = model.SearchValue;
            r.DATATYPE = model.DataTypeStr;
            return r;
        }
        List<T_SEARCH_RECORD_DETAIL> RecordDetailToDbModel(List<ISearchRecord_Detail> modelList)
        {
            if (modelList == null) return null;
            List<T_SEARCH_RECORD_DETAIL> r = new List<T_SEARCH_RECORD_DETAIL>();
            int orderNo = 0;
            foreach (var item in modelList)
            {
                orderNo++;
                var dbModell = RecordDetailToDbModel(item);
                dbModell.ORDERNO = orderNo;
                r.Add(dbModell);
            }
            return r;
        }

        ISearchRecord DbModelToRecord(T_SEARCH_RECORD dbModel)
        {
            if (dbModel == null) return null;
            ISearchRecord r = new ISearchRecord();
            r.ID = dbModel.ID;
            r.RecordRemark = dbModel.RECORDREMARK;
            r.RecordRemark_PY = dbModel.RECORDREMARK_PY;
            return r;
        }
        List<ISearchRecord> DbModelToRecord(List<T_SEARCH_RECORD> dbModel)
        {
            if (dbModel == null) return null;
            List<ISearchRecord> r = new List<ISearchRecord>();
            foreach (var item in dbModel)
            {
                r.Add(DbModelToRecord(item));
            }
            return r;
        }

        T_SEARCH_RECORD RecordToDbModel(ISearchRecord model)
        {
            if (model == null) return null;
            T_SEARCH_RECORD r = new T_SEARCH_RECORD();
            r.ID = model.ID;
            r.RECORDREMARK = model.RecordRemark;
            r.RECORDREMARK_PY = model.RecordRemark_PY;
            return r;
        }
        List<T_SEARCH_RECORD> RecordToDbModel(List<ISearchRecord> modelList)
        {
            if (modelList == null) return null;
            List<T_SEARCH_RECORD> r = new List<T_SEARCH_RECORD>();
            foreach (var item in modelList)
            {
                r.Add(RecordToDbModel(item));
            }
            return r;
        }

        ISearchColumn DbModelToSearchColumn(T_SEARCH_COLUMN columns)
        {
            if (columns == null) return null;
            ISearchColumn r = new ISearchColumn();
            r.ColumnCaption = columns.COLUMNCAPTION;
            r.ColumnName = columns.COLUMNNAME;
            r.DataType = columns.DATATYPE;
            return r;
        }
        List<ISearchColumn> DbModelToSearchColumn(List<T_SEARCH_COLUMN> columns)
        {
            if (columns == null) return null;
            List<ISearchColumn> r = new List<ISearchColumn>();
            foreach (var item in columns)
            {
                r.Add(DbModelToSearchColumn(item));
            }
            return r;
        }

        T_SEARCH_COLUMN SearchColumnToDbModel(ISearchColumn columns)
        {
            if (columns == null) return null;
            T_SEARCH_COLUMN r = new T_SEARCH_COLUMN();
            r.COLUMNCAPTION = columns.ColumnCaption;
            r.COLUMNNAME = columns.ColumnName;
            r.DATATYPE = columns.DataType; ;
            return r;
        }
        List<T_SEARCH_COLUMN> SearchColumnToDbModel(List<ISearchColumn> columns)
        {
            if (columns == null) return null;
            List<T_SEARCH_COLUMN> r = new List<T_SEARCH_COLUMN>();
            foreach (var item in columns)
            {
                r.Add(SearchColumnToDbModel(item));
            }
            return r;
        }

        /// <summary>
        /// 数据库中查询搜索列数据
        /// </summary>
        public List<ISearchColumn> GetSearchColumns()
        {
            List<T_SEARCH_COLUMN> columnList = _AL.GetSearchCloumns(_className);
            return DbModelToSearchColumn(columnList);
        }
        /// <summary>
        /// 保存搜索记录
        /// </summary>
        public bool SaveSearchRecord(ISearchRecord record, List<ISearchRecord_Detail> recordDetails, out string errMsg)
        {
            var searchRecord = RecordToDbModel(record);
            var detailList = RecordDetailToDbModel(recordDetails);
            bool result = _AL.SaveSearchRecord(_ownerForm, searchRecord, detailList, out errMsg);
            return result;
        }
        /// <summary>
        /// 删除已保存的搜索记录
        /// </summary>
        public bool DeleteRecord(ISearchRecord record, out string errMsg)
        {
            T_SEARCH_RECORD searchRecord = RecordToDbModel(record);
            bool result = _AL.DeleteRecord(searchRecord, out errMsg);
            return result;
        }
        /// <summary>
        /// 更新已保存记录的备注说明等信息
        /// </summary>
        public bool UpdateRecord(ISearchRecord record, out string errMsg)
        {
            var dbRecord = RecordToDbModel(record);
            bool result = _AL.UpdateRecord(dbRecord, out errMsg);
            return result;
        }
        /// <summary>
        /// 获取当前窗体保存的搜索记录
        /// </summary>
        public List<ISearchRecord> GetRecordList()
        {
            List<T_SEARCH_RECORD> recordList = _AL.GetRecordList(_ownerForm);
            return DbModelToRecord(recordList);
        }
        /// <summary>
        /// 指定搜索记录获取查询细目
        /// </summary>
        public List<ISearchRecord_Detail> GetRecordDetail(ISearchRecord record)
        {
            var dbRecord = RecordToDbModel(record);
            List<T_SEARCH_RECORD_DETAIL> detailList = _AL.GetRecordDetail(dbRecord);
            List<ISearchRecord_Detail> r = DbModelToRecordDetail(detailList);
            return r;
        }
        /// <summary>
        /// 从数据库中获取最后一次查询的搜索记录
        /// </summary>
        public List<ISearchRecord_Detail> GetDefaultRecordDetail()
        {
            var detail = _AL.GetDefaultRecordDetail(_ownerForm);
            return DbModelToRecordDetail(detail);
        }
    }
}