using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace PixLogic.DAL
{
    public class GetAllReservationsByDate
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public List<Reservation> getAllReservationsByDate(DateTime dateDebut,DateTime dateFin)
        {
            IQueryable<Reservation> reservQuery = from Reservation
                                                  in context.Reservations.Include(c => c.reservable).Include(c => c.manager).Include(c => c.user)
                                                  where Reservation.beginDateEmprunt == null
                                                  where DateTime.Compare(Reservation.beginDateReservation.Value, dateDebut) >= 0
                                                  where DateTime.Compare(Reservation.endDateReservation.Value, dateFin) <= 0
                                                  orderby Reservation.beginDateReservation
                                                  select Reservation;
            List<Reservation> list = new List<Reservation>();
            foreach (var prod in reservQuery)
            {
                list.Add(prod);
            }
            
            return list;
        }
    }
}
