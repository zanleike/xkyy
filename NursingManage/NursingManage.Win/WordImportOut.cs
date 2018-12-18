using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using MSWord = Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;
using Framework.Common;
using System.Windows.Forms;
using System.Data;
using HursingManage.DBModel;
namespace NursingManage.Win
{
    class WordImportOut
    {
        public static bool ShiTi(string title, List<V_SHITI_MUBAN_MINGXI> shiTiList, bool isDisplayAnswer = false)
        {
            try
            {

                object path;                              //文件路径变量
                string strContent;                        //文本内容变量
                MSWord.Application wordApp;                   //Word应用程序变量 
                MSWord.Document wordDoc;                  //Word文档变量

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "word文件|*.doc";
                sfd.FileName = string.Format("{0}.doc", title);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;
                }
                else
                {
                    return false;
                    //path = Environment.CurrentDirectory + "\\MyWord_Print.doc";
                }
                wordApp = new MSWord.ApplicationClass(); //初始化

                wordApp.Visible = true;//使文档可见

                //如果已存在，则删除
                if (File.Exists((string)path))
                {
                    File.Delete((string)path);
                }

                //由于使用的是COM库，因此有许多变量需要用Missing.Value代替
                Object Nothing = Missing.Value;
                wordDoc = wordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);

                #region 页面设置、页眉图片和文字设置，最后跳出页眉设置

                //页面设置
                wordDoc.PageSetup.PaperSize = MSWord.WdPaperSize.wdPaperA4;//设置纸张样式为A4纸
                wordDoc.PageSetup.Orientation = MSWord.WdOrientation.wdOrientPortrait;//排列方式为垂直方向
                wordDoc.PageSetup.TopMargin = 57.0f;
                wordDoc.PageSetup.BottomMargin = 57.0f;
                wordDoc.PageSetup.LeftMargin = 57.0f;
                wordDoc.PageSetup.RightMargin = 57.0f;
                wordDoc.PageSetup.HeaderDistance = 30.0f;//页眉位置
                #endregion
                #region 页码设置并添加页码

                //为当前页添加页码
                MSWord.PageNumbers pns = wordApp.Selection.Sections[1].Headers[MSWord.WdHeaderFooterIndex.wdHeaderFooterEvenPages].PageNumbers;//获取当前页的号码
                pns.NumberStyle = MSWord.WdPageNumberStyle.wdPageNumberStyleNumberInDash;//设置页码的风格，是Dash形还是圆形的
                pns.HeadingLevelForChapter = 0;
                pns.IncludeChapterNumber = false;
                pns.RestartNumberingAtSection = false;
                pns.StartingNumber = 0; //开始页页码？
                object pagenmbetal = MSWord.WdPageNumberAlignment.wdAlignPageNumberCenter;//将号码设置在中间
                object first = true;
                wordApp.Selection.Sections[1].Footers[MSWord.WdHeaderFooterIndex.wdHeaderFooterEvenPages].PageNumbers.Add(ref pagenmbetal, ref first);

                #endregion

                #region 行间距与缩进、文本字体、字号、加粗、斜体、颜色、下划线、下划线颜色设置

                wordApp.Selection.ParagraphFormat.LineSpacing = 16f;//设置文档的行间距
                wordApp.Selection.ParagraphFormat.FirstLineIndent = 30;//首行缩进的长度
                                                                       //写入普通文本
                wordApp.Selection.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphLeft;


                object unite = MSWord.WdUnits.wdStory;
                wordApp.Selection.EndKey(ref unite, ref Nothing);//将光标移到文本末尾
                wordApp.Selection.ParagraphFormat.FirstLineIndent = 0;//取消首行缩进的长度
                strContent = title + "\n";
                wordDoc.Paragraphs.Last.Range.Font.Name = "黑体";
                wordDoc.Paragraphs.Last.Range.Font.Size = 12;
                wordDoc.Paragraphs.Last.Range.Font.Bold = 1;
                wordDoc.Paragraphs.Last.Range.Text = strContent;

                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    for (int j = 0; j < dt.Columns.Count; j++)
                //    {
                //        if (dt.Rows[i][j] == null || dt.Rows[i][j] == DBNull.Value) continue;
                //        wordApp.Selection.EndKey(ref unite, ref Nothing);//将光标移到文本末尾
                //        wordApp.Selection.ParagraphFormat.FirstLineIndent = 0;//取消首行缩进的长度
                //        strContent = dt.Rows[i][j].ToString();
                //        wordDoc.Paragraphs.Last.Range.Font.Name = "黑体";
                //        wordDoc.Paragraphs.Last.Range.InsertAfter(strContent);

                //    }
                //}
                wordApp.Selection.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphCenter;
                wordDoc.Paragraphs.Last.Range.Font.Name = "宋体";
                wordDoc.Paragraphs.Last.Range.Font.Size = 10;
                wordDoc.Paragraphs.Last.Range.Font.Bold = 0;


                Dictionary<string, string> paramDict = new Dictionary<string, string>();
                //paramDict.Add("title", title);
                //DataTable dt = new DataTable();
                //dt.Columns.Add("ShiTiNeiRong");
                //dt.Columns.Add("ShiTiXuanXiang");
                //dt.Columns.Add("LeiXing");
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
                    //dt.Rows.Add(neiRong, xuanXiang.ToString(), leiXing);

                    wordDoc.Paragraphs.Last.Range.InsertAfter(neiRong);
                    wordDoc.Paragraphs.Last.Range.InsertAfter(leiXing + "\n");
                    wordDoc.Paragraphs.Last.Range.InsertAfter(xuanXiang.ToString() + "\n");




                    xuHao++;
                }



                wordApp.Selection.EndKey(ref unite, ref Nothing); //将光标移动到文档末尾
                #endregion



                //WdSaveFormat为Word 2003文档的保存格式
                object format = MSWord.WdSaveFormat.wdFormatDocument;// office 2007就是wdFormatDocumentDefault
                                                                     //将wordDoc文档对象的内容保存为DOCX文档
                wordDoc.SaveAs(ref path, ref format, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                //关闭wordDoc文档对象
                //看是不是要打印
                //wordDoc.PrintOut();



                wordDoc.Close(ref Nothing, ref Nothing, ref Nothing);
                //关闭wordApp组件对象
                wordApp.Quit(ref Nothing, ref Nothing, ref Nothing);
                //MessageBox.Show(" 创建完毕！");
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.LogObj.Error("导出文件失败,文件名:MyWord_Print.doc", ex);
                MessageBox.Show("导出文件失败," + ex.Message);
                return false;
            }
        }


        public static bool TiKu(string title, List<T_SHITI> shiTiList, bool isDisplayAnswer = false)
        {
            try
            {

                object path;                              //文件路径变量
                string strContent;                        //文本内容变量
                MSWord.Application wordApp;                   //Word应用程序变量 
                MSWord.Document wordDoc;                  //Word文档变量

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "word文件|*.doc";
                sfd.FileName = string.Format("{0}.doc", title);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;
                }
                else
                {
                    return false;
                    //path = Environment.CurrentDirectory + "\\MyWord_Print.doc";
                }
                wordApp = new MSWord.ApplicationClass(); //初始化

                wordApp.Visible = true;//使文档可见

                //如果已存在，则删除
                if (File.Exists((string)path))
                {
                    File.Delete((string)path);
                }

                //由于使用的是COM库，因此有许多变量需要用Missing.Value代替
                Object Nothing = Missing.Value;
                wordDoc = wordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);

                #region 页面设置、页眉图片和文字设置，最后跳出页眉设置

                //页面设置
                wordDoc.PageSetup.PaperSize = MSWord.WdPaperSize.wdPaperA4;//设置纸张样式为A4纸
                wordDoc.PageSetup.Orientation = MSWord.WdOrientation.wdOrientPortrait;//排列方式为垂直方向
                wordDoc.PageSetup.TopMargin = 57.0f;
                wordDoc.PageSetup.BottomMargin = 57.0f;
                wordDoc.PageSetup.LeftMargin = 57.0f;
                wordDoc.PageSetup.RightMargin = 57.0f;
                wordDoc.PageSetup.HeaderDistance = 30.0f;//页眉位置
                #endregion
                #region 页码设置并添加页码

                //为当前页添加页码
                MSWord.PageNumbers pns = wordApp.Selection.Sections[1].Headers[MSWord.WdHeaderFooterIndex.wdHeaderFooterEvenPages].PageNumbers;//获取当前页的号码
                pns.NumberStyle = MSWord.WdPageNumberStyle.wdPageNumberStyleNumberInDash;//设置页码的风格，是Dash形还是圆形的
                pns.HeadingLevelForChapter = 0;
                pns.IncludeChapterNumber = false;
                pns.RestartNumberingAtSection = false;
                pns.StartingNumber = 0; //开始页页码？
                object pagenmbetal = MSWord.WdPageNumberAlignment.wdAlignPageNumberCenter;//将号码设置在中间
                object first = true;
                wordApp.Selection.Sections[1].Footers[MSWord.WdHeaderFooterIndex.wdHeaderFooterEvenPages].PageNumbers.Add(ref pagenmbetal, ref first);

                #endregion

                #region 行间距与缩进、文本字体、字号、加粗、斜体、颜色、下划线、下划线颜色设置

                wordApp.Selection.ParagraphFormat.LineSpacing = 16f;//设置文档的行间距
                wordApp.Selection.ParagraphFormat.FirstLineIndent = 30;//首行缩进的长度
                                                                       //写入普通文本
                wordApp.Selection.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphLeft;


                object unite = MSWord.WdUnits.wdStory;
                wordApp.Selection.EndKey(ref unite, ref Nothing);//将光标移到文本末尾
                wordApp.Selection.ParagraphFormat.FirstLineIndent = 0;//取消首行缩进的长度
                strContent = title + "\n";
                wordDoc.Paragraphs.Last.Range.Font.Name = "黑体";
                wordDoc.Paragraphs.Last.Range.Font.Size = 12;
                wordDoc.Paragraphs.Last.Range.Font.Bold = 1;
                wordDoc.Paragraphs.Last.Range.Text = strContent;

                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    for (int j = 0; j < dt.Columns.Count; j++)
                //    {
                //        if (dt.Rows[i][j] == null || dt.Rows[i][j] == DBNull.Value) continue;
                //        wordApp.Selection.EndKey(ref unite, ref Nothing);//将光标移到文本末尾
                //        wordApp.Selection.ParagraphFormat.FirstLineIndent = 0;//取消首行缩进的长度
                //        strContent = dt.Rows[i][j].ToString();
                //        wordDoc.Paragraphs.Last.Range.Font.Name = "黑体";
                //        wordDoc.Paragraphs.Last.Range.InsertAfter(strContent);

                //    }
                //}
                wordApp.Selection.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphCenter;
                wordDoc.Paragraphs.Last.Range.Font.Name = "宋体";
                wordDoc.Paragraphs.Last.Range.Font.Size = 10;
                wordDoc.Paragraphs.Last.Range.Font.Bold = 0;


                Dictionary<string, string> paramDict = new Dictionary<string, string>();
                //paramDict.Add("title", title);
                //DataTable dt = new DataTable();
                //dt.Columns.Add("ShiTiNeiRong");
                //dt.Columns.Add("ShiTiXuanXiang");
                //dt.Columns.Add("LeiXing");
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
                    //string leiXing = string.Format("[{0}][分数：{1}]", shiti.LEIXING, shiti.FENSHU);
                    string leiXing = string.Format("[{0}]", shiti.LEIXING);
                    string neiRong;
                    if (!isDisplayAnswer)
                        neiRong = string.Format("{0}.{1} （）", xuHao, shiti.NEIRONG);
                    else neiRong = string.Format("{0}.{1} （{2}）", xuHao, shiti.NEIRONG, shiti.DAAN);
                    //dt.Rows.Add(neiRong, xuanXiang.ToString(), leiXing);

                    wordDoc.Paragraphs.Last.Range.InsertAfter(neiRong);
                    wordDoc.Paragraphs.Last.Range.InsertAfter(leiXing + "\n");
                    wordDoc.Paragraphs.Last.Range.InsertAfter(xuanXiang.ToString() + "\n");




                    xuHao++;
                }



                wordApp.Selection.EndKey(ref unite, ref Nothing); //将光标移动到文档末尾
                #endregion



                //WdSaveFormat为Word 2003文档的保存格式
                object format = MSWord.WdSaveFormat.wdFormatDocument;// office 2007就是wdFormatDocumentDefault
                                                                     //将wordDoc文档对象的内容保存为DOCX文档
                wordDoc.SaveAs(ref path, ref format, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                //关闭wordDoc文档对象
                //看是不是要打印
                //wordDoc.PrintOut();



                wordDoc.Close(ref Nothing, ref Nothing, ref Nothing);
                //关闭wordApp组件对象
                wordApp.Quit(ref Nothing, ref Nothing, ref Nothing);
                //MessageBox.Show(" 创建完毕！");
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.LogObj.Error("导出文件失败,文件名:MyWord_Print.doc", ex);
                MessageBox.Show("导出文件失败," + ex.Message);
                return false;
            }
        }
    }
}