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
        #region 用户查询结果
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
        #endregion

        #region 房间查询结果
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
        #endregion

        public string RoomId { get; set; }

        public string UserName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
