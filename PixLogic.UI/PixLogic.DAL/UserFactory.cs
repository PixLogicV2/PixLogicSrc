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
            if (image != null) user.image = imageToByteArray(image);
            else user.image = null;

            return user;
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
