using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL.DangAnGuanLi;
using HursingManage.DBModel;

namespace NursingManage.Win.DangAnGuanLi
{
    public partial class FrmDangAnSubTableEdit : BaseEditForm
    {
        public FrmDangAnSubTableEdit(
            EditFormConfig editFormConfig,
            List<InputEditConfig> tableConfig,
            T_DANGAN_TABLE model,
            EditModelHandle<T_DANGAN_TABLE> SaveEditDataHandle
            )
        {
            InitializeComponent();
            this._EditFormConfig = editFormConfig;
            this._TableConfig = tableConfig;
            this._Model = model;
            this.SaveEditDataHandle = SaveEditDataHandle;
        }

        EditFormConfig _EditFormConfig;
        List<InputEditConfig> _TableConfig;
        T_DANGAN_TABLE _Model;
        EditModelHandle<T_DANGAN_TABLE> SaveEditDataHandle;

        void InitForm()
        {
            //this.Width = _EditFormConfig.EditFormWidth;
            //this.Height = _EditFormConfig.EditFormHight;
        }

        void InitInputControl()
        {
            foreach (var config in _TableConfig)
            {
                ucInput uc = new ucInput(config, dcm1, comboxList1);
                flp.Controls.Add(uc);
                //if (config.FieldName == "col7" && config.ControlType==4)
                //{
                //    MessageBox.Show("111");
                //}
            }            
        }

        private void FrmDangAnSubTableEdit_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            if (_Model == null)
            {
                _Model = new T_DANGAN_TABLE();
            }
            InitForm();
            InitInputControl();
            dcm1.SetControlValue(_Model); 
            if (string.IsNullOrWhiteSpace(_Model.ID))
            {
                //新增
            }
            else
            { 
                //编辑
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (SaveEditDataHandle(_Model, out errMsg))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}