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
            return itemQuery.ToList();
        }
        public List<User> getAllUsersByString(string search)
        {
            search.ToLower();
            List<User> users = getAllUsers();
            List<User> results = users.FindAll(
            delegate (User user)
            {
                if (user.name.ToLower().Contains(search)) return user.name.ToLower().Contains(search);
                else return user.nickname.ToLower().Contains(search);
            }
            );
            return results;
        }
    }
}
