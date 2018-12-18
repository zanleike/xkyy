using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace Framework.WinCommon.Components
{
    [ProvideProperty("EnterIsTab", typeof(Control))]
    public class ControlExtend : Component, IExtenderProvider
    {
        public bool CanExtend(object extendee)
        {
            return
                extendee is TextBox ||
                extendee is ComboBox ||
                extendee is DateTimePicker ||
                extendee is CheckBox ||
                extendee is NumericUpDown;
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

        public ControlExtend(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        #endregion

        class SetupModel
        {
            bool _EnterIsTab = true;

            public bool EnterIsTab
            {
                get { return _EnterIsTab; }
                set { _EnterIsTab = value; }
            }
        }
        /// <summary>
        /// 所有文本框的验证信息字典
        /// </summary>
        private Dictionary<Control, SetupModel> _SetupModelDict;

        /// <summary>
        /// 根据t得到对象
        /// </summary>
        private SetupModel GetSetupModel(Control t)
        {
            if (_SetupModelDict != null && _SetupModelDict.ContainsKey(t))
            {
                return _SetupModelDict[t];
            }
            else
            {
                SetupModel vInfo = new SetupModel();
                vInfo.EnterIsTab = true;
                _SetupModelDict.Add(t, vInfo);
                t.KeyDown += new KeyEventHandler(t_KeyDown);                
                return vInfo;
            }
        }

        void t_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Control ctl = sender as Control;
                var setModel = GetSetupModel(ctl);
                if (setModel.EnterIsTab)
                {
                    SendKeys.Send("{Tab}");
                }
            }
        }

        #region 扩展到控件的属性

        [Category("ControlExtend,控件扩展方法")]
        [Description("是否启用控件的回车当Tab使用")]
        public bool GetEnterIsTab(Control t)
        {
            SetupModel vInfo = GetSetupModel(t);
            return vInfo.EnterIsTab;
        }
        public void SetEnterIsTab(Control t, bool s)
        {
            SetupModel vInfo = GetSetupModel(t);
            vInfo.EnterIsTab = s;
        }

        #endregion
    }
}