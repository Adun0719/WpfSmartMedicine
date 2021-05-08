using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfSmartMedicine.DataBase.Models
{
    public class User
    {
        [Required,Key]
        public string ID { get; set; }
        [Required,MaxLength(20)]
        public string Name { get; set; }
        [Required, MaxLength(10)]
        public string RoomID { get; set; }
        [ForeignKey("RoomID")]
        public Room Room { get; set; }
        [Required,MaxLength(3),Range(0,150)]
        public int Age { get; set; }
        [Required,MaxLength(5)]
        public string Sex { get; set; }
        [Required,Column(TypeName = "date")]
        public DateTime Birthday { get; set; }
    }
}
