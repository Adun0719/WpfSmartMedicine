using System;
using System.Collections.Generic;
using System.Text;
using WpfSmartMedicine.Models;
using System.Threading;

namespace WpfSmartMedicine.src
{
    public class MainWindowListenThread
    {
        public Timer Timer { get; set; }

        public int Interval { get; set; }

        public ModelMainWindow Model { get; set; }

        public MainWindowListenThread()
        {
            Model = new ModelMainWindow();
            Interval = 200;
        }

        public void Start()
        {
            Timer = new Timer(p => DateTimeChange(),null,0,Interval);
        }

        public void DateTimeChange()
        {
            Model.Date = DateTime.Now.ToLongDateString();
            Model.Time = DateTime.Now.ToLongTimeString();
        }

    }
}
