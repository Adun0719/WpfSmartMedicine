using System;
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

using WpfSmartMedicine.Models;
using WpfSmartMedicine.Views;

namespace WpfSmartMedicine.src
{
    public class DynamicGrid:WrapPanel
    {
        private int _ItemNum;

        public int ItemNum 
        { 
            get 
            {
                return _ItemNum;
            } 
            set 
            {
                _ItemNum = value;
            }
        }

        public DynamicGrid()
        {
            Orientation = Orientation.Vertical;
        }

        public DynamicGrid Init()
        {
            //for(int i = 0; i < ItemNum; i++)
            //{
            //    this.Children.Add(new Frame()
            //    {
            //        Content = new PageRealTimeDataItem()
            //    });
            //}
            var model = new ModelRealTimeDataItem
            {
                RoomID = "1001",
                SensorValue = "正常"
            };
            this.Children.Add(new Frame()
            {
                Content = new PageRealTimeDataItem() 
                { 
                    DataContext = model
                }
            });
            var model1 = new ModelRealTimeDataItem
            {
                RoomID = "1002",
                SensorValue = "异常"
            };
            this.Children.Add(new Frame()
            {
                Content = new PageRealTimeDataItem()
                {
                    DataContext = model1
                }
            });

            return this;
            //Grid.Children.Add(new TextBlock() 
            //{ 
            //    FontSize = 50, 
            //    Text = "Hello World", 
            //    Visibility = Visibility.Visible,
            //    Height = 30,
            //    Width = 80
            //}); ;
        }
    }
}
