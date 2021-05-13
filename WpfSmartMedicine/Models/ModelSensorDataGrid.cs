using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

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
