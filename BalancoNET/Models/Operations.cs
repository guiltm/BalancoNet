using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancoNET.Models
{
    public abstract class Operations
    {
        private int ID { get; set; }

        [Required]
        private double Value { get; set; }

        public Category Category { get; set; }

        public DateTime Date { get; set; }
        
        [StringLength(100)]
        public String Observation { get; set; }
    }
}
