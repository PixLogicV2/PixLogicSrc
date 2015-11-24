using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class UpdateReservation
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void updateReservation(int idReservation,DateTime? DateDebut,DateTime? DateFin)
        {
            Reservation reservation;
            reservation = context.Reservations.Where(s => s.ReservationId == idReservation).FirstOrDefault<Reservation>();

            if (reservation != null)
            {
                reservation.beginDateReservation = DateDebut;
                reservation.endDateReservation = DateFin;
                context.Entry(reservation).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
