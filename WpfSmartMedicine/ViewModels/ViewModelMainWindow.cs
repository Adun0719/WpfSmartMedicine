using System;
using System.Collections.Generic;
using System.Text;
using WpfSmartMedicine.Models;
using WpfSmartMedicine.src;

namespace WpfSmartMedicine.ViewModels
{
    public class ViewModelMainWindow
    {
        public ModelMainWindow Model { get; set; }

        public ViewModelMainWindow()
        {
            Model = new ModelMainWindow();
            var thread = new MainWindowListenThread
            {
                Model = Model
            };
            thread.Start();
        }

    }
}
