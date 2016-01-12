using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class AddMail
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public void addMail(Mail mail)
        {
            context.Mails.Add(mail);
            context.SaveChanges();
        }
        public List<Mail> getAllMails()
        {
            IQueryable<Mail> itemQuery = from Mail in context.Mails
                                         select Mail;
            return itemQuery.ToList();
        }
    }
}
