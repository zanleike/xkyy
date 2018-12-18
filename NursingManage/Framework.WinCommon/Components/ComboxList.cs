/*
    创建日期: 2013.9.4
    创建者:张存
    邮箱:zhangcunliang@126.com
    修改记录:
        2015.6.9 筛选数据源只有一条记录时绑定绑定控件(TextBox)未赋值的bug
        2016.1.12 使用鼠标选取会不选择的bug修复
        2016.1.18 当使用鼠标单击选择时会默认第一个选项,更改为使用鼠标双击才能选择.
        2017.3.31 当GridView超出窗体下限时居中显示
        2017.4.1  选中行之后将光标移到下一个TabIndex控件上
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Framework.WinCommon.Controls;

namespace Framework.WinCommon.Components
{
    [Serializable]
    public class ComBoxModel
    {
        public ComBoxListColumn[] Columns { set; get; }
        public string ReturnColumn { get; set; }
        public string ReturnTagColumn { get; set; }
        public DataTable DataSource { set; get; }
        public int GridViewWidth { set; get; }
        public int DisplayRowCount { set; get; } //GridView显示几行数据
        public Control NextControl { set; get; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsUse { set; get; }
    }

    [Serializable]
    public class ComBoxListColumn
    {
        string _FieldName;

        public string FieldName
        {
            get { return _FieldName; }
            set { _FieldName = value; }
        }
        string _FieldCaption;

        public string FieldCaption
        {
            get { return _FieldCaption; }
            set { _FieldCaption = value; }
        }

        int _ColumnWidth = 0;
        /// <summary>
        /// 列宽
        /// </summary>
        public int ColumnWidth
        {
            get { return _ColumnWidth; }
            set { _ColumnWidth = value; }
        }

        bool _IsVisible = true;

        public bool IsVisible
        {
            get { return _IsVisible; }
            set { _IsVisible = value; }
        }

        bool _IsReturnText = false;
        /// <summary>
        /// 用于返回控件文本的列,每个集合中只能有一个为true.
        /// </summary>
        [Description("用于返回控件文本的列,每个集合中只能有一个为true.")]
        public bool IsReturnText
        {
            get { return _IsReturnText; }
            set { _IsReturnText = value; }
        }

        bool _IsReturnTag;
        /// <summary>
        /// 用于返回控件Tag属性的列,常用于保存Id,便于取值,每个集合中只能有一个为true.
        /// </summary>
        [Description("用于返回控件Tag属性的列,常用于保存Id,便于取值,每个集合中只能有一个为true.")]
        public bool IsReturnTag
        {
            get { return _IsReturnTag; }
            set { _IsReturnTag = value; }
        }

        public override string ToString()
        {
            return _FieldCaption;
        }
    }

    [ProvideProperty("Columns", typeof(TextBox))]
    [ProvideProperty("ReturnColumn", typeof(TextBox))]
    [ProvideProperty("ReturnTagColumn", typeof(TextBox))]
    [ProvideProperty("GridViewWidth", typeof(TextBox))]
    [ProvideProperty("DisplayRowCount", typeof(TextBox))]
    [ProvideProperty("NextControl", typeof(TextBox))]
    [ProvideProperty("IsUse", typeof(TextBox))]
    public class ComboxList : Component, IExtenderProvider
    {
        #region IExtenderProvider成员

        public bool CanExtend(object extendee)
        {
            return extendee is TextBox;
        }

        #endregion

        #region 系统生成

        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        #endregion

        #region 构造方法

        public ComboxList(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            _ComBoxDict = new Dictionary<TextBox, ComBoxModel>();
            SelectedRowHandle += new ComboxListSelectedRowAfterDeleate(My_SelectedRowHandle);
        }

        #endregion

        #region 私有变量

        /// <summary>
        /// 当前控件使用的GridView
        /// </summary>
        ZCDataGridView _MyGridView;
        /// <summary>
        /// 当前扩展控件的参数集合
        /// </summary>
        private Dictionary<TextBox, ComBoxModel> _ComBoxDict;

        #endregion

        #region 公用方法及事件

        /// <summary>
        /// 按回车选择行之后的事件
        /// </summary>
        public event ComboxListSelectedRowAfterDeleate SelectedRowHandle;
        /// <summary>
        /// 在显示GridView之前出发的事件,这个事件通常是用于绑定数据源
        /// </summary>
        public event ComboxListShowBeforeDeleate BeforeShowGridView;

        /// <summary>
        /// GridView最多显示的行号,默认是5
        /// </summary>
        int _MaxRowCount = 5;
        /// <summary>
        /// GridView最多显示的行号
        /// </summary>
        public int MaxRowCount
        {
            get { return _MaxRowCount; }
            set { _MaxRowCount = value; }
        }

        /// <summary>
        /// GridView的数据源
        /// </summary>
        DataTable _GridViewDataSource;
        /// <summary>
        /// 获取或设置要显示GridView的数据源
        /// </summary>
        public DataTable GridViewDataSource
        {
            get { return _GridViewDataSource; }
            set { _GridViewDataSource = value; }
        }

        #endregion

        #region 私有方法

        /// <summary>
        /// 根据TextBox控件,得到Combox字典中的实体类,如果不存在则往字典里增加一条记录
        /// </summary>
        private ComBoxModel GetComBoxDict(TextBox tb)
        {
            if (_ComBoxDict == null)
            {
                _ComBoxDict = new Dictionary<TextBox, ComBoxModel>();
            }
            if (_ComBoxDict.ContainsKey(tb))
            {
                return _ComBoxDict[tb];
            }
            else
            {
                ComBoxModel cbModel = new ComBoxModel();
                cbModel.Columns = new ComBoxListColumn[] { }; // new List<ComBoxListColumn>();
                //cbModel.ReturnColumn = string.Empty;
                cbModel.DataSource = null;
                cbModel.NextControl = tb;
                _ComBoxDict.Add(tb, cbModel);
                RegisterTextBoxEvent(tb);
                return cbModel;
            }
        }
        /// <summary>
        /// 注册文本框的事件
        /// </summary>
        private void RegisterTextBoxEvent(TextBox txtBox)
        {
            txtBox.Enter += new EventHandler(txtBox_Enter);
            //txtBox.KeyUp += new KeyEventHandler(txtBox_KeyUp);
            //keyPress是在keydown之后触发,所以在keyDown绑定数据源,keyPress显示Grid
            txtBox.KeyPress += new KeyPressEventHandler(txtBox_KeyPress);
        }

        void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                TextBox tb = (TextBox)sender;
                if (_ComBoxDict[tb].IsUse)
                {
                    ShowGridView(tb);
                }
            }
        }
        /// <summary>
        /// 获得焦点时将DataGridView隐藏
        /// </summary>
        void txtBox_Enter(object sender, EventArgs e)
        {
            if (_MyGridView != null && _MyGridView.Tag != sender)
            {
                _MyGridView.Visible = false;
            }
        }
        /// <summary>
        /// 当选中行后的处理事件
        /// </summary>
        void My_SelectedRowHandle(object sender, SelectRowEventArgs e)
        {

            if (e == null) return;
            DataRow dr = e.SelectedRow;
            if (dr == null) return;
            TextBox tb = sender as TextBox;
            if (!string.IsNullOrEmpty(_ComBoxDict[tb].ReturnColumn))
            {
                tb.Text = dr[_ComBoxDict[tb].ReturnColumn].ToString();
            }
            if (!string.IsNullOrEmpty(_ComBoxDict[tb].ReturnTagColumn))
            {
                tb.Tag = dr[_ComBoxDict[tb].ReturnTagColumn];
            }
            if (_ComBoxDict[tb].NextControl == tb)
            {
                tb.Focus();
                SendKeys.Send("{Tab}");
            }
            else if (_ComBoxDict[tb].NextControl != null)
            {
                _ComBoxDict[tb].NextControl.Focus();
                if (_ComBoxDict[tb].NextControl is TextBox)
                {
                    TextBox nextTextBox = (TextBox)_ComBoxDict[tb].NextControl;
                    nextTextBox.SelectionStart = nextTextBox.Text.Length;
                }
            }
            if (_MyGridView != null)
                _MyGridView.Visible = false;
        }

        void SelectRowHandle()
        {
            if (SelectedRowHandle != null)
            {
                SelectRowEventArgs selectedRow = new SelectRowEventArgs();
                selectedRow.SelectedRow = _MyGridView.GetSelectedRowData<DataRow>();
                selectedRow.BindControl = _MyGridView.Tag as TextBox;
                SelectedRowHandle(_MyGridView.Tag, selectedRow);
            }
        }

        /// <summary>
        /// 生成GridView和GridView列的方法,以及注册GridView事件
        /// </summary>
        void GenerateGridView(TextBox tb)
        {
            //创建GridView,并注册事件
            if (_MyGridView == null)
            {

                _MyGridView = new ZCDataGridView();
                _MyGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                _MyGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                _MyGridView.ScrollBars = ScrollBars.None;
                _MyGridView.RowHeadersVisible = false;
                _MyGridView.DisplayRowCount = false;
                _MyGridView.MouseDoubleClick += (s, e) =>
                {
                    SelectRowHandle();
                };
                _MyGridView.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {   
                        SelectRowHandle();
                    }
                    if (e.KeyCode == Keys.Escape)
                    {
                        var currTextBox = _MyGridView.Tag as TextBox;
                        _MyGridView.Visible = false;
                        currTextBox.Focus();
                        currTextBox.SelectionStart = tb.Text.Length;
                    }
                };
                tb.FindForm().KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Escape)
                    {
                        var currTextBox = _MyGridView.Tag as TextBox;
                        _MyGridView.Visible = false;
                        currTextBox.Focus();
                        currTextBox.SelectionStart = tb.Text.Length;
                    }
                };
            }
            //开始生成列
            _MyGridView.Columns.Clear();
            ComBoxListColumn[] columnList = _ComBoxDict[tb].Columns;
            if (columnList == null || columnList.Length == 0) return;
            for (int i = 0; i < columnList.Length; i++)
            {
                DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
                dgvCol.HeaderText = columnList[i].FieldCaption;
                dgvCol.DataPropertyName = columnList[i].FieldName;
                if (!columnList[i].IsVisible)
                {
                    dgvCol.Visible = false;
                }
                _MyGridView.Columns.Add(dgvCol);
            }
        }

        #region 取得顶点相对位置横坐标
        /// <summary>
        /// 取得顶点相对位置横坐标
        /// </summary>
        /// <param name="crl"></param>
        /// <returns></returns>
        private int GetLeft(Control crl)
        {
            if (crl.Parent is Form)
            {
                return crl.Left;
            }
            else
            {
                return crl.Left + GetLeft(crl.Parent);
            }
        }
        #endregion

        #region 取得顶点相对位置纵坐标
        /// <summary>
        /// 取得顶点相对位置纵坐标
        /// </summary>
        /// <param name="crl"></param>
        /// <returns></returns>
        private int GetTop(Control crl)
        {
            if (crl.Parent is Form)
            {
                return crl.Top;
            }
            else
            {
                return crl.Top + GetTop(crl.Parent);
            }
        }
        #endregion

        /// <summary>
        /// 设置GridView的宽和高并显示和数据源,如果数据源为null则return        
        /// </summary>
        void ShowGridView(TextBox tb)
        {
            if (!_ComBoxDict[tb].IsUse) return;
            if (BeforeShowGridView != null)
            {
                BeforeShowGridView(tb, null);
            }
            if (_GridViewDataSource == null || _GridViewDataSource.Rows.Count == 0) return;
            SelectRowEventArgs selectedRow = new SelectRowEventArgs();
            selectedRow.BindControl = tb;
            //if (_GridViewDataSource.Rows.Count == 1)
            //{
            //    selectedRow.SelectedRow = _GridViewDataSource.Rows[0];
            //    SelectedRowHandle(tb, selectedRow);
            //    return;
            //}
            GenerateGridView(tb);
            if (_MyGridView.Columns.Count == 0) return;
            _MyGridView.DataSource = null;
            _MyGridView.DataSource = _GridViewDataSource;
            _MyGridView.Tag = tb;
            _MyGridView.Parent = tb.FindForm(); // tb.Parent;
            _MyGridView.BringToFront();
            _MyGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            _MyGridView.AutoResizeColumns();

            int newWidth = 0;
            for (int i = 0; i < _MyGridView.Columns.Count; i++)
            {
                if (_MyGridView.Columns[i].Visible)
                    newWidth = newWidth + _MyGridView.Columns[i].Width + 1;
            }
            //最多显示行的数量
            int showRowCount = _MaxRowCount;
            if (showRowCount > _MyGridView.Rows.Count) showRowCount = _MyGridView.Rows.Count;
            if (_MyGridView.Rows.Count > showRowCount)
            {
                _MyGridView.ScrollBars = ScrollBars.Vertical;
                _MyGridView.Width = newWidth + 20; //加上进度条的宽    
            }
            else
            {
                _MyGridView.Width = newWidth;
            }

            int headerHeight = _MyGridView.Rows[0].Height; //列标题的高            
            _MyGridView.Height = headerHeight * showRowCount + _MyGridView.ColumnHeadersHeight + 5;
            if (_MyGridView.Width < tb.Width)
            {
                _MyGridView.Width = tb.Width;
                _MyGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            _MyGridView.Left = GetLeft(tb);
            _MyGridView.Top = GetTop(tb) + tb.Height;
            //_MyGridView.Rows[0].Selected = false;
            Form thisForm = _MyGridView.FindForm();
            if (_MyGridView.Width > thisForm.Width) _MyGridView.Width = thisForm.Width;
            if (_MyGridView.Height > thisForm.Height) _MyGridView.Height = thisForm.Height;

            if (_MyGridView.Top + _MyGridView.Height + 20 > thisForm.Height)
            {
                //如果超出了窗体的最下面，那么居中显示在窗体中央
                _MyGridView.Top = (thisForm.Height - _MyGridView.Height - 20) / 2;
            }
            if (_MyGridView.Left + _MyGridView.Width + 20 > thisForm.Width)
            {
                _MyGridView.Left = (thisForm.Width - _MyGridView.Height - 20) / 2;
            }
            _MyGridView.Visible = true;
            _MyGridView.Focus();

            if (_GridViewDataSource.Rows.Count == 1)
            {
                selectedRow.SelectedRow = _GridViewDataSource.Rows[0];
                SelectedRowHandle(tb, selectedRow);
                return;
            }

        }

        #endregion

        #region 文本框的扩展方法们

        [Category("自定义选择框扩展属性")]
        [Description("获取或设置列信息")]
        public ComBoxListColumn[] GetColumns(TextBox t)
        {
            ComBoxModel cbModel = GetComBoxDict(t);
            return cbModel.Columns;
        }
        public void SetColumns(TextBox t, ComBoxListColumn[] list)
        {
            ComBoxModel cbModel = GetComBoxDict(t);

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].IsReturnText)
                {
                    cbModel.ReturnColumn = list[i].FieldName;
                }
                if (list[i].IsReturnTag)
                {
                    cbModel.ReturnTagColumn = list[i].FieldName;
                }
            }
            cbModel.Columns = list;
        }

        [Category("自定义选择框扩展属性")]
        [Description("获取或设置返回列的字段名")]
        public string GetReturnColumn(TextBox t)
        {
            ComBoxModel cbModel = GetComBoxDict(t);
            return cbModel.ReturnColumn;
        }

        [Category("自定义选择框扩展属性")]
        [Description("获取或设置返回列的字段名")]
        public string GetReturnTagColumn(TextBox t)
        {
            ComBoxModel cbModel = GetComBoxDict(t);
            return cbModel.ReturnTagColumn;
        }

        [Category("自定义选择框扩展属性")]
        [Description("获取或设置该数据源的GridView宽")]
        public int GetGridViewWidth(TextBox t)
        {
            ComBoxModel cbModel = GetComBoxDict(t);
            return cbModel.GridViewWidth;
        }
        public void SetGridViewWidth(TextBox t, int s)
        {
            ComBoxModel cbModel = GetComBoxDict(t);
            cbModel.GridViewWidth = s;
        }

        [Category("自定义选择框扩展属性")]
        [Description("获取或设置GridView要显示的行数")]
        public int GetDisplayRowCount(TextBox t)
        {
            ComBoxModel cbModel = GetComBoxDict(t);
            return cbModel.DisplayRowCount;
        }
        public void SetDisplayRowCount(TextBox t, int s)
        {
            ComBoxModel cbModel = GetComBoxDict(t);
            cbModel.DisplayRowCount = s;
        }

        [Category("自定义选择框扩展属性")]
        [Description("获取或设置选中后的跳转的控件")]
        public Control GetNextControl(TextBox t)
        {
            ComBoxModel cbModel = GetComBoxDict(t);
            return cbModel.NextControl;
        }
        public void SetNextControl(TextBox t, Control s)
        {
            ComBoxModel cbModel = GetComBoxDict(t);
            cbModel.NextControl = s;
        }

        [Category("自定义选择框扩展属性")]
        [Description("获取或设置是否启用ComboxList扩展组件")]
        public bool GetIsUse(TextBox t)
        {
            ComBoxModel cbModel = GetComBoxDict(t);
            return cbModel.IsUse;
        }
        public void SetIsUse(TextBox t, bool s)
        {
            ComBoxModel cbModel = GetComBoxDict(t);
            cbModel.IsUse = s;
        }

        #endregion
    }
}
