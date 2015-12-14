using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace PixLogic.DAL
{
    class GetAllUsers
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public List<User> getAllUsers()
        {
            IQueryable<User> itemQuery = from User in context.Users.Include(c => c.userClass)
                                         select User;
            List<User> list = new List<User>();
            foreach (var prod in itemQuery)
            {
                list.Add(prod);
            }
            return list;
        }
        public List<User> getAllUsersByString(string search)
        {
            search.ToLower();
            List<User> users = getAllUsers();
            List<User> results = users.FindAll(
            delegate (User user)
            {
                return user.name.ToLower().Contains(search);
            }
            );
            return results;
        }
    }
}
