using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Framework.WinCommon.TreeData
{
    public class MenuItemHeler
    {
        static void AddChildData(List<TreeDataModel> MenuItemList, ToolStripMenuItem p_tn)
        {
            for (int i = 0; i < MenuItemList.Count; i++)
            {
                string text = MenuItemList[i].Text;
                string c_No = MenuItemList[i].CId;
                string p_No = MenuItemList[i].PId;
                if (p_No == p_tn.Name)
                {
                    ToolStripMenuItem tn = new ToolStripMenuItem();
                    tn.Name = c_No;
                    tn.Text = text;
                    tn.Tag = MenuItemList[i];
                    if (MenuItemList[i].OnClickEvent != null)
                        tn.Click += MenuItemList[i].OnClickEvent;
                    p_tn.DropDownItems.Add(tn);
                    AddChildData(MenuItemList, tn);
                }
            }
        }

        public static void AddToMenu(List<TreeDataModel> MenuItemList, MenuStrip menuStrip)
        {
            if (TreeDataCommon.CheckIdIsRepeat(MenuItemList)) return;
            for (int i = 0; i < MenuItemList.Count; i++)
            {
                if (MenuItemList[i].PId == null || MenuItemList[i].PId == "0" || MenuItemList[i].IsRoot)
                {
                    ToolStripMenuItem p_tn = new ToolStripMenuItem();
                    p_tn.Name = MenuItemList[i].CId;
                    p_tn.Text = MenuItemList[i].Text;
                    p_tn.Tag = MenuItemList[i];
                    if (MenuItemList[i].OnClickEvent != null)
                        p_tn.Click += new EventHandler(MenuItemList[i].OnClickEvent);
                    AddChildData(MenuItemList, p_tn);
                    menuStrip.Items.Add(p_tn);
                }
            }
        }
    }
}
