using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace PixLogic.DAL
{
    public class GetAllReservationsByReservableId
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public List<Reservation> getAllReservationsByReservableId(int id)
        {
            IQueryable<Reservation> reservQuery = from Reservation
                                                  in context.Reservations.Include(c => c.reservable).Include(c => c.manager).Include(c => c.user)
                                                  where Reservation.beginDateEmprunt == null
                                                  where Reservation.reservable.ReservableId == id
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
