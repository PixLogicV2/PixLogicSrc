using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class DeleteUser
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void deleteUser(int id)
        {
            var user = (from u in context.Users
                        where u.UserId == id
                        select u).FirstOrDefault();

            context.Entry(user).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
