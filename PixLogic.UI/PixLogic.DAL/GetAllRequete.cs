using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class GetAllRequete
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public List<Requete> getAllItems()
        {
            IQueryable<Requete> requeteQuery = from Requete in context.Requetes
                                               select Requete;
            List<Requete> list = new List<Requete>();
            foreach (var prod in requeteQuery)
            {
                list.Add(prod);
            }
            return list;
        }
    }
}
