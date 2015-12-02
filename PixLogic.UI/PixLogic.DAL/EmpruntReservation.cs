using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class EmpruntReservation
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void empruntReservation(int idReservation)
        {
            Reservation reservation;
            reservation = context.Reservations.Where(s => s.ReservationId == idReservation).FirstOrDefault<Reservation>();

            if (reservation != null)
            {
                reservation.beginDateEmprunt = reservation.beginDateReservation;
                reservation.endDateEmprunt = reservation.endDateReservation;
                reservation.beginDateReservation = null;
                reservation.endDateReservation = null;
                context.Entry(reservation).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
