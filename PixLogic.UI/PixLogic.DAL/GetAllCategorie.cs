using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetAllCategorie
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public List<Categorie> getAllCategorie()
        {
            IQueryable<Categorie> itemQuery = from Categorie in context.Categories
                                         select Categorie;
            List<Categorie> list = new List<Categorie>();
            foreach (var prod in itemQuery)
            {
                list.Add(prod);
            }
            return list;
        }
        public List<Categorie> getAllCategorieByString(string search)
        {
            search.ToLower();
            List<Categorie> items = getAllCategorie();
            List<Categorie> results = items.FindAll(
            delegate (Categorie item)
            {
                return item.name.ToLower().Contains(search);
            }
            );
            return results;
        }
    }
}
