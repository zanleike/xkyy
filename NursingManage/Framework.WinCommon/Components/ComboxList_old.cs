//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.ComponentModel;
//using System.Windows.Forms;
////using ZhCun.Framework.WinCommon.Forms;
//using System.Data;
//using ZhCun.Framework.WinCommon.Controls;

//namespace ZhCun.Framework.WinCommon.Components
//{
    

//    /// <summary>
//    /// CoboxList选中行后触发事件的委托类型
//    /// </summary>
//    /// <param name="tb">所触发的文本框</param>
//    /// <param name="dr">当前选中的行数据</param>
//    public delegate void ComboxListSelectRowDeleate(TextBox tb, DataRow dr);

//    [ProvideProperty("Columns", typeof(TextBox))]
//    [ProvideProperty("ReturnColumn", typeof(TextBox))]
//    [ProvideProperty("ReturnTagColumn", typeof(TextBox))]
//    [ProvideProperty("GridViewWidth", typeof(TextBox))]
//    [ProvideProperty("DisplayRowCount", typeof(TextBox))]
//    [ProvideProperty("NextControl", typeof(TextBox))]
//    [ProvideProperty("IsUse", typeof(TextBox))]
//    public class ComboxList_old : Component, IExtenderProvider
//    {
//        public bool CanExtend(object extendee)
//        {
//            return extendee is TextBox;
//        }
//        #region 系统生成

//        /// <summary>
//        /// 必需的设计器变量。
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary> 
//        /// 清理所有正在使用的资源。
//        /// </summary>
//        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//        /// <summary>
//        /// 设计器支持所需的方法 - 不要
//        /// 使用代码编辑器修改此方法的内容。
//        /// </summary>
//        private void InitializeComponent()
//        {
//            components = new System.ComponentModel.Container();
//        }

//        #endregion

//        #region 构造方法
        
//        public ComboxList_old(IContainer container)
//        {
//            container.Add(this);
//            InitializeComponent();
//            _ComBoxDict = new Dictionary<TextBox, ComBoxModel>();
//        }

//        #endregion

//        /// <summary>
//        /// 所有文本框的验证信息字典
//        /// </summary>
//        private Dictionary<TextBox, ComBoxModel> _ComBoxDict;
//        /// <summary>
//        /// 根据TextBox控件,得到Combox字典中的实体类,如果不存在则往字典里增加一条记录
//        /// </summary>
//        private ComBoxModel GetComBoxDict(TextBox tb)
//        {
//            if (_ComBoxDict == null)
//            {
//                _ComBoxDict = new Dictionary<TextBox, ComBoxModel>();
//            }
//            if (_ComBoxDict.ContainsKey(tb))
//            {
//                return _ComBoxDict[tb];
//            }
//            else
//            {
//                ComBoxModel cbModel = new ComBoxModel();
//                cbModel.Columns = new ComBoxListColumn[] { }; // new List<ComBoxListColumn>();
//                //cbModel.ReturnColumn = string.Empty;
//                cbModel.DataSource = null;
//                cbModel.NextControl = tb;
//                _ComBoxDict.Add(tb, cbModel);
//                RegisterTextBoxEvent(tb);
//                return cbModel;
//            }
//        }        
//        /// <summary>
//        /// 注册文本框的事件
//        /// </summary>
//        private void RegisterTextBoxEvent(TextBox txtBox)
//        {
//            txtBox.KeyDown += new KeyEventHandler(txtBox_KeyDown);
//            txtBox.Leave += new EventHandler(txtBox_Leave);
//            txtBox.Enter += new EventHandler(txtBox_Enter);
//            txtBox.KeyUp += new KeyEventHandler(txtBox_KeyUp);
//            //txtBox.TextChanged += new EventHandler(txtBox_TextChanged);
//            //txtBox.KeyPress += new KeyPressEventHandler(txtBox_KeyPress);
//        }
//        //BUG:当清空文本框时,tag属性没有清空
//        ////文本改变时,将tag属性清空
//        //void txtBox_TextChanged(object sender, EventArgs e)
//        //{
//        //    TextBox tb = (TextBox)sender;
//        //    tb.Tag = null;
//        //}

//        //获得焦点是触发
//        void txtBox_Enter(object sender, EventArgs e)
//        {
//            if (_LastGridViewByTextbox != (TextBox)sender && _ZCGridView != null)
//            {
//                _ZCGridView.Visible = false;
//            }
//            if (_ZCGridView != null) _ZCGridView.Tag = sender;
//        }

//        //键盘弹起触发,开始生成列
//        void txtBox_KeyUp(object sender, KeyEventArgs e)
//        {
//            if (e.KeyCode == Keys.Enter)
//            {
//                TextBox tb = (TextBox)sender;
//                if (_ComBoxDict.ContainsKey(tb))
//                {
//                    //如果_ZCGridView为null则生成GridView.
//                    GenerateGridView(tb);
//                    //生成GridView列,如果tb是上次的控件则不再创建
//                    GenerateGridViewColumns(tb);
//                    if (_ZCGridView != null) _ZCGridView.Tag = sender;
//                    //绑定GridView数据源,并设置宽度高度和位置显示
//                    ShowGridView(tb);
//                }
//            }
//        }

//        //文本框离开焦点隐藏GridView
//        void txtBox_Leave(object sender, EventArgs e)
//        {
//            if (_ZCGridView != null && _ZCGridView.Focused == false)
//            {
//                _ZCGridView.Visible = false;
//            }
//        }

//        // 文本框的点击方法,此事件只操作跟GridView相关的
//        void txtBox_KeyDown(object sender, KeyEventArgs e)
//        {
//            if (_ZCGridView == null || _ZCGridView.Visible == false || _ZCGridView.Rows.Count == 0) return;
//            if (e.KeyCode == Keys.Enter)
//            {
//                //ExecSelectedRowHandle((TextBox)sender);
//            }
//            else if (e.KeyCode == Keys.Down)
//            {
//                if (_ZCGridView.SelectedRows.Count > 0)
//                {
//                    int selIndex = _ZCGridView.SelectedRows[0].Index;
//                    if (selIndex < _ZCGridView.Rows.Count - 1)
//                        _ZCGridView.Rows[selIndex + 1].Selected = true;
//                }
//                else
//                {
//                    _ZCGridView.Rows[0].Selected = true;
//                }
//                _ZCGridView.Focus();
//            }
//            else if (e.KeyCode == Keys.Up)
//            {
//                if (_ZCGridView.SelectedRows.Count > 0)
//                {
//                    int selIndex = _ZCGridView.SelectedRows[0].Index;
//                    if (selIndex == 0) _ZCGridView.Rows[0].Selected = true;
//                    else _ZCGridView.Rows[selIndex - 1].Selected = true;
//                }
//                else
//                {
//                    _ZCGridView.Rows[0].Selected = true;
//                }
//                _ZCGridView.Focus();
//            }
//            else if (e.KeyCode == Keys.Escape)
//            {
//                if (_ZCGridView != null)
//                    _ZCGridView.Visible = false;
//            }
//        }

//        /// <summary>
//        /// 按回车选择行之后的事件
//        /// </summary>
//        public event ComboxListSelectRowDeleate SelectedRowHandle;

//        /// <summary>
//        /// 执行算中行的操作,多个事件公用
//        /// </summary>
//        void ExecSelectedRowHandle(TextBox tb)
//        {
//            //选中项回车返回
//            if (_ZCGridView.SelectedRows.Count > 0)
//            {
//                DataTable dt = _ComBoxDict[tb].DataSource;
//                if (dt == null) return;
//                int selIndex = _ZCGridView.SelectedRows[0].Index;
//                if (_ComBoxDict[tb].ReturnColumn!=null && dt.Columns.Contains(_ComBoxDict[tb].ReturnColumn))
//                    tb.Text = dt.Rows[selIndex][_ComBoxDict[tb].ReturnColumn].ToString();
//                if (_ComBoxDict[tb].ReturnTagColumn!=null && dt.Columns.Contains(_ComBoxDict[tb].ReturnTagColumn))
//                    tb.Tag = dt.Rows[selIndex][_ComBoxDict[tb].ReturnTagColumn];
//                if (SelectedRowHandle != null)
//                {
//                    SelectedRowHandle(tb, dt.Rows[selIndex]);
//                }
//                _ZCGridView.Visible = false;
//                if (_ComBoxDict[tb].NextControl != tb)
//                {
//                    _ComBoxDict[tb].NextControl.Focus();
//                    if (_ComBoxDict[tb].NextControl is TextBox)
//                    {
//                        //如果下一个控件是文本框的话选中所有文本
//                        ((TextBox)_ComBoxDict[tb].NextControl).SelectAll();
//                    }
//                }
//                else
//                {
//                    //tb.Focus();
//                    //tb.SelectionStart = tb.TextLength;
//                }
//                //_GridViewDataSource = null;
//            }
//        }

//        /// <summary>
//        /// 当前控件使用的GridView
//        /// </summary>
//        ZCDataGridView _ZCGridView;

//        /// <summary>
//        /// 生成GridView并生成列信息.
//        /// </summary>
//        void GenerateGridView(TextBox tb)
//        {
//            if (_ZCGridView == null)
//            {
//                _ZCGridView = new ZCDataGridView();
//                _ZCGridView.AutoGenerateColumns = false;
//                Form frm = tb.FindForm();
//                frm.Controls.Add(_ZCGridView);
//                _ZCGridView.Visible = false;
//                _ZCGridView.BringToFront();
//                _ZCGridView.KeyDown += new KeyEventHandler(delegate(object sender, KeyEventArgs e)
//                    {
//                        TextBox cTxtBox = ((ZCDataGridView)sender).Tag as TextBox;
//                        if (e.KeyCode == Keys.Enter)
//                        {
//                            ExecSelectedRowHandle(cTxtBox);
//                        }
//                        else if (e.KeyCode == Keys.Escape)
//                        {
//                            _ZCGridView.Visible = false;
//                            tb.Focus();
//                        }
//                        else if (
//                            e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left
//                         && e.KeyCode != Keys.Right
//                                    )
//                        {
//                            cTxtBox.Focus();
//                            //if (_ZCGridView.SelectedRows.Count > 0)
//                            //{
//                            //    //int selIndex = _ZCGridView.SelectedRows[0].Index;

//                            //}
//                            //SendKeys.Send(e.KeyCode.ToString());
//                        }
//                    });
//                _ZCGridView.MouseLeave += new EventHandler(delegate(object sender, EventArgs e)
//                    {
//                        TextBox cTxtBox = ((ZCDataGridView)sender).Tag as TextBox;
//                        if (_ZCGridView.Visible == true) cTxtBox.Focus();
//                    });

//                _ZCGridView.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(delegate(object sender, DataGridViewCellMouseEventArgs e)
//                    {
//                        TextBox cTxtBox = ((ZCDataGridView)sender).Tag as TextBox;
//                        ExecSelectedRowHandle(cTxtBox);
//                    });
//            }
//        }
//        /// <summary>
//        /// 最后一次绑定GridView的的文本框,此变量用来判断是否再次创建列
//        /// </summary>
//        TextBox _LastGridViewByTextbox = null;

        
//        //DataTable _GridViewDataSource;
//        ///// <summary>
//        ///// 数据源
//        ///// </summary>
//        //public DataTable GridViewDataSource
//        //{
//        //    get { return _GridViewDataSource; }
//        //    set { _GridViewDataSource = value; }
//        //}

        

//        /// <summary>
//        /// 生成GridView列的方法
//        /// </summary>
//        void GenerateGridViewColumns(TextBox tb)
//        {
//            //if (tb == _LastGridViewByTextbox) return; 去掉这行解决了一个重复选择不显示的bug
//            if (_ComBoxDict.ContainsKey(tb))
//            {
//                _ZCGridView.Columns.Clear();
//                ComBoxListColumn[] columnList = _ComBoxDict[tb].Columns;
//                if (columnList == null || columnList.Length == 0) return;
//                _ZCGridView.Columns.Clear();
//                for (int i = 0; i < columnList.Length; i++)
//                {
//                    DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
//                    dgvCol.HeaderText = columnList[i].FieldCaption;
//                    dgvCol.DataPropertyName = columnList[i].FieldName;
//                    if (!columnList[i].IsVisible)
//                    {
//                        //_ZCGridView.Columns[i].Visible = false;
//                        dgvCol.Visible=false;
//                    }
//                    _ZCGridView.AddColumn(dgvCol);
                    
//                }
//            }
//            _LastGridViewByTextbox = tb;
//        }
//        /// <summary>
//        /// 设置GridView的宽和高并显示和数据源,如果数据源为null则return
//        /// </summary>
//        void ShowGridView(TextBox tb)
//        {
//            if (!_ComBoxDict[tb].IsUse) return;
//            if (_ComBoxDict[tb].DataSource == null) return;            
//            _ZCGridView.DataSource = _ComBoxDict[tb].DataSource;

//            //if (_GridViewDataSource == null) return;
//            //_ZCGridView.DataSource = _GridViewDataSource;

//            if (_ZCGridView.Rows.Count < 1) return;
//            _ZCGridView.Visible = true;
//            _ZCGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
//            _ZCGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
//            _ZCGridView.RowHeadersVisible = false;
//            _ZCGridView.DisplayRowCount = false;
//            if (_ComBoxDict[tb].DataSource.Rows.Count == 1)
//            {
//                ExecSelectedRowHandle(tb);
//                return;
//            }
//            _ZCGridView.Top = tb.Top + tb.Height;
//            _ZCGridView.Left = tb.Left;

//            int newWidth = 0;
//            for (int i = 0; i < _ZCGridView.Columns.Count; i++)
//            {
//                if (_ZCGridView.Columns[i].Visible)
//                    newWidth = newWidth + _ZCGridView.Columns[i].Width + 1;
//            }

//            int showRowCount = 5;//最多显示行的数量
//            if (showRowCount > _ZCGridView.Rows.Count) showRowCount = _ZCGridView.Rows.Count;
//            if (_ZCGridView.Rows.Count > showRowCount)
//            {
//                _ZCGridView.Width = newWidth + 20; //加上进度条的宽    
//            }
//            else
//            {
//                _ZCGridView.Width = newWidth;
//            }

//            int headerHeight = _ZCGridView.Rows[0].Height + 1; //列标题的高
//            _ZCGridView.Height = headerHeight * showRowCount + _ZCGridView.ColumnHeadersHeight;
//            if (_ZCGridView.Width < tb.Width)
//            {
//                _ZCGridView.Width = tb.Width;
//                _ZCGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//            }
//            _ZCGridView.Rows[0].Selected = false;
//        }
//        /// <summary>
//        /// 设置指定文本框的数据源
//        /// </summary>
//        /// <param name="tb">文本框控件</param>
//        /// <param name="dt">数据源</param>
//        public void SetDataSource(TextBox tb, DataTable dt)
//        {   
//            if (_ComBoxDict.ContainsKey(tb))
//            {
//                //if (_ZCGridView != null)
//                //    _ZCGridView.DataSource = dt;
//                _ComBoxDict[tb].DataSource = dt;
//            }
//            //_GridViewDataSource = dt;
//        }

//        [Category("自定义选择框扩展属性")]
//        [Description("获取或设置列信息")]
//        public ComBoxListColumn[] GetColumns(TextBox t)
//        {
//            ComBoxModel cbModel = GetComBoxDict(t);
//            return cbModel.Columns;
//        }
//        public void SetColumns(TextBox t, ComBoxListColumn[] list)
//        {
//            ComBoxModel cbModel = GetComBoxDict(t);

//            for (int i = 0; i < list.Length; i++)
//            {
//                if (list[i].IsReturnText)
//                {
//                    cbModel.ReturnColumn = list[i].FieldName;
//                }
//                if (list[i].IsReturnTag)
//                {
//                    cbModel.ReturnTagColumn = list[i].FieldName;
//                }
//            }
//            cbModel.Columns = list;
//        }

//        [Category("自定义选择框扩展属性")]
//        [Description("获取或设置返回列的字段名")]
//        public string GetReturnColumn(TextBox t)
//        {
//            ComBoxModel cbModel = GetComBoxDict(t);
//            return cbModel.ReturnColumn;
//        }

//        [Category("自定义选择框扩展属性")]
//        [Description("获取或设置返回列的字段名")]
//        public string GetReturnTagColumn(TextBox t)
//        {
//            ComBoxModel cbModel = GetComBoxDict(t);
//            return cbModel.ReturnTagColumn;
//        }

//        [Category("自定义选择框扩展属性")]
//        [Description("获取或设置该数据源的GridView宽")]
//        public int GetGridViewWidth(TextBox t)
//        {
//            ComBoxModel cbModel = GetComBoxDict(t);
//            return cbModel.GridViewWidth;
//        }
//        public void SetGridViewWidth(TextBox t, int s)
//        {
//            ComBoxModel cbModel = GetComBoxDict(t);
//            cbModel.GridViewWidth = s;
//        }

//        [Category("自定义选择框扩展属性")]
//        [Description("获取或设置GridView要显示的行数")]
//        public int GetDisplayRowCount(TextBox t)
//        {
//            ComBoxModel cbModel = GetComBoxDict(t);
//            return cbModel.DisplayRowCount;
//        }
//        public void SetDisplayRowCount(TextBox t, int s)
//        {
//            ComBoxModel cbModel = GetComBoxDict(t);
//            cbModel.DisplayRowCount = s;
//        }

//        [Category("自定义选择框扩展属性")]
//        [Description("获取或设置选中后的跳转的控件")]
//        public Control GetNextControl(TextBox t)
//        {
//            ComBoxModel cbModel = GetComBoxDict(t);
//            return cbModel.NextControl;
//        }
//        public void SetNextControl(TextBox t, Control s)
//        {
//            ComBoxModel cbModel = GetComBoxDict(t);
//            cbModel.NextControl = s;
//        }

//        [Category("自定义选择框扩展属性")]
//        [Description("获取或设置是否启用ComboxList扩展组件")]
//        public bool GetIsUse(TextBox t)
//        {
//            ComBoxModel cbModel = GetComBoxDict(t);
//            return cbModel.IsUse;
//        }
//        public void SetIsUse(TextBox t, bool s)
//        {
//            ComBoxModel cbModel = GetComBoxDict(t);
//            cbModel.IsUse = s;
//        }
//    }
//}
