using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Framework.Common.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public class ExcelHelperNPOL
    {
        /// <summary>
        /// 
        /// </summary>
        public class X2003
        {
            #region Excel2003
            /// <summary>
            /// 将Excel文件中的数据读出到DataTable中(xls)
            /// </summary>/// <returns></returns>
            public static DataSet ExcelToTableForXLS(string file)
            {
                DataSet ds = new DataSet();
                using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    HSSFWorkbook hssfworkbook = new HSSFWorkbook(fs);
                    for (int i = 0; i < hssfworkbook.NumberOfSheets; i++)
                    {
                        DataTable dt = new DataTable();
                        ISheet sheet = hssfworkbook.GetSheetAt(i);
                        dt.TableName = sheet.SheetName;
                        //表头
                        IRow header = sheet.GetRow(sheet.FirstRowNum);
                        List<int> columns = new List<int>();
                        for (int j = 0; j < header.LastCellNum; j++)
                        {
                            object obj = GetValueTypeForXLS(header.GetCell(j) as HSSFCell);
                            if (obj == null || obj.ToString() == string.Empty)
                            {
                                dt.Columns.Add(new DataColumn("Columns" + j.ToString()));
                                //continue;
                            }
                            else
                                dt.Columns.Add(new DataColumn(obj.ToString()));
                            columns.Add(j);
                        }
                        //数据
                        for (int rowIndex = sheet.FirstRowNum + 1; rowIndex <= sheet.LastRowNum; rowIndex++)
                        {
                            DataRow dr = dt.NewRow();
                            bool hasValue = false;
                            foreach (int colIndex in columns)
                            {
                                dr[colIndex] = GetValueTypeForXLS(sheet.GetRow(rowIndex).GetCell(colIndex) as HSSFCell);
                                if (dr[colIndex] != null && dr[colIndex].ToString() != string.Empty)
                                {
                                    hasValue = true;
                                }
                            }
                            if (hasValue)
                            {
                                dt.Rows.Add(dr);
                            }
                        }
                        ds.Tables.Add(dt);
                    }
                }
                return ds;
            }

            static bool IsNumberByCellValue(Type type)
            {
                if (type == typeof(int) ||
                    type == typeof(decimal) ||
                    type == typeof(double) ||
                    type == typeof(float) ||
                    type == typeof(long))
                {
                    return true;
                }
                return false;
            }

            /// <summary>
            /// 将DataTable数据导出到Excel文件中(xls)
            /// </summary>
            /// <param name="dt"></param>
            /// <param name="file"></param>
            public static void TableToExcelForXLS(DataTable dt, string file, string sheetName = "default")
            {
                HSSFWorkbook hssfworkbook = new HSSFWorkbook();
                ISheet sheet = hssfworkbook.CreateSheet(sheetName);

                //表头
                IRow row = sheet.CreateRow(0);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ICell cell = row.CreateCell(i);
                    cell.SetCellValue(dt.Columns[i].Caption);
                }
                //数据
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    IRow row1 = sheet.CreateRow(i + 1);
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (dt.Rows[i][j] == null || dt.Rows[i][j] == DBNull.Value) continue;

                        ICell cell = row1.CreateCell(j);
                        if (IsNumberByCellValue(dt.Columns[j].DataType))
                        {
                            //cell.SetCellType(CellType.Numeric);
                            cell.SetCellValue(Convert.ToDouble(dt.Rows[i][j]));
                        }
                        else
                        {
                            cell.SetCellValue(dt.Rows[i][j].ToString());
                        }

                    }
                }
                //转为字节数组
                using (MemoryStream stream = new MemoryStream())
                {
                    hssfworkbook.Write(stream);
                    var buf = stream.ToArray();
                    //保存为Excel文件
                    using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
                    {
                        fs.Write(buf, 0, buf.Length);
                        fs.Flush();
                    }
                }
            }

            /// <summary>
            /// 获取单元格类型(xls)
            /// </summary>
            /// <param name="cell"></param>
            /// <returns></returns>
            private static object GetValueTypeForXLS(HSSFCell cell)
            {
                if (cell == null)
                    return null;
                switch (cell.CellType)
                {
                    case CellType.Blank: //BLANK:
                        return null;
                    case CellType.Boolean: //BOOLEAN:
                        return cell.BooleanCellValue;
                    case CellType.Numeric: //NUMERIC:
                        return cell.NumericCellValue;
                    case CellType.String: //STRING:
                        return cell.StringCellValue;
                    case CellType.Error: //ERROR:
                        return cell.ErrorCellValue;
                    case CellType.Formula: //FORMULA:
                    default:
                        return "=" + cell.CellFormula;
                }
            }
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        public class X2007
        {
            #region Excel2007
            /// <summary>
            /// 将Excel文件中的数据读出到DataTable中(xlsx)
            /// </summary>
            public static DataSet ExcelToTableForXLSX(string file)
            {
                DataSet ds = new DataSet();
                using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    XSSFWorkbook xssfworkbook = new XSSFWorkbook(fs);
                    for (int i = 0; i < xssfworkbook.NumberOfSheets; i++)
                    {
                        DataTable dt = new DataTable();
                        ISheet sheet = xssfworkbook.GetSheetAt(i);
                        //表头
                        IRow header = sheet.GetRow(sheet.FirstRowNum);
                        if (header == null) return ds;
                        List<int> columns = new List<int>();
                        for (int j = 0; j < header.LastCellNum; j++)
                        {
                            object obj = GetValueTypeForXLSX(header.GetCell(j) as XSSFCell);
                            if (obj == null || obj.ToString() == string.Empty)
                            {
                                dt.Columns.Add(new DataColumn("Columns" + j.ToString()));
                                //continue;
                            }
                            else
                                dt.Columns.Add(new DataColumn(obj.ToString()));
                            columns.Add(j);
                        }
                        //数据
                        for (int rowIndex = sheet.FirstRowNum + 1; rowIndex <= sheet.LastRowNum; rowIndex++)
                        {
                            DataRow dr = dt.NewRow();
                            bool hasValue = false;
                            foreach (int colIndex in columns)
                            {
                                dr[colIndex] = GetValueTypeForXLSX(sheet.GetRow(rowIndex).GetCell(colIndex) as XSSFCell);
                                if (dr[colIndex] != null && dr[colIndex].ToString() != string.Empty)
                                {
                                    hasValue = true;
                                }
                            }
                            if (hasValue)
                            {
                                dt.Rows.Add(dr);
                            }
                        }
                        ds.Tables.Add(dt);
                    }
                }
                return ds;
            }

            /// <summary>
            /// 将DataTable数据导出到Excel文件中(xlsx)
            /// </summary>
            /// <param name="dt"></param>
            /// <param name="file"></param>
            public static void TableToExcelForXLSX(DataTable dt, string file)
            {
                XSSFWorkbook xssfworkbook = new XSSFWorkbook();
                ISheet sheet = xssfworkbook.CreateSheet("Test");

                //表头
                IRow row = sheet.CreateRow(0);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ICell cell = row.CreateCell(i);
                    cell.SetCellValue(dt.Columns[i].ColumnName);
                }

                //数据
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    IRow row1 = sheet.CreateRow(i + 1);
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ICell cell = row1.CreateCell(j);
                        cell.SetCellValue(dt.Rows[i][j].ToString());
                    }
                }
                //转为字节数组
                MemoryStream stream = new MemoryStream();
                xssfworkbook.Write(stream);
                var buf = stream.ToArray();

                //保存为Excel文件
                using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(buf, 0, buf.Length);
                    fs.Flush();
                }
            }

            /// <summary>
            /// 获取单元格类型(xlsx)
            /// </summary>
            /// <param name="cell"></param>
            /// <returns></returns>
            private static object GetValueTypeForXLSX(XSSFCell cell)
            {
                if (cell == null)
                    return null;
                switch (cell.CellType)
                {
                    case CellType.Blank: //BLANK:
                        return null;
                    case CellType.Boolean: //BOOLEAN:
                        return cell.BooleanCellValue;
                    case CellType.Numeric: //NUMERIC:
                        return cell.NumericCellValue;
                    case CellType.String: //STRING:
                        return cell.StringCellValue;
                    case CellType.Error: //ERROR:
                        return cell.ErrorCellValue;
                    case CellType.Formula: //FORMULA:
                    default:
                        return "=" + cell.CellFormula;
                }
            }
            #endregion
        }

        public static DataSet GetDataTable(string filepath)
        {
            var ds = new DataSet();
            if (filepath[filepath.Length - 1] == 's')
            {
                ds = X2003.ExcelToTableForXLS(filepath);
            }
            else
            {
                ds = X2007.ExcelToTableForXLSX(filepath);
            }
            //if (filepath.Last() == 's')
            //{
            //    dt = x2003.ExcelToTableForXLS(filepath);
            //}
            //else
            //{
            //    
            //}
            return ds;
        }
    }
}