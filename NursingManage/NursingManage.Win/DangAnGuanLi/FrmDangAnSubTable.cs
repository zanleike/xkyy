using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;
using HursingManage.AL.DangAnGuanLi;

namespace NursingManage.Win.DangAnGuanLi
{
    public partial class FrmDangAnSubTable : BaseEditForm
    {
        public FrmDangAnSubTable(T_DANGAN dangAnModel, ExGroupInfo exGroupInfo)
        {
            InitializeComponent();
            this._DangAnModel = dangAnModel;
            this._ExGroupInfo = exGroupInfo;
        }

        ExGroupInfo _ExGroupInfo;
        ALDangAnExConfig _AL;
        T_DANGAN _DangAnModel;
        EditFormConfig _PeiZhiModel;
        List<InputEditConfig> _TableConfig;

        void BindDataSource()
        {
            var dt = _AL.GetSubTableData(_DangAnModel, _ExGroupInfo.GroupName);
            dgv.DataSource = dt;
        }

        private void FrmDangAnSubTable_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("姓名：{0}，扩展项：{1}", _DangAnModel.XINGMING, _ExGroupInfo.GroupCaption);

            _AL = new ALDangAnExConfig();

            this.toolStripStatusLabel1.Text = _AL.GetRemark(_ExGroupInfo.GroupName);    //备注写到窗口下面
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
            //_AL = new ALDangAnExConfig();
            this._TableConfig = _AL.GetExColumns(_ExGroupInfo.GroupName);
            this._PeiZhiModel = _AL.GetPeiZhiParam();
            foreach (var item in _TableConfig)
            {
                DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
                dgvCol.HeaderText = item.FieldCaption;
                dgvCol.DataPropertyName = item.FieldName;

                dgv.Columns.Add(dgvCol);
            }
            BindDataSource();
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            T_DANGAN_TABLE model = new T_DANGAN_TABLE();
            model.DANGANID = _DangAnModel.ID;
            model.GROUPNAME = _ExGroupInfo.GroupName;
            FrmDangAnSubTableEdit frm = new FrmDangAnSubTableEdit(
                _PeiZhiModel, _TableConfig, model, _AL.AddSubTable);
            frm.Text = string.Format("姓名：{0}，扩展项：{1}，新增", _DangAnModel.XINGMING, _ExGroupInfo.GroupCaption);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("新增完成。");
                BindDataSource();
            }
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            var model = dgv.GetSelectedClassData<T_DANGAN_TABLE>();
            if (model == null)
            {
                ShowMessage("未选中任何记录。");
                return;
            }
            FrmDangAnSubTableEdit frm = new FrmDangAnSubTableEdit(
                _PeiZhiModel, _TableConfig, model, _AL.UpdateSubTable);
            frm.Text = string.Format("姓名：{0}，扩展项：{1}，修改", _DangAnModel.XINGMING, _ExGroupInfo.GroupCaption);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改完成。");
                BindDataSource();
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            var model = dgv.GetSelectedClassData<T_DANGAN_TABLE>();
            if (model == null)
            {
                ShowMessage("未选中任何记录。");
                return;
            }
            if (ShowQuestion("确实要删除当前选中记录吗？", "删除确认"))
            {
                string errMsg;
                if (_AL.DeleteSubTable(model, out errMsg))
                {
                    ShowMessage("删除成功。");
                    BindDataSource();
                }
                else
                {
                    ShowMessage(errMsg);
                }
            }
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            BindDataSource();
        }
    }
}
