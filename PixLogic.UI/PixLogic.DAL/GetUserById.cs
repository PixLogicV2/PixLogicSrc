using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetUserById
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public User getUserById(int id)
        {
            IQueryable<User> userQuery = from User in context.Users
                                         where User.UserId == id
                                         select User;
            return userQuery.First();
        }
    }
}
