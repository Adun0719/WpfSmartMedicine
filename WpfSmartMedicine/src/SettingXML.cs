using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace WpfSmartMedicine.src
{
    public class SettingXML
    {
        public string path;

        private XmlDocument Xml = new XmlDocument();

        public string PortName { get; set; }

        public string DataGridConnectString { get; set; }

        public void XmlLoad()
        {
            var time = Xml.CreateElement("Time",$"{DateTime.Now}");
            Xml.AppendChild(time);
        }

        public void XmlSave()
        {
            var port = Xml.CreateElement("PortName",PortName);
            var dataGridConnectString = Xml.CreateElement("DataGridConnectString", DataGridConnectString);
            Xml.AppendChild(dataGridConnectString);
            Xml.Save(path);
        }
    }
}
