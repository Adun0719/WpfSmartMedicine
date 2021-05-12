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
        }
        /// <summary>
        /// 读取当前串口列表
        /// </summary>
        /// <param name="obj"></param>
        private void PortNamesCommandData(object obj)
        {
            Model.PortNames = SerialPort.GetPortNames().ToList();
        }
        
        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="obj"></param>
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
