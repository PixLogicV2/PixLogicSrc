using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class AddUserClass
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public void addUserClass(UserClass userclass)
        {
            context.UserClasses.Add(userclass);
            context.SaveChanges();
        }
        public void addUserClassToUser(int userId, int catId)
        {
            User user;
            UserClass userClass;
            user = context.Users.Where(s => s.UserId== userId).FirstOrDefault();
            userClass = context.UserClasses.Where(s => s.UserClassId == catId).FirstOrDefault<UserClass>();
            user.userClass = userClass;
            context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void deleteUserClass(int id)
        {
            var user = (from u in context.UserClasses
                        where u.UserClassId == id
                        select u).FirstOrDefault();

            context.Entry(user).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public void updateUserClass(int id, string name, int credits)
        {
            UserClass userClass;
            userClass = context.UserClasses.Where(u => u.UserClassId == id).FirstOrDefault<UserClass>();

            if (userClass != null)
            {
                userClass.name = name;
                userClass.credits=credits;
                context.Entry(userClass).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
