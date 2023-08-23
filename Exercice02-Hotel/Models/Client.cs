using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02_Hotel.Models
{
    [Table("client")]
    internal class Client
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("lastname")]
        [StringLength(100)]
        [Required]
        public string? Lastname { get; set; }
        [Column("firstname")]
        [StringLength(100)]
        [Required]
        public string? Firstname { get; set; }
        [Column("phone")]
        [StringLength(20)]
        [Required]
        public string? Phone { get; set; }
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

        public override string ToString()
        {
            return $"{Id} - {Lastname!.ToUpper()} {Firstname} - Tel : {Phone}";
        }
    }
}
