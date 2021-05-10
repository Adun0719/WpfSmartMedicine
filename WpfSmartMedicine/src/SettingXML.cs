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

        private XmlWriterSettings XmlWriterSettings = new XmlWriterSettings();

        private XmlReaderSettings XmlReaderSettings = new XmlReaderSettings();

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

        public string XmlRead(string str) 
        {
            //待补充
            xElement = XElement.Load("conf.xml");
            string result = xElement.Element(str).Value.Trim();
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
