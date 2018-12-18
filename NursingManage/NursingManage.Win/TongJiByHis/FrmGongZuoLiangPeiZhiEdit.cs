using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;

namespace NursingManage.Win.TongJiByHis
{
    public partial class FrmGongZuoLiangPeiZhiEdit : BaseEditForm
    {
        public FrmGongZuoLiangPeiZhiEdit(EditModelHandle<T_GONGZUOLIANG_PEIZHI> SaveHandle, T_GONGZUOLIANG_PEIZHI model)
        {
            InitializeComponent();
            this.SavePeiZhiHandle = SaveHandle;
            this._Model = model;
        }

        EditModelHandle<T_GONGZUOLIANG_PEIZHI> SavePeiZhiHandle;
        T_GONGZUOLIANG_PEIZHI _Model;

        private void FrmGongZuoLiangPeiZhiEdit_Load(object sender, EventArgs e)
        {
            if (_Model == null)
            {
                _Model = new T_GONGZUOLIANG_PEIZHI();
                this.Text = "工作量配置 新增";
            }
            else
            {
                this.Text = "工作量配置 修改";
                dcm1.SetControlValue(_Model);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _Model.ClearChangedState();
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (SavePeiZhiHandle(_Model, out errMsg))
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
