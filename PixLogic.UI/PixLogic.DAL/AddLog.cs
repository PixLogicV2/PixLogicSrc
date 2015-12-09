using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class AddLog
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public void addLog(Log log)
        {
            context.Logs.Add(log);
            context.SaveChanges();
        }
    }
}
