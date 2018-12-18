using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Framework.WinCommon.Controls
{
    public delegate void CalendarEventHandle(object sender, CalendarEventArgs e);

    public class CalendarEventArgs : EventArgs
    {
        public int Year { set; get; }
        public int Month { set; get; }
        public int Day { set; get; }
        public string CellText { set; get; }
        public object CellValue { set; get; }
        public DataGridViewCell DGVCell { set; get; }
    }

    public class DgvCalendar : DataGridView
    {
        public DgvCalendar()
        {
            InitializeComponent();
        }
        void InitializeComponent()
        {

            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeRows = false;
            this.AutoGenerateColumns = false; //自动创建列
            this.ReadOnly = true;
            this.BackgroundColor = Color.White;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.RowHeadersVisible = false;
            this.DefaultCellStyle = new DataGridViewCellStyle()
            {
                WrapMode = DataGridViewTriState.True,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Font = new Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            };
            _WeekDict.Add(0, "周日");
            _WeekDict.Add(1, "周一");
            _WeekDict.Add(2, "周二");
            _WeekDict.Add(3, "周三");
            _WeekDict.Add(4, "周四");
            _WeekDict.Add(5, "周五");
            _WeekDict.Add(6, "周六");
            this.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
        }
        /// <summary>
        /// GridView字典列表,key:该月的第几天
        /// </summary>
        Dictionary<int, DataGridViewCell> _GirdViewCellDict = new Dictionary<int, DataGridViewCell>();
        /// <summary>
        /// 周的字典,key:0-7,value:周日-周六
        /// </summary>
        Dictionary<int, string> _WeekDict = new Dictionary<int, string>();
        int _Year;
        /// <summary>
        /// 获取当前日历的年份
        /// </summary>
        public int Year
        {
            get { return _Year; }
        }
        int _Month;
        /// <summary>
        /// 获取当前日历的月份
        /// </summary>
        public int Month
        {
            get { return _Month; }
        }

        int _RowHeight = 80;
        /// <summary>
        /// 每行的高度
        /// </summary>
        public int RowHeight
        {
            get { return _RowHeight; }
            set { _RowHeight = value; }
        }

        int _FirstWeek = 1;
        /// <summary>
        /// 星期的开始是周几,0:周日,1周一
        /// </summary>
        public int FirstWeek
        {
            get { return _FirstWeek; }
            set { _FirstWeek = value; }
        }

        string GetCellText(int day, string cellText)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(day.ToString());
            DateTime date = new DateTime(_Year, _Month, day);
            //公立节日
            string gljr = ChinaDate.GetHoliday(date);
            if (!string.IsNullOrEmpty(gljr))
            {
                sb.AppendLine(gljr);
            }
            //农历日期

            string nlrq_day = ChinaDate.GetDay(date);
            if (nlrq_day == "初一")
            {
                string nlrq_month = ChinaDate.GetMonth(date);
                sb.AppendLine(nlrq_month);
            }
            else
            {
                sb.AppendLine(nlrq_day);
            }
            string nljq = ChinaDate.GetSolarTerm(date);
            if (!string.IsNullOrEmpty(nljq))
            {
                sb.AppendLine(nljq);
            }
            if (!string.IsNullOrEmpty(cellText))
            {
                sb.AppendLine(string.Format("({0})", cellText));
            }

            return sb.ToString();
        }

        /// <summary>
        /// 设置选中项值改变后触发的事件
        /// </summary>
        public event CalendarEventHandle SetValueAfter;
        /// <summary>
        /// 设置当前月份的指定某天的单元格内容
        /// </summary>
        /// <param name="day">当月第几天(几号)</param>
        /// <param name="cellText">显示值</param>
        /// <param name="cellValue">cell.Value</param>
        public void SetCellValue(int day, string cellText, object cellValue)
        {
            _GirdViewCellDict[day].Value = GetCellText(day, cellText); //string.Format("{0} {1}", day, cellText);
            _GirdViewCellDict[day].Tag = cellValue;
        }
        /// <summary>
        /// 设置当前所有选中项的值
        /// </summary>
        /// <param name="cellText">文本显示</param>
        /// <param name="cellValue">cell.Tag值</param>
        public void SetSelectedValue(string cellText, object cellValue)
        {
            foreach (int dayValue in _GirdViewCellDict.Keys)
            {
                if (_GirdViewCellDict[dayValue].Selected)
                {
                    SetCellValue(dayValue, cellText, cellValue);
                    if (SetValueAfter != null)
                    {
                        CalendarEventArgs e = new CalendarEventArgs();
                        e.Year = _Year;
                        e.Month = _Month;
                        e.Day = dayValue;
                        e.CellText = cellText;
                        e.CellValue = cellValue;
                        e.DGVCell = _GirdViewCellDict[dayValue];
                        SetValueAfter(this, e);
                    }
                }
            }
        }
        /// <summary>
        /// 获取所有cell.Tag值,Key:日期(该月的第几天)
        /// </summary>
        public Dictionary<int, object> GetCellValueDict()
        {
            Dictionary<int, object> dict = new Dictionary<int, object>();
            foreach (var item in _GirdViewCellDict.Keys)
            {
                dict.Add(item, _GirdViewCellDict[item].Tag);
            }
            return dict;
        }
        /// <summary>
        /// 初始化日历控件
        /// </summary>
        public void InitiCalendar(int year, int month)
        {
            this.Columns.Clear();
            _GirdViewCellDict.Clear();
            _Year = year;
            _Month = month;
            int colIndex = _FirstWeek;
            for (int i = 0; i < 7; i++)
            {
                this.Columns.Add("Week" + i, _WeekDict[colIndex]);
                colIndex++;
                if (colIndex >= 7) colIndex = 0;
            }
            this.Rows.Clear();
            //得到本月第一天是星期几
            int firstDayWeek = (int)(new DateTime(year, month, 1)).DayOfWeek;
            //该月的最后一天是几号
            int lastDay = (new DateTime(year, month, 1)).AddMonths(1).AddDays(-1).Day;

            int newRowIndex = this.Rows.Add();

            this.Rows[newRowIndex].Height = _RowHeight;
            //几号
            int dayValue = 1;
            //周几
            int dayWeek = firstDayWeek;
            //string columnName;
            //while 是增加行,不知道是多少行
            dayWeek = firstDayWeek - _FirstWeek;
            if (dayWeek < 0)
            {
                dayWeek = 7 + dayWeek;
            }
            while (true)
            {
                DataGridViewCell dgvc = this.Rows[newRowIndex].Cells[dayWeek];
                dgvc.Value = GetCellText(dayValue, string.Empty);
                _GirdViewCellDict.Add(dayValue, dgvc);
                dayWeek++;
                dayValue++;
                if (dayValue > lastDay)
                {
                    break;
                }
                if (dayWeek > 6)
                {
                    newRowIndex = this.Rows.Add();
                    this.Rows[newRowIndex].Height = _RowHeight;
                    dayWeek = 0;
                }
            }
            this.SelectedCells[0].Selected = false;
            this.Height = this.ColumnHeadersHeight + _RowHeight * this.Rows.Count + 5;
        }
    }
}