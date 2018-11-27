using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace MODEL
{
    public class PublicClass
    {
        /// <summary>
        /// 写配置文件
        /// </summary>
        /// <param name="section">存放名称</param>
        /// <param name="key">存放KEY</param>
        /// <param name="value">存放的路径</param>
        /// <param name="filePath">配置文件路径</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

        /// <summary>
        /// 读配置文件
        /// </summary>
        /// <param name="section">读取的名称</param>
        /// <param name="key">读取KEY</param>
        /// <param name="def"></param>
        /// <param name="value">读取路径</param>
        /// <param name="size"></param>
        /// <param name="filePath">配置文件路径</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder value, int size, string filePath);
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="stringToDecrypt">待解密字符串</param>
        /// <param name="sEncryptionKey">密钥</param>
        /// <returns>解密后的字符串</returns>
        public static string Decrypt(string stringToDecrypt, string sEncryptionKey)
        {
            try
            {
                byte[] rgbIV = { 10, 20, 30, 40, 50, 60, 70, 80 };
                byte[] rgbKey = Encoding.UTF8.GetBytes(sEncryptionKey.Substring(0, 8));
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                byte[] buffer = Convert.FromBase64String(stringToDecrypt);
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, provider.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                stream2.Write(buffer, 0, buffer.Length);
                stream2.FlushFinalBlock();
                return Encoding.UTF8.GetString(stream.ToArray());
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="stringToEncrypt">待加密字符串</param>
        /// <param name="sEncryptionKey">密钥</param>
        /// <returns>加密后的字符串</returns>
        public static string Encrypt(string stringToEncrypt, string sEncryptionKey)
        {
            try
            {
                byte[] rgbIV = { 10, 20, 30, 40, 50, 60, 70, 80 };
                byte[] rgbKey = Encoding.UTF8.GetBytes(sEncryptionKey.Substring(0, 8));
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                byte[] bytes = Encoding.UTF8.GetBytes(stringToEncrypt);
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                stream2.Write(bytes, 0, bytes.Length);
                stream2.FlushFinalBlock();
                return Convert.ToBase64String(stream.ToArray());
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// 获取XML信息
        /// </summary>
        /// <param name="xmlPathName">路径</param>
        /// <param name="sourceDt">数据原表</param>
        /// <param name="nodeName">获取信息关键字</param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DataTable GetXMLInfo(string xmlPathName, DataTable sourceDt, string nodeName, string key, string value)
        {
            //XmlDocument XmlDoc = new XmlDocument();
            //XmlDoc.Load(xmlPathName);  // 读取XML
            StreamReader sr = new StreamReader(xmlPathName); //读取TXT
            string str = sr.ReadToEnd();
            sr.DiscardBufferedData();
            sr.Close();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(str);

            for (int i = 0; i < xmlDoc.GetElementsByTagName(nodeName).Count; i++)
            {
                DataRow drNew = sourceDt.NewRow();
                foreach (XmlElement item in xmlDoc.GetElementsByTagName(nodeName)[i].ChildNodes)
                {
                    if (item.Name == key)
                    {
                        drNew[0] = item.InnerText;
                    }
                    if (item.Name == value)
                    {
                        drNew[1] = item.InnerText;
                    }
                }
                if (!string.IsNullOrEmpty(drNew[0].ToString()))
                {
                    sourceDt.Rows.InsertAt(drNew, sourceDt.Rows.Count);
                }
            }
            return sourceDt;
        }
        /// <summary>
        /// 创建XML和节点
        /// </summary>
        /// <param name="xmlPathName"></param> XML 最高级
        /// <param name="xmlNode1">第一级名字</param>
        /// <param name="xmlNode2">第二级名字</param>
        /// <param name="xmlNode3">第三级名字</param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool CreateXmlInfo(string xmlPathName, string xmlNode1, string xmlNode2, string xmlNode3, string key, string value)
        {
            //GetOrSetConfig.CreateXmlInfo(Application.StartupPath + @"\\" + @"ShowActionType.xml", "Type", "Key", "value", textBox1.Text, textBox2.Text);
            //MessageBox.Show("添加成功！");
            try
            {
                if (File.Exists(xmlPathName))//存在文件，添加即可
                {
                    StreamReader sr = new StreamReader(xmlPathName);
                    string str = sr.ReadToEnd();
                    sr.DiscardBufferedData();
                    sr.Close();
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(str);
                    //XmlDocument xmlDoc = new XmlDocument();
                    //xmlDoc.Load(xmlPathName);  //XML文件读取
                    XmlNodeList nodeLst = xmlDoc.SelectSingleNode("XML").ChildNodes;
                    bool finded = false;
                    foreach (XmlNode nodes in nodeLst)
                    {
                        foreach (XmlNode item in nodes.ChildNodes)
                        {
                            if (item.InnerText == key)
                            {
                                item.ParentNode.RemoveAll();//移除该同级节点信息
                                finded = true;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (finded)
                        {
                            //修改
                            XmlElement item1 = xmlDoc.CreateElement(xmlNode2);
                            item1.InnerText = key;
                            nodes.AppendChild(item1);

                            XmlElement item2 = xmlDoc.CreateElement(xmlNode3);
                            item2.InnerText = value;
                            nodes.AppendChild(item2);
                            xmlDoc.Save(xmlPathName);
                            return true;
                        }
                    }
                    //直接新增
                    XmlNode node = xmlDoc.SelectSingleNode("XML");
                    XmlElement node1 = xmlDoc.CreateElement(xmlNode1);

                    XmlElement node2 = xmlDoc.CreateElement(xmlNode2);
                    node2.InnerText = key;
                    node1.AppendChild(node2);

                    XmlElement node3 = xmlDoc.CreateElement(xmlNode3);
                    node3.InnerText = value;
                    node1.AppendChild(node3);

                    node.AppendChild(node1);
                    xmlDoc.Save(xmlPathName);
                    return true;
                }
                else //无文件，创建新增
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    //XmlDeclaration declaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlElement node = xmlDocument.CreateElement("XML");
                    XmlElement node1 = xmlDocument.CreateElement(xmlNode1);

                    XmlElement node2 = xmlDocument.CreateElement(xmlNode2);
                    node2.InnerText = key;
                    node1.AppendChild(node2);

                    XmlElement node3 = xmlDocument.CreateElement(xmlNode3);
                    node3.InnerText = value;
                    node1.AppendChild(node3);
                    node.AppendChild(node1);
                    //xmlDocument.AppendChild(declaration);
                    xmlDocument.AppendChild(node);
                    xmlDocument.Save(xmlPathName);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            #region XML  学习
            ////定义XMLDocument
            //XmlDocument xmlDocument = new XmlDocument();
            ////定义XML文档头文件
            //XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", null);
            ////增加XML文档头
            //xmlDocument.AppendChild(xmlDeclaration);
            ////定义XML的根
            //XmlElement xmlRoot = xmlDocument.CreateElement("userdata");
            ////添加根的属性
            //xmlRoot.SetAttribute("createuser", "true");
            ////修改根属性的值
            //xmlRoot.GetAttributeNode("createuser").Value = "false";
            ////添加子节点并设置子节点属性
            //xmlDocument.AppendChild(xmlRoot);
            //XmlElement dataconnection = xmlDocument.CreateElement("dataconnection");
            //XmlElement server = xmlDocument.CreateElement("server");
            //server.InnerText = "localhost";
            //XmlElement uid = xmlDocument.CreateElement("uid");
            //uid.InnerText = "sa";
            //XmlElement pwd = xmlDocument.CreateElement("pwd");
            //xmlRoot.AppendChild(dataconnection);
            //dataconnection.AppendChild(server);
            //dataconnection.AppendChild(uid);
            //dataconnection.AppendChild(pwd);
            ////保存XML文档
            //xmlDocument.Save("book.xml");
            ////读取子节点server的值
            //XmlNode xnserver = xmlDocument.SelectSingleNode("userdata/dataconnection/server");
            //Console.WriteLine("node server's value is " + xnserver.InnerText);
            //Console.ReadLine();
            //=======================bookstore.XML内容====================
            //<?xml version="1.0" encoding="gb2312"?>
            //<bookstore>
            //  <book>
            //  </book>
            //  <book>
            //  </book>
            //  <book genre="李赞红" ISBN="2-3631-4">
            //    <title>CS从入门到精通</title>
            //    <author>候捷</author>
            //    <price>58.3</price>
            //  </book>
            //  <book genre="李赞红" ISBN="2-3631-4">
            //    <title>CS从入门到精通</title>
            //    <author>候捷</author>
            //    <price>58.3</price>
            //  </book>
            //</bookstore>
            //=======================读取========================
            //            XmlDocument doc = new XmlDocument();
            //            doc.Load(@"d:\bookstore.xml");
            //            XmlElement root = doc.DocumentElement;

            //            MessageBox.Show(root.SelectNodes("book")[0].InnerText);

            //=======================添加=========================
            //            XmlDocument xmlDoc = new XmlDocument();
            //            xmlDoc.Load(@"d:\bookstore.xml");
            //            XmlNode root = xmlDoc.SelectSingleNode("bookstore");//查找<bookstore>
            //            XmlElement xe1 = xmlDoc.CreateElement("book");//创建一个<book>节点
            //            xe1.SetAttribute("genre", "李赞红");//设置该节点的genre属性
            //            xe1.SetAttribute("ISBN", "2-3631-4");//设置该节点的ISBN属性

            //            XmlElement xesub1 = xmlDoc.CreateElement("title");//添加一个名字为title的子节点
            //            xesub1.InnerText = "CS从入门到精通";//设置文本
            //            xe1.AppendChild(xesub1);//把title添加到<book>节点中

            //            XmlElement xesub2 = xmlDoc.CreateElement("author");
            //            xesub2.InnerText = "候捷";
            //            xe1.AppendChild(xesub2);

            //            XmlElement xesub3 = xmlDoc.CreateElement("price");
            //            xesub3.InnerText = "58.3";
            //            xe1.AppendChild(xesub3);

            //            root.AppendChild(xe1);//把book添加到<bookstore>根节点中
            //            xmlDoc.Save(@"d:\bookstore.xml");

            //======================修改========================
            //            XmlDocument xmlDoc = new XmlDocument();
            //            xmlDoc.Load(@"d:\bookstore.xml");
            //            XmlNodeList nodeList = xmlDoc.SelectSingleNode("bookstore").ChildNodes;//获取bookstore节点的所有子节点
            //            foreach (XmlNode xn in nodeList)//遍历所有名字为bookstore的子节点
            //            {
            //                XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型
            //                if (xe.GetAttribute("genre") == "李赞红")//如果genre属性值为“李赞红”
            //                {
            //                    xe.SetAttribute("genre", "update李赞红");//则修改该属性为“update李赞红”

            //                    XmlNodeList nls = xe.ChildNodes;//继续获取xe(xn)子节点的所有子节点
            //                    foreach (XmlNode xn1 in nls)//遍历
            //                    {
            //                        XmlElement xe2 = (XmlElement)xn1;//转换类型
            //                        if (xe2.Name == "author")//如果找到
            //                        {
            //                            xe2.InnerText = "亚胜";//则修改
            //                            break;//找到退出来
            //                        }
            //                    }
            //                    break;
            //                }
            //            }
            //            xmlDoc.Save(@"d:\bookstore.xml");//保存。

            //========================删除=========================

            //            XmlDocument xmlDoc = new XmlDocument();
            //            xmlDoc.Load(@"d:\bookstore.xml");
            //            XmlNodeList xnl = xmlDoc.SelectSingleNode("bookstore").ChildNodes;

            //            foreach (XmlNode xn in xnl)
            //            {
            //                XmlElement xe = (XmlElement)xn;

            //                if (xe.GetAttribute("genre") == "fantasy")
            //                {
            //                    xe.RemoveAttribute("genre");//删除genre属性
            //                }
            //                else if (xe.GetAttribute("genre") == "update李赞红")
            //                {
            //                    xe.RemoveAll();//删除该节点的全部内容
            //                }
            //            }
            //            xmlDoc.Save(@"d:\bookstore.xml");
            #endregion
        }
        public static void ColorToInt16(Byte R, Byte G, Byte B)
        {
            // return System.Drawing. //Translator.ToHtml(System.Drawing.Color.FromArgb(R, G, B));
            //return Convert.ToInt32(hex);
        }
    }
}
