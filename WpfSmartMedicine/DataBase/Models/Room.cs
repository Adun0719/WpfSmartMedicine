using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WpfSmartMedicine.DataBase.Models
{
    public class Room
    {
        public string ID { get; set; }

        public List<User> UserInfos { get; set; }

        public Room()
        {
            UserInfos = new List<User>();

        }
    }
}
