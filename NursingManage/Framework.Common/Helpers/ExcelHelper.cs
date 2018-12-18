using System;
using System.Collections.Generic;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Framework.Common.Helpers
{
    /// <summary>
    /// Excel操作类
    /// </summary>
    public class ExcelHelper : IDisposable
    {
        #region 私有变量
        Excel.Application _app;
        Excel.Workbook _workBook;
        Excel.Worksheet _workSheet;
        Excel.Range _range;
        /// <summary>
        /// Excel启动之前时间(用于结束进程判断)
        /// </summary>
        DateTime _beforeTime;
        /// <summary>
        /// Excel启动之后时间(用于结束进程判断)
        /// </summary>
        DateTime _afterTime;

        object missing = Missing.Value;

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数，打开一个已有的工作簿
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <param name="sheets">工作表,可以是索引(从1开始),可以是工作表名称</param>
        /// <param name="isVisible">是否显示工作表</param>
        public ExcelHelper(string fileName, object sheets, bool isVisible)
        {
            if (!File.Exists(fileName))
                throw new Exception("指定路径的Excel文件不存在！");

            //创建一个Application对象并使其可见
            _beforeTime = DateTime.Now;
            //_app = new Excel.ApplicationClass();
            _app = new Excel.Application();
            _app.Visible = isVisible;
            _afterTime = DateTime.Now;

            //打开一个WorkBook
            _workBook = _app.Workbooks.Open(fileName,
             Type.Missing, Type.Missing, Type.Missing, Type.Missing,
             Type.Missing, Type.Missing, Type.Missing, Type.Missing,
             Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            //得到WorkSheet对象
            _workSheet = (Excel.Worksheet)_workBook.Sheets.get_Item(sheets);
            this.IsKillExcelProcess = true;
        }
        /// <summary>
        /// 构造函数，打开一个已有的工作簿,默认不显示工作表,并将第一个工作表设置当前工作表
        /// </summary>
        public ExcelHelper(string fileName)
            : this(fileName, 1, false)
        { }
        /// <summary>
        /// 构造函数，新建一个工作簿
        /// </summary>
        public ExcelHelper(bool isVisible)
        {
            //创建一个Application对象并使其可见
            _beforeTime = DateTime.Now;
            //_app = new Excel.ApplicationClass();
            _app = new Excel.Application();
            _app.Visible = isVisible;
            _afterTime = DateTime.Now;

            //新建一个WorkBook
            _workBook = _app.Workbooks.Add(Type.Missing);

            //得到WorkSheet对象
            _workSheet = (Excel.Worksheet)_workBook.Sheets.get_Item(1);
            this.IsKillExcelProcess = true;
        }

        #endregion

        #region 属性

        /// <summary>
        /// 保存文件后是否杀掉excel进程，win10系统无权限会异常
        /// </summary>
        public bool IsKillExcelProcess { set; get; }

        #endregion

        #region 单元格方法

        /// <summary>
        /// 向单元格写入数据，对当前WorkSheet操作
        /// </summary>
        /// <param name="rowIndex">行索引</param>
        /// <param name="columnIndex">列索引</param>
        /// <param name="text">要写入的文本值</param>
        public void SetCellValue(int rowIndex, int columnIndex, string text)
        {
            try
            {
                _workSheet.Cells[rowIndex, columnIndex] = text;
            }
            catch
            {
                this.KillExcelProcess();
                throw new Exception("向单元格[" + rowIndex + "," + columnIndex + "]写数据出错！");
            }
        }
        /// <summary>
        /// 根据当前单元格名称设置单元格内容
        /// </summary>
        /// <param name="cellName"></param>
        /// <param name="text"></param>
        public void SetCellValue(string cellName, string text)
        {
            try
            {
                _range = _workSheet.get_Range(cellName);
                _range.Value = text;
            }
            catch
            {
                this.KillExcelProcess();
                throw new Exception("向单元格[" + cellName + "]写数据出错！");
            }
        }
        /// <summary>
        /// 根据索引获取单元格值
        /// </summary>
        /// <param name="rowIndex">行索引</param>
        /// <param name="columnIndex">列索引</param>
        /// <returns>返回object,通常是string</returns>
        public object GetCellValue(int rowIndex, int columnIndex)
        {
            try
            {
                _range = (Excel.Range)_workSheet.Cells[rowIndex, columnIndex];
                return _range.Value2;
            }
            catch
            {
                this.KillExcelProcess();
                throw new Exception("从单元格[" + rowIndex + "," + columnIndex + "]读数据出错！");
            }

        }
        /// <summary>
        /// 根据单元格名称读取Excel单元格内容
        /// </summary>
        /// <param name="cellName">单元格名称</param>
        /// <returns>返回内容</returns>
        public object GetCellValue(string cellName)
        {
            try
            {
                _range = _workSheet.get_Range(cellName);
                return _range.Value2;
            }
            catch
            {
                this.KillExcelProcess();
                throw new Exception("从单元格[" + cellName + "]读数据出错！");
            }
        }
        /// <summary>
        /// 合并单元格，并赋值，对指定WorkSheet操作
        /// </summary>
        /// <param name="beginRowIndex">开始行索引</param>
        /// <param name="beginColumnIndex">开始列索引</param>
        /// <param name="endRowIndex">结束行索引</param>
        /// <param name="endColumnIndex">结束列索引</param>
        /// <param name="text">合并后Range的值</param>
        public void MergeCells(int beginRowIndex, int beginColumnIndex, int endRowIndex, int endColumnIndex, string text)
        {
            //workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(sheetIndex);
            _range = _workSheet.get_Range(_workSheet.Cells[beginRowIndex, beginColumnIndex], _workSheet.Cells[endRowIndex, endColumnIndex]);

            _range.ClearContents();  //先把Range内容清除，合并才不会出错
            _range.MergeCells = true;
            _range.Value = text;
            _range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            _range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
        }

        #endregion

        #region Worksheet方法

        /// <summary>
        /// 改变当前工作表
        /// </summary>
        /// <param name="sheetIndex">工作表索引</param>
        public void ChangeCurrentWorkSheet(int sheetIndex)
        {
            //若指定工作表索引超出范围，则不改变当前工作表
            if (sheetIndex < 1)
                return;

            if (sheetIndex > this._workBook.Sheets.Count)
                return;
            this._workSheet = (Excel.Worksheet)this._workBook.Sheets.get_Item(sheetIndex);
        }
        /// <summary>
        /// 改变当前工作表的名字
        /// </summary>
        /// <param name="sheetName">修改的工作表</param>
        public void ModifySheetName(string sheetName)
        {
            this._workSheet.Name = sheetName;
        }


        #endregion

        #region app方法
        /// <summary>
        /// 预览文件
        /// </summary>
        public void PreviewFile()
        {
            _app.Visible = true;
        }
        /// <summary>
        /// 保存文件
        /// </summary>
        public void SaveFile()
        {
            try
            {
                _workBook.Save();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.Dispose();
            }
        }
        /// <summary>
        /// 输出Excel文件并退出
        /// </summary>
        public void OutputExcelFile(string outputFile)
        {
            SaveAsFile(outputFile, string.Empty);
        }
        /// <summary>        
        /// 将Excel文件另存为指定格式        
        /// </summary>
        /// <param name="outputFile">输出文件</param>
        /// <param name="format">HTML，CSV，TEXT，EXCEL，XML</param>
        public void SaveAsFile(string outputFile, string format)
        {
            if (outputFile == null)
                throw new Exception("没有指定输出文件路径！");

            try
            {
                switch (format)
                {
                    case "HTML":
                        {
                            _workBook.SaveAs(outputFile, Excel.XlFileFormat.xlHtml, missing, missing, missing, missing, Excel.XlSaveAsAccessMode.xlExclusive, missing, missing, missing, missing);
                            break;
                        }
                    case "CSV":
                        {
                            _workBook.SaveAs(outputFile, Excel.XlFileFormat.xlCSV, missing, missing, missing, missing, Excel.XlSaveAsAccessMode.xlExclusive, missing, missing, missing, missing);
                            break;
                        }
                    case "TEXT":
                        {
                            _workBook.SaveAs(outputFile, Excel.XlFileFormat.xlHtml, missing, missing, missing, missing, Excel.XlSaveAsAccessMode.xlExclusive, missing, missing, missing, missing);
                            break;
                        }
                    //     case "XML":
                    //     {
                    //      workBook.SaveAs(outputFile,Excel.XlFileFormat.xlXMLSpreadsheet, Type.Missing, Type.Missing,
                    //       Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange,
                    //       Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    //      break;
                    //     }
                    default:
                        {
                            _workBook.SaveAs(outputFile, missing, missing, missing, missing, missing, Excel.XlSaveAsAccessMode.xlExclusive, missing, missing, missing, missing);
                            break;
                        }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.Dispose();
            }
        }
        /// <summary>
        /// 结束Excel进程
        /// </summary>
        public void KillExcelProcess()
        {
            if (IsKillExcelProcess)
            {
                Process[] myProcesses;
                DateTime startTime;
                myProcesses = Process.GetProcessesByName("Excel");

                //得不到Excel进程ID，暂时只能判断进程启动时间
                foreach (Process myProcess in myProcesses)
                {
                    startTime = myProcess.StartTime;

                    if (startTime > _beforeTime && startTime < _afterTime)
                    {
                        myProcess.Kill();
                    }
                }
            }
        }
        /// <summary>
        /// 释放所有excel操作的对象,并结束Excel进程
        /// </summary>
        public void Dispose()
        {
            if (_workBook != null)
            {
                _workBook.Close(null, null, null);
            }
            if (_app != null)
            {
                _app.Workbooks.Close();
                _app.Quit();
            }
            if (_range != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(_range);
                _range = null;
            }
            //if (range1 != null)
            //{
            //    System.Runtime.InteropServices.Marshal.ReleaseComObject(range1);
            //    range1 = null;
            //}
            //if (range2 != null)
            //{
            //    System.Runtime.InteropServices.Marshal.ReleaseComObject(range2);
            //    range2 = null;
            //}

            if (_workSheet != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(_workSheet);
                _workSheet = null;
            }
            if (_workBook != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(_workBook);
                _workBook = null;
            }
            if (_app != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(_app);
                _app = null;
            }

            GC.Collect();
            try
            {
                this.KillExcelProcess();
            }
            catch (Exception ex)
            {                
                throw;
            }            
        }

        #endregion
    }
}