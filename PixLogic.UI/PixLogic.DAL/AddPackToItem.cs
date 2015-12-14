using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
   public class AddPackToItem
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void addPackToItem(string  itemName,string packName)
        {
            Item item;
            Pack pack;
            item = context.Items.Where(s => s.name == itemName).FirstOrDefault();
            pack = context.Packs.Where(s => s.name == packName).FirstOrDefault<Pack>();
            item.pack = pack;
            pack.price += item.price;
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            context.Entry(pack).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
