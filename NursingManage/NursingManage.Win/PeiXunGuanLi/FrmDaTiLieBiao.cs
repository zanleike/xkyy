using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;
using Framework.Common.Helpers;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmDaTiLieBiao : BaseEditForm
    {
        public FrmDaTiLieBiao(
                List<V_SHITI_MUBAN_MINGXI> muBanMingXiData,
                T_PEIXUNJIHUA_MINGXI jiHuaMingXiModel,
                EditModelHandle<T_PEIXUNJIHUA_MINGXI> SaveDaTiHandle)
        {
            InitializeComponent();
            this._MuBanMingXiData = muBanMingXiData;
            this._JiHuaMingXiModel = jiHuaMingXiModel;
            this.SaveDaTiHandle = SaveDaTiHandle;
        }

        List<V_SHITI_MUBAN_MINGXI> _MuBanMingXiData;
        T_PEIXUNJIHUA_MINGXI _JiHuaMingXiModel;
        EditModelHandle<T_PEIXUNJIHUA_MINGXI> SaveDaTiHandle;

        private void FrmDaTiLieBiao_Load(object sender, EventArgs e)
        {
            if (_MuBanMingXiData == null || _MuBanMingXiData.Count == 0)
            {
                MessageBox.Show("试题数为空。");
                this.Close();
                return;
            }
            col_NEIRONG.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv.ReadOnly = false;
            for (int i = 1; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].ReadOnly = true;
            }
            dgv.DataSource = _MuBanMingXiData;
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count == 0)
            {
                //dgv.Rows[0].Selected = true;
                dgv.Rows[0].Cells[0].Selected = true;
            }
            int rowIndex = dgv.SelectedCells[0].RowIndex;
            var selModel =dgv.GetSelectedClassData<V_SHITI_MUBAN_MINGXI>(rowIndex);
            FrmDaTi frm = new FrmDaTi(
                selModel,
                () =>
                {
                    //下一题;
                    var nextIndex = dgv.CurrentRow.Index + 1;
                    if (nextIndex >= dgv.Rows.Count) nextIndex = 0;
                    dgv.Rows[nextIndex].Cells[0].Selected = true;
                    var selectedRow = dgv.GetSelectedClassData<V_SHITI_MUBAN_MINGXI>(nextIndex);
                    return selectedRow;
                }, () =>
                {
                    //上一题;
                    var prevIndex = dgv.CurrentRow.Index - 1;
                    if (prevIndex < 0) prevIndex = dgv.Rows.Count - 1;
                    dgv.Rows[prevIndex].Cells[0].Selected = true;
                    var selectedRow = dgv.GetSelectedClassData<V_SHITI_MUBAN_MINGXI>(prevIndex);
                    return selectedRow;
                }, (shiTimXiMu) =>
                {

                });
            frm.ShowDialog();
        }



        private void tsBtnEditor_Click(object sender, EventArgs e)
        {
            if (!ShowQuestion("确实要提交答卷吗？提交后不可修改", "提交答卷确认"))
            {
                return;
            }
            dgv.EndEdit();
            StringBuilder daTi = new StringBuilder();
            int zqs = 0;
            decimal fenShu = 0;
            foreach (var item in _MuBanMingXiData)
            {
                if (item.DaTi == null) item.DaTi = string.Empty;
                daTi.AppendFormat("{0},", item.DaTi.Trim());
                if (StringHelper.StringEquals(item.DaTi, item.DAAN))
                {
                    zqs++;
                    fenShu += item.FENSHU;
                }
            }
            daTi.Remove(daTi.Length - 1, 1);

            _JiHuaMingXiModel.ClearChangedState();
            _JiHuaMingXiModel.SHITISHU = _MuBanMingXiData.Count;
            _JiHuaMingXiModel.ZHENGQUESHU = zqs;
            _JiHuaMingXiModel.FENSHU = fenShu;
            _JiHuaMingXiModel.DATI = daTi.ToString();
            string errMsg;
            if (SaveDaTiHandle(_JiHuaMingXiModel, out errMsg))
            {
                ShowMessage("提交答题完成。");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }
    }
}