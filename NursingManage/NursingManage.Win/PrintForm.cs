using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
//using grproLib;  // 5.X
using gregn6Lib;   // 6.X
using System.IO;


namespace NursingManage.Win
{
    public partial class PrintForm : BaseEditForm
    {
        public PrintForm(string templateName, DataTable dt, Dictionary<string, string> paramDict)
        {
            InitializeComponent();
            _TemplateFileName = templateName;
            _MainReport = new GridppReport();
            _IsClose = !InitiPrint(templateName, dt, paramDict);
        }

        GridppReport _MainReport;
        DataTable _DataTable;
        string _TemplateFileName;
        /// <summary>
        /// 这个变量用来判断是输出花打印时是否异常,如果异常在formload时退出
        /// </summary>
        bool _IsClose = false;

        /// <summary>
        /// 初始化打印属性
        /// </summary>
        bool InitiPrint(string templateName, DataTable dt, Dictionary<string, string> paramDict)
        {
            if (_DataTable != null) _DataTable.Clear();
            _DataTable = dt;
            if (File.Exists(templateName) == false)
            {
                MessageBox.Show("打印模板文件不存在，或者路径不正确！\r\n" + templateName, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            _MainReport.LoadFromFile(templateName);
            _MainReport.FetchRecord += new _IGridppReportEvents_FetchRecordEventHandler(Report_FetchRecord);
            //填充参数字段
            SetReportParameter(_MainReport, paramDict);
            this.axGRPrintViewer1.Report = _MainReport;
            return true;
        }
        /// <summary>
        /// 填充主报表数据明细,(事件: _IGridppReportEvents_FetchRecordEventHandler的方法)
        /// </summary>
        void Report_FetchRecord()
        {
            try
            {
                SetFetchRecord(_MainReport, _DataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 填充参数字段
        /// </summary>
        /// <param name="report">Report对象</param>
        /// <param name="paramDict">盘数字典</param>
        void SetReportParameter(GridppReport report, Dictionary<string, string> paramDict)
        {
            if (paramDict == null) return;
            foreach (string keyItem in paramDict.Keys)
            {
                IGRParameter param = report.ParameterByName(keyItem);
                if (param != null)
                    param.AsString = paramDict[keyItem];
            }
        }
        /// <summary>
        ///  将 DataTable 的数据转储到 Grid++Report 的数据集中
        /// </summary>
        void SetFetchRecord(GridppReport report, DataTable dt)
        {
            if (dt == null) return;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                report.DetailGrid.Recordset.Append();
                foreach (IGRField fld in report.DetailGrid.Recordset.Fields)
                {
                    if (dt.Columns.Contains(fld.Name))
                    {
                        fld.Value = dt.Rows[i][fld.Name];
                    }
                }
                report.DetailGrid.Recordset.Post();
            }
        }

        private void FrmPrint_Load(object sender, EventArgs e)
        {
            if (_IsClose)
            {
                this.Close();
                return;
            }
            //axGRPrintViewer1.Print(false);
            //axGRPrintViewer1.Report.Printer.PrinterName = "打印机名";            
            axGRPrintViewer1.Start();
            this.Text = this.Text + string.Format("模板文件:{0}", _TemplateFileName);
        }

        private void FrmPrint_FormClosed(object sender, FormClosedEventArgs e)
        {
            axGRPrintViewer1.Stop();
            axGRPrintViewer1.Dispose();
        }
    }
}