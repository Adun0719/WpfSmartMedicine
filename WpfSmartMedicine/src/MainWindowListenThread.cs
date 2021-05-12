﻿using System;
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
            Model = new ModelMainWindow();
            Interval = 200;
        }

        public void Start()
        {
            Timer = new DispatcherTimer();
        }

        public void DateTimeChange()
        {
            Model.Date = DateTime.Now.ToLongDateString();
            Model.Time = DateTime.Now.ToLongTimeString();
        }

    }
}
