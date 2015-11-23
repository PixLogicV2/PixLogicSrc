using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    [Table("Reservation")]
    public class Reservation
    {
        public int ReservationId { get; set; }
        public bool isPack { get; set; }
        public DateTime ? beginDateReservation { get; set; }
        public DateTime ? endDateReservation { get; set; }
        public DateTime ? beginDateEmprunt { get; set; }
        public DateTime ? endDateEmprunt { get; set; }
        public User user { get; set; }
        public Reservable reservable { get; set; }
        public Manager manager { get; set; }
    }
}
