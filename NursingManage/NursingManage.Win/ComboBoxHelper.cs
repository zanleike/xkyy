using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.AL;
using HursingManage.DBModel;
using System.Windows.Forms;

namespace NursingManage.Win
{
    class ComboBoxHelper
    {
        public static List<string> GetDictList(int dictType)
        {
            ALDictionary al = new ALDictionary();
            var dictList = al.GetDictList(dictType);
            List<string> rList = new List<string>();
            if (dictList != null)
            {
                foreach (var item in dictList)
                {
                    rList.Add(item.DICTVALUE);
                }
            }
            return rList;
        }
        public static void SetDictComboBox(ComboBox coBox, int dictTypeValue, string defaultItem = null)
        {
            var dictList = GetDictList(dictTypeValue);
            coBox.Items.Clear();
            if (!string.IsNullOrWhiteSpace(defaultItem))
            {
                coBox.Items.Add(defaultItem);
            }
            coBox.Items.AddRange(dictList.ToArray());
            if (coBox.Items.Count > 0)
            {
                coBox.SelectedIndex = 0;
            }
        }
        public static void SetDictComboBox(ComboBox coBox, DictType dictType, string defaultItem = null)
        {
            var dictTypeValue = (int)dictType;
            SetDictComboBox(coBox, dictTypeValue, defaultItem);
        }
    }
}