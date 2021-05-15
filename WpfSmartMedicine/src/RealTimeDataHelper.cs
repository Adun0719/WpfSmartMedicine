﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

using WpfSmartMedicine.Views;

namespace WpfSmartMedicine.src
{
    public class RealTimeDataHelper:Grid
    {
        public RealTimeDataHelper()
        {
        }

        private void Init()
        {
            this.Children.Add(new Frame()
            {
                Content = new PageRealTimeDataItem(),
            }) ;
        }
    }
}
