using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask1.Models
{
    public class Order
    {
        public int id { get; set; }
        [Required]
        public string SenderCity { get; set; }
        [Required]
        public string SenderAddress { get; set; }
        [Required]
        public string RecieverCity { get; set; }
        [Required]
        public string RecieverAddress { get; set; }
        [Required]
        public float Weight { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
