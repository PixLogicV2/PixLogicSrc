using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class ContainReservationByReservableId
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public bool containReservationByReservableId(int id)
        {
            IQueryable<Reservation> reservationQuery = from Reservation in context.Reservations
                                                       where Reservation.reservable.ReservableId == id
                                                       select Reservation;
            if (reservationQuery.Any()) return true;
            return false;

        }
    }
}
