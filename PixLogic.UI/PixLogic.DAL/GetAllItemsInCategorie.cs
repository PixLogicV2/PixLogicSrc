using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace PixLogic.DAL
{
    public class GetAllItemsInCategorie
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public List<Item> getAllItemsInCategorie(int id)
        {
            IQueryable<Item> itemQuery = from Item in context.Items.Include(c => c.pack).Include(c => c.categorie)
                                         where Item.categorie.CategorieId == id
                                         select Item;
            List<Item> list = new List<Item>();
            foreach (var prod in itemQuery)
            {
                list.Add(prod);
            }
            return list;

        }
    }
}
