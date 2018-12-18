using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;
using Framework.WinCommon.Controls;
using Framework.Common.Helpers;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmShiTiPingFenLuRu : BaseEditForm
    {
        //public FrmShiTiPingFenLuRu(DataTable muBanMingXiData)
        public FrmShiTiPingFenLuRu(EditModelHandle<T_PEIXUNJIHUA_MINGXI> SavePingFenHandle, List<V_SHITI_MUBAN_MINGXI> muBanMingXiData, V_PEIXUNJIHUA_MINGXI jiHuaXiMu)
        {
            InitializeComponent();
            this._MuBanMingXiData = muBanMingXiData;
            this._JiHuaXiMu = jiHuaXiMu;
            this.SavePingFenHandle = SavePingFenHandle;
        }

        List<V_SHITI_MUBAN_MINGXI> _MuBanMingXiData;
        V_PEIXUNJIHUA_MINGXI _JiHuaXiMu;
        EditModelHandle<T_PEIXUNJIHUA_MINGXI> SavePingFenHandle;

        /// <summary>
        /// 答案赋值
        /// </summary>
        void DaAnFuZhi(string daAn)
        {
            if (!string.IsNullOrWhiteSpace(daAn))
            {
                string[] daTiList = daAn.Split(',');
                for (int i = 0; i < _MuBanMingXiData.Count; i++)
                {
                    if (daTiList.Length > i)
                    {
                        _MuBanMingXiData[i].DaTi = daTiList[i].Trim().ToUpper();
                        _MuBanMingXiData[i].ShiFouZhengQue = StringHelper.StringEquals(_MuBanMingXiData[i].DaTi, _MuBanMingXiData[i].DAAN);
                    }
                }
            }
        }

        protected virtual void InitDataGridView(ZCDataGridView dgv)
        {
            dgv.ReadOnly = false;
            col_ShiFouZhengQue.ReadOnly = false;
            col_ShiFouZhengQue.IndeterminateValue = false;
            col_ShiFouZhengQue.FalseValue = false;
            col_ShiFouZhengQue.TrueValue = true;
            for (int i = 2; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].ReadOnly = true;
            }
            dgv.DataSource = _MuBanMingXiData;
            DaAnFuZhi(_JiHuaXiMu.DATI);
        }
        private void FrmShiTiPingFenLuRu_Load(object sender, EventArgs e)
        {
            col_NEIRONG.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            InitDataGridView(dgv);
        }
        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tsTxtSearchValue.Text))
            {
                decimal xuhao;
                decimal.TryParse(tsTxtSearchValue.Text, out xuhao);
                dgv.DataSource = _MuBanMingXiData.FindAll(s => s.SHITIXUHAO == xuhao);
            }
            else
            {
                dgv.DataSource = _MuBanMingXiData;
            }

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
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == col_ShiFouZhengQue.Index)
            {
                bool jieGuo = dgv.GetCellValueByRowIndex<bool>(e.RowIndex, col_ShiFouZhengQue.Name);
                if (jieGuo)
                {
                    string daAn = dgv.GetCellValueByRowIndex<string>(e.RowIndex, col_DaAn.Name);
                    dgv.SetCellValueByRowIndex(e.RowIndex, col_DaTi.Index, daAn);
                }
            }
            else if (e.ColumnIndex == col_DaTi.Index)
            {
                string daTi = dgv.GetCellValueByRowIndex<string>(e.RowIndex, col_DaTi.Name);
                string daAn = dgv.GetCellValueByRowIndex<string>(e.RowIndex, col_DaAn.Name);
                bool isOK = StringHelper.StringEquals(daTi, daAn);
                dgv.SetCellValueByRowIndex(e.RowIndex, col_ShiFouZhengQue.Index, isOK);
            }
        }

        private void dgv_CellLeave(object sender, DataGridViewCellEventArgs e)
        { }

        private void btnPiLiangPingFen_Click(object sender, EventArgs e)
        {
            FrmShiTiPingFenDaAnLuRu frm = new FrmShiTiPingFenDaAnLuRu(SaveDaAn);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("批量评分完成！");
                //dgv.EndEdit();
                dgv.DataSource = null;
                dgv.DataSource = _MuBanMingXiData;
            }
        }

        bool SaveDaAn(string daAn, out string errMsg)
        {
            DaAnFuZhi(daAn);
            errMsg = null;
            return true;
        }

        private void btnSavePingFen_Click(object sender, EventArgs e)
        {
            dgv.EndEdit();
            StringBuilder daTi = new StringBuilder();
            int zqs = 0;
            decimal fenShu = 0;
            foreach (var item in _MuBanMingXiData)
            {
                //if (string.IsNullOrWhiteSpace(item.DaTi)) continue;
                if (item.DaTi == null) item.DaTi = string.Empty;
                daTi.AppendFormat("{0},", item.DaTi.Trim());
                if (StringHelper.StringEquals(item.DaTi, item.DAAN))
                {
                    zqs++;
                    fenShu += item.FENSHU;
                }
            }
            daTi.Remove(daTi.Length - 1, 1);
            T_PEIXUNJIHUA_MINGXI jiHuaMingXi = new T_PEIXUNJIHUA_MINGXI();
            jiHuaMingXi.SHITISHU = _MuBanMingXiData.Count;
            jiHuaMingXi.ZHENGQUESHU = zqs;
            jiHuaMingXi.FENSHU = fenShu;
            jiHuaMingXi.ID = _JiHuaXiMu.ID;
            jiHuaMingXi.DATI = daTi.ToString();
            string errMsg;
            if (SavePingFenHandle(jiHuaMingXi, out errMsg))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }
    }
}