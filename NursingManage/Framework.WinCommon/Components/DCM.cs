/*
    创建日期: 2014.6.4
    创建者:张存
    邮箱:zhangcunliang@126.com
    说明:
        
    修改记录:
        2015.1.13 407行,combox获得value,如果选中项为null,则返回null
        2015.11.7   将控件值赋值到对象时,取消class和new的泛型限制
        2016.4.26   combox设置时当为记录为,0默认还会选中第一项的bug修复
        2017.3.23   反射获取对象属性时,忽略大小写;
        2017.3.29   日期控件如果赋值给string类型是，默认取值为格式化类型
        2017.4.7    增加对控件 NumericUpDown 的支持
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using Framework.Common.Helpers;

namespace Framework.WinCommon.Components
{
    /// <summary>
    /// 数据库 与 控件映射扩展组件
    /// Database Control Mapping
    /// </summary>
    [ProvideProperty("IsUse", typeof(Control))]
    //[ProvideProperty("IsTagValue", typeof(Control))]
    [ProvideProperty("TextColumnName", typeof(Control))]
    [ProvideProperty("TagColumnName", typeof(Control))]
    public class DCM : Component, IExtenderProvider
    {
        public bool CanExtend(object extendee)
        {
            return
                extendee is TextBox ||
                extendee is ComboBox ||
                extendee is DateTimePicker ||
                extendee is CheckBox ||
                extendee is NumericUpDown ||
                extendee is PictureBox
                ;
        }

        #region 系统生成

        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            //errorProvider.Dispose();
        }
        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            _SetupModelDict = new Dictionary<Control, SetupModel>();
        }

        #endregion

        #region 构造方法

        public DCM(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        #endregion

        class SetupModel
        {
            public bool IsUse { set; get; }
            public string TextColumnName { set; get; }
            public string TagColumnName { set; get; }
        }
        /// <summary>
        /// 所有文本框的验证信息字典
        /// </summary>
        private Dictionary<Control, SetupModel> _SetupModelDict;

        /// <summary>
        /// 根据t得到对象
        /// </summary>
        private SetupModel GetValidationInfo(Control t)
        {
            if (_SetupModelDict != null && _SetupModelDict.ContainsKey(t))
            {
                return _SetupModelDict[t];
            }
            else
            {
                SetupModel vInfo = new SetupModel();
                vInfo.IsUse = false;
                vInfo.TextColumnName = null;
                vInfo.TagColumnName = null;
                _SetupModelDict.Add(t, vInfo);
                return vInfo;
            }
        }

        #region 控件值与对象值交换

        /// <summary>
        /// 将扩展的控件的值赋值给DataRow,
        /// dr必须包含它所属的DataTable
        /// </summary>
        public void SetValueToDataRow(DataRow dr)
        {
            DataTable dt = dr.Table;
            foreach (Control item in _SetupModelDict.Keys)
            {
                if (!_SetupModelDict[item].IsUse) continue;
                if (!string.IsNullOrEmpty(_SetupModelDict[item].TextColumnName))
                {
                    if (dt.Columns.Contains(_SetupModelDict[item].TextColumnName))
                    {
                        object columnValue = null;
                        if (item is TextBox)
                        {
                            columnValue = GetTextBoxValue(item);
                        }
                        else if (item is CheckBox)
                        {
                            columnValue = GetCheckBoxValue(item);
                        }
                        else if (item is ComboBox)
                        {
                            columnValue = GetComBoxValue(item);
                        }
                        else if (item is DateTimePicker)
                        {
                            columnValue = GetDateTimePickerValue(item);
                        }
                        else if (item is NumericUpDown)
                        {
                            columnValue = GetNumericUpDownValue(item);
                        }
                        else if (item is PictureBox)
                        {
                            columnValue = GetPictureBox(item);
                        }
                        dr[_SetupModelDict[item].TextColumnName] = columnValue;
                    }
                }
                if (!string.IsNullOrEmpty(_SetupModelDict[item].TagColumnName))
                {
                    if (dt.Columns.Contains(_SetupModelDict[item].TagColumnName))
                    {
                        object columnValue = null;
                        if (item is TextBox)
                        {
                            columnValue = GetTextBoxTagValue(item);
                        }
                        else if (item is CheckBox)
                        {
                            columnValue = GetCheckBoxTagValue(item);
                        }
                        else if (item is ComboBox)
                        {
                            columnValue = GetComBoxTagValue(item);
                        }
                        else if (item is DateTimePicker)
                        {
                            columnValue = GetDateTimePickerTagValue(item);
                        }
                        else if (item is NumericUpDown)
                        {
                            columnValue = GetNumericUpDownTagValue(item);
                        }
                        else if (item is PictureBox)
                        {
                            columnValue = GetPictureBoxTagValue(item);
                        }
                        dr[_SetupModelDict[item].TagColumnName] = columnValue;
                    }
                }
            }
        }

        static BindingFlags PropertyBindingFlags = BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.Instance;

        /// <summary>
        /// 将控件值赋值到一个实体对象
        /// </summary>
        /// <param name="obj"></param>
        public void SetValueToClassObj<T>(T obj)
        {
            Type objType = obj.GetType();
            foreach (Control item in _SetupModelDict.Keys)
            {
                if (!_SetupModelDict[item].IsUse) continue;

                if (!string.IsNullOrEmpty(_SetupModelDict[item].TextColumnName))
                {
                    System.Reflection.PropertyInfo pro = objType.GetProperty(_SetupModelDict[item].TextColumnName, PropertyBindingFlags);
                    if (pro != null)
                    {
                        object columnValue = null;
                        if (item is TextBox)
                        {
                            columnValue = GetTextBoxValue(item);
                        }
                        else if (item is CheckBox)
                        {
                            columnValue = GetCheckBoxValue(item);
                        }
                        else if (item is ComboBox)
                        {
                            columnValue = GetComBoxValue(item);
                        }
                        else if (item is DateTimePicker)
                        {
                            bool isString = pro.PropertyType == typeof(string);
                            columnValue = GetDateTimePickerValue(item, isString);
                        }
                        else if (item is NumericUpDown)
                        {
                            columnValue = GetNumericUpDownValue(item);
                        }
                        else if (item is PictureBox)
                        {
                            columnValue = GetPictureBox(item);
                        }
                        try
                        {
                            //如果类型转换失败,则强转一下
                            object rObj = Convert.ChangeType(columnValue, pro.PropertyType);
                            pro.SetValue(obj, rObj, null);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(_SetupModelDict[item].TagColumnName))
                {
                    System.Reflection.PropertyInfo proTag = objType.GetProperty(_SetupModelDict[item].TagColumnName, PropertyBindingFlags);
                    if (proTag != null)
                    {
                        object columnValue = null;
                        if (item is TextBox)
                        {
                            columnValue = GetTextBoxTagValue(item);
                        }
                        else if (item is CheckBox)
                        {
                            columnValue = GetCheckBoxTagValue(item);
                        }
                        else if (item is ComboBox)
                        {
                            columnValue = GetComBoxTagValue(item);
                        }
                        else if (item is DateTimePicker)
                        {
                            columnValue = GetDateTimePickerTagValue(item);
                        }
                        else if (item is NumericUpDown)
                        {
                            columnValue = GetNumericUpDownTagValue(item);
                        }
                        else if (item is PictureBox)
                        {
                            columnValue = GetPictureBoxTagValue(item);
                        }
                        if (columnValue != null)
                        {
                            columnValue = columnValue.ToString();
                            //如果类型转换失败,则强转一下
                            columnValue = Convert.ChangeType(columnValue, proTag.PropertyType);

                        }
                        proTag.SetValue(obj, columnValue, null);
                    }
                }
            }
        }
        /// <summary>
        /// 根据对象值设置控件值
        /// </summary>
        /// <typeparam name="T">对象必须是一个类和可以实例化</typeparam>
        /// <param name="obj"></param>
        public void SetControlValue<T>(T obj)
        {
            Type objType = typeof(T);
            foreach (Control item in _SetupModelDict.Keys)
            {
                if (!_SetupModelDict[item].IsUse) continue;

                if (!string.IsNullOrEmpty(_SetupModelDict[item].TextColumnName))
                {
                    System.Reflection.PropertyInfo pro = objType.GetProperty(_SetupModelDict[item].TextColumnName, PropertyBindingFlags);
                    if (pro != null)
                    {
                        object columnValue = null;
                        if (obj != null)
                        {
                            columnValue = pro.GetValue(obj, null);
                        }
                        if (item is TextBox)
                        {
                            SetTextBoxValue(item, columnValue);
                        }
                        else if (item is CheckBox)
                        {
                            SetCheckBoxValue(item, columnValue);
                        }
                        else if (item is ComboBox)
                        {
                            SetComBoxValue(item, columnValue);
                        }
                        else if (item is DateTimePicker)
                        {
                            SetDateTimePickerValue(item, columnValue);
                        }
                        else if (item is NumericUpDown)
                        {
                            SetNumericUpDownValue(item, columnValue);
                        }
                        else if (item is PictureBox)
                        {
                            SetPictureBoxValue(item, columnValue);
                        }
                    }
                }
                if (!string.IsNullOrEmpty(_SetupModelDict[item].TagColumnName))
                {
                    System.Reflection.PropertyInfo proTag = objType.GetProperty(_SetupModelDict[item].TagColumnName, PropertyBindingFlags);

                    if (proTag != null)
                    {
                        object columnValue = null;
                        if (obj != null)
                        {
                            columnValue = proTag.GetValue(obj, null);
                        }
                        if (item is ComboBox)
                        {
                            SetComBoxTagValue(item, columnValue);
                        }
                        else if (item is DateTimePicker)
                        {
                            SetDateTimePickerTagValue(item, columnValue);
                        }
                        else
                        {
                            item.Tag = columnValue;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 根据datarow设置控件的值
        /// </summary>
        public void SetControlValueFromDataRow(DataRow dr)
        {
            foreach (Control item in _SetupModelDict.Keys)
            {
                if (!_SetupModelDict[item].IsUse) continue;

                if (!string.IsNullOrEmpty(_SetupModelDict[item].TextColumnName))
                {
                    if (!dr.Table.Columns.Contains(_SetupModelDict[item].TextColumnName)) continue;
                    object columnValue = dr[_SetupModelDict[item].TextColumnName];
                    if (item is TextBox)
                    {
                        SetTextBoxValue(item, columnValue);
                    }
                    else if (item is CheckBox)
                    {
                        SetCheckBoxValue(item, columnValue);
                    }
                    else if (item is ComboBox)
                    {
                        SetComBoxValue(item, columnValue);
                    }
                    else if (item is DateTimePicker)
                    {
                        SetDateTimePickerValue(item, columnValue);
                    }
                    else if (item is NumericUpDown)
                    {
                        SetNumericUpDownValue(item, columnValue);
                    }
                    else if (item is PictureBox)
                    {
                        SetPictureBoxValue(item, columnValue);
                    }
                }
                if (!string.IsNullOrEmpty(_SetupModelDict[item].TagColumnName))
                {
                    if (!dr.Table.Columns.Contains(_SetupModelDict[item].TagColumnName)) continue;
                    object columnValue = dr[_SetupModelDict[item].TagColumnName];
                    if (item is ComboBox)
                    {
                        SetComBoxTagValue(item, columnValue);
                    }
                    else
                    {
                        item.Tag = columnValue;
                    }
                }
            }
        }
        /// <summary>
        /// 设置控件的Text=Empty,tag=null
        /// </summary>
        public void SetControlValueEmpty()
        {
            foreach (Control item in _SetupModelDict.Keys)
            {
                if (item is DateTimePicker ||
                    item is CheckBox ||
                    item is ComboBox

                    ) continue;
                item.Text = string.Empty;
                item.Tag = null;
            }
        }

        object GetTextBoxValue(Control textBox)
        {
            return textBox.Text;
        }
        object GetCheckBoxValue(Control checkBox)
        {
            CheckBox cb = checkBox as CheckBox;
            if (cb != null)
            {
                return cb.Checked;
            }
            return null;
        }
        object GetComBoxValue(Control combox)
        {
            ComboBox cbox = combox as ComboBox;
            if (cbox == null) return null;
            return cbox.Text;
        }
        object GetDateTimePickerValue(Control dateTimePicker, bool isString = false)
        {
            DateTimePicker dtp = dateTimePicker as DateTimePicker;
            if (dtp != null)
            {
                if (isString)
                {
                    return dtp.Value.ToString(dtp.CustomFormat);
                }
                return dtp.Value;
            }
            return null;
        }
        object GetNumericUpDownValue(Control numericUpDown)
        {
            NumericUpDown dtp = numericUpDown as NumericUpDown;
            return dtp.Value;
        }

        object GetPictureBox(Control ctrl)
        {
            PictureBox pic = ctrl as PictureBox;
            if (pic != null)
                if (pic.Image != null)
                {
                    return FileHelper.ImageToByteArray(pic.Image);
                }
                else
                    return null;
            else
                return null;
        }

        object GetTextBoxTagValue(Control textBox)
        {
            return textBox.Tag;
        }
        object GetCheckBoxTagValue(Control checkBox)
        {
            return checkBox.Tag;
        }
        object GetComBoxTagValue(Control combox)
        {
            ComboBox cbox = combox as ComboBox;
            if (cbox == null) return null;
            if (cbox.SelectedValue != null) return cbox.SelectedValue;

            object selItem = cbox.SelectedItem;
            if (selItem == null) return null;
            string propertyName = _SetupModelDict[combox].TagColumnName;
            if (!string.IsNullOrEmpty(propertyName))
            {
                Type t = selItem.GetType();
                PropertyInfo pro = t.GetProperty(propertyName, PropertyBindingFlags);
                if (pro == null)
                {
                    pro = t.GetProperty(cbox.ValueMember, PropertyBindingFlags);
                }
                if (pro != null)
                {
                    return pro.GetValue(selItem, null);
                }
            }
            return null;
        }
        object GetDateTimePickerTagValue(Control dateTimePicker)
        {
            DateTimePicker dtp = dateTimePicker as DateTimePicker;
            if (dtp.ShowCheckBox)
            {
                return dtp.Checked;
            }
            return null;
        }
        object GetNumericUpDownTagValue(Control numericUpDown)
        {
            return numericUpDown.Tag;
        }

        object GetPictureBoxTagValue(Control pic)
        {
            return pic.Tag;
        }

        void SetTextBoxValue(Control textBox, object value)
        {
            if (value == null) textBox.Text = string.Empty;
            else textBox.Text = value.ToString();
        }
        void SetCheckBoxValue(Control checkBox, object value)
        {
            CheckBox ckBox = checkBox as CheckBox;
            if (value != null)
            {
                ckBox.Checked = Convert.ToBoolean(value);
            }
        }
        void SetComBoxValue(Control comboBox, object value)
        {
            ComboBox coBox = comboBox as ComboBox;
            for (int i = 0; i < coBox.Items.Count; i++)
            {
                coBox.SelectedIndex = i;

                if (coBox.Text.Equals(value))
                {
                    coBox.SelectedIndex = i;
                    return;
                }
            }
            coBox.SelectedIndex = -1;
        }
        void SetDateTimePickerValue(Control dateTimePicker, object value)
        {
            DateTimePicker dtp = dateTimePicker as DateTimePicker;
            DateTime dt = Convert.ToDateTime(value);
            if (dt >= DateTime.MaxValue || dt <= DateTime.MinValue)
            {
                dtp.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:00"));
            }
            else
            {
                dtp.Value = dt;
            }
        }
        void SetComBoxTagValue(Control comboBox, object value)
        {
            if (value == null) return;
            ComboBox coBox = comboBox as ComboBox;
            coBox.SelectedValue = value;
            if (coBox.DataSource == null)
            {
                string propertyName = coBox.ValueMember;
                for (int i = 0; i < coBox.Items.Count; i++)
                {
                    coBox.SelectedIndex = i;
                    object selObj = coBox.Items[i];

                    Type t = selObj.GetType();
                    PropertyInfo pro = t.GetProperty(propertyName, PropertyBindingFlags);
                    if (pro != null)
                    {
                        object val = pro.GetValue(coBox.Items[i], null);
                        if (val.Equals(value))
                        {
                            //coBox.SelectedIndex = i;
                            return;
                        }
                    }
                }
                if (coBox.Items.Count > 0)
                    coBox.SelectedIndex = 0;
            }
        }
        //设置复选框的值
        void SetDateTimePickerTagValue(Control dateTimePicker, object value)
        {
            DateTimePicker dtp = dateTimePicker as DateTimePicker;
            dtp.Checked = Convert.ToBoolean(value);
        }

        void SetNumericUpDownValue(Control numbericUpDown, object value)
        {
            var num = numbericUpDown as NumericUpDown;
            if (value != null || value != DBNull.Value)
            {
                decimal deci;
                if (decimal.TryParse(value.ToString(), out deci))
                {
                    num.Value = deci;
                }
            }
        }

        void SetPictureBoxValue(Control pic, object value)
        {
            PictureBox p = pic as PictureBox;
            byte[] data = value as byte[];
            if (p != null && data != null)
                p.Image = FileHelper.ByteArrayToImage(data);
        }


        #endregion

        #region 扩展到控件的属性

        [Category("DataTable控件映射")]
        [Description("是否启用控件映射DataTable")]
        public bool GetIsUse(Control t)
        {
            SetupModel vInfo = GetValidationInfo(t);
            return vInfo.IsUse;
        }
        public void SetIsUse(Control t, bool s)
        {
            SetupModel vInfo = GetValidationInfo(t);
            vInfo.IsUse = s;
        }

        //[Category("DataTable控件映射")]
        //[Description("映射值是否返回的是Tag属性值")]
        //public bool GetIsTagValue(Control t)
        //{
        //    SetupModel vInfo = GetValidationInfo(t);
        //    return vInfo.IsTagValue;
        //}
        //public void SetIsTagValue(Control t, bool s)
        //{
        //    SetupModel vInfo = GetValidationInfo(t);
        //    vInfo.IsTagValue = s;
        //}

        [Category("DataTable控件映射")]
        [Description("文本框Text的值,Combox选中项的Text的值,控件映射的DataTable列名")]
        public string GetTextColumnName(Control t)
        {
            SetupModel vInfo = GetValidationInfo(t);
            return vInfo.TextColumnName;
        }
        public void SetTextColumnName(Control t, string s)
        {
            SetupModel vInfo = GetValidationInfo(t);
            vInfo.TextColumnName = s;
        }

        [Category("DataTable控件映射")]
        [Description("ComBox控件的选中项对象属性值,或文本框的Tag值映射的值")]
        public string GetTagColumnName(Control t)
        {
            SetupModel vInfo = GetValidationInfo(t);
            return vInfo.TagColumnName;
        }
        public void SetTagColumnName(Control t, string s)
        {
            SetupModel vInfo = GetValidationInfo(t);
            vInfo.TagColumnName = s;
        }

        #endregion
    }
}
