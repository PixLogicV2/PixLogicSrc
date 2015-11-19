using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetAllReservations
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public List<Reservation> getAllReservations()
        {
            IQueryable<Reservation> reservQuery = from Reservation in context.Reservations
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
