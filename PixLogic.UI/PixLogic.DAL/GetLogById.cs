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
            return itemQuery.First();
        }
    }
}
