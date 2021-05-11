using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using WpfSmartMedicine.src;
using System.IO.Ports;
using System.Linq;

namespace WpfSmartMedicine.Models
{
    public class ModelSetting:INotifyPropertyChanged
    {
        #region 串口下拉框列表和选中数据
        private List<string> _PortNames;

        public List<string> PortNames
        {
            get 
            {
                return _PortNames;
            }
            set 
            {
                _PortNames = value;
                NotifyPropertyChanged("PortNames");
            } 
        }

        private string _PortName;

        public string PortName 
        {
            get
            {
                return _PortName;
            }
            set 
            {
                _PortName = value;
                NotifyPropertyChanged("PortName");
            }
        }
        #endregion

        #region 连接字符串数据
        private string _SqlConnnectString;

        public string SqlConnectString 
        {
            get 
            {
                return _SqlConnnectString;
            } 
            set
            {
                _SqlConnnectString = value;
                NotifyPropertyChanged("SqlConnectString");
            } 
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName) 
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }

        public ModelSetting() 
        {
            PortNames = SerialPort.GetPortNames().ToList();
            SettingXML xML = new SettingXML();
            xML.XmlCreate();//检测配置文件是否存在，否则生成
            SqlConnectString = xML.XmlRead("SqlConnectString");
        }
    }
}
