using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetCategorieById
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public Categorie getCategorieById(int id)
        {
            IQueryable<Categorie> itemQuery = from Categorie in context.Categories
                                              where Categorie.CategorieId == id
                                              select Categorie;
            return itemQuery.First();
        }

            public Categorie getCategorieByName(string name)
        {
            IQueryable<Categorie> itemQuery = from Categorie in context.Categories
                                              where Categorie.name == name
                                              select Categorie;
            return itemQuery.First();
        }
    }
}
