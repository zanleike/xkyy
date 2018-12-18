using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.WinCommon.AdvanceSearch
{
    internal delegate bool SaveSearchRecordHandle(ISearchRecord record, List<ISearchRecord_Detail> recordDetails, out string errMsg);

    public partial class FrmSearchSave : Form
    {
        public FrmSearchSave()
        {
            InitializeComponent();
        }
        internal FrmSearchSave(ISearchConfig config, ISearchRecord record)
            : this()
        {
            this._Config = config;
            this._Record = record;
        }
        internal FrmSearchSave(ISearchConfig config, List<ISearchRecord_Detail> recordDetails)
            : this()
        {
            this._Config = config;
            this.RecordDetails = recordDetails;
        }

        ISearchConfig _Config;
        ISearchRecord _Record;
        List<ISearchRecord_Detail> RecordDetails;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string err;
            //ISearchRecord record = null;
            bool saveResult;
            if (_Record == null)
            {
                _Record = new ISearchRecord();
                _Record.RecordRemark = txtSearchName.Text;
                _Record.RecordRemark_PY = txtSearchNamePY.Text;
                saveResult = _Config.SaveSearchRecord(_Record, RecordDetails, out err);
            }
            else
            {
                saveResult = _Config.UpdateRecord(_Record, out err);
            }
            if (saveResult)
            {
                MessageBox.Show("保存成功.");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("保存失败\r\n" + err);
            }
        }

        private void FrmSearchSaveEdit_Load(object sender, EventArgs e)
        {
            if (_Record == null)
            {
                if (RecordDetails == null || RecordDetails.Count == 0)
                {
                    MessageBox.Show("要保存的搜索明细为空");
                    this.Close();
                    return;
                }
                this.Text += " 保存记录";
            }
            else
            {
                this.Text += " 修改名称";
            }
        }
    }
}