using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class UpdateRequete
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public void updateRequete(string name, string text)
        {
            Requete query;
            query = context.Requetes.Where(s => s.name == name).FirstOrDefault<Requete>();

            if(query != null)
            {
                query.name = name;
                query.text = text;
                context.Entry(query).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
