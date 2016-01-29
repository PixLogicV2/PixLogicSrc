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
        public void addPackToItem(string  itemRef,int packId)
        {
            Item item;
            Pack pack;
            item = context.Items.Where(s => s.reference == itemRef).FirstOrDefault();
            pack = context.Packs.Where(s => s.ReservableId == packId).FirstOrDefault<Pack>();
            item.pack = pack;
            pack.price += item.price;
            pack.dispo = item.dispo;
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            context.Entry(pack).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
