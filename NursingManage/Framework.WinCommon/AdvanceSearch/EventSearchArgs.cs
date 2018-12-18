using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework.WinCommon.AdvanceSearch
{
    public class EventSearchArgs
    {
        public List<ISearchRecord_Detail> SearchRecord { set; get; }
        public bool IsCancel { set; get; }
        public object Sender { set; get; }
    }
}
