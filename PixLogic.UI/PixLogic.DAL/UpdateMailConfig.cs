using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class UpdateMailConfig
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void updateMailConfig(string serveurStmp,int port,string email,string mdp)
        {
            MailConfig mailConfig;
            mailConfig = context.MailConfigs.FirstOrDefault<MailConfig>();

            if (mailConfig!= null)
            {
                mailConfig.serveurStmp=serveurStmp;
                mailConfig.port = port;
                mailConfig.email = email;
                mailConfig.mdp = mdp;
                context.Entry(mailConfig).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
