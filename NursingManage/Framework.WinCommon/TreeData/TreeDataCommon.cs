using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework.WinCommon.TreeData
{
    internal class TreeDataCommon
    {
        /// <summary>
        /// 检查Id是否重复
        /// </summary>
        public static bool CheckIdIsRepeat(List<TreeDataModel> teeDataList)
        {
            for (int i = 0; i < teeDataList.Count; i++)
            {
                for (int j = i + 1; j < teeDataList.Count; j++)
                {
                    if (teeDataList[i].CId == teeDataList[j].CId) return true;
                }
            }
            return false;
        }
    }
}