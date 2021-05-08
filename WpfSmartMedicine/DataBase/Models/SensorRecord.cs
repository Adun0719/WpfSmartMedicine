using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WpfSmartMedicine.DataBase.Models
{
    public class SensorRecord
    {
        [Required, Key]
        public string ID { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required, MaxLength(10)]
        public Room Room { get; set; }
        [Required, MaxLength(50)]
        public string SensorName { get; set; }
        public string Status { get; set; }
        public decimal SensorData { get; set; }
    }
}
