using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace WpfSmartMedicine.src
{
    public class SettingXML
    {
        public string path;

        private readonly XmlWriterSettings XmlWriterSettings = new XmlWriterSettings();

        private XmlWriter xmlWriter;

        private XElement xElement;

        public string PortName { get; set; }

        public string SqlConnectString { get; set; }

        public void XmlSave()
        {
            XmlWriterSettings.ConformanceLevel = ConformanceLevel.Auto;
            xmlWriter = XmlWriter.Create("conf.xml",XmlWriterSettings);
            xmlWriter.WriteStartElement("Config");
            xmlWriter.WriteElementString("CreateTime", DateTime.Now.ToString());
            xmlWriter.WriteElementString("PortName", PortName);
            xmlWriter.WriteElementString("SqlConnectString",
                SqlConnectString);
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
        }
        /* 示例：
         * <Config>
         *      <CreateTime>2021/5/12 星期三 1:51:40</CreateTime>
         *      <PortName>COM1</PortName>
         *      <SqlConnectString>Data Source=NEWLAND-PC;Integrated Security=True;Initial Catalog=SmartMedicine</SqlConnectString>
         * </Config>
         * */

        public string XmlRead(string str) 
        {
            xElement = XElement.Load("conf.xml");
            string result = xElement?.Element(str).Value.Trim();
            return result;
        }

        public void XmlCreate()
        {
            if (File.Exists("conf.xml"))
            {
                return;
            }
            XmlSave();
        }
    }
}
