using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WpfSmartMedicine.Models
{
    public class ModelMainWindow : INotifyPropertyChanged
    {
        private DateTime _LocalTime;

        public DateTime LocalTime 
        { 
            get 
            {
                return _LocalTime; 
            } 
            set 
            {
                _LocalTime = value;
                NotifyPropertyChanged("LocalTime");
            } 
        }
        public bool NetConnectStatus { get; set; }
        public bool ComConnectStatus { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
