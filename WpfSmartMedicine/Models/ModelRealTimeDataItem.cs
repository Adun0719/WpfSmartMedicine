using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WpfSmartMedicine.Models
{
    public class ModelRealTimeDataItem:INotifyPropertyChanged
    {
        private string _RoomID;

        public string RoomID 
        {
            get
            {
                return _RoomID;
            }
            set
            {
                _RoomID = value;
                NotifyPropertyChaned("RoomID");
            }
        }

        private string _SensorValue;

        public string SensorValue
        { 
            get
            {
                return _SensorValue;
            }
            set 
            {
                _SensorValue = value;
                NotifyPropertyChaned("SemsorValue");
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChaned(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

         
    }
}
