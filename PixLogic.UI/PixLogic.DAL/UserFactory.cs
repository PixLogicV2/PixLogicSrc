using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace PixLogic.DAL
{
    class UserFactory
    {
        public User build(string name, string nickname, string mail, string classe, string phoneNumber, Image image)
        {
            User user = new User();
            user.name = name;
            user.nickname = nickname;
            user.mail = mail;
            user.classe = classe;
            user.phoneNumber = phoneNumber;
            if (image != null) user.image = Helper.imageToByteArray(image);
            else user.image = null;

            user.credits = 100;
            return user;
        }
    }
}
