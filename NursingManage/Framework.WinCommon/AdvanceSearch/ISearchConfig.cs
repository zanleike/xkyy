using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.WinCommon.AdvanceSearch
{
    public interface ISearchConfig
    {
        string OwnerForm { get; }
        bool SaveSearchRecord(ISearchRecord record, List<ISearchRecord_Detail> recordDetails, out string errMsg);
        bool DeleteRecord(ISearchRecord record, out string errMsg);
        bool UpdateRecord(ISearchRecord record, out string errMsg);
        List<ISearchRecord> GetRecordList();
        List<ISearchRecord_Detail> GetRecordDetail(ISearchRecord record);
        List<ISearchRecord_Detail> GetDefaultRecordDetail();
        List<ISearchColumn> GetSearchColumns();
        
    }
}