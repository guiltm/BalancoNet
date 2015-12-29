using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancoNET.Models
{
    public abstract class Transaction
    {
        private int ID { get; set; }
        private double Value { get; set; }
        public Category Category { get; set; }
        public DateTime Date { get; set; }
        public String Observation { get; set; }
    }
}
