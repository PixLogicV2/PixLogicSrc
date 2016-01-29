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
            return itemQuery.ToList();
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
        public List<Categorie> getAllCategorieByListItem(List<Item> items)
        {
            List<Categorie> cat = getAllCategorie();
            List<Categorie> results = new List<Categorie>();
            foreach(Categorie c in cat)
            {
                foreach (Item i in items)
                {
                    if( c.name.Equals(i.categorie.name) && (!results.Contains(c)))results.Add(c);
                }
            }
            return results;
        }
    }
}
