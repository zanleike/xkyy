using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Data;
using System.Xml;

namespace Framework.Common.Helpers
{
    public class SerializesHelper
    {
        public SerializesHelper()
        {  }
        
        byte[] SerializeByBase(IFormatter formatter, object obj) 
        {
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] bytes;
                formatter.Serialize(ms, obj);
                bytes = ms.ToArray();
                return bytes;
            }
        }
        T DeSerializeByBase<T>(IFormatter formatter, byte[] array)
        {
            using (MemoryStream ms = new MemoryStream(array))
            {
                return (T)formatter.Deserialize(ms);
            }
        }
        /// <summary>
        /// 二进制序列化
        /// </summary>
        public byte[] SerializeByBinary(object obj)
        {
            return SerializeByBase(new BinaryFormatter(), obj);
        }
        /// <summary>
        /// 二进制反序列化
        /// </summary>
        public T DeSerializeByBinary<T>(byte[] array)
        {
            return DeSerializeByBase<T>(new BinaryFormatter(), array);
        }

        ///// <summary>
        ///// SoapFormatter序列化
        ///// </summary>
        //public byte[] SerializeBySoap(object obj)
        //{           
        //    return SerializeByBase(new SoapFormatter(), obj); 
        //}
        ///// <summary>
        ///// SoapFormatter反序列化序列化
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="array"></param>
        ///// <returns></returns>
        //public T DeSerializeBySoap<T>(byte[] array)
        //{
        //    return DeSerializeByBase<T>(new SoapFormatter(), array);
        //}
        /// <summary>
        /// 将对象序列化成xml对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public byte[] SerializeByXml<T>(T t)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] bytes;
                XmlSerializer xmlSer = new XmlSerializer(typeof(T));
                xmlSer.Serialize(ms, t);
                bytes = ms.ToArray();
                return bytes;
            }
        }
        /// <summary>
        /// 将xml流发序列化成对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public T DeSerializeByXml<T>(byte[] array)
        {
            using (MemoryStream ms = new MemoryStream(array))
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(T));
                ms.Position = 0;
                return (T)xmlSer.Deserialize(ms);
            }
        }

        /// <summary>
        /// 序列化DataTable
        /// </summary>
        /// <param name="pDt">包含数据的DataTable</param>
        /// <returns>序列化的DataTable</returns>
        private static string SerializeDataTableXml(DataTable pDt)
        {
            // 序列化DataTable
            StringBuilder sb = new StringBuilder();
            XmlWriter writer = XmlWriter.Create(sb);
            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
            serializer.Serialize(writer, pDt);
            writer.Close();

            return sb.ToString();
        }


        /// <summary>
        /// 反序列化DataTable
        /// </summary>
        /// <param name="pXml">序列化的DataTable</param>
        /// <returns>DataTable</returns>
        public static DataTable DeserializeDataTable(string pXml)
        {

            StringReader strReader = new StringReader(pXml);
            XmlReader xmlReader = XmlReader.Create(strReader);
            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));

            DataTable dt = serializer.Deserialize(xmlReader) as DataTable;

            return dt;
        }

    }
}
