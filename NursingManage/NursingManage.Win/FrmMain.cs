using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Framework.WinCommon.Forms;
using NursingManage.Win.XiTongGuanLi;
using HursingManage.AL;
using NursingManage.Win.PeiXunGuanLi;
using NursingManage.Win.DangAnGuanLi;
using WeifenLuo.WinFormsUI.Docking;
using HursingManage.DBModel;
using NursingManage.Win.ZhiLiangKongZhi;
using NursingManage.Win.TongJiByHis;

namespace NursingManage.Win
{
    public partial class FrmMain : BaseForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        ALMain _AL;
        public static bool IsApplicationExit { set; get; }
        FrmHomePage _HomePageForm;
        static FrmMain _MainForm;

        /// <summary>
        /// 设置指定菜单项及下所有子菜单，并交由SetMenuAction处理
        /// </summary>
        void SetMenuItemHandle(ToolStripMenuItem menuItem, Action<ToolStripItem> SetMenuAction)
        {
            SetMenuAction(menuItem);
            if (menuItem != null && menuItem.DropDownItems.Count > 0)
            {
                foreach (ToolStripItem item in menuItem.DropDownItems)
                {
                    ToolStripMenuItem menu = item as ToolStripMenuItem;
                    if (menu != null)
                    {
                        //SetMenuAction(item);
                        SetMenuItemHandle(menu, SetMenuAction);
                    }
                }
            }
        }

        void SetLoginState()
        {
            tslbUserName.Text = _AL.GetUserName();
            tslbKeShi.Text = _AL.GetKeShiName();
            tslbUserType.Text = _AL.GetRoleName();
            tslbLoginTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            List<T_ROLE_MENU> rList = _AL.GetRoleMenu();
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                SetMenuItemHandle(item, (menuItem) =>
                {
                    if (_AL.IsAdminLogin)
                    {
                        menuItem.Visible = true;
                    }
                    else
                    {
                        bool haveRight = (rList != null && rList.Select(s => s.MENUNAME).Contains(menuItem.Name));
                        menuItem.Visible = haveRight;
                    }
                });
            }
            //ToolStripButton
            foreach (ToolStripItem item in toolStrip2.Items)
            {
                if (item is ToolStripButton)
                {
                    if (_AL.IsAdminLogin)
                    {
                        item.Visible = true;
                    }
                    else
                    {
                        bool buttonVisible = (rList != null && rList.Select(s => s.BUTTONNAME).Contains(item.Name));
                        item.Visible = buttonVisible;
                    }
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string appVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            if (!string.IsNullOrWhiteSpace(AppConfig.AppSettings.AppCaption))
            {
                this.Text = AppConfig.AppSettings.AppCaption;
                notifyIcon1.Text = this.Text;
            }
            _AL = new ALMain();
            _AL.WriteDBLog("登录成功，版本：" + appVersion);
            _HomePageForm = new FrmHomePage();
            _HomePageForm.Show(this.dockPanel1);
            SetLoginState();
            _MainForm = this;
        }

        private void tsmiChangeUser_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                IDockContent[] documents = this.dockPanel1.DocumentsToArray();
                foreach (IDockContent content in documents)
                {
                    content.DockHandler.Close();
                }
                SetLoginState();
            }
        }

        /// <summary>
        /// 在dockPanl中打开单例窗体到dockPanel中
        /// </summary>
        protected internal static void ShowMDISubForm<T>(Func<BaseForm> CreateForm) where T : BaseForm, new()
        {
            BaseForm frm = FormsCommon.CreateSingletonForm<T>(() => { return CreateForm(); });
            frm.Show(_MainForm.dockPanel1);
        }

        public static void ShowMDIForm<T>() where T : BaseForm, new()
        {
            var frm = FormsCommon.CreateSingletonForm<T>();
            frm.Show(_MainForm.dockPanel1);
        }

        /// <summary>
        /// 在dockPanl中打开单例窗体到dockPanel中
        /// </summary>
        protected void ShowMDISubForm<T>() where T : BaseForm, new()
        {
            BaseForm frm = FormsCommon.CreateSingletonForm<T>();
            frm.Show(this.dockPanel1);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsApplicationExit)
            {
                return;
            }
            else
            {
                tsMenuExit_Click(sender, e);
            }
            this.notifyIcon1.Dispose();
        }

        private void tsMYongHuGuanLi_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmYongHuGuanLi>();
        }

        private void tsmKeShiGuanLi_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmKeShi>();
        }

        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePassword frm = new FrmChangePassword();
            frm.ShowDialog();
        }

        private void tsMenuExit_Click(object sender, EventArgs e)
        {
            if (!ShowQuestion("确实要退出系统吗?", "退出确认"))
            {
                return;
            }
            IsApplicationExit = true;
            this.Close();
        }

        private void tsmiDangAn_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmDangAnNew>();
        }

        private void tsmiTiKuGuanLi_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmTiKuGuanLi>();
        }

        private void tsMenuShiTiMuBan_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmShiTiMuBan>();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.ShowInTaskbar == false && notifyIcon1.Visible == true)
            {
                string oldOperatorId = _AL.GetOperatorId();
                FrmLogin verifyLoginForm = new FrmLogin();
                verifyLoginForm.StartPosition = FormStartPosition.CenterScreen;
                verifyLoginForm.TopMost = true;
                if (verifyLoginForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (oldOperatorId != _AL.GetOperatorId())
                    {
                        //如果不是用原操作解锁
                        IDockContent[] documents = this.dockPanel1.DocumentsToArray();
                        foreach (IDockContent content in documents)
                        {
                            content.DockHandler.Close();
                        }
                        SetLoginState();
                    }
                    //还原窗体显示 
                    this.WindowState = FormWindowState.Maximized;
                    //激活窗体并给予它焦点 
                    this.Activate();
                    //任务栏区显示图标 
                    this.ShowInTaskbar = true;
                    //托盘区图标隐藏 
                    notifyIcon1.Visible = false;

                    //打开一个窗口再关闭,当最小化托盘后再打开,dockpanel的子窗口会显示不正常
                    FrmBase frm = FormsCommon.CreateSingletonForm<FrmLogin>();
                    frm.Show(this.dockPanel1);
                    frm.Close();
                }
            }
        }
        private void tsBtnLock_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //隐藏任务栏区图标 
            this.ShowInTaskbar = false;
            //图标显示在托盘区 
            notifyIcon1.Visible = true;
        }
        private void tsmiRoleRight_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmJueSeGuanLi>();
        }
        private void tsMenuPeiXunJiHua_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmPeiXunJiHua>();
        }
        private void tsMenuJiHuaQueRen_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmPeiXunJiHuaQueRen>();
        }
        private void tsMenuShiJuanPingFen_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmShiTiPingFen>();
        }
        private void tsmiZhiLiangBiaoZhun_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmZhiLiangBiaoZhun>();
        }
        private void tsmiZhiKongJiHua_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmZhiKongJiHua>();
        }
        private void tsmiZhiKongJianCha_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmZhiKongJianCha>();
        }
        private void tsmiAutoUpdate_Click(object sender, EventArgs e)
        {
            AppUpdater.Instance.CheckUpdate();
        }
        private void tsmPingFenMingXi_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmVPingFenMingXiChaKan>();
        }
        private void tsmiJianChaQueRen_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmZhiKongJianChaQueRen2>();
        }
        private void tsmiPingFenHuiZong_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmVPingFenHuiZong>();
        }

        private void tsmiZhiKongWenTiHuiZong_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmVZhiKongWenTiHuiZong>();
        }

        private void tsmiJiHuaQueRen2_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmPeiXunJihuaQueRenByZaiXian>();
        }

        private void tsmiDepart_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmDepart>();
        }

        private void tsmiZhiKongJianChaChaXun_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmVZhiKongKeShiHeGeLv>();
        }

        private void tsmiJiNengBiaoZhun_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmJiNengBiaoZhun>();
        }

        private void tsmiTest_Click(object sender, EventArgs e)
        {
            ALCommon.TestProc();
        }

        private void tsmiYaChuangTongJi_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmYaChuangTongJi>();
        }

        private void tsmiDiDaoTongJi_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmDieDaoTongJi>();
        }

        private void tsmiRiDongTaiHuiZong_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmRiDongTaiHuiZong>();
        }

        private void tsmiHuLiGuanLuTongJi_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmHuLiGuanLuTongJi>();
        }

        private void tsBtnDangAn_Click(object sender, EventArgs e)
        {
            tsmiDangAn_Click(sender, e);
        }

        private void tsmiRegisterPringCom_Click(object sender, EventArgs e)
        {
            //注册打印组件（COM）
            string grdes6File = System.AppDomain.CurrentDomain.BaseDirectory + @"\Grid++6.0注册\grdes6.dll";
            string gregn6File = System.AppDomain.CurrentDomain.BaseDirectory + @"\Grid++6.0注册\gregn6.dll";
            //C:\windows\syswow64\Regsvr32.exe // 64 位；
            //C:\windows\system32\Regsvr32.exe // 64 位
            string registerExe;
            string diskKey = Environment.SystemDirectory.Substring(0, 1); //盘符，解决系统不再c盘的情况
            if (IntPtr.Size == 8)
            {
                //64 bit
                registerExe = diskKey + @":\windows\syswow64\Regsvr32.exe ";
            }
            else if (IntPtr.Size == 4)
            {
                //32 bit
                registerExe = diskKey + @":\windows\system32\Regsvr32.exe ";
            }
            else
            {
                //...NotSupport
                registerExe = "Regsvr32.exe";
            }
            string cmd = string.Format("{0} {1}\r\n{0} {2}", registerExe, grdes6File, gregn6File);
            //MessageBox.Show(cmd);
            System.Diagnostics.Process.Start(registerExe, grdes6File);
            System.Diagnostics.Process.Start(registerExe, gregn6File);
        }

        private void tsmiAbort_Click(object sender, EventArgs e)
        {
            (new AboutBox()).ShowDialog();
        }

        private void tsmiZhiKongJianCha_KeShi_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmZhiKongJianCha_KeShi>();
        }

        private void tsmiWeiKaoMingXi_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmWeiKaoMingXi>();
        }

        private void tsmiGongZuoLiang_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmGongZuoLiang>();
        }

        private void tsmiFileMgr_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmFileMgr>();
        }

        private void tsmiHuLiGuanLuTongJiKeShi_Click(object sender, EventArgs e)
        {
            ShowMDISubForm<FrmHuLiGuanLuTongJiKeShi>();
        }
    }
}