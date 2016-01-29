using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
   public class AddCategorie
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public void addCategorie(Categorie categorie)
        {
            context.Categories.Add(categorie);
            context.SaveChanges();
        }
    }
}
