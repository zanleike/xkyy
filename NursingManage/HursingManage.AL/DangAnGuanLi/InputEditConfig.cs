using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HursingManage.AL.DangAnGuanLi
{
    public enum ControlType : int
    {
        Text = 1,
        TextComboxBox = 2,
        TextMultiline = 3,
        ComboBox = 4,
        ComboBoxDropDownList = 5,
        DateTimePicker = 6,
        PictureBox = 7
    }

    public class InputEditConfig
    {
        public string FieldName { set; get; }
        public string FieldCaption { set; get; }
        public int ControlHeight { set; get; }
        public int ControlWidht { set; get; }
        public int CaptionControlLen { set; get; }
        public int ControlType { set; get; }
        public int OrderNo { set; get; }
        public string DataSource { set; get; }
        public bool IsRequired { set; get; }
    }
    public class EditFormConfig
    {
        public int EditFormWidth { set; get; }
        public int EditFormHight { set; get; }
    }
    public class ExGroupInfo
    {
        public string GroupName { set; get; }
        public string GroupCaption { set; get; }
    }
}