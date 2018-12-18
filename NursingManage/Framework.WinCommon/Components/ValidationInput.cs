using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using Framework.Common.Validation;

namespace Framework.WinCommon.Components
{
    [ProvideProperty("ValidType", typeof(TextBox))]
    [ProvideProperty("DataType", typeof(TextBox))]
    [ProvideProperty("ValidMaxValue", typeof(TextBox))]
    [ProvideProperty("ValidMinValue", typeof(TextBox))]
    [ProvideProperty("CompareValue", typeof(TextBox))]
    [ProvideProperty("ErrMessage", typeof(TextBox))]
    [ProvideProperty("AttributeType", typeof(TextBox))]
    public class ValidationInput : Component, IExtenderProvider
    {
        public bool CanExtend(object extendee)
        {
            return extendee is TextBox;
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
        }

        #endregion

        #region 构造方法

        public ValidationInput(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            _ValidationDict = new Dictionary<TextBox, InputValidationModel>();
            _ErrorProvider = new ErrorProvider();
        }

        #endregion

        /// <summary>
        /// 要验证控件的Text属性还是Tag属性
        /// </summary>
        public enum ControlAttribute
        {
            /// <summary>
            /// 验证控件Text属性
            /// </summary>
            Text,
            /// <summary>
            /// 验证控件的Tag属性
            /// </summary>
            Tag
        }

        class InputValidationModel : ValidationModel
        {
            public ControlAttribute AttributeType { set; get; }
        }

        /// <summary>
        /// 所有文本框的验证信息字典
        /// </summary>
        private Dictionary<TextBox, InputValidationModel> _ValidationDict;

        //获取验证实体
        private InputValidationModel GetValidationInfo(TextBox t)
        {
            if (_ValidationDict != null && _ValidationDict.ContainsKey(t))
            {
                return _ValidationDict[t];
            }
            else
            {
                InputValidationModel vInfo = new InputValidationModel();
                vInfo.ErrMessage = "验证错误!";
                vInfo.ValidType = ValidTypeEnum.None;
                vInfo.AttributeType = ControlAttribute.Text;
                _ValidationDict.Add(t, vInfo);
                t.Leave += new EventHandler(t_Leave);
                return vInfo;
            }
        }
        void t_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (_ValidationDict[tb].AttributeType == ControlAttribute.Text)
            {
                _ValidationDict[tb].ValidObject = tb.Text;
            }
            else
            {
                _ValidationDict[tb].ValidObject = tb.Tag;
            }
            bool r = Validation.ThisModel.Validating(_ValidationDict[tb]);
            if (r)
            {
                _ErrorProvider.SetError(tb, "");
            }
            else
            {
                //tb.Focus();
                //tb.SelectAll();
                //离开时只验证是否错误,不错误则去掉错误提示
                //_ErrorProvider.SetError(tb, _ValidationDict[tb].ErrMessage);
            }
        }

        ErrorProvider _ErrorProvider;

        /// <summary>
        /// 开始所有验证信息,验证成功返回true,否则errorProvider来提示错误
        /// </summary>
        public bool Validating()
        {
            int errCount = 0;
            foreach (var item in _ValidationDict.Keys)
            {   
                if (_ValidationDict[item].AttributeType == ControlAttribute.Text)
                {
                    _ValidationDict[item].ValidObject = item.Text;
                }
                else
                {
                    _ValidationDict[item].ValidObject = item.Tag;
                }
                bool r = Validation.ThisModel.Validating(_ValidationDict[item]);
                if (r)
                {
                    _ErrorProvider.SetError(item, "");
                }
                else
                {
                    errCount++;
                    //item.Focus();
                    //item.SelectAll();
                    _ErrorProvider.SetError(item, _ValidationDict[item].ErrMessage);
                    //return false;
                }
            }
            return errCount > 0 ? false : true;
        }

        [Category("验证扩展属性")]
        [Description("验证类型,控件验证的总开关")]
        public ValidTypeEnum GetValidType(TextBox t)
        {
            ValidationModel vInfo = GetValidationInfo(t);
            return vInfo.ValidType;
        }
        public void SetValidType(TextBox t, ValidTypeEnum s)
        {
            ValidationModel vInfo = GetValidationInfo(t);
            vInfo.ValidType = s;
        }

        [Category("验证扩展属性")]
        [Description("验证的数据类型")]
        public DataTypeEnum GetDataType(TextBox t)
        {
            ValidationModel vInfo = GetValidationInfo(t);
            return vInfo.DataType;
        }
        public void SetDataType(TextBox t, DataTypeEnum s)
        {
            ValidationModel vInfo = GetValidationInfo(t);
            vInfo.DataType = s;
        }

        [Category("验证扩展属性")]
        [Description("验证的值的最大值")]
        public string GetValidMaxValue(TextBox t)
        {
            ValidationModel vInfo = GetValidationInfo(t);
            return vInfo.MaxValue;
        }
        public void SetValidMaxValue(TextBox t, string s)
        {
            ValidationModel vInfo = GetValidationInfo(t);
            vInfo.MaxValue = s;
        }

        [Category("验证扩展属性")]
        [Description("验证的值的最小值")]
        public string GetValidMinValue(TextBox t)
        {
            ValidationModel vInfo = GetValidationInfo(t);
            return vInfo.MinValue;
        }
        public void SetValidMinValue(TextBox t, string s)
        {
            ValidationModel vInfo = GetValidationInfo(t);
            vInfo.MinValue = s;
        }

        [Category("验证扩展属性")]
        [Description("验证的值的比较值")]
        public string GetCompareValue(TextBox t)
        {
            ValidationModel vInfo = GetValidationInfo(t);
            return vInfo.CompareValue;
        }
        public void SetCompareValue(TextBox t, string s)
        {
            ValidationModel vInfo = GetValidationInfo(t);
            vInfo.CompareValue = s;
        }

        [Category("验证扩展属性")]
        [Description("验证失败后显示的错误信息")]
        public string GetErrMessage(TextBox t)
        {
            ValidationModel vInfo = GetValidationInfo(t);
            return vInfo.ErrMessage;
        }
        public void SetErrMessage(TextBox t, string s)
        {
            ValidationModel vInfo = GetValidationInfo(t);
            vInfo.ErrMessage = s;
        }

        [Category("验证扩展属性")]
        [Description("获取或设置要验证控件的属性是Text还是Tag属性")]
        public ControlAttribute GetAttributeType(TextBox t)
        {
            InputValidationModel vInfo = GetValidationInfo(t);
            return vInfo.AttributeType;
        }
        public void SetAttributeType(TextBox t, ControlAttribute s)
        {
            InputValidationModel vInfo = GetValidationInfo(t);
            vInfo.AttributeType = s;
        }
    }
}
