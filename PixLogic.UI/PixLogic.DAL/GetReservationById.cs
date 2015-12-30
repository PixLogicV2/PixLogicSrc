using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetReservationById
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public Reservation getReservationById(int id)
        {
            IQueryable<Reservation> reservQuery = from Reservation in context.Reservations
                                                  where Reservation.ReservationId == id
                                         select Reservation;
            return reservQuery.First();
        }
    }
}
