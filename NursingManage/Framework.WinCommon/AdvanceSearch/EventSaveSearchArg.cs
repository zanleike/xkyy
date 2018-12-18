using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework.WinCommon.AdvanceSearch
{
    public class EventSaveSearchArg
    {
        public Form OwnerForm { set; get; }
        public List<ISearchRecord_Detail> SearchRecords { set; get; }
        public bool IsDefault { set; get; }
    }
}