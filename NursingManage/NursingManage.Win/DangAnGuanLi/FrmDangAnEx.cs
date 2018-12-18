using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZCJH.HursingManage.DBModel;

namespace ZCJH.NursingManage.Win.DangAnGuanLi
{
    public partial class FrmDangAnEx : BaseEditForm
    {
        public FrmDangAnEx()
        {
            InitializeComponent();
        }

        public T_DANGAN_EX GetDangAnEx()
        {
            T_DANGAN_EX model = new T_DANGAN_EX();
            dcm1.SetValueToClassObj(model);
            return model;
        }

        public void SetDangAnEx(T_DANGAN_EX model)
        {
            dcm1.SetControlValue(model);
        }

        private void FrmDangAnEx_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 0;
        }
    }
}
