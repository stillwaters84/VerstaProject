using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask1.Models
{
    public class Order
    {
        public int id { get; set; }
        public string SenderCity { get; set; }
        public string SenderAddress { get; set; }
        public string RecieverCity { get; set; }
        public string RecieverAddress { get; set; }
        public float Weight { get; set; }
        public DateTime Date { get; set; }
    }
}
