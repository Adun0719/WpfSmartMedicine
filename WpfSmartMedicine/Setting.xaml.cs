﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using WpfSmartMedicine.src;

namespace WpfSmartMedicine
{
    /// <summary>
    /// Setting.xaml 的交互逻辑
    /// </summary>
    public partial class Setting : Window
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();

        }

        private void BtnSet_Click(object sender, RoutedEventArgs e)
        {
            SettingXML settingXML = new SettingXML();
            settingXML.XmlLoad();
            settingXML.path = $"{Directory.GetCurrentDirectory()}/conf.xml";
            settingXML.PortName = CmbPortNames.Text;
            settingXML.DataGridConnectString = TbDataGridUri.Text;
            settingXML.XmlSave();
        }
    }
}
