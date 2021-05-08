using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfSmartMedicine.ViewModels;

namespace WpfSmartMedicine.Views
{
    /// <summary>
    /// PageInfoManagement.xaml 的交互逻辑
    /// </summary>
    public partial class PageInfoManagement : Page
    {
        public PageInfoManagement()
        {
            InitializeComponent();
            DataContext = new ViewModelInfoManagement();
        }
    }
}
