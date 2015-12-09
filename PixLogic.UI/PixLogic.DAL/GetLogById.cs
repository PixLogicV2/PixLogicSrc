using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetLogById
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public Log getLogById(int id)
        {
            IQueryable<Log> itemQuery = from Log in context.Logs
                                         where Log.LogId == id
                                         select Log;
            List<Log> list = new List<Log>();
            foreach (var prod in itemQuery)
            {
                list.Add(prod);
            }
            return list.First();
        }
    }
}
