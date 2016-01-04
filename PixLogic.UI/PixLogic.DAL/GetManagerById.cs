using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class GetManagerById
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public Manager getManagerById(int id)
        {
            IQueryable<Manager> managerQuery = from Manager in context.Managers
                                                  where Manager.ManagerId == id
                                                  select Manager;
            return managerQuery.First();
        }
    }
}
