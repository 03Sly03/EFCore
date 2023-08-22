using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02_Hotel.Models
{
    internal class ReservationRoom
    {
        public int Id { get; set; }
        [Column("room_id")]
        public int RoomId { get; set; }
        public Room? Room { get; set; }
        [Column("reservation_id")]
        public int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
    }
}
