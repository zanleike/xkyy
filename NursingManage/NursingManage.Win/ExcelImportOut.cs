using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.Common.Helpers;
using System.Data;
using HursingManage.DBModel;
using Framework.Common.CommonFunction;
using Framework.Common;
using System.IO;

namespace NursingManage.Win
{
    class ExcelOut
    {
        static Encoding CSVEncoding = Encoding.GetEncoding("gbk");

        public static bool OutCSV(DataGridView dgv, string fileName)
        {
            try
            {
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("导出数据为空!");
                    return false;
                }
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "excel文件|*.csv";
                sfd.FileName = string.Format("{0}.csv", fileName);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string tmpFile = sfd.FileName;
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, CSVEncoding))
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            if (dgv.Columns[i].Visible)
                            {
                                sb.AppendFormat("{0},", dgv.Columns[i].HeaderText);
                            }
                        }
                        sb.Append(Environment.NewLine);
                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgv.Columns.Count; j++)
                            {
                                if (dgv.Columns[j].Visible)
                                {
                                    sb.AppendFormat("{0},", dgv.Rows[i].Cells[j].Value);
                                }
                            }
                            sb.Append(Environment.NewLine);
                        }
                        sw.Write(sb.ToString());
                        sw.Flush();
                        sw.Close();
                    }
                    MessageBox.Show("导出成功!");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogHelper.LogObj.Error("导出文件失败,文件名:" + fileName, ex);
                MessageBox.Show("导出文件失败," + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 导出csv文件，如果Caption不等于ColumnName 那么导出，否则不进行导出
        /// </summary>
        public static bool OutCSV(DataTable dt, string fileName, out string errMsg)
        {
            try
            {
                if (dt == null || dt.Rows.Count == 0)
                {
                    errMsg = "导出数据为空!";
                    return false;
                }
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "excel文件|*.csv";
                sfd.FileName = string.Format("{0}.csv", fileName);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string tmpFile = sfd.FileName;
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, CSVEncoding))
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            //if (!string.IsNullOrWhiteSpace(dt.Columns[i].Caption))
                            if (dt.Columns[i].Caption != dt.Columns[i].ColumnName)
                            {
                                sb.AppendFormat("{0},", dt.Columns[i].Caption);
                            }
                        }
                        sb.Append(Environment.NewLine);
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            for (int j = 0; j < dt.Columns.Count; j++)
                            {
                                if (dt.Columns[j].Caption != dt.Columns[j].ColumnName)
                                {
                                    object value = dt.Rows[i][j];
                                    string valueStr;
                                    if (value == null || value == DBNull.Value) valueStr = string.Empty;
                                    valueStr = value.ToString().Replace(Environment.NewLine, "  ");
                                    sb.AppendFormat("{0},", valueStr);
                                }
                            }
                            sb.Append(Environment.NewLine);
                        }
                        sw.Write(sb.ToString());
                        sw.Flush();
                        sw.Close();
                    }
                    errMsg = "导出成功!";
                    return true;
                }
                errMsg = "操作取消!";
                return false;
            }
            catch (Exception ex)
            {
                LogHelper.LogObj.Error("导出文件失败,文件名:" + fileName, ex);
                errMsg = "导出文件失败," + ex.Message;
                return false;
            }
        }

        public static bool OutExcel(DataTable dt, string defaultFileName, string templateFile, List<string> orderColumn)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "excel文件|*.xls";
            sfd.FileName = string.Format("{0}.xls", defaultFileName);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //模板文件
                string tmpFile = AppDomain.CurrentDomain.BaseDirectory + string.Format("ExcelTemplates\\{0}", templateFile);
                using (ExcelHelper excel = new ExcelHelper(tmpFile, 1, false))
                {
                    excel.IsKillExcelProcess = false;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < orderColumn.Count; j++)
                        {
                            excel.SetCellValue(i + 2, j + 1, dt.Rows[i][orderColumn[j]].ToString());
                        }
                    }
                    string outFileName = sfd.FileName;
                    excel.SaveAsFile(outFileName, "xls");
                }
                return true;
            }
            return false;
        }

        public static bool OutExcelNPOL(DataTable dt, string defaultFileName, bool columnNameIsCaption = false)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "excel文件|*.xls";
            sfd.FileName = string.Format("{0}.xls", defaultFileName);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                for (int i = dt.Columns.Count - 1; i >= 0; i--)
                {
                    if (!columnNameIsCaption)
                    {
                        if (dt.Columns[i].Caption == dt.Columns[i].ColumnName)
                        {
                            dt.Columns.RemoveAt(i);
                        }
                    }
                }
                ExcelHelperNPOL.X2003.TableToExcelForXLS(dt, sfd.FileName);
                return true;
            }
            return false;
        }

        public static bool OutExcelByGridView(DataGridView dgv, string defaultFileName,string sheetName="default")
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "excel文件|*.xls";
            sfd.FileName = string.Format("{0}.xls", defaultFileName);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn item in dgv.Columns)
                {
                    if (item.Visible == false) continue;
                    DataColumn dc = new DataColumn();
                    dc.Caption = item.HeaderText;
                    dc.ColumnName = item.DataPropertyName;
                    if (item.ValueType != null)
                    {
                        dc.DataType = item.ValueType;
                    }
                    dt.Columns.Add(dc);
                }
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    var dr = dt.NewRow();
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        var dgvCol = dgv.Columns[j];
                        if (dgvCol.Visible)
                        {
                            dr[dgvCol.DataPropertyName] = dgv.Rows[i].Cells[j].Value;
                        }
                    }
                    dt.Rows.Add(dr);
                }
                ExcelHelperNPOL.X2003.TableToExcelForXLS(dt, sfd.FileName, sheetName);
                return true;
            }
            return false;
        }

        public static void SetColumnCaptionAndOrdinal(DataTable dt, string columnName, string caption, int ordinal)
        {
            dt.Columns[columnName].Caption = caption;
            dt.Columns[columnName].SetOrdinal(ordinal);
        }

        public static bool OutExcelByMuBanShiTi(DataTable dt, string defaultFileName)
        {
            DataTable outTable = dt.Copy();
            SetColumnCaptionAndOrdinal(outTable, V_SHITI_MUBAN_MINGXI.CNMUBANMINGCHENG, "模板名称", 0);
            SetColumnCaptionAndOrdinal(outTable, V_SHITI_MUBAN_MINGXI.CNFENLEI, "试题类别", 1);
            SetColumnCaptionAndOrdinal(outTable, V_SHITI_MUBAN_MINGXI.CNSHITIXUHAO, "试题序号", 2);
            SetColumnCaptionAndOrdinal(outTable, V_SHITI_MUBAN_MINGXI.CNNEIRONG, "内容", 3);
            SetColumnCaptionAndOrdinal(outTable, V_SHITI_MUBAN_MINGXI.CNLEIXING, "类型", 4);
            SetColumnCaptionAndOrdinal(outTable, V_SHITI_MUBAN_MINGXI.CNXIANGMUA, "选项A", 5);
            SetColumnCaptionAndOrdinal(outTable, V_SHITI_MUBAN_MINGXI.CNXIANGMUB, "选项B", 6);
            SetColumnCaptionAndOrdinal(outTable, V_SHITI_MUBAN_MINGXI.CNXIANGMUC, "选项C", 7);
            SetColumnCaptionAndOrdinal(outTable, V_SHITI_MUBAN_MINGXI.CNXIANGMUD, "选项D", 8);
            SetColumnCaptionAndOrdinal(outTable, V_SHITI_MUBAN_MINGXI.CNXIANGMUE, "选项E", 9);
            SetColumnCaptionAndOrdinal(outTable, V_SHITI_MUBAN_MINGXI.CNDAAN, "答案", 10);
            SetColumnCaptionAndOrdinal(outTable, V_SHITI_MUBAN_MINGXI.CNFENSHU, "分数", 11);

            return OutExcelNPOL(outTable, defaultFileName);
        }
        public static bool OutDangAn(DataTable dt, string defaultFileName)
        {
            DataTable outTable = dt.Copy();
            int orderNo = 0;
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNKESHI, "科室", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNBIANHAO, "员工编号", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNXINGMING, "姓名", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNXINGBIE, "性别", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNSHOUJI, "手机号码", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNCHUSHENGRIQI, "出生日期", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNNIANLING, "年龄", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNMINZU, "民族", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNHUNFOU, "婚否", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNZHENGZHIMIANMAO, "政治面貌", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNSHENFENZHENG, "身份证号", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNJIATINGDIZHI, "家庭地址", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNNENGJI, "能级", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNZHIWU, "职务", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNZHICHENG, "现职称", orderNo++);            
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNHUSHIZIGEBIANMA, "护士资格证书编码", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNHUSHIZIGESHIJIAN, "护士资格证书取得时间", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNHUSHIZHIYEBIANMA, "护士执业证书编码", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNHUSHIZHIYESHIJIAN, "护士执业证书取得时间", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNCHUSHIXUELI, "初始学历", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNCHUSHIBIYEYUANXIAO, "初始毕业院校", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNXUELI, "最高学历", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNBIYEXUEXIAO, "最高毕业院校", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNXUEWEI, "学位", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNRUKESHIJIAN, "入科时间", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNRUKENIANXIAN, "现科室工作年限", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNLAIYUANSHIJIAN, "来院时间", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNLAIYUANNIANXIAN, "来院年限", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNGONGZUOSHIJIAN, "参加工作时间", orderNo++);
            SetColumnCaptionAndOrdinal(outTable, V_DANGAN.CNGONGZUONIANXIAN, "工作年限", orderNo++); 
            return OutExcelNPOL(outTable, defaultFileName);
        }

        public static bool OutExcelByZhiLiangBiaoZhun(DataTable dt, string defaultFileName)
        {
            DataTable outTable = dt.Copy();
            SetColumnCaptionAndOrdinal(outTable, T_ZHILIANGBIAOZHUN.CNXUHAO, "序号", 0);
            SetColumnCaptionAndOrdinal(outTable, T_ZHILIANGBIAOZHUN.CNLEIXING1, "一级类型", 1);
            SetColumnCaptionAndOrdinal(outTable, T_ZHILIANGBIAOZHUN.CNLEIXING2, "二级类型", 2);
            SetColumnCaptionAndOrdinal(outTable, T_ZHILIANGBIAOZHUN.CNNEIRONG, "内容", 3);
            return OutExcelNPOL(outTable, defaultFileName);
        }
    }
}