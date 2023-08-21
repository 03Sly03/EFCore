using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01_Adresses.Models
{
    [Table("addresse")]
    internal class Address
    {
        public int Id { get; set; }
        public int StreetNumber { get; set; }
        [Required]
        public string? StreetName { get; set; }
        public string? AdditionalAddress { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? PostalCode { get; set; }

        public override string ToString()
        {
            return $"{Id} - {StreetNumber}, {StreetName}{(AdditionalAddress != "" ? ", " + AdditionalAddress : "")}, {City} - {PostalCode}";
        }
    }
}
