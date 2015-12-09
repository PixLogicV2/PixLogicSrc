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
        public List<Log> getAllLogs()
        {
            IQueryable<Log> reservQuery = from Log
                                                  in context.Logs
                                                  select Log;
            List<Log> list = new List<Log>();
            foreach (var prod in reservQuery)
            {
                list.Add(prod);
            }
            return list;
        }
        public List<Log> getAllLogsByString(string search)
        {
            search.ToLower();
            List<Log> reservations = getAllLogs();
            List<Log> results = reservations.FindAll(
            delegate (Log reservation)
            {
                if (reservation.reservableName.ToLower().Contains(search)) return reservation.reservableName.ToLower().Contains(search);
                else return reservation.userName.ToLower().Contains(search);
            }
            );
            return results;
        }
        public List<Log> getAllLogsByDate(DateTime dateDebut, DateTime dateFin)
        {
            IQueryable<Log> reservQuery = from Log
                                                  in context.Logs
                                                  where DateTime.Compare(Log.beginDateEmprunt.Value, dateDebut) >= 0
                                                  where DateTime.Compare(Log.endDateEmprunt.Value, dateFin) <= 0
                                                  orderby Log.beginDateEmprunt
                                                  select Log;
            List<Log> list = new List<Log>();
            foreach (var prod in reservQuery)
            {
                list.Add(prod);
            }

            return list;
        }
    }
}
