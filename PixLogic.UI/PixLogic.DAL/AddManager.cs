using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class AddManager
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public void addManager(Manager manag)
        {
            context.Managers.Add(manag);
            context.SaveChanges();
        }
        public void deleteManager(string managerName)
        {
            var item = (from s in context.Managers
                        where s.name == managerName
                        select s).FirstOrDefault();

            context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public void updateManager(int id, string name, string mdp)
        {
            Manager user;
            user = context.Managers.Where(u => u.ManagerId == id).FirstOrDefault<Manager>();

            if (user != null)
            {
                user.name = name;
                user.mdp = mdp;
                context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
