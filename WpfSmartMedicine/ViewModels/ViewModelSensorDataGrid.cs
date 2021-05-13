using System;
using System.Collections.Generic;
using System.Text;
using WpfSmartMedicine.Models;

namespace WpfSmartMedicine.ViewModels
{
    public class ViewModelSensorDataGrid
    {
        public ModelSensorDataGrid Model { get; set; }

        public ViewModelSensorDataGrid()
        {
            Model = new ModelSensorDataGrid();
        }
    }
}
