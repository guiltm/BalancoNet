using BalancoNET.HelpCodes.EnumTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BalancoNET.Models
{
    public class Operations
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public double Value { get; set; }

        public Category Category { get; set; }

        public DateTime Date { get; set; }

        [StringLength(100)]
        public String Observation { get; set; }

        [Required]
        public OperationType OperationTypes { get; set; } 
    }
}