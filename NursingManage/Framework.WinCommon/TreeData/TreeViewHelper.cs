using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework.WinCommon.TreeData
{
    public class TreeViewHelper
    {
        /// <summary>
        /// 设置treeview为级联选择状态，
        /// 即：当父节点选中后所有子节点都会被选中，当子节点选中后父级节点必被选中
        /// </summary>
        /// <param name="tv"></param>
        public static void SetRelationCheckState(TreeView tv)
        {
            tv.AfterCheck += (sender, e) =>
            {
                if (e.Action != TreeViewAction.Unknown)
                {
                    if (e.Node.Parent != null && e.Node.Checked == true)
                    {
                        e.Node.Parent.Checked = true;
                    }
                    if (e.Node.Nodes != null && e.Node.Nodes.Count > 0)
                    {
                        CheckedAllSubNode(e.Node);
                    }
                }
            };
        }

        /// <summary>
        /// 设置TreeView所有选中项为取消选中状态
        /// </summary>
        public static void SetAllCancelChecked(TreeView tv)
        {
            foreach (TreeNode item in tv.Nodes)
            {
                item.Checked = false;
                CheckedAllSubNode(item);
            }
        }
        /// <summary>
        /// 设置所有子节点与当前节点相同的状态
        /// </summary>
        public static void CheckedAllSubNode(TreeNode tn)
        {
            if (tn.Nodes.Count > 0)
            {
                foreach (TreeNode item in tn.Nodes)
                {
                    item.Checked = tn.Checked;
                    CheckedAllSubNode(item);
                }
            }
        }
        /// <summary>
        /// 获取指定节点下的所有节点的选中项,返回到一个list中
        /// </summary>
        /// <param name="outNodes">返回的节点对象</param>
        /// <param name="node">根节点</param>
        public static void GetCheckedNodes(List<TreeNode> outNodes, TreeNode node)
        {
            if (outNodes == null) outNodes = new List<TreeNode>();
            if (node.Nodes.Count > 0)
            {
                foreach (TreeNode item in node.Nodes)
                {
                    if (item.Checked)
                    {
                        outNodes.Add(item);
                        //GetCheckedNodes(outNodes, item);
                    }
                    GetCheckedNodes(outNodes, item);
                }
            }
        }
        /// <summary>
        /// 获取treeview下的所有复选框选中项
        /// </summary>
        /// <param name="outNodes">返回的节点对象</param>
        /// <param name="tv">treeview对象</param>
        public static void GetCheckedNodes(List<TreeNode> outNodes, TreeView tv)
        {
            foreach (TreeNode item in tv.Nodes)
            {
                if (item.Checked)
                {
                    outNodes.Add(item);
                }
                GetCheckedNodes(outNodes, item);
            }
        }
        /// <summary>
        /// 选中所有指定
        /// </summary>
        public static void SetCheckedState(TreeView tv, string key, bool checkState)
        {
            foreach (TreeNode item in tv.Nodes)
            {
                if (item.Name.Equals(key, StringComparison.CurrentCultureIgnoreCase))
                {
                    item.Checked = checkState;
                    return;
                }
                if (SetCheckedState(item, key, checkState))
                {
                    return;
                }
            }
        }
        public static bool SetCheckedState(TreeNode targetNode, string key, bool checkState)
        {
            if (targetNode.Nodes.Count > 0)
            {
                foreach (TreeNode item in targetNode.Nodes)
                {
                    if (item.Name.Equals(key, StringComparison.CurrentCultureIgnoreCase))
                    {
                        item.Checked = checkState;
                        return true;
                    }
                    if (SetCheckedState(item, key, checkState))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void SetCheckedState(TreeView tv, string[] keys, bool checkState)
        {
            foreach (var item in keys)
            {
                SetCheckedState(tv, item, checkState);
            }
        }
        /// <summary>
        /// 遍历所有节点，当FindResultHandle返回true时结束遍历
        /// </summary>
        public static void SearchNodeToHandle(TreeView tv, TreeNodeSearchHandle FindResultHandle)
        {
            foreach (TreeNode item in tv.Nodes)
            {
                if (FindResultHandle(item))
                {
                    return;
                }
                else
                {
                    if (SearchNodeToHandle(item, FindResultHandle))
                    {
                        return;
                    }
                }
            }
        }
        static bool SearchNodeToHandle(TreeNode tn, TreeNodeSearchHandle FindResultHandle)
        {
            foreach (TreeNode item in tn.Nodes)
            {
                if (FindResultHandle(item))
                {
                    return true;
                }
                else
                {
                    if (SearchNodeToHandle(item, FindResultHandle))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
    /// <summary>
    /// 遍历节点，知道匹配到指定节点，返回true则表示不再继续查找，否则再进行下一个查找
    /// </summary>
    /// <param name="tn"></param>
    /// <returns></returns>
    public delegate bool TreeNodeSearchHandle(TreeNode tn);
}