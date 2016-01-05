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
        public bool containPseudoManager(string pseudo)
        {
            IQueryable<Manager> itemQuery = from Manager in context.Managers
                                         where Manager.pseudo == pseudo
                                         select Manager;
            if (itemQuery.Any()) return true;
            return false;
    }
        public List<Manager> getAllManagers()
        {
            IQueryable<Manager> itemQuery = from Manager in context.Managers
                                         select Manager;
            return itemQuery.ToList();
        }
        public void deleteManager(int id)
        {
            var item = (from s in context.Managers
                        where s.ManagerId == id
                        select s).FirstOrDefault();

            context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public void updateManager(int id, string name,string nickname, string mdp,string phone,string pseudo)
        {
            Manager user;
            user = context.Managers.Where(u => u.ManagerId == id).FirstOrDefault<Manager>();

            if (user != null)
            {
                user.name = name;
                user.mdp = mdp;
                user.nickname = nickname;
                user.phone = phone;
                user.pseudo = pseudo;
                context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
