using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    public partial class FrmZhiKongJiHuaEdit : BaseEditForm
    {
        public FrmZhiKongJiHuaEdit(EditModelHandle<T_ZHIKONGJIHUA> EditJiHuaHandle, T_ZHIKONGJIHUA model = null)
        {
            InitializeComponent();
            this.EditJiHuaHandle = EditJiHuaHandle;
            this._Model = model;
        }

        EditModelHandle<T_ZHIKONGJIHUA> EditJiHuaHandle;
        T_ZHIKONGJIHUA _Model;

        private void FrmZhiKongJiHuaEdit_Load(object sender, EventArgs e)
        {
            if (_Model == null)
            {
                this.Text = "质控计划 新增";
                _Model = new T_ZHIKONGJIHUA();
            }
            else
            {
                this.Text = "质控计划 修改";
                dcm1.SetControlValue(_Model);
            }            
            chbShiFouFuCha.Checked = _Model.SHIFOUFUCHA == "是";
            ComboxListHelper.SetZhiKongJiHua(comboxList1, txtFuChaJiHua);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string errMsg;
            dcm1.SetValueToClassObj(_Model);
            _Model.SHIFOUFUCHA = chbShiFouFuCha.Checked ? "是" : "否";
            if (EditJiHuaHandle(_Model, out errMsg))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void chbShiFouFuCha_CheckedChanged(object sender, EventArgs e)
        {
            txtFuChaJiHua.ReadOnly = !chbShiFouFuCha.Checked;
        }
    }
}
