using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCodeFirstSoultion.Models
{
    public class Customer
    {
        public Customer() { }   // default constructor

        public int Id { get; set; }         // c sharp will recognize Id as a primary key for a class
        [StringLength(10), Required]        // required = not nullable
        public string Code { get; set; }    // this must be a unique value 
        [StringLength(50), Required]
        public string Name { get; set; }
        public bool IsNational { get; set; }
        [Column(TypeName = "Decimal(9,2)")]
        public decimal Sales { get; set; }
        
        public DateTime DateCreated { get; set; }
    }
}
