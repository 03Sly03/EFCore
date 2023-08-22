using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02_Hotel.Models
{
    [Table("reservation")]
    internal class Reservation
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("client_id")]
        public int ClientId { get; set; }
        public Client? Client { get; set; }
        public List<ReservationRoom> ReservationRooms { get; set; } = new List<ReservationRoom>();
    }
}
