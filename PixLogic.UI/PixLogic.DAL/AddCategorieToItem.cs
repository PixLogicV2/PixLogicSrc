using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class AddCategorieToItem
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void addCategorieToItem(string itemName, string catName)
        {
            Item item;
            Categorie categorie;
            item = context.Items.Where(s => s.name == itemName).FirstOrDefault();
            categorie = context.Categories.Where(s => s.name == catName).FirstOrDefault<Categorie>();
            item.categorie = categorie;
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
