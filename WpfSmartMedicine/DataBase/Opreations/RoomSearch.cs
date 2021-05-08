using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WpfSmartMedicine.DataBase.DataContexts;
using WpfSmartMedicine.DataBase.Models;

namespace WpfSmartMedicine.DataBase.Opreations
{
    public class RoomSearch
    {
        DataContext context = new DataContext();
        public string RoomID { get; set; }       

        public List<Room> Search()
        {
            List<Room> searchResult = context.Room.Where(p => p.ID.Contains(RoomID)).ToList();
            return searchResult;
        }
    }
}
