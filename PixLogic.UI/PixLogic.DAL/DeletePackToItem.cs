using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
   public class DeletePackToItem
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void deletePackToItem(string itemName)
        {
            Item item;
            item = context.Items.Where(s => s.name == itemName).FirstOrDefault();
            Pack pack = context.Packs.Where(s => s.name == item.pack.name).FirstOrDefault();
            pack.price -= item.price;
            item.pack = null;
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            context.Entry(pack).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
