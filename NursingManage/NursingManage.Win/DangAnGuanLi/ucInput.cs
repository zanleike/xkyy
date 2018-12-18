using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.WinCommon.Components;
using HursingManage.AL.DangAnGuanLi;
using Framework.Common.Helpers;

namespace NursingManage.Win.DangAnGuanLi
{
    public partial class ucInput : UserControl
    {
        public ucInput()
        {
            InitializeComponent();
        }
        public ucInput(InputEditConfig config, DCM dcm, ComboxList cboxList)
            : this()
        {
            this.panelText.Visible = false;
            InitControl(config, dcm, cboxList);
        }

        public void InitControl(InputEditConfig config, DCM dcm, ComboxList cboxList)
        {
            this.Width = config.ControlWidht;
            this.Height = config.ControlHeight;
            panelCaption.Width = config.CaptionControlLen;
            ControlType controlType = (ControlType)config.ControlType;
            Panel inputPanel;
            switch (controlType)
            {
                case ControlType.Text:
                case ControlType.TextComboxBox:
                    inputPanel = panelText;
                    break;
                case ControlType.TextMultiline:
                    inputPanel = panelTxtMultiline;
                    break;
                case ControlType.ComboBox:
                    inputPanel = panelComBox;
                    break;
                case ControlType.ComboBoxDropDownList:
                    inputPanel = panelComBox;
                    break;
                case ControlType.DateTimePicker:
                    inputPanel = panelDatePicker;
                    break;
                case ControlType.PictureBox:
                    inputPanel = panelpicturebox;
                    break;
                default:
                    inputPanel = null;
                    break;
            }
            inputPanel.Visible = true;
            inputPanel.Dock = DockStyle.Fill;
           
            lbCaption.Text = config.FieldCaption;
            Control inputControl = inputPanel.Controls[0];
            inputControl.TabIndex = config.OrderNo;
            dcm.SetTextColumnName(inputControl, config.FieldName);
            dcm.SetIsUse(inputControl, true);
            if (controlType == ControlType.TextComboxBox)
            {
                int dictType = Convert.ToInt32(config.DataSource);
                TextBox tb = inputControl as TextBox;
                ComboxListHelper.SetDict(cboxList, tb, dictType, config.FieldCaption);
            }
            else if (controlType == ControlType.ComboBox || controlType == ControlType.ComboBoxDropDownList)
            {
                int dictType = Convert.ToInt32(config.DataSource);
                var coBox = inputControl as ComboBox;
                ComboBoxHelper.SetDictComboBox(coBox, dictType);
                if (controlType == ControlType.ComboBoxDropDownList)
                {
                    coBox.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            if (config.IsRequired)
            {
                //inputPanel.Width -= panelRequired.Width;
                panelRequired.Visible = true;
            }
        }

        private void ucInput_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            
            //OpenFileDialog fd = new OpenFileDialog();
            //fd.AddExtension = true;
            //fd.Filter = "JPG|*.jpg|PNG|*.png|所有文件|*.*";
            //fd.FilterIndex = 0;
            //fd.CheckFileExists = true;
            //fd.RestoreDirectory = true;
            ////fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //fd.ValidateNames = true;
            //if (DialogResult.OK == fd.ShowDialog())
            //{
            //    //if (FileHelper.IsStandardPicture(fd.FileName))
            //    //{
            //    pictureBox.Image = Bitmap.FromFile(fd.FileName);
            //    //}
            //    //else
            //    //{
            //    //    MessageBox.Show("文件尺寸最大为100K,请核对后重试!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    //}
            //}
        }
        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            //左单机事件
            if (e.Button==MouseButtons.Left && e.Clicks==1)
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
                    //if (FileHelper.IsStandardPicture(fd.FileName))
                    //{
                    pictureBox.Image = Bitmap.FromFile(fd.FileName);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("文件尺寸最大为100K,请核对后重试!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                }
            }
            //右单机事件
            if (e.Button == MouseButtons.Right && e.Clicks == 1)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Image files (*.jpg)|*.jpg";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Title = "导出文件保存路径";
                saveFileDialog.FileName = null;
                saveFileDialog.ShowDialog();
                string strPath = saveFileDialog.FileName;
                if (strPath.Length != 0)
                {
                    Image img = pictureBox.Image;
                    img.Save(strPath);
                }
            }
        }
    }
}
