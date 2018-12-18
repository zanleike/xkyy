using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;
using Framework.WinCommon.Components;
using HursingManage.AL;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmPeiXunJiHuaEdit : BaseEditForm
    {
        public FrmPeiXunJiHuaEdit(EditModelHandle<T_PEIXUNJIHUA> SaveHandle, T_PEIXUNJIHUA model)
        {
            InitializeComponent();
            this.SaveJiHuaHandle = SaveHandle;
            this._Model = model;
        }

        EditModelHandle<T_PEIXUNJIHUA> SaveJiHuaHandle;
        T_PEIXUNJIHUA _Model;

        bool SaveJieHua()
        {
            _Model.ClearChangedState();            
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (!SaveJiHuaHandle(_Model, out errMsg))
            {
                ShowMessage(errMsg);
                return false;
            }
            else
            {
               
                return true;
            }
        }

        private void FrmPeiXunJiHuaEdit_Load(object sender, EventArgs e)
        {
            if (_Model != null)
            {
                //修改
                this.Text = "培训计划 修改";
                dcm1.SetControlValue(_Model);
            }
            else
            {
                //新增
                this.Text = "培训计划 新增";
                _Model = new T_PEIXUNJIHUA();              
            }
            //ComboxListHelper.SetKeShi(comboxList1, txtKeShi);
            //ComboxListHelper.SetUser(comboxList1, txtPeiXunRen);
            //ComboxListHelper.SetShiTiMuBan(comboxList1, txtShiTiMuBan);
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (SaveJieHua())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}