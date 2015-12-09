using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class AddRequete
    {
        private DataContext context;

        public void SetContext(DataContext datacontext)
        {
            this.context = datacontext;
        }

        public void addRequete(Requete query)
        {
            context.Requetes.Add(query);
            context.SaveChanges();
        }
    }
}
