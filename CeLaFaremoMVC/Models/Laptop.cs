using CeLaFaremoMVC.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CeLaFaremoMVC.Models
{
    public class Laptop
    {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Modello { get; set; }
        public int RamMemory { get; set; }
        public int SsdMemory { get; set; }
        public Categories Categories { get; set; }
        public int ElectronicId { get; set; }
    }
}
