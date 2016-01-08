using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class GetRequeteById
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public Requete getRequeteById (int id)
        {
            IQueryable<Requete> requeteQuery = from Requete in context.Requetes
                                         where Requete.RequeteId == id
                                         select Requete;
            return requeteQuery.First();
        }
    }
}
