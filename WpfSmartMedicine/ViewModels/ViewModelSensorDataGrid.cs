using System;
using System.Collections.Generic;
using System.Text;
using WpfSmartMedicine.Models;
using WpfSmartMedicine.Commands;
using WpfSmartMedicine.DataBase.Opreations;


namespace WpfSmartMedicine.ViewModels
{
    public class ViewModelSensorDataGrid
    {
        public ModelSensorDataGrid Model { get; set; }

        public DelegateCommand SelectCommand { get; set; }

        public ViewModelSensorDataGrid()
        {
            Model = new ModelSensorDataGrid();
            SelectCommand = new DelegateCommand
            {
                ExecuteCommand = new Action<object>(SelectCommandData)
            };
        }

        private void SelectCommandData(object obj)
        {
            var sensorSearch = new SensorSearch()
            {
                SensorName = Model.SensorName
            };
            Model.SensorRecords = sensorSearch.Search();
        }
    }
}
