using System;
using System.Collections.Generic;
using System.Text;
using WpfSmartMedicine.Commands;
using WpfSmartMedicine.Models;
using WpfSmartMedicine.DataBase.Opreations;
using WpfSmartMedicine.DataBase.Models;
using System.Linq;

namespace WpfSmartMedicine.ViewModels
{
    public class ViewModelInfoManagement
    {
        public DelegateCommand UserCommand { get; set; }

        public DelegateCommand RoomCommand { get; set; }

        public ModelInfoManagement Model { get; set; }

        public ViewModelInfoManagement()
        {
            Model = new ModelInfoManagement();
            UserCommand = new DelegateCommand
            {
                ExecuteCommand = new Action<object>(UserCommandData)
            };
            RoomCommand = new DelegateCommand
            {
                ExecuteCommand = new Action<object>(RoomCommandData)
            };
        }

        private void UserCommandData(object obj)
        {
            var userSearch = new UserSearch();
            userSearch.UserName = Model.UserName;
            Model.UserTable = userSearch.Search();
        }

        private void RoomCommandData(object obj)
        {
            var roomSearch = new RoomSearch();
            roomSearch.RoomID = Model.RoomId;
            Model.RoomTable = roomSearch.Search();
        }

    }
}
