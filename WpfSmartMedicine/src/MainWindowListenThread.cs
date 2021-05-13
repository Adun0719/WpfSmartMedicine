using System;
using System.Collections.Generic;
using System.Text;
using WpfSmartMedicine.Models;
using System.Windows.Threading;

namespace WpfSmartMedicine.src
{
    public class MainWindowListenThread
    {
        public DispatcherTimer Timer { get; set; }

        public int Interval { get; set; }

        public ModelMainWindow Model { get; set; }

        public MainWindowListenThread()
        {
            Interval = 200;
            Timer = new DispatcherTimer();
            Timer.Tick += DateTimeChange;
            Timer.Interval = TimeSpan.FromMilliseconds(Interval);
        }

        public void Start()
        {
            Timer.Start();
        }

        private void DateTimeChange(object sender, EventArgs e)
        {
            Model.Date = DateTime.Now.ToLongDateString();
            Model.Time = DateTime.Now.ToLongTimeString();
        }

    }
}
