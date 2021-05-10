using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using WpfSmartMedicine.DataBase.Models;

namespace WpfSmartMedicine.Models
{
    public class ModelInfoManagement : INotifyPropertyChanged
    {
        private List<User> _UserTable;
        public List<User> UserTable
        {
            get 
            {
                return _UserTable;
            }
            set 
            {
                _UserTable = value;
                NotifyPropertyChanged("UserTable");
            }
        }

        private List<Room> _RoomTable;
        public List<Room> RoomTable
        {
            get
            {
                return _RoomTable;
            }
            set
            {
                _RoomTable = value;
                NotifyPropertyChanged("RoomTable");
            }
        }

        public string RoomId { get; set; }

        public string UserName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
