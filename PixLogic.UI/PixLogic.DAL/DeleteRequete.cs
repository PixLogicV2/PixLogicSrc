using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class DeleteRequete
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public void deleteRequete(string queryToDelete)
        {
            var requete = (from r in context.Requetes
                           where r.name == queryToDelete
                           select r).FirstOrDefault();
            context.Entry(queryToDelete).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
