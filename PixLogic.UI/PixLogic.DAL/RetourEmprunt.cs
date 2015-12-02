using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class RetourEmprunt
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void retourEmprunt(int idReservation,DateTime? rendu)
        {
            Reservation reservation;
            reservation = context.Reservations.Where(s => s.ReservationId == idReservation).FirstOrDefault<Reservation>();

            if (reservation != null)
            {
                reservation.dateRendu = rendu;
                context.Entry(reservation).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
