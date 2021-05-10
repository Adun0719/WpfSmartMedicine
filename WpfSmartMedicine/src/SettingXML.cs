using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace WpfSmartMedicine.src
{
    public class SettingXML
    {
        public string path;

        private XmlWriterSettings XmlWriterSettings = new XmlWriterSettings();

        private XmlReaderSettings XmlReaderSettings = new XmlReaderSettings();

        private XmlWriter xmlWriter;

        private XmlReader xmlReader;

        public string PortName { get; set; }

        public string SqlConnectString { get; set; }

        public void XmlSave()
        {
            XmlWriterSettings.ConformanceLevel = ConformanceLevel.Auto;
            xmlWriter = XmlWriter.Create("conf.xml",XmlWriterSettings);
            xmlWriter.WriteStartElement("CreateTime",DateTime.Now.ToString());
            xmlWriter.WriteAttributeString("PortName",PortName);
            xmlWriter.WriteAttributeString("SqlConnectString", SqlConnectString);
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
        }

        public string XmlRead(string str) 
        {
            XmlReaderSettings.ConformanceLevel = ConformanceLevel.Auto;
            xmlReader = XmlReader.Create("conf.xml", XmlReaderSettings);
            var result = xmlReader[str];
            xmlReader.Close();
            return result;
        }
    }
}
