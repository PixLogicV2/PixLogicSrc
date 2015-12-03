using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
   public class GetIdCategorie
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public int getIdCategorie(string itemName)
        {
            IQueryable<Categorie> itemQuery = from Categorie in context.Categories
                                         where Categorie.name == itemName
                                         select Categorie;
            List<Categorie> list = new List<Categorie>();
            foreach (var prod in itemQuery)
            {
                list.Add(prod);
            }
            return list.First().CategorieId;
        }
    }
}
