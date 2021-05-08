using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WpfSmartMedicine.DataBase.Models
{
    public class User
    {
        [Required,Key]
        public int ID { get; set; }
        [Required,MaxLength(20)]
        public string Name { get; set; }

        public int Age { get; set; }
        [Required,MaxLength(5)]
        public string Sex { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
    }
}
