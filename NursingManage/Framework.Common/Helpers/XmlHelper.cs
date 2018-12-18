using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Framework.Common.Helpers
{
    /// <summary>
    /// XmlHelper 的摘要说明
    /// </summary>
    public class XmlHelper
    {
        public XmlHelper()
        {
            _RootName = "Root";
        }
        public XmlHelper(string rootName)
        {
            _RootName = rootName;
        }
        private string _RootName;

        public string RootName
        {
            get { return _RootName; }
            set { _RootName = value; }
        }

        public bool InsertOrUpdate(string path, string node, string element, string attribute, string value)
        {
            string v = Read(path, node + "/" + element, attribute);
            if (string.IsNullOrEmpty(v))
            {
                return Insert(path, node, element, attribute, value);
            }
            else
            {
                return Update(path, node + "/" + element, attribute, value);
            }
        }

        /// <summary>
        /// 读取数据        
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="node">节点</param>
        /// <param name="attribute">属性名，非空时返回该属性值，否则返回串联值</param>
        /// <returns>string</returns>
        /**************************************************
         * 使用示列:\r\n        
         * XmlHelper.Read(path, "/Node", "")
         * XmlHelper.Read(path, "/Node/Element[@Attribute='Name']", "Attribute")
         **************************************************/
        public string Read(string path, string node, string attribute)
        {
            string value = "";
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode xn;
                xn = doc.SelectSingleNode(_RootName + "/" + node);                
                value = (attribute.Equals("") ? xn.InnerText : xn.Attributes[attribute].Value);
            }
            catch { }
            return value;
        }

        /// <summary>
        /// 插入数据,如果 path 文件不存在则创建        
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="node">节点</param>
        /// <param name="element">元素名，非空时插入新元素，否则在该元素中插入属性</param>
        /// <param name="attribute">属性名，非空时插入该元素属性值，否则插入元素值</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        /**************************************************
         * 使用示列:       
         * XmlHelper.Insert(path, "/Node", "Element", "", "Value")
         * XmlHelper.Insert(path, "/Node", "Element", "Attribute", "Value")
         * XmlHelper.Insert(path, "/Node", "", "Attribute", "Value")
         ************************************************/
        public bool Insert(string path, string node, string element, string attribute, string value)
        {
            try
            {
                if (!File.Exists(path))
                {
                    XmlDocument createDoc = new XmlDocument();
                    XmlDeclaration dec = createDoc.CreateXmlDeclaration("1.0", "utf-8", null);
                    createDoc.AppendChild(dec);
                    XmlElement root = createDoc.CreateElement(_RootName);
                    createDoc.AppendChild(root);
                    createDoc.Save(path);
                }
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode xn;
                if (_RootName != node)
                {
                    xn = doc.SelectSingleNode(_RootName + "/" + node);
                }
                else
                {
                    xn = doc.SelectSingleNode(node);
                }
                if (element.Equals(""))
                {
                    if (!attribute.Equals(""))
                    {
                        XmlElement xe = (XmlElement)xn;
                        xe.SetAttribute(attribute, value);
                    }
                }
                else
                {
                    XmlElement xe = doc.CreateElement(element);
                    if (attribute.Equals(""))
                        xe.InnerText = value;
                    else
                        xe.SetAttribute(attribute, value);
                    xn.AppendChild(xe);
                }
                doc.Save(path);
                return true;
            }
            catch { return false; }
        }
        /// <summary>
        /// 在根节点创建元素
        /// </summary>        
        public bool Insert(string path, string element, string attribute, string value)
        {
            return Insert(path, _RootName, element, attribute, value);
        }
        /// <summary>
        /// 修改数据        
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="node">节点</param>
        /// <param name="attribute">属性名，非空时修改该节点属性值，否则修改节点值</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        /**************************************************
         * 使用示列:
         * XmlHelper.Insert(path, "/Node", "", "Value")
         * XmlHelper.Insert(path, "/Node", "Attribute", "Value")
         ************************************************/
        public bool Update(string path, string node, string attribute, string value)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode xn = doc.SelectSingleNode(_RootName + "/" + node);
                XmlElement xe = (XmlElement)xn;
                if (attribute.Equals(""))
                    xe.InnerText = value;
                else
                    xe.SetAttribute(attribute, value);
                doc.Save(path);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// 删除数据        
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="node">节点</param>
        /// <param name="attribute">属性名，非空时删除该节点属性值，否则删除节点值</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        /**************************************************
         * 使用示列:
         * XmlHelper.Delete(path, "/Node", "")
        * XmlHelper.Delete(path, "/Node", "Attribute")
        ************************************************/
        public static bool Delete(string path, string node, string attribute)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode xn = doc.SelectSingleNode(node);
                XmlElement xe = (XmlElement)xn;
                if (attribute.Equals(""))
                    xn.ParentNode.RemoveChild(xn);
                else
                    xe.RemoveAttribute(attribute);
                doc.Save(path);
                return true;
            }
            catch { return false; }
        }
    }
}
