using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace WpfSmartMedicine.Model
{
    public class ModelInfoManagement : INotifyPropertyChanged
    {
        public DataTable UserTable{ get; set; }



        public event PropertyChangedEventHandler PropertyChanged;
    }
}
