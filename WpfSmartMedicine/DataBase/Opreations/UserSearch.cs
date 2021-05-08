using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WpfSmartMedicine.DataBase.DataContexts;
using WpfSmartMedicine.DataBase.Models;

namespace WpfSmartMedicine.DataBase.Opreations
{
    public class UserSearch
    {
        readonly DataContext context = new DataContext();
        public string UserName { get; set; }

        public List<User> Search()
        {
            List<User> searchResult = context.User.Where(p => p.Name.Contains(UserName)).ToList();
            return searchResult;
        }
    }
}