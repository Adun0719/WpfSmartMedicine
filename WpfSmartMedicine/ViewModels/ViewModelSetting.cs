using System;
using System.Collections.Generic;
using System.Text;
using WpfSmartMedicine.src;
using WpfSmartMedicine.Commands;
using WpfSmartMedicine.Models;
using System.IO.Ports;
using System.Linq;

namespace WpfSmartMedicine.ViewModels
{
    public class ViewModelSetting
    {
        public DelegateCommand PortNamesCommand { get; set; }

        public DelegateCommand SaveCommand { get; set; }

        public ModelSetting Model { get; set; }

        public ViewModelSetting()
        {
            Model = new ModelSetting();
            PortNamesCommand = new DelegateCommand 
            {
                ExecuteCommand = new Action<object>(PortNamesCommandData)
            };
            SaveCommand = new DelegateCommand
            {
                ExecuteCommand = new Action<object>(SaveCommandData)
            };
            Model.PortNames = SerialPort.GetPortNames().ToList();
            SettingXML xML = new SettingXML();
            xML.XmlCreate();
            Model.SqlConnectString = xML.XmlRead("SqlConnectString");
        }

        private void PortNamesCommandData(object obj)
        {
            Model.PortNames = SerialPort.GetPortNames().ToList();
        }
        
        private void SaveCommandData(object obj)
        {
            SettingXML xML = new SettingXML
            {
                PortName = Model.PortName,
                SqlConnectString = Model.SqlConnectString
            };
            xML.XmlSave();
        }

    }
}
