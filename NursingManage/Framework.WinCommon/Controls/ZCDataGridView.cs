/*    
    时间:2013.6.15
    创建人:张存
    邮箱:zhangcunliang@126.com
    
    2017.4.7  实现绑定数据源之后所选中行还保持原有选中
    2017.8.1  是否保持原有选中会默认选中首行，加上是否保持原有选项的配置
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using Framework.Common.Helpers;

namespace Framework.WinCommon.Controls
{
    /// <summary>
    /// 绑定分页数据的委托
    /// </summary>
    public delegate DataTable BindPagingDataDelegate(int onePageCount, int pageNo, out int recordCount);
    /// <summary>
    /// 绑定非分页数据的委托
    /// </summary>
    public delegate DataTable BindDataDelegate();

    public class ZCDataGridView : DataGridView
    {
        public ZCDataGridView()
        {
            InitializeComponent();
        }

        ///// <summary>
        ///// 主键名
        ///// </summary>
        //string _PKName;
        /// <summary>
        /// 最后一次选中的行号，用于刷新数据源之后选中行不变的效果
        /// </summary>
        int LastSelectedRowIndex = 0;

        void InitializeComponent()
        {
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeRows = false;
            this.AutoGenerateColumns = false; //自动创建列
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ReadOnly = true;
            //this.RowHeadersVisible = false; //行前面那列
            this.MultiSelect = false; //多选
            this.BackgroundColor = Color.White;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.CellClick += new DataGridViewCellEventHandler(ZCDataGridView_CellClick);
            this.SelectionChanged += new EventHandler(ZCDataGridView_SelectionChanged);

            #region 样式
            ////奇数行样式
            //DataGridViewCellStyle alternatingRowsStyle = new System.Windows.Forms.DataGridViewCellStyle();            
            //alternatingRowsStyle.BackColor = System.Drawing.SystemColors.Control;
            ////缺省行样式,非奇数行
            //DataGridViewCellStyle rowDefaultStyle = new System.Windows.Forms.DataGridViewCellStyle();
            //rowDefaultStyle.BackColor = System.Drawing.Color.Snow;
            //this.RowsDefaultCellStyle = rowDefaultStyle;
            //this.AlternatingRowsDefaultCellStyle = alternatingRowsStyle;
            //this.BackgroundColor = System.Drawing.Color.Snow;
            #endregion
            //初始化样式
            InitiStyle();
            this.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dgv_RowPostPaint);

            this.DataBindingComplete += DataBindingComplete_ViewDisplay;
        }

        #region 行号显示

        bool _DisplayRowCount = false;
        /// <summary>
        /// 是否显示行号
        /// </summary>
        public bool DisplayRowCount
        {
            get { return _DisplayRowCount; }
            set
            {
                this.RowHeadersVisible = value;
                _DisplayRowCount = value;
            }
        }

        void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (!_DisplayRowCount) return;
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                this.RowHeadersWidth - 4,
                e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
            this.RowHeadersDefaultCellStyle.Font,
                rectangle,
                this.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        #endregion

        bool _IsKeepOldSelected = true;

        /// <summary>
        /// 是否保持原有的选中行der，默认为true
        /// </summary>
        public bool IsKeepOldSeldected
        {
            get { return _IsKeepOldSelected; }
            set { _IsKeepOldSelected = value; }
        }

        #region 样式处理

        bool _UseControlStyle = true;
        /// <summary>
        /// 是否使用控件本身的样式,
        /// true:将设置成系统默认样式
        /// </summary>
        [Description("是否使用控件本身的样式,true:将设置成系统默认样式"), Category("_张存的GridView"), Browsable(true)]
        public bool UseControlStyle
        {
            get { return _UseControlStyle; }
            set
            {
                if (value)
                {
                    InitiStyle();
                }
                _UseControlStyle = value;
            }
        }
        /// <summary>
        /// 初始化GridView样式
        /// </summary>
        public void InitiStyle()
        {
            this.BackgroundColor = System.Drawing.Color.Snow;
            this.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }

        #endregion

        #region 字段对应的内容显示,如某列显示 1:对应"是"

        /// <summary>
        /// 视图对应字典,key:列名, 2级key:原值,2级value:对应值
        /// </summary>
        Dictionary<string, Dictionary<string, string>> _ViewDict;
        /// <summary>
        /// 增加一个对应列及值要显示的内容
        /// </summary>
        /// <param name="colName">列名</param>
        /// <param name="sourceValue">原显示的列值</param>
        /// <param name="disPlayValue">对应显示的值</param>
        public void AddViewColumn(string colName, string sourceValue, string disPlayValue)
        {
            if (!this.Columns.Contains(colName))
            {
                return;
            }
            if (_ViewDict == null)
            {
                _ViewDict = new Dictionary<string, Dictionary<string, string>>();
            }

            Dictionary<string, string> viewData;
            if (!_ViewDict.ContainsKey(colName))
            {
                DataGridViewColumn oldDgvc = this.Columns[colName];
                oldDgvc.Visible = false;
                DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                dgvc.HeaderText = oldDgvc.HeaderText;
                dgvc.Name = oldDgvc.Name + "_view";
                dgvc.ReadOnly = true;
                dgvc.Width = oldDgvc.Width;
                dgvc.Visible = true;
                dgvc.DisplayIndex = oldDgvc.DisplayIndex;
                this.Columns.Add(dgvc);
                viewData = new Dictionary<string, string>();
                _ViewDict.Add(colName, viewData);
            }
            else
            {
                viewData = _ViewDict[colName];
            }
            if (!viewData.ContainsKey(sourceValue))
            {
                viewData.Add(sourceValue, disPlayValue);
            }
            else
            {
                viewData[sourceValue] = disPlayValue;
            }
        }
        /// <summary>
        /// 数据加载完成后触发相关视图的处理
        /// </summary>
        void DataBindingComplete_ViewDisplay(object sender, DataGridViewBindingCompleteEventArgs e)
        {   
            if (_IsKeepOldSelected)
            {
                if (this.Rows.Count > 0)
                {
                    if (LastSelectedRowIndex < 0)
                    {
                        this.Rows[0].Selected = true;
                        this.CurrentCell = this.Rows[0].Cells[0];
                    }
                    else if (LastSelectedRowIndex >= this.Rows.Count)
                    {
                        this.Rows[this.Rows.Count - 1].Selected = true;
                        if (this.Columns[0].Visible)
                            this.CurrentCell = this.Rows[this.Rows.Count - 1].Cells[0];
                    }
                    else
                    {
                        this.Rows[LastSelectedRowIndex].Selected = true;
                        if (this.Columns[0].Visible)
                            this.CurrentCell = this.Rows[LastSelectedRowIndex].Cells[0];
                    }
                }
            }

            if (_ViewDict != null && _ViewDict.Count > 0)
            {
                object cellValue;
                for (int i = 0; i < this.Rows.Count; i++)
                {
                    foreach (string colName in _ViewDict.Keys)
                    {
                        if (this.Columns.Contains(colName))
                        {
                            cellValue = this.Rows[i].Cells[colName].Value;
                            if (cellValue == null || cellValue == DBNull.Value) cellValue = string.Empty;
                            Dictionary<string, string> viewValues = _ViewDict[colName];
                            foreach (var viewValue in viewValues.Keys)
                            {
                                if (cellValue.ToString() == viewValue)
                                {
                                    this.Rows[i].Cells[colName + "_view"].Value = viewValues[viewValue];

                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion

        /// <summary>
        /// 绑定数据源
        /// </summary>
        public void BindDataSource(object dataSource)
        {
            this.DataSource = null;
            this.DataSource = dataSource;
        }
        /// <summary>
        /// 返回第一列的所有选中行
        /// </summary>
        public object[] GetAllSelectedItem()
        {
            if (this.SelectedRows.Count > 0)
            {
                object[] objArr = new object[this.SelectedRows.Count];
                for (int i = 0; i < SelectedRows.Count; i++)
                {
                    objArr[i] = SelectedRows[i].Cells[0].Value;
                }
                return objArr;
            }
            return null;
        }
        /// <summary>
        /// 返回指定列的所有的选中行
        /// </summary>
        public object[] GetAllSelectedItem(string columnName)
        {
            if (this.SelectedRows.Count > 0)
            {
                if (!this.Columns.Contains(columnName))
                {
                    return null;
                }
                object[] objArr = new object[this.SelectedRows.Count];
                for (int i = 0; i < SelectedRows.Count; i++)
                {
                    objArr[i] = SelectedRows[i].Cells[columnName].Value;
                }
                return objArr;
            }
            return null;
        }
        /// <summary>
        /// 返回选中的首行的指定列的值，未获取到返回null
        /// </summary>
        public object GetFirstSelectItem(string columnName)
        {
            object[] selItem = GetAllSelectedItem(columnName);
            if (selItem != null && selItem.Length > 0)
            {
                return selItem[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 返回选中的首行的指定列的值，未获取到返回null
        /// </summary>
        public T GetFirstSelectItem<T>(string columnName)
        {
            return GetCellValueByRowIndex<T>(this.SelectedRows[0].Cells[0].RowIndex, columnName);
        }
        /// <summary>
        /// 根据行索引号获取指定单元格的值
        /// </summary>
        public object GetCellValueByRowIndex(int rowIndex, string columnName)
        {
            if (rowIndex < this.Rows.Count && this.Columns.Contains(columnName))
            {
                object cellValue = this.Rows[rowIndex].Cells[columnName].Value;
                return cellValue;
            }
            return null;
        }
        public T GetCellValueByRowIndex<T>(int rowIndex, string columnName)
        {
            object obj = GetCellValueByRowIndex(rowIndex, columnName);
            if (obj != null && obj != DBNull.Value)
            {
                if (default(T) is ValueType)
                {
                    T t = (T)Convert.ChangeType(obj, obj.GetType());
                    return t;
                }
                else
                {
                    T t = (T)obj;
                    return t;
                }

            }
            return default(T);
        }
        /// <summary>
        /// 设置指定行和列的单元格的值
        /// </summary>
        public bool SetCellValueByRowIndex(int rowIndex, string columnName, object cellValue)
        {
            if (rowIndex < this.Rows.Count && this.Columns.Contains(columnName))
            {
                this.Rows[rowIndex].Cells[columnName].Value = cellValue;
                return true;
            }
            return false;
        }
        /// <summary>
        /// 设置指定行和列的单元格的值
        /// </summary>
        public bool SetCellValueByRowIndex(int rowIndex, int columnIndex, object cellValue)
        {
            this.Rows[rowIndex].Cells[columnIndex].Value = cellValue;
            return true;
        }
        /// <summary>
        /// 根据列值的匹配选中行,指定是否多选,isMultiSelect为false则只选中第一个匹配值,指定是否用正则表达式匹配
        /// </summary>
        public bool SelectedRow(string colName, string colValue, bool isMultiSelect, bool isRegexMatch)
        {
            bool r = false;
            bool matchOk;
            for (int i = 0; i < this.Rows.Count; i++)
            {
                matchOk = false;
                object cellValue = this.Rows[i].Cells[colName].Value;
                if (cellValue == null) continue;
                if (cellValue.ToString() == colValue)
                {
                    matchOk = true;
                }
                else if (isRegexMatch)
                {
                    if (RegexHelper.Check(cellValue.ToString(), colValue))
                    {
                        matchOk = true;
                    }
                }
                if (matchOk) r = true;
                if (matchOk)
                {
                    this.Rows[i].Selected = true;
                    if (!isMultiSelect)
                    {
                        break;
                    }
                }
            }
            return r;
        }

        #region 获得指定行的绑定的数据源数据(某行)

        /// <summary>
        /// 获取当前选中行的绑定数据行(非DataGrid行)
        /// </summary>
        /// <typeparam name="T">DataRow或它的子类</typeparam>
        /// <param name="rowIndex">行索引</param>
        /// <returns>返回一个行对象</returns>
        public T GetSelectedRowData<T>(int rowIndex) where T : DataRow
        {
            if (rowIndex < 0) return null;
            DataRowView drv = (DataRowView)this.Rows[rowIndex].DataBoundItem;
            T row = (T)drv.Row;
            return row;
        }
        /// <summary>
        /// 获取当前选中行所绑定的数据源数据
        /// </summary>
        /// <typeparam name="T">DataRow或它的子类</typeparam>
        /// <returns>返回一个DataRow对象</returns>
        public T GetSelectedRowData<T>() where T : DataRow
        {
            if (this.SelectedRows.Count == 0) return null;
            int selIndex = this.SelectedRows[0].Index;
            return GetSelectedRowData<T>(selIndex);
        }
        /// <summary>
        /// 获取当前选中行的绑定数据行(非DataGrid行)
        /// </summary>        
        /// <param name="rowIndex">行索引</param>
        /// <returns>返回一个DataRow</returns>
        public DataRow GetSelectedRowData(int rowIndex)
        {
            return GetSelectedRowData<DataRow>(rowIndex);
        }
        /// <summary>
        /// 获得当前选中行的数据源数据
        /// </summary>
        public DataRow GetSelectedRowData()
        {
            if (this.SelectedRows.Count == 0) return null;
            int selRowIndex = this.SelectedRows[0].Index;
            return GetSelectedRowData(selRowIndex);
        }
        /// <summary>
        /// 返回当前绑定数据源的一行数据的实体类对象
        /// </summary>
        /// <typeparam name="T">实体类对象类型</typeparam>
        /// <param name="rowIndex">行索引</param>
        /// <returns>返回实体类对象</returns>
        public T GetSelectedClassData<T>(int rowIndex) where T : class, new()
        {
            if (rowIndex < 0) return null;
            if (rowIndex >= this.Rows.Count) return null;
            object dataBoundItem = this.Rows[rowIndex].DataBoundItem;
            if (dataBoundItem == null) return null;
            T rowObj = null; // = dataBoundItem as T;
            if (dataBoundItem is T)
            {
                rowObj = dataBoundItem as T;
            }
            else if (this.Rows[rowIndex].DataBoundItem is DataRowView)
            {
                //这个是支持把一个绑定了DataTable数据源的行转换成一个实体类
                DataRowView drv = this.Rows[rowIndex].DataBoundItem as DataRowView;
                rowObj = new T();
                ReflectionHelper.SetPropertyValue(rowObj, drv.Row);
            }
            else
            {
                //支持把相同属性的对象根据行赋值
                rowObj = new T();
                ReflectionHelper.SetPropertyValue(rowObj, dataBoundItem);
            }
            return rowObj;
        }
        public bool GetSelectedClassData<T>(int rowIndex, ref T model)
        {
            if (rowIndex < 0) return false;
            if (rowIndex >= this.Rows.Count) return false;
            object dataBoundItem = this.Rows[rowIndex].DataBoundItem;
            if (dataBoundItem == null) return false;
            if (dataBoundItem is T)
            {
                model = (T)dataBoundItem;
                return true;
            }
            return false;
        }
        public bool GetSelectedClassData<T>(ref T model)
        {
            if (this.SelectedRows.Count == 0) return false;
            int selIndex = this.SelectedRows[0].Index;
            return GetSelectedClassData<T>(selIndex, ref model);
        }
        /// <summary>
        /// 获取当前选中行绑定的数据源
        /// </summary>
        /// <typeparam name="T">绑定数据源的列</typeparam>
        /// <returns></returns>
        public T GetSelectedClassData<T>() where T : class, new()
        {
            if (this.SelectedRows.Count == 0) return null;
            int selIndex = this.SelectedRows[0].Index;
            return GetSelectedClassData<T>(selIndex);
        }

        #endregion

        #region 事件

        [Description("当选中改变并且点击单元格时触发"), Category("_张存的GridView"), Browsable(true)]
        public event DataGridViewCellEventHandler SelectionChangedAndCellClick;
        bool IsSelectChange; //是否选中改变
        void ZCDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsSelectChange)
            {
                LastSelectedRowIndex = e.RowIndex;
                IsSelectChange = false;
                if (SelectionChangedAndCellClick != null)
                {
                    SelectionChangedAndCellClick(sender, e);
                }

            }
        }
        void ZCDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.SelectedRows.Count > 0)
            {
                IsSelectChange = true;
            }
        }

        #endregion
    }
}
