using CeLaFaremoMVC.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CeLaFaremoMVC.Models
{
    public class Electronic
    {
        [Key] 
        public int Id { get; set; }
        public Categories Category { get; set; }
        public List<Laptop> Laptops { get; set; }
        public List<Phone> Phones { get; set; }
    }
}
