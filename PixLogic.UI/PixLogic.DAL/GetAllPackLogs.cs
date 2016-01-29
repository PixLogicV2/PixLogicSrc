using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class GetAllPackLogs
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public List<Log> getAllPackLogs(List<Log> list)
        {
            List<Log> result = new List<Log>();
            foreach (var l in list)
            {
                if (l.isPack == true) result.Add(l);
            }
            return result;
        }
        public List<Log> getAllItemLogs(List<Log> list)
        {
            List<Log> result = new List<Log>();
            foreach (var l in list)
            {
                if (l.isPack == false) result.Add(l);
            }
            return result;
        }
    }
}
