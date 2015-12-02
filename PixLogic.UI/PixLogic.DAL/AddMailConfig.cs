using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class AddMailConfig
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public void addMailConfig(MailConfig mailconfig)
        {
            context.MailConfigs.Add(mailconfig);
            context.SaveChanges();
        }
    }
}
