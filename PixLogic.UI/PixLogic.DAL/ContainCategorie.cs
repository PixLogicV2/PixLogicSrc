using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class ContainCategorie
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public bool containCategorie(string name)
        {
            IQueryable<Categorie> itemQuery = from Categorie in context.Categories
                                         where Categorie.name == name
                                         select Categorie;
            if (itemQuery.Any()) return true;
            return false;

        }
    }
}
