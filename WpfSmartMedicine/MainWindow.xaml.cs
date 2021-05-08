using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WpfSmartMedicine.View;

namespace WpfSmartMedicine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            this.Dispatcher.Invoke(() => 
            {
                LbTitleDate.Content = DateTime.Now.ToLongDateString();
            });
            Timer_Loaded();
            FrameMainWindow.Content = new PageRealTimeData();
            RbRealTimeData.IsChecked = true;
        }

        public void Timer_Loaded()
        {
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LbTitleTime.Content = DateTime.Now.ToLongTimeString();
        }

        private void RbRealTimeData_Checked(object sender, RoutedEventArgs e)
        {
            FrameMainWindow.Content = new PageRealTimeData();
        }

        private void RbDataGrid_Checked(object sender, RoutedEventArgs e)
        {
            FrameMainWindow.Content = new PageDataGrid();
        }

        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            Setting set = new Setting();
            set.Show();
            this.Close();
        }
    }
}
