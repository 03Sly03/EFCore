using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02_Hotel.Models
{
    [Table("room")]
    internal class Room
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("number_of_bed")]
        [Required]
        public int NumberOfBed { get; set; }
        [Column("price")]
        [Required]
        public decimal Price { get; set; }
        [Column("client_id")]
        public List<ReservationRoom> ReservationRooms { get; set; } = new List<ReservationRoom>();
    }
}
