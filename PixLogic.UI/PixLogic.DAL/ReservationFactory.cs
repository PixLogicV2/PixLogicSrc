using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class ReservationFactory
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public Reservation build(bool isPack, DateTime beginDateReservation, DateTime endDateReservation,
            DateTime beginDateEmprunt, DateTime endDateEmprunt, int idUser, int idElement, int idManager)
        {
            Reservation reservation = new Reservation();

            reservation.isPack = isPack;
            reservation.beginDateReservation = beginDateReservation;
            reservation.endDateReservation = endDateReservation;
            reservation.beginDateEmprunt = beginDateEmprunt;
            reservation.endDateEmprunt = endDateEmprunt;
            reservation.user = context.Users.Where(s => s.UserId == idUser).FirstOrDefault();
            reservation.reservable = context.Reservables.Where(s => s.ReservableId == idElement).FirstOrDefault();
            reservation.manager = context.Managers.Where(s => s.ManagerId == idManager).FirstOrDefault();

            return reservation;
        }
    }
}
