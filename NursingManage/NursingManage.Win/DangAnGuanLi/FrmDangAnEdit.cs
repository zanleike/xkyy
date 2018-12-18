using System;
using System.Drawing;
using System.Windows.Forms;
using HursingManage.DBModel;
using Framework.Common.Helpers;

namespace NursingManage.Win.DangAnGuanLi
{
    public partial class FrmDangAnEdit : BaseEditForm
    {
        public FrmDangAnEdit(EditModelHandle<T_DANGAN> EditHandle, T_DANGAN model)
        {
            InitializeComponent();
            this.EditHandle = EditHandle;
            this._Model = model;
        }
        EditModelHandle<T_DANGAN> EditHandle;
        T_DANGAN _Model;

        private void FrmDangAnEdit_Load(object sender, EventArgs e)
        {
            ComboBoxHelper.SetDictComboBox(coBoxNengJi, HursingManage.AL.DictType.NengJi);
            ComboBoxHelper.SetDictComboBox(coBoxZhengZhiMianMao, HursingManage.AL.DictType.ZhengZhiMianMao);

            coBoxZaiZhi.SelectedIndex = 0;
            if (_Model != null)
            {
                this.Text = " 个人档案修改";
                dcm1.SetControlValue(_Model);
            }
            else
            {
                this.Text = " 个人档案新增";
                //txtZaiZhi.Text = "在职";
                //txtZaiZhi.Tag = txtZaiZhi.Text;
                _Model = new T_DANGAN();
            }
            if (IsHuShiZhangLogin)
            {
                txtKeShi.Tag = KeShiId;
                txtKeShi.Text = KeShi;
                txtKeShi.ReadOnly = false;
            }
            ComboxListHelper.SetKeShi(comboxList1, txtKeShi);
            ComboxListHelper.SetDict(comboxList1, txtMINZU, HursingManage.AL.DictType.MinZu, "名称");
            ComboxListHelper.SetDict(comboxList1, txtZhiCheng, HursingManage.AL.DictType.ZhiCheng, "职称");
            ComboxListHelper.SetDict(comboxList1, txtZhiWu, HursingManage.AL.DictType.ZhiWu, "职务名称");

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
             _Model.ClearChangedState();
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            if (EditHandle(_Model, out errMsg))
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

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            //if (_ExForm == null)
            //{
            //    _ExForm = new FrmDangAnEx();
            //    _ExForm.TopLevel = false;
            //    _ExForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //    tabPage2.Controls.Add(_ExForm);
            //    _ExForm.Show();
            //    _ExForm.SetDangAnEx(_Model.ExDangAn);
            //}
        }

        private void txtXINGMING_Leave(object sender, EventArgs e)
        {
            txtXINGMING_PY.Text = StringHelper.GetPinYin(txtXINGMING.Text);
        }
        protected override void SaveHandle(object sender, EventArgs e)
        {
            btnOK_Click(sender, e);
        }

        private void txtIDCard_Leave(object sender, EventArgs e)
        {
            var idInfo = IdentityHelper.GetIdentityInfo(txtIDCard.Text);
            if (idInfo != null)
            {
                dtpChuShengRiQi.Value = idInfo.Birthday;
            }
        }

        private void picEmp_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.AddExtension = true;
            fd.Filter = "JPG|*.jpg|PNG|*.png|所有文件|*.*";
            fd.FilterIndex = 0;
            fd.CheckFileExists = true;
            fd.RestoreDirectory = true;
            //fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fd.ValidateNames = true;
            if (DialogResult.OK == fd.ShowDialog())
            {
                if (FileHelper.IsStandardPicture(fd.FileName))
                {
                    picEmp.Image = Bitmap.FromFile(fd.FileName);
                }
                else
                {
                    MessageBox.Show("文件尺寸最大为100K,请核对后重试!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}