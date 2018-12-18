using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL;
using HursingManage.DBModel;

namespace NursingManage.Win.TongJiByHis
{
    public partial class FrmGongZuoLiang : BaseListForm
    {
        public FrmGongZuoLiang()
        {
            InitializeComponent();
        }

        ALGongZuoLiang _AL;
        /// <summary>
        /// 当前查询提示信息
        /// </summary>
        string _CurrentSearchPrompt;

        void InitTreeView()
        {
            List<T_KESHI> keShiList = _AL.GetDepartList();
            List<T_DANGAN> dangAnList = _AL.GetDangAnList();
            foreach (var keShi in keShiList)
            {
                TreeNode keShiNode = new TreeNode();
                keShiNode.Name = keShi.BIANMA;
                keShiNode.Text = keShi.MINGCHENG;
                keShiNode.Tag = keShi;
                var searchResult = dangAnList.Where(s => s.KESHIID == keShi.ID);
                if (searchResult != null && searchResult.Count() > 0)
                {
                    foreach (var dangAn in searchResult)
                    {
                        TreeNode dangAnNode = new TreeNode();
                        dangAnNode.Name = dangAn.HIS_SYS_NAME;
                        dangAnNode.Text = dangAn.XINGMING;
                        dangAnNode.Tag = dangAn;
                        keShiNode.Nodes.Add(dangAnNode);
                    }
                }
                tv.Nodes.Add(keShiNode);
            }
        }

        void BindDataByTree()
        {
            List<T_KESHI> keShiList = _AL.GetDepartList();
            tv.Nodes.Clear();
            foreach (var keShi in keShiList)
            {
                if (string.IsNullOrWhiteSpace(keShi.LEIXING1))
                {
                    TreeNode tn = new TreeNode();
                    tn.Name = keShi.MINGCHENG;
                    tn.Text = keShi.MINGCHENG;
                    tn.Tag = keShi;
                    tv.Nodes.Add(tn);
                    continue;
                }
                TreeNode node1Level;
                if (tv.Nodes.ContainsKey(keShi.LEIXING1))
                {
                    node1Level = tv.Nodes[keShi.LEIXING1];
                }
                else
                {
                    node1Level = new TreeNode();
                    node1Level.Name = keShi.LEIXING1;
                    node1Level.Text = keShi.LEIXING1;
                    tv.Nodes.Add(node1Level);
                }
                if (string.IsNullOrWhiteSpace(keShi.LEIXING2))
                {
                    TreeNode tn = new TreeNode();
                    tn.Name = keShi.MINGCHENG;
                    tn.Text = keShi.MINGCHENG;
                    tn.Tag = keShi;
                    node1Level.Nodes.Add(tn);
                    continue;
                }
                TreeNode node2Level;
                if (node1Level.Nodes.ContainsKey(keShi.LEIXING2))
                {
                    node2Level = node1Level.Nodes[keShi.LEIXING2];
                }
                else
                {
                    node2Level = new TreeNode();
                    node2Level.Name = keShi.LEIXING2;
                    node2Level.Text = keShi.LEIXING2;
                    node1Level.Nodes.Add(node2Level);
                }
                TreeNode node3Level = new TreeNode();
                node3Level.Name = keShi.MINGCHENG;
                node3Level.Text = keShi.MINGCHENG;
                node3Level.Tag = keShi;
                node2Level.Nodes.Add(node3Level);
            }
        }

        private void FrmGongZuoLiang_Load(object sender, EventArgs e)
        {
            //dgv.AutoGenerateColumns = true;
            //重置查询 将从历史数据中获取或重新查询的选项，目前先隐藏了该选项，调试阶段不启用。
            tscoBoxRestSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            tscoBoxRestSearch.SelectedIndex = 0;
            tscoBoxRestSearch.Visible = false;
            tsbtnConfig.Visible = IsAdminLogin;
            _AL = new ALGongZuoLiang();
            int hisSearchMonth = 12;
            DateTime dt = DateTime.Now.AddMonths(hisSearchMonth * -1);
            for (int i = 0; i <=hisSearchMonth; i++)
            {
                tsCoBoxMonth.Items.Add(dt.AddMonths(i).ToString("yyyy-MM"));
            }
            tsCoBoxMonth.Text = DateTime.Now.ToString("yyyy-MM");
            InitTreeView();
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnSearchProc_Click(object sender, EventArgs e)
        {   
            var searchMonths = tsCoBoxMonth.Text;
            searchMonths = string.Format("{0}-01", searchMonths);
            DateTime dtDate;
            if (!DateTime.TryParse(searchMonths, out dtDate))
            {
                ShowMessage("输入的日期格式不正确。");
                tsCoBoxMonth.Focus();
                return;
            }
            //if (tv.SelectedNode.Level != 1)ming 
            //{
            //    ShowMessage("请选中一个护士");
            //    return;
            //}
            T_GONGZUOLIANG param = new T_GONGZUOLIANG();
            param.STARTDATE = dtDate.ToString("yyyy-MM-dd");
            param.ENDDATE = dtDate.AddMonths(1).ToString("yyyy-MM-dd");
            if (tv.SelectedNode.Level == 0)//ming
                param.KESHIBIANMA = tv.SelectedNode.Name;
            else
            {
                param.KESHIBIANMA = tv.SelectedNode.Parent.Name;
                param.HUSHIBIANMA = tv.SelectedNode.Name;
                param.HUSHI = tv.SelectedNode.Text;
            }
            //if (string.IsNullOrWhiteSpace(param.HUSHIBIANMA))ming
            //{
            //    ShowMessage("当前护士对应的his编号为空。");
            //    return;
            //}
            tslbState.Text = string.Format("科室编码：{0}，护士：{1}",param.KESHIBIANMA, param.HUSHI);
            bool isRest = tscoBoxRestSearch.SelectedIndex == 1;

            List<T_GONGZUOLIANG_DETAIL> rList= null;

            StartRunWork(
                    () =>
                    {
                        rList = _AL.GetGongZuoLiang(param, isRest);
                    },
                    () =>
                    {
                        dgv.DataSource = rList;
                        _CurrentSearchPrompt = string.Format("{0}({1})", param.HUSHI, tsCoBoxMonth.Text);
                    });
        }

        private void tsbtnConfig_Click(object sender, EventArgs e)
        {
            FrmMain.ShowMDIForm<FrmGongZuoLiangPeiZhi>();
        }

        private void tsBtnExcelOut_Click(object sender, EventArgs e)
        {

            if (ExcelOut.OutExcelByGridView(dgv, string.Format("工作量统计{0:yyyyMMdd}",DateTime.Now), _CurrentSearchPrompt))
            {
                ShowMessage("导出成功。");
            }
        }
    }
}