using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Framework.WinCommon.Forms;
using HursingManage.AL;

namespace NursingManage.Win
{
    public partial class BaseForm : FrmBase
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 是否管理员登录
        /// </summary>
        [Browsable(false)]
        public bool IsAdminLogin
        {
            get
            {
                return ALCommon.Instance.IsAdminLogin;
            }
        }
        /// <summary>
        /// 是否护理部登录
        /// </summary>
        [Browsable(false)]
        public bool IsHuLiBuLogin
        {
            get
            {
                return ALCommon.Instance.IsHuLiBuLogin;
            }
        }
        /// <summary>
        /// 是否护士长登录
        /// </summary>
        [Browsable(false)]
        public bool IsHuShiZhangLogin
        {
            get
            {
                return ALCommon.Instance.IsHuShiZhangLogin;
            }
        }
        /// <summary>
        /// 科室Id
        /// </summary>
        [Browsable(false)]
        public string KeShiId
        {
            get
            {
                return ALCommon.Instance.KeShiId;
            }
        }
        /// <summary>
        /// 科室名称
        /// </summary>
        [Browsable(false)]
        public string KeShi
        {
            get
            {
                return ALCommon.Instance.KeShi;
            }
        }
    }
}