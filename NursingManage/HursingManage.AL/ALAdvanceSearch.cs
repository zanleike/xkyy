using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;

namespace HursingManage.AL
{
    public class ALAdvanceSearch : ALBase
    {
        public List<T_SEARCH_COLUMN> GetSearchCloumns(string modelClass)
        {
            var query = DB.CreateQueryCondition<T_SEARCH_COLUMN>();
            query.WhereAnd(s => s.MODELCLASS == modelClass);
            query.OrderBy(s => s.ORDERNO);
            var queryReuslt = DB.QueryWhere<T_SEARCH_COLUMN>(query);
            return queryReuslt.ToList();
        }

        /// <summary>
        /// 保存搜索记录
        /// </summary>
        public bool SaveSearchRecord(string ownerForm, T_SEARCH_RECORD searchRecord, List<T_SEARCH_RECORD_DETAIL> detailList, out string errMsg)
        {
            if (detailList == null || detailList.Count == 0)
            {
                errMsg = "记录明细不能为空!";
                return false;
            }
            string recordID = GetGuid();
            searchRecord.ID = recordID;
            searchRecord.OPERATORID = CurrentLoginUser.ID;
            searchRecord.OWNERFORM = ownerForm;
            DB.Insert(searchRecord);
            foreach (var detail in detailList)
            {
                detail.RECORDID = recordID;
                detail.OWNERFORM = ownerForm;
                DB.Insert(detail);
            }
            errMsg = null;
            return true;
        }

        public bool DeleteRecord(T_SEARCH_RECORD searchRecord, out string errMsg)
        {
            if (searchRecord == null)
            {
                errMsg = "所要删除的记录为空.";
                return false;
            }
            DB.Delete<T_SEARCH_RECORD_DETAIL>(s => s.RECORDID == searchRecord.ID);
            DB.Delete<T_SEARCH_RECORD>(searchRecord);
            errMsg = null;
            return true;
        }

        public List<T_SEARCH_RECORD> GetRecordList(string ownerForm)
        {
            var query = DB.CreateQueryCondition<T_SEARCH_RECORD>();
            query.WhereAnd(s => s.OWNERFORM == ownerForm && s.OPERATORID == CurrentLoginUser.ID);
            query.OrderBy(s => s.LASTTIME);
            var queryResult = DB.QueryWhere<T_SEARCH_RECORD>(query);
            return queryResult.ToList();
        }

        public List<T_SEARCH_RECORD_DETAIL> GetRecordDetail(T_SEARCH_RECORD searchRecord)
        {
            if (searchRecord == null) return null;
            var query = DB.CreateQueryCondition<T_SEARCH_RECORD_DETAIL>();
            query.WhereAnd(s => s.RECORDID == searchRecord.ID);
            query.OrderBy(s => s.ORDERNO);
            var qResult = DB.QueryWhere<T_SEARCH_RECORD_DETAIL>(query);
            return qResult.ToList();
        }

        public List<T_SEARCH_RECORD_DETAIL> GetDefaultRecordDetail(string ownerForm)
        {
            var query = DB.CreateQueryCondition<T_SEARCH_RECORD>();
            query.WhereAnd(s => s.OWNERFORM == ownerForm && s.OPERATORID == CurrentLoginUser.ID);
            query.OrderBy(s => s.LASTTIME, Framework.EmOrderByType.Desc);
            var queryResult = DB.QueryWhere<T_SEARCH_RECORD>(query);
            var result = queryResult.ToEntity();
            return GetRecordDetail(result);
        }

        public bool UpdateRecord(T_SEARCH_RECORD dbRecord, out string errMsg)
        {
            DB.Update(dbRecord);
            errMsg = null;
            return true;
        }
    }
}