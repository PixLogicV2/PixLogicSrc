using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace PixLogic.DAL
{
   public class GetAllEmprunts
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public List<Reservation> getAllEmprunts()
        {
            IQueryable<Reservation> reservQuery = from Reservation
                                                  in context.Reservations.Include(c => c.reservable).Include(c => c.manager).Include(c => c.user)
                                                  where Reservation.beginDateReservation == null
                                                  where Reservation.dateRendu == null
                                                  select Reservation;
            List<Reservation> list = new List<Reservation>();
            foreach (var prod in reservQuery)
            {
                list.Add(prod);
            }
            return list;
        }
        public List<Reservation> getAllEmpruntsByDate(DateTime dateDebut, DateTime dateFin)
        {
            IQueryable<Reservation> reservQuery = from Reservation
                                                  in context.Reservations.Include(c => c.reservable).Include(c => c.manager).Include(c => c.user)
                                                  where Reservation.beginDateReservation == null
                                                  where Reservation.dateRendu==null
                                                  //where DateTime.Compare(Reservation.beginDateEmprunt.Value, dateDebut) >= 0
                                                 // where DateTime.Compare(Reservation.endDateEmprunt.Value, dateFin) <= 0
                                                  orderby Reservation.beginDateReservation
                                                  select Reservation;
            List<Reservation> list = new List<Reservation>();
            foreach (var prod in reservQuery)
            {
                if(DateTime.Compare(prod.beginDateEmprunt.Value.Date, dateDebut.Date) >= 0 && DateTime.Compare(prod.endDateEmprunt.Value.Date, dateFin.Date) <= 0)
                list.Add(prod);
            }

            return list;
        }
        public List<Reservation> getAllEmpruntsByDateFin(DateTime dateFin)
        {
            IQueryable<Reservation> reservQuery = from Reservation
                                                  in context.Reservations.Include(c => c.reservable).Include(c => c.manager).Include(c => c.user)
                                                  where Reservation.beginDateReservation == null
                                                  where Reservation.dateRendu == null
                                                 //where DateTime.Compare(Reservation.endDateEmprunt.Value.Date,dateFin.Date)==0
                                                  orderby Reservation.beginDateReservation
                                                  select Reservation;
            List<Reservation> list = new List<Reservation>();
            foreach (var prod in reservQuery)
            {
                if(DateTime.Compare(prod.endDateEmprunt.Value.Date, dateFin.Date) == 0)
                list.Add(prod);

            }

            return list;
        }
        public List<Reservation> getAllEmpruntsByString(string search)
        {
            search.ToLower();
            List<Reservation> reservations = getAllEmprunts();
            List<Reservation> results = reservations.FindAll(
            delegate (Reservation reservation)
            {
                if (reservation.reservable.name.ToLower().Contains(search)) return reservation.reservable.name.ToLower().Contains(search);
                else return reservation.user.name.ToLower().Contains(search);
            }
            );
            return results;
        }
        public List<Reservation> getAllEmpruntsByReservableId(int id)
        {
            IQueryable<Reservation> reservQuery = from Reservation
                                                  in context.Reservations.Include(c => c.reservable).Include(c => c.manager).Include(c => c.user)
                                                  where Reservation.beginDateReservation == null
                                                  where Reservation.dateRendu == null
                                                  where Reservation.reservable.ReservableId == id
                                                  orderby (Reservation.beginDateReservation)
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
