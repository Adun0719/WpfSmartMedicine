using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using WpfSmartMedicine.src;
using WpfSmartMedicine.ViewModels;

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
            } 
        }

        private string _Date;

        public string Date 
        {
            get 
            {
                return _Date;
            }
            set 
            {
                _Date = value;
                NotifyPropertyChanged("Date");
            }
        }

        private string _Time;

        public string Time 
        {
            get 
            {
                return _Time;
            }
            set
            {
                _Time = value;
                NotifyPropertyChanged("Time");
            } 
        }


        public bool NetConnectStatus { get; set; }
        public bool ComConnectStatus { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ModelMainWindow()
        {
            var thread = new MainWindowListenThread
            {
                Model = this
            };
            thread.Start();
        }
    }
}
