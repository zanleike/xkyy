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
    public partial class FrmJiNengBiaoZhunLeiBieEdit : BaseEditForm
    {
        public FrmJiNengBiaoZhunLeiBieEdit(
            EditModelHandle<T_JINENGLEIBIE> SaveLeiBieHandle,
            T_JINENGLEIBIE model)
        {
            InitializeComponent();
            this.SaveLeiBieHandle = SaveLeiBieHandle;
            this._Model = model;
        }
        T_JINENGLEIBIE _Model;
        EditModelHandle<T_JINENGLEIBIE> SaveLeiBieHandle;

        private void FrmJiNengBiaoZhunLeiBieEdit_Load(object sender, EventArgs e)
        {
            if (_Model == null)
            {
                _Model = new T_JINENGLEIBIE();
            }
            dcm1.SetControlValue(_Model);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (SaveLeiBieHandle(_Model, out errMsg))
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
