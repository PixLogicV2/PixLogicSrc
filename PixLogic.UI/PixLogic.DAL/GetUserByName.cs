using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetUserByName
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public User getUserByName(string userName,string userNickName)
        {
            IQueryable<User> userQuery = from User in context.Users
                                         where User.name == userName
                                         where User.nickname==userNickName
                                         select User;
            return userQuery.First();
        }
    }
}
