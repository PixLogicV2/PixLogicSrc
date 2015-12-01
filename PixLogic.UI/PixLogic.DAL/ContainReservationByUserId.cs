using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class ContainReservationByUserId
    {

        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public bool containReservationByUserId(string name)
        {
            IQueryable<Reservation> reservationQuery = from Reservation in context.Reservations
                                         where Reservation.user.name == name
                                         select Reservation;
            if (reservationQuery.Any()) return true;
            return false;

        }
    }
}
