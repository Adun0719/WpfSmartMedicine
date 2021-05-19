using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using WpfSmartMedicine.DataBase.Models;
namespace WpfSmartMedicine.Models
{
    public class ModelSensorDataGrid : INotifyPropertyChanged
    {
        private List<string> _SearchModel;

        public List<string> SearchModel 
        {
            get{ return _SearchModel; }
            set
            {
                _SearchModel = value;
                NotifyPropertyChanged("SearchModel");
            }
        }

        private string _SensorName;

        public string SensorName 
        {
            get 
            {
                return _SensorName;
            }
            set 
            {
                _SensorName = value;
                NotifyPropertyChanged("SensorName");
            } 
        }

        private List<SensorRecord> _SensorRecords;

        public List<SensorRecord> SensorRecords 
        {
            get 
            {
                return _SensorRecords;
            }
            set 
            {
                _SensorRecords = value;
                NotifyPropertyChanged("SensorRecords");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ModelSensorDataGrid()
        {
            SearchModel = new List<string>
            {
                "最近三天",
                "最近一周",
                "最近一个月",
                "最近三个月"
            };
        }
    }
}
