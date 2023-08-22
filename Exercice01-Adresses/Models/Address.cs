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
        [Column("id")]
        public int Id { get; set; }
        [Column("street_number")]
        [StringLength(50)]
        public string? StreetNumber { get; set; }
        [Column("street_name")]
        [StringLength(200)]
        [Required]
        public string? StreetName { get; set; }
        [Column("additional_address")]
        [StringLength(150)]
        public string? AdditionalAddress { get; set; }
        [Column("city")]
        [StringLength(50)]
        [Required]
        public string? City { get; set; }
        [Column("postal_code")]
        [StringLength(5)]
        [Required]
        public string? PostalCode { get; set; }

        public override string ToString()
        {
            return $"{Id} - {StreetNumber}, {StreetName}{(AdditionalAddress != "" ? ", " + AdditionalAddress : "")}, {City} - {PostalCode}";
        }
    }
}
