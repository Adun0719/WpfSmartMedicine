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

        public DelegateCommand PortNameCommand { get; set; }

        public DelegateCommand SqlConnectStringCommand { get; set; }

        public DelegateCommand SaveCommand { get; set; }

        public ModelSetting Model { get; set; }

        public ViewModelSetting()
        {
            Model = new ModelSetting();
            PortNamesCommand = new DelegateCommand 
            {
                ExecuteCommand = new Action<object>(PortNamesCommandData)
            };
            PortNameCommand = new DelegateCommand
            {
                ExecuteCommand = new Action<object>(PortNameCommandData)
            };
            SqlConnectStringCommand = new DelegateCommand
            {
                ExecuteCommand = new Action<object>(SqlConnectStringCommandData)
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

        private void PortNameCommandData(object obj)
        {
            SettingXML xML = new SettingXML();
            Model.PortName = xML.XmlRead("PortName");
        }

        private void SqlConnectStringCommandData(object obj)
        {
            SettingXML xML = new SettingXML();
            Model.SqlConnectString = xML.XmlRead("SqlConnectString");
        }
        
        private void SaveCommandData(object obj)
        {
            SettingXML xML = new SettingXML();
            xML.PortName = Model.PortName;
            xML.SqlConnectString = Model.SqlConnectString;
            xML.XmlSave();
        }

    }
}
