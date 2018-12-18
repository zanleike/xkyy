using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;
using Framework.WinCommon.TreeData;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    public partial class FrmZhiLiangBiaoZhunXuanZe : BaseEditForm
    {
        public FrmZhiLiangBiaoZhunXuanZe(EditModelHandle<List<T_ZHILIANGBIAOZHUN>> BaoCunBiaoZhunHandle, List<T_ZHILIANGBIAOZHUN> biaoZhunList)
        {
            InitializeComponent();
            this._BiaoZhunList = biaoZhunList;
            this.BaoCunBiaoZhunHandle = BaoCunBiaoZhunHandle;
        }

        //保存问题标准        
        EditModelHandle<List<T_ZHILIANGBIAOZHUN>> BaoCunBiaoZhunHandle;

        // 质量标准列表
        List<T_ZHILIANGBIAOZHUN> _BiaoZhunList;

        void BindTreeView()
        {
            var leiBieList = _BiaoZhunList.Select(s => s.LEIBIE).Distinct().OrderBy(s => s);
            foreach (var leiBie in leiBieList)
            {
                TreeNode leiBieNode = new TreeNode();
                leiBieNode.Name = leiBie;
                leiBieNode.Text = leiBie;
                tv.Nodes.Add(leiBieNode);
                var leiXing1List = _BiaoZhunList.Where(s => s.LEIBIE == leiBie).OrderBy(s => s.XUHAO);
                var leiXing1NameList = leiXing1List.Select(s => s.LEIXING1).Distinct();
                foreach (var leiXing1 in leiXing1NameList)
                {
                    TreeNode leiXing1Node = new TreeNode();
                    leiXing1Node.Name = leiXing1;
                    leiXing1Node.Text = leiXing1;
                    leiBieNode.Nodes.Add(leiXing1Node);

                    var leiXing2List = leiXing1List.Where(s => s.LEIXING1 == leiXing1);
                    var leiXing2NameList = leiXing2List.Select(s => s.LEIXING2).Distinct();
                    foreach (var leiXing2 in leiXing2NameList)
                    {
                        if (string.IsNullOrWhiteSpace(leiXing2))
                        {
                            foreach (var biaoZhun in leiXing2List)
                            {
                                TreeNode biaoZhunNode = new TreeNode();
                                biaoZhunNode.Text = string.Format("{0}.{1}", biaoZhun.XUHAO, biaoZhun.NEIRONG);
                                biaoZhunNode.Name = biaoZhun.ID;
                                biaoZhunNode.Tag = biaoZhun;
                                leiXing1Node.Nodes.Add(biaoZhunNode);
                            }
                        }
                        else
                        {
                            TreeNode leiXing2Node = new TreeNode();
                            leiXing2Node.Name = leiXing2;
                            leiXing2Node.Text = leiXing2;
                            leiXing1Node.Nodes.Add(leiXing2Node);
                            var biaoZhunList = leiXing2List.Where(s => s.LEIXING2 == leiXing2);
                            foreach (var biaoZhun in biaoZhunList)
                            {
                                TreeNode biaoZhunNode = new TreeNode();
                                biaoZhunNode.Text = string.Format("{0}.{1}", biaoZhun.XUHAO, biaoZhun.NEIRONG);
                                biaoZhunNode.Name = biaoZhun.ID;
                                biaoZhunNode.Tag = biaoZhun;
                                leiXing2Node.Nodes.Add(biaoZhunNode);
                            }
                        }
                    }
                    //leiXing1Node.Expand();
                }
                leiBieNode.Expand();
            }
        }

        private void FrmZhiLiangBiaoZhunXuanZe_Load(object sender, EventArgs e)
        {
            if (_BiaoZhunList == null)
            {
                MessageBox.Show("标准列表为空！");
                this.Close();
                return;
            }
            BindTreeView();
            TreeViewHelper.SetRelationCheckState(tv);
        }

        private void btnBaoCun_Click(object sender, EventArgs e)
        {
            List<TreeNode> seletedNodes = new List<TreeNode>();
            TreeViewHelper.GetCheckedNodes(seletedNodes, tv);
            if (seletedNodes == null || seletedNodes.Count == 0)
            {
                ShowMessage("没有选中任何内容。");
                return;
            }
            List<T_ZHILIANGBIAOZHUN> biaoZhunList = new List<T_ZHILIANGBIAOZHUN>();
            foreach (var item in seletedNodes)
            {
                var biaoZhun = item.Tag as T_ZHILIANGBIAOZHUN;
                if (biaoZhun != null) biaoZhunList.Add(biaoZhun);
            }

            var groupData = biaoZhunList.GroupBy(s => s.LEIBIE).Select(g => (new { name = g.Key, count = g.Count() })).ToList();            
            foreach (var item in groupData)
            {
                if (item.count > 10)
                {
                    if (ShowQuestion("当前选择记录超过10个，是否继续?", "选择过多提示"))
                    {
                        break;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            //a[0].
            string errMsg;
            if (BaoCunBiaoZhunHandle(biaoZhunList, out errMsg))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<string> SearchHisIds = new List<string>();
        void FindSearch()
        {
            string searchValue = tstxtSearch.Text;
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                return;
            }
            TreeViewHelper.SearchNodeToHandle(tv, (node) =>
            {
                var biaoZhun = node.Tag as T_ZHILIANGBIAOZHUN;
                if (biaoZhun != null)
                {
                    int xuHao;
                    if (int.TryParse(searchValue, out xuHao))
                    {
                        if (biaoZhun.XUHAO == xuHao && !SearchHisIds.Contains(biaoZhun.ID))
                        {
                            tv.Focus();
                            tv.SelectedNode = node;
                            SearchHisIds.Add(biaoZhun.ID);
                            return true;
                        }
                    }
                    else
                    {
                        if (biaoZhun.NEIRONG.Contains(searchValue) && !SearchHisIds.Contains(biaoZhun.ID))
                        {
                            tv.Focus();
                            tv.SelectedNode = node;
                            SearchHisIds.Add(biaoZhun.ID);
                            return true;
                        }
                    }
                }
                return false;
            });
        }

        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            SearchHisIds.Clear();
            FindSearch();
        }

        private void tstxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsBtnSearch_Click(sender, e);
            }
        }

        private void tv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                FindSearch();
            }
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            e.Node.Expand();
        }

        private void tv_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
            {
                e.Node.Expand();
            }
        }
    }
}