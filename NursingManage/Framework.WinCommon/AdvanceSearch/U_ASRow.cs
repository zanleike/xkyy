using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Framework.WinCommon.AdvanceSearch
{
    internal partial class U_ASRow : UserControl
    {
        public U_ASRow()
        {
            InitializeComponent();
            InitiCompareSign();
            coBoxConnectSign.SelectedIndex = 0;
            coBoxField.ValueMember = "ColumnName";
            coBoxField.DisplayMember = "ColumnCaption";
        }
        public U_ASRow(string controlName, ISearchColumn[] cm)
            : this()
        {
            this.Name = controlName;
            InitiColumns(cm);
        }
        class CompareSignModel
        {
            public string CompareSignHZ { set; get; }
            public CompareSignEnum CompareSign { set; get; }
        }
        /// <summary>
        /// 初始化比较符
        /// </summary>
        void InitiCompareSign()
        {
            var cs = new List<CompareSignModel>();
            cs.Add(new CompareSignModel() { CompareSign = CompareSignEnum.EqualTo, CompareSignHZ = "等于" });
            cs.Add(new CompareSignModel() { CompareSign = CompareSignEnum.Like, CompareSignHZ = "类似于" });
            cs.Add(new CompareSignModel() { CompareSign = CompareSignEnum.NotEqualTo, CompareSignHZ = "不等于" });
            cs.Add(new CompareSignModel() { CompareSign = CompareSignEnum.NotLike, CompareSignHZ = "非类似于" });
            cs.Add(new CompareSignModel() { CompareSign = CompareSignEnum.GreaterThan, CompareSignHZ = "大于" });
            cs.Add(new CompareSignModel() { CompareSign = CompareSignEnum.GreaterThanOrEqual, CompareSignHZ = "大于等于" });
            cs.Add(new CompareSignModel() { CompareSign = CompareSignEnum.LessThan, CompareSignHZ = "小于" });
            cs.Add(new CompareSignModel() { CompareSign = CompareSignEnum.LessThanOrEqual, CompareSignHZ = "小于等于" });
            coBoxCompareSign.DataSource = cs;
            coBoxCompareSign.DisplayMember = "CompareSignHZ";
            coBoxCompareSign.ValueMember = "CompareSign";
        }
        bool _IsFirstRow = false;
        /// <summary>
        /// 是否首行,首行会隐藏连接符和删除按钮
        /// </summary>
        public bool IsFirstRow
        {
            get { return _IsFirstRow; }
            set
            {
                _IsFirstRow = value;
                if (IsFirstRow)
                {
                    coBoxConnectSign.Visible = false;
                }
                else
                {
                    coBoxConnectSign.Visible = true;
                    btnDelete.Visible = true;
                }
            }
        }

        public void InitiColumns(ISearchColumn[] cm)
        {
            coBoxField.DataSource = cm;
        }
        public void InitiColumns(List<ISearchColumn> cm)
        {
            coBoxField.DataSource = cm;
        }

        public void SetCompareSign(string compareSignEnumStr)
        {
            CompareSignEnum cse = (CompareSignEnum)Enum.Parse(typeof(CompareSignEnum), compareSignEnumStr, true);
            coBoxCompareSign.SelectedValue = cse;
        }

        public void SetConnectorSign(string connectorSignStr)
        {
            coBoxConnectSign.Text = connectorSignStr;
        }

        public void SetSelectColumn(string columnsName)
        {
            coBoxField.SelectedValue = columnsName;
        }

        public void SetSearchValue(string serValue)
        {
            txtValue.Text = serValue;
        }

        public void SetSearchModel(ISearchRecord_Detail record)
        {
            SetCompareSign(record.CompareSignStr);
            SetConnectorSign(record.ConnectorSignStr);
            SetSelectColumn(record.FieldName);
            SetSearchValue(record.SearchValue);
        }

        public ISearchRecord_Detail GetSearchRecord()
        {
            if (coBoxField.SelectedValue == null || coBoxField.SelectedValue.ToString() == string.Empty) return null;
            if (txtValue.Text.Trim().Length == 0) return null;
            ISearchRecord_Detail sr = new ISearchRecord_Detail();
            CompareSignEnum cse = (CompareSignEnum)coBoxCompareSign.SelectedValue;
            //sr.CompareSign = cse;
            sr.CompareSignStr = cse.ToString();
            if (coBoxConnectSign.Visible)
            {
                sr.ConnectorSignStr = coBoxConnectSign.Text;
            }
            else
            {
                sr.ConnectorSignStr = string.Empty;
            }
            sr.FieldName = coBoxField.SelectedValue.ToString();
            var column = coBoxField.SelectedItem as ISearchColumn;
            sr.DataTypeStr = column.DataType;
            sr.SearchValue = txtValue.Text;
            return sr;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}