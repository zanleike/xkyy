using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace Framework.Common.Helpers
{
    /// <summary>
    /// 文件操作类
    /// </summary>
    public class FileHelper
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Image ByteArrayToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            return Image.FromStream(ms);
        }

        /// <summary>
        /// 用于判断档案中的照片文件大小 小于100K
        /// </summary>
        /// <param name="picPath"></param>
        /// <returns></returns>
        public static bool IsStandardPicture(string picPath)
        {
            int stdandard = 100 * 1024;
            if (File.Exists(picPath))
            {
                return File.ReadAllBytes(picPath).Length <= stdandard;
            }
            return false;
        }

        /// <summary>
        /// 指定内容写如文本文件,如果文件存在则打开不存在则创建
        /// </summary>
        /// <param name="fullPath">包含文件名的文件名</param>
        /// <param name="content">内容</param>
        public static void TextFileWrite(string fullPath, string content)
        {
            using (FileStream aFile = new FileStream(fullPath, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(aFile))
                {
                    sw.Write(content);
                    sw.Close();
                }
            }
        }
        /// <summary>
        /// 根据文件名读取文本文件内容
        /// </summary>
        /// <param name="fullPath">包含路径的完成文件名</param>
        /// <returns>返回文本 内容</returns>
        public static string TextFileRead(string fullPath)
        {
            using (FileStream aFile = new FileStream(fullPath, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(aFile))
                {
                    string r = null;
                    r = sr.ReadToEnd();
                    return r;
                }
            }
        }
        /// <summary>
        /// 获得文件的MD5十六进制字符串
        /// </summary>
        public static string GetFileMD5Hex(string fileName)
        {
            byte[] md5Val = GetFileMD5Byte(fileName);
            string md5HexVal = NumberHelper.ByteArrToHex(md5Val);
            return md5HexVal;
        }
        /// <summary>
        /// 获得文件的MD5十六进制字符串
        /// </summary>
        public static byte[] GetFileMD5Byte(string fileName)
        {
            using (FileStream file = new FileStream(fileName, FileMode.Open))
            {
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] md5Val = md5.ComputeHash(file);
                return md5Val;
            }
        }

        /// <summary>
        /// 获得指定路径下的所有子目录
        /// </summary>
        /// <param name="pathList">用来输出的路径列表</param>
        /// <param name="rootPath">要搜索的路径</param>
        public static void GetAllPaths(List<string> pathList, string rootPath)
        {
            string[] paths = Directory.GetDirectories(rootPath);
            if (paths == null) return;
            foreach (var item in paths)
            {
                pathList.Add(item);
                GetAllPaths(pathList, item);
            }
        }
        /// <summary>
        /// 复制指定文件夹下的所有文件到指定文件夹,存在会替换
        /// </summary>
        /// <param name="sourceDir">要复制文件的目录</param>
        /// <param name="targetDir">复制的目标文件夹</param>
        static void CopyDir(string sourceDir, string targetDir)
        {
            //当前应用程序的全路径
            string assemblyFullName = Assembly.GetCallingAssembly().Location;
            List<string> sourcePaths = new List<string>();
            sourcePaths.Add(sourceDir);
            GetAllPaths(sourcePaths, sourceDir);
            if (sourcePaths.Count == 0) return;
            Directory.CreateDirectory(targetDir);
            foreach (var path in sourcePaths)
            {
                string newTargetDir = targetDir + path.Remove(0, path.IndexOf(sourceDir) + sourceDir.Length);
                Directory.CreateDirectory(newTargetDir);
                string[] sourceFiles = Directory.GetFiles(path);
                foreach (var file in sourceFiles)
                {
                    string targetFile = targetDir + file.Remove(0, file.IndexOf(sourceDir) + sourceDir.Length);
                    //如果是自己那么跳过
                    if (targetFile == assemblyFullName)
                    {
                        continue;
                    }
                    File.Copy(file, targetFile, true);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <param name="fullFileName"></param>
        public static void WriteBytesToFile(byte[] file, string fullFileName)
        {
            using (FileStream fs = new FileStream(fullFileName, FileMode.Create))
            {
                fs.Write(file, 0, file.Length);

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullFileName"></param>
        /// <returns></returns>
        public static byte[] ReadBytes4File(string fullFileName)
        {
            using (FileStream fs = new FileStream(fullFileName, FileMode.Open))
            {
                long len = fs.Length;
                byte[] rBytes = new byte[len];
                fs.Read(rBytes, 0, (int)len);
                return rBytes;
            }
        }
    }
}
