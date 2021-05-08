using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WpfSmartMedicine.DataBase.Models
{
    public class Room
    {
        [Required,Key,MaxLength(10)]
        public string ID { get; set; }

    }
}
