using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class DeleteLog
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void deleteLogByReservableName(string name)
        {
            List<Log> logs;
            logs = context.Logs.Where(s => s.reservableName == name).ToList();
            foreach(Log l in logs)context.Entry(l).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public void deleteLogByDate(DateTime debut, DateTime fin)
        {
            List<Log> logs;
            logs = context.Logs.ToList();
            foreach (Log l in logs)
            {
                if(l.beginDateEmprunt.Value.Date>debut.Date && l.endDateEmprunt.Value.Date<fin.Date)
                context.Entry(l).State = System.Data.Entity.EntityState.Deleted;
            }
            context.SaveChanges();
        }
        public void deleteLogById(int id)
        {
            var log = (from s in context.Logs
                        where s.LogId == id
                        select s).FirstOrDefault();

            context.Entry(log).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
