using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Framework.Common.Helpers
{
    public class RegexHelper
    {
        /// <summary>
        /// 根据正则表达式取得 一条匹配的分组列表,如只有1条则表示并没有分组
        /// </summary>        
        public static List<string> GetMatch(string inputStr, string regexStr)
        {
            List<string> list = new List<string>();
            Match match = Regex.Match(inputStr, regexStr);
            if (match.Success)
            {
                for (int i = 0; i < match.Groups.Count; i++)
                {
                    list.Add(match.Groups[i].Value);
                }
            }
            return list;
        }
        /// <summary>
        /// 获得指定分组索引的匹配字符串
        /// </summary>        
        public static string GetMatch(string inputStr, string regexStr, int groupIndex)
        {
            List<string> list = GetMatch(inputStr, regexStr);
            if (list.Count > 0 && groupIndex >= 0 && groupIndex < list.Count)
            {
                return list[groupIndex];
            }
            return string.Empty;
        }
        /// <summary>
        /// 根据正则表达式获得所有匹配项且包含所有匹配项的分组集
        /// </summary>        
        public static List<List<string>> GetAllMatchAndGroup(string inputStr, string regexStr)
        {
            List<List<string>> list = new List<List<string>>();
            MatchCollection mc = Regex.Matches(inputStr, regexStr);
            for (int i = 0; i < mc.Count; i++)
            {
                if (mc[i].Success)
                {
                    Match match = mc[i];
                    List<string> matchGroupList = new List<string>();
                    for (int j = 0; j < match.Groups.Count; j++)
                    {
                        matchGroupList.Add(match.Groups[j].Value);
                    }
                    list.Add(matchGroupList);
                }
            }
            return list;
        }
        // <summary>
        /// 根据正则表达式获得所有匹配项且包含所有匹配项的分组集,指定分组索引
        /// </summary>        
        public static List<string> GetAllMatchAndGroup(string inputStr, string regexStr, int groupIndex)
        {
            List<string> resultList = new List<string>();
            List<List<string>> list = GetAllMatchAndGroup(inputStr, regexStr);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Count > 0 && groupIndex >= 0 && groupIndex < list[i].Count)
                {
                    resultList.Add(list[i][groupIndex]);
                }
            }
            return resultList;
        }
        /// <summary>
        /// 替换指定字符串
        /// </summary>
        public static string ReplaceStr(string inputStr, string regexStr, string replaceValue)
        {
            Regex r = new Regex(regexStr);
            return r.Replace(inputStr, replaceValue);
        }
        /// <summary>
        /// 验证字符串是否匹配正则规则
        /// </summary>
        public static bool Check(string inputStr, string regexStr)
        {
            try
            {
                Match match = Regex.Match(inputStr, regexStr);
                if (match.Success)
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

            return false;
        }
    }
}
