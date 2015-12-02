using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace PixLogic.DAL
{
    public class GetAllLogs
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public List<Reservation> getAllLogs()
        {
            IQueryable<Reservation> reservQuery = from Reservation
                                                  in context.Reservations.Include(c => c.reservable).Include(c => c.manager).Include(c => c.user)
                                                  where Reservation.dateRendu != null
                                                  select Reservation;
            List<Reservation> list = new List<Reservation>();
            foreach (var prod in reservQuery)
            {
                list.Add(prod);
            }
            return list;
        }
        public List<Reservation> getAllLogsByString(string search)
        {
            search.ToLower();
            List<Reservation> reservations = getAllLogs();
            List<Reservation> results = reservations.FindAll(
            delegate (Reservation reservation)
            {
                if (reservation.reservable.name.ToLower().Contains(search)) return reservation.reservable.name.ToLower().Contains(search);
                else return reservation.user.name.ToLower().Contains(search);
            }
            );
            return results;
        }
    }
}
