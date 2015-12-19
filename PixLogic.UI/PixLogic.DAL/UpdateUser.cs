using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PixLogic.DAL
{
    public class UpdateUser
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void updateUser(int id, string name, string nickname, string mail, string phoneNumber, Image image, UserClass classe)
        {
            User user;
            user = context.Users.Where(u => u.UserId == id).FirstOrDefault<User>();

            if (user != null)
            {
                user.name = name;
                user.nickname = nickname;
                user.mail = mail;
                user.userClass = classe;
                user.phoneNumber = phoneNumber;
                if (image != null) user.image = Helper.imageToByteArray(image);
                else user.image = null;
                user.userClass = classe;
                context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
