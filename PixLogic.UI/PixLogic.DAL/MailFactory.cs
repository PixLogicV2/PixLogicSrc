using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class MailFactory
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public Mail build(string nameUser,string nicknameUser,string mailUser,string text, DateTime date)
        {
            Mail mail = new Mail();
            mail.nameUser = nameUser;
            mail.nicknameUser = nicknameUser;
            mail.mailUser = mailUser;
            mail.text = text;
            mail.date = date;

            return mail;
        }
    }
}
