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
        public void addCategorieToItem(int itemId, int catId)
        {
            Item item;
            Categorie categorie;
            item = context.Items.Where(s => s.ReservableId == itemId).FirstOrDefault();
            categorie = context.Categories.Where(s => s.CategorieId == catId).FirstOrDefault<Categorie>();
            item.categorie = categorie;
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
