using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmDaTi : BaseEditForm
    {
        public FrmDaTi(
                V_SHITI_MUBAN_MINGXI shiTiModel,
                Func<V_SHITI_MUBAN_MINGXI> NextShiTiHandle,
                Func<V_SHITI_MUBAN_MINGXI> PrevShiTiHandle,
                Action<V_SHITI_MUBAN_MINGXI> SaveResultHandle)
        {
            InitializeComponent();
            this._ShiTiModel = shiTiModel;
            this.NextShiTiHandle = NextShiTiHandle;
            this.PrevShiTiHandle = PrevShiTiHandle;
            this.SaveResultHandle = SaveResultHandle;
        }

        V_SHITI_MUBAN_MINGXI _ShiTiModel;
        Func<V_SHITI_MUBAN_MINGXI> NextShiTiHandle;
        Func<V_SHITI_MUBAN_MINGXI> PrevShiTiHandle;
        Action<V_SHITI_MUBAN_MINGXI> SaveResultHandle;

        void SetControlValue()
        {
            dcm1.SetControlValue(_ShiTiModel);
            string daTi = _ShiTiModel.DaTi;
            if (_ShiTiModel.DaTi == null) _ShiTiModel.DaTi = string.Empty;
            chBoxA.Checked = _ShiTiModel.DaTi.ToUpper().Contains("A");
            chBoxB.Checked = _ShiTiModel.DaTi.ToUpper().Contains("B");
            chBoxC.Checked = _ShiTiModel.DaTi.ToUpper().Contains("C");
            chBoxD.Checked = _ShiTiModel.DaTi.ToUpper().Contains("D");
            chBoxE.Checked = _ShiTiModel.DaTi.ToUpper().Contains("E");
            chBoxF.Checked = _ShiTiModel.DaTi.ToUpper().Contains("F");
        }
        void GetControlValue()
        {
            dcm1.SetValueToClassObj(_ShiTiModel);
            StringBuilder dati = new StringBuilder();
            if (chBoxA.Checked) dati.Append("A");
            if (chBoxB.Checked) dati.Append("B");
            if (chBoxC.Checked) dati.Append("C");
            if (chBoxD.Checked) dati.Append("D");
            if (chBoxE.Checked) dati.Append("E");
            if (chBoxF.Checked) dati.Append("F");
            _ShiTiModel.DaTi = dati.ToString();
        }

        private void FrmDaTi_Load(object sender, EventArgs e)
        {
            dcm1.SetControlValue(_ShiTiModel);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GetControlValue();
            _ShiTiModel = NextShiTiHandle();
            SetControlValue();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            GetControlValue();
            _ShiTiModel = PrevShiTiHandle();
            SetControlValue();
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            GetControlValue();
            SaveResultHandle(_ShiTiModel);
        }

        private void btnCancelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}