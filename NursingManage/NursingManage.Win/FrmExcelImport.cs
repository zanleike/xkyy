using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Framework.Common.Helpers;
using Framework.Common;

namespace NursingManage.Win
{
    public partial class FrmExcelImport : BaseEditForm
    {
        public FrmExcelImport(EditModelHandle<DataRow> AddHandle)
        {
            InitializeComponent();
            this.AddHandle = AddHandle;
        }

        EditModelHandle<DataRow> AddHandle;
        DataSet _DataSource;

        //private EditModelHandle<DataRow> editModelHandle;

        private void FrmExcelImport_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = true;
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel文件|*.xls;*.xlsx";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _DataSource = ExcelHelperNPOL.GetDataTable(ofd.FileName);
                tsCoboxTableList.Items.Clear();
                if (_DataSource == null || _DataSource.Tables.Count == 0)
                {
                    MessageBox.Show("该Excel文件中不包含任何工作表。");
                    this.Close();
                    return;
                }
                foreach (DataTable item in _DataSource.Tables)
                {
                    item.Columns.Add("导入结果",typeof(string));
                    tsCoboxTableList.Items.Add(item.TableName);
                }
                tsCoboxTableList.SelectedIndex = 0;
                dgv.DataSource = _DataSource.Tables[0];
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                ShowMessage("未选中任何行");
                return;
            }
            dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                try
                {
                    dgv.Rows[i].Selected = true;
                    DataRow dr = dgv.GetSelectedRowData(i);
                    DataGridViewCell dgvc = dgv.Rows[i].Cells[col_Result.Name];
                    string errMsg;
                    if (AddHandle(dr, out errMsg))
                    {
                        dgvc.Value = "导入成功";
                    }
                    else
                    {
                        dgvc.Value = errMsg;
                        dgvc.Style.BackColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    dgv.Rows[i].Cells[0].Value = "程序异常，" + ex.Message;
                    LogHelper.LogObj.Error("导入数据发生异常", ex);
                }
            }
        }

        private void tsCoboxTableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.DataSource = _DataSource.Tables[tsCoboxTableList.SelectedIndex];
        }
    }
}