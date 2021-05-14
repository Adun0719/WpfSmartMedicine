using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using WpfSmartMedicine.Views;
using WpfSmartMedicine.ViewModels;
using System.Windows.Controls;

namespace WpfSmartMedicine.Models
{
    public class ModelRealTimeData : INotifyPropertyChanged
    {
        private int _RoomNum;

        public int RoomNum 
        {
            get
            {
                return _RoomNum;
            }
            set
            {
                _RoomNum = value;
                NotifyPropertyChanged("RoomNum");
            }
        }

        private List<ModelRealTimeDataItem> _ModelRealTimeDataItems;

        public List<ModelRealTimeDataItem> ModelRealTimeDataItems 
        {
            get 
            {
                return _ModelRealTimeDataItems;
            }
            set
            {
                _ModelRealTimeDataItems = value;
                NotifyPropertyChanged("ModelRealTimeDataItems");
            }
        }

        private List<PageRealTimeDataItem> _PageInfoManagementItems;

        public List<PageRealTimeDataItem> PageInfoManagementItems 
        { 
            get 
            {
                return _PageInfoManagementItems;
            }
            set 
            {
                _PageInfoManagementItems = value;
                NotifyPropertyChanged("PageInfoManagementItems");
            }
        }

        private ViewModelRealTimeDataItem _ViewModelRealTimeDataItem;

        public ViewModelRealTimeDataItem ViewModelRealTimeDataItem
        {
            get
            {
                return _ViewModelRealTimeDataItem;
            }
            set
            {
                _ViewModelRealTimeDataItem = value;
                NotifyPropertyChanged("ViewModelRealTimeDataItem");
            }
        }


        private List<Frame> _Frames { get; set; }

        public List<Frame> Frames
        {
            get
            {
                return _Frames;
            }
            set
            {
                _Frames = value;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
