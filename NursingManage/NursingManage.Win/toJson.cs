using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using System;
using System.Windows.Forms;

namespace NursingManage.Win
{
   class toJson
    {
        public string strJson(string deptName)
        {
            string path = Directory.GetCurrentDirectory();
            path = path + "\\dept_dict.txt";
            string jsonText = this.ReadTxtContent(path);
            //string jsonText = "{\"shenzheng\":\"深圳\",\"beijing\":\"北京\",\"shanghai\":[{\"zj1\":\"zj11\",\"zj2\":\"zj22\"},\"zjs\"]}";
            //转为json对象
            JObject jo = (JObject)JsonConvert.DeserializeObject(jsonText);
            string zone="";
            if (string.IsNullOrEmpty(deptName)) {
                zone = "%";
            }
            else
            {
                try
                {
                    zone = jo[deptName].ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show("请输入正确的科室！");
                }
                
            }
            return zone;
        }

        /// <summary>
        /// 读取txt文件内容
        /// </summary>
        /// <param name="Path">文件地址</param>
        public string ReadTxtContent(string Path)
        {
            StreamReader sr = new StreamReader(Path, Encoding.Default);
            string txt = sr.ReadToEnd();
            byte[] mybyte = Encoding.UTF8.GetBytes(txt);
            txt = Encoding.UTF8.GetString(mybyte);
            return txt;
        }

    }
}
