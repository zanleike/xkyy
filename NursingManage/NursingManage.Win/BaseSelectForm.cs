using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;
using Framework.Common.CommonFunction;
using Framework.Common.Helpers;
using Framework.WinCommon.Controls;
using Framework.Entitys;

namespace NursingManage.Win
{
    delegate void OnSelectedHandle<TModel>(List<TModel> datas) where TModel : class ,new();

    public partial class BaseSelectForm<TModel> : BaseEditForm where TModel : class ,new()
    {
        public BaseSelectForm(DataTable dataSource, bool isSingle = false)
        {
            InitializeComponent();
            this._DataSource = dataSource;
            this._SingleSelection = isSingle;
        }
        //已选中的个数
        int _SelectedCount = 0;
        bool _SingleSelection;
        public event Action<List<TModel>> OnSelectedHandle;
        //列名与数据源名
        protected string SelectColumnName = "IsSelected";
        protected DataTable _DataSource;
        protected virtual void SelectedHandle<TModel>(List<TModel> datas) where TModel : class ,new()
        {

        }
        protected virtual Dictionary<string, string> GetGridViewColumnInfo()
        {
            Dictionary<string, string> columnDict = new Dictionary<string, string>();
            columnDict.Add("未配置列", "未配置列");
            return columnDict;
        }
        protected virtual void SearchDataView(DataView dv, string serValue)
        {
            dv.RowFilter = string.Format("USER_NO like '%{0}%' or USER_NAME_PY like '%{0}%' or USER_NAME like '%{0}%'", serValue);
        }
        protected virtual void InitDataGridView(ZCDataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.ReadOnly = false;
            DataGridViewCheckBoxColumn firstCol = new DataGridViewCheckBoxColumn();
            firstCol.Name = SelectColumnName;
            firstCol.DataPropertyName = SelectColumnName;
            firstCol.HeaderText = "选择";
            firstCol.ReadOnly = false;
            firstCol.IndeterminateValue = false;
            firstCol.FalseValue = false;
            firstCol.TrueValue = true;
            dgv.Columns.Add(firstCol);
            var columnInfo = GetGridViewColumnInfo();
            foreach (string item in columnInfo.Keys)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.DataPropertyName = item;
                col.HeaderText = columnInfo[item];
                col.ReadOnly = true;
                dgv.Columns.Add(col);
            }
            _DataSource.Columns.Add(SelectColumnName, typeof(bool));
            dgv.DataSource = _DataSource;
        }
        private void BaseSelectForm_Load(object sender, EventArgs e)
        {
            if (_DataSource == null || _DataSource.Rows.Count == 0)
            {
                MessageBox.Show("当前可添加记录为空.");
                this.Close();
                return;
            }
            if (_SingleSelection) tsbtnAllSelected.Visible = false;
            InitDataGridView(dgv);
        }
        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            string serValue = tsTxtSearchValue.Text;
            DataView dv = new DataView(_DataSource);
            if (!string.IsNullOrWhiteSpace(serValue))
            {
                SearchDataView(dv, serValue);
                //dv.RowFilter = string.Format("USER_NO like '%{0}%' or USER_NAME_PY like '%{0}%' or USER_NAME like '%{0}%'", serValue);
            }
            dgv.DataSource = dv;
        }
        private void tsBtnSelected_Click(object sender, EventArgs e)
        {
            dgv.EndEdit();
            List<TModel> users = new List<TModel>();
            foreach (DataRow item in _DataSource.Rows)
            {
                bool isSelected = Utils.ConvertType<bool>(item[SelectColumnName]);
                if (isSelected)
                {
                    TModel u = new TModel();
                    ReflectionHelper.SetPropertyValue(u, item);
                    users.Add(u);
                }
            }
            if (users.Count == 0)
            {
                ShowMessage("没有选中任何记录.");
                return;
            }
            //if (_SingleSelection && users.Count > 1)  ming
            //{
            //    ShowMessage("只能选中一条记录.");
            //    return;
            //}
            if (OnSelectedHandle != null)
            {
                OnSelectedHandle(users);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage("未绑定选择事件.");
            }
        }
        private void dgv_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isSelected = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !isSelected;
        }
        private void tsbtnAllSelected_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells[SelectColumnName].Value = true;
            }
            dgv.EndEdit();
            //foreach (DataRow item in _DataSource.Rows)
            //{
            //    item[SelectColumnName] = true;
            //}
        }
        private void tsbtnUnAllSelected_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells[SelectColumnName].Value = false;
            }
            dgv.EndEdit();
            //foreach (DataRow item in _DataSource.Rows)
            //{
            //    item[SelectColumnName] = false;
            //}
        }
        private void tsTxtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsBtnSearch_Click(sender, e);
            }
        }
        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var selectedValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                bool r = Utils.ConvertType<bool>(selectedValue);
                _SelectedCount += r ? 1 : -1;
                lbSelectedCount.Text = _SelectedCount.ToString();
            }
        }
        private void BaseSelectForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (dgv.Rows.Count > 0 && dgv.SelectedCells.Count > 0)
                {
                    int rowIndex = dgv.SelectedCells[0].RowIndex;
                    object selectedValue = dgv.Rows[rowIndex].Cells[0].Value;
                    bool isSelected = Utils.ConvertType<bool>(selectedValue);
                    dgv.Rows[rowIndex].Cells[0].Value = !isSelected;
                }
            }
        }
        private void BaseSelectForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}