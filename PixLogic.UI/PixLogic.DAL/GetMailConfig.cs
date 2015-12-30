using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetMailConfig
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public MailConfig getMailConfig()
        {
            IQueryable<MailConfig> userQuery =  from MailConfig 
                                                in context.MailConfigs
                                                select MailConfig;
            return userQuery.First();
        }
    }
}
