using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HursingManage.DBModel;
using Framework.Common;

namespace NursingManage.Win
{
    public class PrintHelper
    {
        public static void ShiTi(string title, List<V_SHITI_MUBAN_MINGXI> shiTiList, bool isDisplayAnswer = false)
        {
            Dictionary<string, string> paramDict = new Dictionary<string, string>();
            paramDict.Add("title", title);
            DataTable dt = new DataTable();
            dt.Columns.Add("ShiTiNeiRong");
            dt.Columns.Add("ShiTiXuanXiang");
            dt.Columns.Add("LeiXing");
            int xuHao = 1; //可将序号代替为：SHITIXUHAO
            StringBuilder xuanXiang = new StringBuilder();
            foreach (var shiti in shiTiList)
            {
                xuanXiang.Clear();
                xuanXiang.AppendFormat("A.{0}  ", shiti.XIANGMUA);
                xuanXiang.AppendFormat("B.{0}  ", shiti.XIANGMUB);
                if (shiti.LEIXING != "判断题")
                {
                    if (!string.IsNullOrWhiteSpace(shiti.XIANGMUC))
                        xuanXiang.AppendFormat("C.{0}  ", shiti.XIANGMUC);
                    if (!string.IsNullOrWhiteSpace(shiti.XIANGMUD))
                        xuanXiang.AppendFormat("D.{0}  ", shiti.XIANGMUD);
                    if (!string.IsNullOrWhiteSpace(shiti.XIANGMUE))
                        xuanXiang.AppendFormat("E.{0}  ", shiti.XIANGMUE);
                    if (!string.IsNullOrWhiteSpace(shiti.XIANGMUF))
                        xuanXiang.AppendFormat("E.{0}", shiti.XIANGMUF);
                }
                string leiXing = string.Format("[{0}][分数：{1}]", shiti.LEIXING, shiti.FENSHU);
                string neiRong;
                if (!isDisplayAnswer)
                    neiRong = string.Format("{0}.{1} （）", xuHao, shiti.NEIRONG);
                else neiRong = string.Format("{0}.{1} （{2}）", xuHao, shiti.NEIRONG, shiti.DAAN);
                dt.Rows.Add(neiRong, xuanXiang.ToString(), leiXing);
                xuHao++;
            }
            string path = AppDomain.CurrentDomain.BaseDirectory + "PrintTemplates\\培训试题.grf";
            PrintForm frm = new PrintForm(path, dt, paramDict);
            frm.ShowDialog();
        }

        public static void ZhiKongJiLuByKeShi(T_ZHIKONG_KESHI jiLuModel, List<T_ZHIKONG_KESHI_NEIRONG> neiRongList, List<T_ZHIKONG_KESHI_WENTI> wenTiList)
        {
            Dictionary<string, string> paramDict = new Dictionary<string, string>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "PrintTemplates\\质控检查记录_科室.grf";
            paramDict.Add("科室", jiLuModel.KESHI);
            paramDict.Add("检查日期", jiLuModel.JIANCHARIQI.ToString("yyyy-MM-dd"));
            paramDict.Add("质控人员", jiLuModel.ZHIKONGRENYUAN);
            paramDict.Add("讲评人", jiLuModel.JIANGPINGREN);
            paramDict.Add("讲评时间", jiLuModel.JIANGPINGSHIJIAN.ToString("yyyy-MM-dd"));
            paramDict.Add("参加人员", jiLuModel.CANJIARENYUAN);
            StringPlus jianChaNeiRong = new StringPlus();
            StringPlus jianChaJieGuo = new StringPlus();
            if (neiRongList != null)
            {
                //var neiRongOrderList = neiRongList.OrderBy(s => s.BIAOZHUNLEIBIE).ToList();
                int orderNo = 0;
                foreach (var item in neiRongList)
                {
                    orderNo++;
                    jianChaNeiRong.AppendLine("{0}.{1};", orderNo, item.BIAOZHUNLEIBIE);
                    if (wenTiList != null && wenTiList.Count > 0)
                    {
                        var wenTiByLeiBie = wenTiList.Where(s => s.BIAOZHUNLEIBIEID == item.BIAOZHUNLEIBIEID);
                        foreach (var wenTi in wenTiByLeiBie)
                        {
                            jianChaJieGuo.Append("{0}.{1}；", orderNo, wenTi.WENTISHUOMING);
                        }
                        jianChaJieGuo.AppendLine("。（合格率:{0}%）", item.HEGELV);
                    }
                    else
                    {
                        jianChaJieGuo.Append("无问题。");
                        jianChaJieGuo.AppendLine("（合格率:{0}%）", item.HEGELV);
                    }
                }
            }
            paramDict.Add("检查内容", jianChaNeiRong.ToString());
            paramDict.Add("检查结果", jianChaJieGuo.ToString());
            paramDict.Add("问题分析", jiLuModel.YUANYINFENXI);
            paramDict.Add("改进措施", jiLuModel.GAIJINCUOSHI);
            PrintForm frm = new PrintForm(path, null, paramDict);
            frm.ShowDialog();
        }
        /// <summary>
        /// 质控记录打印（护理部）
        /// </summary>
        public static void ZhiKongJiLu(V_ZHIKONGJIHUA_KESHI jiLuModel, List<V_ZHIKONGJIHUA_NEIRONG> neiRongList, List<T_ZHIKONGJIHUA_JIEGUO> wenTiList)
        {
            Dictionary<string, string> paramDict = new Dictionary<string, string>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "PrintTemplates\\质控检查记录.grf";
            paramDict.Add("科室", jiLuModel.KESHI);
            paramDict.Add("检查日期", jiLuModel.JIANCHASHIJIAN);
            paramDict.Add("质控人员", jiLuModel.JIANCHARENYUAN);
            paramDict.Add("限期整改日期", jiLuModel.GAIJINSHIJIAN_XIANQI);
            paramDict.Add("检查人员", jiLuModel.JIANCHARENYUAN);

            StringPlus jianChaNeiRong = new StringPlus();
            StringPlus jianChaJieGuo = new StringPlus();
            if (neiRongList != null)
            {
                int orderNo = 0;
                foreach (var item in neiRongList)
                {
                    orderNo++;
                    jianChaNeiRong.AppendLine("{0}.{1}（合格率：{2}%）;", orderNo, item.BIAOZHUNLEIBIE, item.HEGELV);
                    if (wenTiList == null)
                    {
                        jianChaJieGuo.Append("{0}.无问题", orderNo, item.HEGELV);
                    }
                    else
                    {
                        int subOrderNo = 1;
                        var wenTiByLeiBie = wenTiList.Where(s => s.BIAOZHUNLEIBIEID == item.BIAOZHUNLEIBIEID);
                        jianChaJieGuo.Append("{0}.", orderNo);
                        if (wenTiByLeiBie != null && wenTiByLeiBie.Count() > 0)
                        {
                            //foreach (var wenTi in wenTiByLeiBie)
                            //问题类别数量
                            int wenTiByLeiBieCount = wenTiByLeiBie.Count();
                            for (int i = 0; i < wenTiByLeiBieCount; i++)
                            {
                                var wenTi = wenTiByLeiBie.ElementAt(i);
                                //去掉问题项行首与行尾的换行符
                                string JianChaJieGuo = wenTi.JIANCHAJIEGUO.Trim('\r').Trim('\n');
                                //问题项2条以上才显示序号
                                if (wenTiByLeiBieCount > 1)
                                {
                                    //如果第一条包含有换行，则将换行前的内容作为小标题输出
                                    if (i == 0 && JianChaJieGuo.Contains("\r\n"))
                                    {
                                        int IndexCrlf = JianChaJieGuo.IndexOf("\r\n");
                                        jianChaJieGuo.Append("{0}",JianChaJieGuo.Substring(0,IndexCrlf));
                                        jianChaJieGuo.Append("\r\n（{0}）", subOrderNo);
                                        jianChaJieGuo.Append("{0}", JianChaJieGuo.Substring(IndexCrlf).TrimStart());
                                        
                                        subOrderNo++;
                                        continue;
                                    }
                                    else
                                    {
                                        jianChaJieGuo.Append("\r\n（{0}）", subOrderNo);
                                    }
                                    
                                }
                                jianChaJieGuo.Append("{0}；", JianChaJieGuo.Replace("\r\n", ""));
                                subOrderNo++;
                            }
                        }
                        else
                        {
                            jianChaJieGuo.Append("无问题");
                        }
                    }
                    //jianChaJieGuo.DelLastChar("；");
                    jianChaJieGuo.AppendLine("（合格率:{0}%）", item.HEGELV);
                }
                jianChaNeiRong.Append("{0}.住院患者满意度调查。", orderNo + 1);
                jianChaJieGuo.Append("{0}.{1}。", orderNo + 1, jiLuModel.MANYIDUSHUOMING);
            }

            paramDict.Add("检查内容", jianChaNeiRong.ToString());
            paramDict.Add("检查结果", jianChaJieGuo.ToString());
            paramDict.Add("问题分析", jiLuModel.YUANYINFENXI);
            paramDict.Add("改进措施", jiLuModel.GAIJINSHUOMING);
            paramDict.Add("整改情况", jiLuModel.ZHENGGAIQINGKUANG);
            PrintForm frm = new PrintForm(path, null, paramDict);
            frm.ShowDialog();
        }
    }
}