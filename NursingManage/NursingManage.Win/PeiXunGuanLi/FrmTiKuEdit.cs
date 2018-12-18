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
    public partial class FrmTiKuEdit : BaseEditForm
    {
        public FrmTiKuEdit(EditModelHandle<T_SHITI> SaveModelHanel, T_SHITI model)
        {
            InitializeComponent();
            this.SaveModelHanel = SaveModelHanel;
            this._Model = model;
        }

        EditModelHandle<T_SHITI> SaveModelHanel;
        T_SHITI _Model;

        private void FrmTiKuEdit_Load(object sender, EventArgs e)
        {
            coBoxJianYiChengDu.SelectedIndex = 0;
            if (_Model == null)
            {
                this.Text += " 新增";
                coBoxShiTiLeiXing.SelectedIndex = 0;
            }
            else
            {
                this.Text += " 修改";
                dcm1.SetControlValue(_Model);
                if (_Model.DAAN.Contains("A")) chBoxXIANGMUA_OK.Checked = true;
                if (_Model.DAAN.Contains("B")) chBoxXIANGMUB_OK.Checked = true;
                if (_Model.DAAN.Contains("C")) chBoxXIANGMUC_OK.Checked = true;
                if (_Model.DAAN.Contains("D")) chBoxXIANGMUD_OK.Checked = true;
                if (_Model.DAAN.Contains("E")) chBoxXIANGMUE_OK.Checked = true;
                if (_Model.DAAN.Contains("F")) chBoxXIANGMUF_OK.Checked = true;
            }
        }

        private void coBoxShiTiLeiXing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coBoxShiTiLeiXing.SelectedIndex == 3 || coBoxShiTiLeiXing.SelectedIndex == 4)
            {
                //问答题
                panelDuoXuan.Visible = false;
                panelWenDa.Visible = true;
                panelWenDa.Parent = gBoxDaAn;
                panelWenDa.Dock = DockStyle.Fill;
            }
            else if (coBoxShiTiLeiXing.SelectedIndex == 2)
            {
                //判断题
                panelDuoXuanEx.Visible = false;
                if (_Model == null)
                {
                    txtXIANGMUA.Text = "正确";
                    txtXIANGMUB.Text = "错误";
                }
            }
            else
            {
                panelDuoXuanEx.Visible = true;
                if (_Model == null)
                {
                    txtXIANGMUA.Text = string.Empty;
                    txtXIANGMUB.Text = string.Empty;
                }
                panelDuoXuanEx.Visible = true;
                panelWenDa.Visible = false;
                panelDuoXuan.Parent = gBoxDaAn;
                panelDuoXuan.Visible = true;
                panelDuoXuan.Dock = DockStyle.Fill;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_Model == null)
            {
                _Model = new T_SHITI();
            }
            dcm1.SetValueToClassObj(_Model);            
            string err;
            StringBuilder sb = new StringBuilder();
            if (chBoxXIANGMUA_OK.Checked) sb.Append("A");
            if (chBoxXIANGMUB_OK.Checked) sb.Append("B");
            if (_Model.LEIXING != "判断题")
            {
                if (chBoxXIANGMUC_OK.Checked) sb.Append("C");
                if (chBoxXIANGMUD_OK.Checked) sb.Append("D");
                if (chBoxXIANGMUE_OK.Checked) sb.Append("E");
                if (chBoxXIANGMUF_OK.Checked) sb.Append("F");
            }
            _Model.DAAN = sb.ToString();
            if (!SaveModelHanel(_Model, out err))
            {
                ShowMessage(err);
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chBoxXIANGMU_CheckedChanged(object sender, EventArgs e)
        {
            if (coBoxShiTiLeiXing.SelectedIndex == 0 || coBoxShiTiLeiXing.SelectedIndex == 2)
            {
                var chkBox = sender as CheckBox;
                if (chkBox.Checked)
                {
                    chBoxXIANGMUA_OK.Checked = false;
                    chBoxXIANGMUB_OK.Checked = false;
                    chBoxXIANGMUC_OK.Checked = false;
                    chBoxXIANGMUD_OK.Checked = false;
                    chBoxXIANGMUE_OK.Checked = false;
                    chBoxXIANGMUF_OK.Checked = false;
                    chkBox.Checked = true;
                }
            }
        }
    }
}