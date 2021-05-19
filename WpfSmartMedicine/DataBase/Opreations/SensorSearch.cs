using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WpfSmartMedicine.DataBase.DataContexts;
using WpfSmartMedicine.DataBase.Models;


namespace WpfSmartMedicine.DataBase.Opreations
{
    public class SensorSearch
    {
        readonly DataContext context = new DataContext();
        public string SensorName { get; set; }

        public List<SensorRecord> Search()
        {
            List<SensorRecord> searchResult = context.SensorRecord.Where(p => p.RoomID.Contains(SensorName)).ToList();
            return searchResult;
        }

    }
}
