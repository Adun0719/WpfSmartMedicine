using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfSmartMedicine.DataBase.Models
{
    public class SensorRecord
    {
        [Required, Key]
        public string ID { get; set; }
        [Required, MaxLength(10)]
        public string RoomID { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [ForeignKey("RoomID")]
        public Room Room { get; set; }
        [Required, MaxLength(50)]
        public string SensorName { get; set; }
        [MaxLength(50)]
        public string Status { get; set; }
        public decimal SensorData { get; set; }
    }
}
