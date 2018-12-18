using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Framework.Common.Helpers;
using Framework.Common;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmTiKuGuanLi_ShiTiZhengLi : BaseEditForm
    {
        public FrmTiKuGuanLi_ShiTiZhengLi()
        {
            InitializeComponent();
        }

        private void FrmTiKuGuanLi_ShiTiZhengLi_Load(object sender, EventArgs e)
        {
            //dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        }

        private void btnSelectTxtFile_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "文本文件|*.txt|所有文件|*.*";

            ////ofd.Filter = "Excel文件2003|*.xls|Excel文件2007|*.xlsx";
            //ofd.Multiselect = false;
            //if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    txtSelectTxtFile.Text = ofd.FileName;
            //    txtSaveToFile.Text = ofd.FileName.Substring(0, ofd.FileName.LastIndexOf('.'));
            //}
        }

        //private void btnOK_Click(object sender, EventArgs e)
        //{

        //}
        class ShiTiNeiRong
        {
            public string XuHao { set; get; }
            public string NeiRong { set; get; }
            public string DaAn { set; get; }
            public string XuanXiangA { set; get; }
            public string XuanXiangB { set; get; }
            public string XuanXiangC { set; get; }
            public string XuanXiangD { set; get; }
            public string XuanXiangE { set; get; }
            public string XuanXiangF { set; get; }
        }

        private void tsbnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";            
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                List<ShiTiNeiRong> rList = new List<ShiTiNeiRong>();
                using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default))
                {
                    string allText = sr.ReadToEnd();
                    allText = allText.Replace(" ","");
                    string[] neiRongList = allText.Split(new string[] { "\r\n\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    
                    foreach (var item in neiRongList)
                    {
                        try
                        {
                            string[] splitSub = item.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                            if (splitSub == null || splitSub.Length < 2)
                            {
                                rList.Add(null);
                            }
                            else if (splitSub.Length == 2)
                            {
                                string regStr = @"([\d]+)[．.](.+)";
                                var neiRongJieGuo = RegexHelper.GetMatch(splitSub[0].Trim(), regStr);
                                ShiTiNeiRong model = new ShiTiNeiRong();
                                model.XuHao = neiRongJieGuo[1];
                                model.NeiRong = neiRongJieGuo[2];
                                model.DaAn = RegexHelper.GetMatch(splitSub[1], "[a-fA-F]+", 0);
                                model.XuanXiangA = "正确";
                                model.XuanXiangB = "错误";
                                rList.Add(model);
                            }
                            else
                            {
                                string regStr = @"([\d]+)[．.](.+)[\(（]\s{0,}([A-Fa-f]+)\s{0,}[\)）]";
                                var neiRongJieGuo = RegexHelper.GetMatch(splitSub[0].Trim(), regStr);

                                ShiTiNeiRong model = new ShiTiNeiRong();
                                model.XuHao = neiRongJieGuo[1];
                                model.NeiRong = neiRongJieGuo[2];
                                model.DaAn = neiRongJieGuo[3];

                                if (splitSub.Length > 1)
                                {
                                    model.XuanXiangA = RegexHelper.ReplaceStr(splitSub[1], "A[.．]", "");
                                }
                                if (splitSub.Length > 2)
                                {
                                    model.XuanXiangB = RegexHelper.ReplaceStr(splitSub[2], "B[.．]", "");
                                }
                                if (splitSub.Length > 3)
                                {
                                    model.XuanXiangC = RegexHelper.ReplaceStr(splitSub[3], "C[.．]", "");
                                }
                                if (splitSub.Length > 4)
                                {
                                    model.XuanXiangD = RegexHelper.ReplaceStr(splitSub[4], "D[.．]", "");
                                }
                                if (splitSub.Length > 5)
                                {
                                    model.XuanXiangE = RegexHelper.ReplaceStr(splitSub[5], "E[.．]", "");
                                }
                                if (splitSub.Length > 6)
                                {
                                    model.XuanXiangF = RegexHelper.ReplaceStr(splitSub[6], "F[.．]", "");
                                }
                                rList.Add(model);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("处理试题发生异常，内容：\r\n" + item);
                            LogHelper.LogObj.Error("导入题库发生异常", ex);
                        }
                    }
                }
                dgv.DataSource = null;
                dgv.DataSource = rList;
                dgv.Tag = ofd.FileName;
            }
        }

        private void tsbtnOutExcel_Click(object sender, EventArgs e)
        {
            string defaultFileName = Path.GetFileNameWithoutExtension(dgv.Tag.ToString());
            if (ExcelOut.OutExcelByGridView(dgv, defaultFileName))
            {
                ShowMessage("导出成功！");
                //MessageBox.Show("导出成功");
            }
            else
            {
                ShowMessage("导出失败。。");
            }
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
