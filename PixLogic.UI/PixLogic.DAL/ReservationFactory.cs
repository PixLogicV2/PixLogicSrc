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

        public Reservation build(bool isPack, DateTime? beginDateReservation, DateTime? endDateReservation,
            DateTime? beginDateEmprunt, DateTime? endDateEmprunt, User user, Reservable element, Manager manager)
        {
            Reservation reservation = new Reservation();

            reservation.isPack = isPack;
            reservation.beginDateReservation = beginDateReservation;
            reservation.endDateReservation = endDateReservation;
            reservation.beginDateEmprunt = beginDateEmprunt;
            reservation.endDateEmprunt = endDateEmprunt;
            reservation.user = user;
            reservation.reservable = element;
            reservation.manager = manager;
            reservation.dateRendu = null;

            return reservation;
        }
    }
}
