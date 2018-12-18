using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.WinCommon.AdvanceSearch
{
    public partial class FrmSearchList : Form
    {
        public FrmSearchList()
        {
            InitializeComponent();
        }
        internal FrmSearchList(Action<ISearchRecord> SelectedHandle, ISearchConfig config)
            : this()
        {
            this.OnSelectedHandle = SelectedHandle;
            this._Config = config;
        }

        ISearchConfig _Config;
        Action<ISearchRecord> OnSelectedHandle;
        void BindDataSource()
        {
            dgv.DataSource = _Config.GetRecordList();
        }

        private void FrmSearchList_Load(object sender, EventArgs e)
        {
            BindDataSource();
        }
        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsBtnSelected_Click(object sender, EventArgs e)
        {
            if (OnSelectedHandle != null)
            {
                var record = dgv.GetSelectedClassData<ISearchRecord>();
                OnSelectedHandle(record);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("未绑定选中方法.");
            }
        }
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            var record = dgv.GetSelectedClassData<ISearchRecord>();
            if (record == null)
            {
                MessageBox.Show("未选中任何记录.");
                return;
            }
            if (MessageBox.Show("确实要删除当前选中记录吗?", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            
            string err;
            if (!_Config.DeleteRecord(record, out err))
            {
                MessageBox.Show("删除失败\r\n" + err);
            }
            else
            {
                BindDataSource();
                MessageBox.Show("删除成功.");
            }
        }
        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            var record = dgv.GetSelectedClassData<ISearchRecord>();
            if (record == null)
            {
                MessageBox.Show("未选中任何记录.");
                return;
            }
            FrmSearchSave frm = new FrmSearchSave(_Config, record);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindDataSource();
            }
        }
    }
}