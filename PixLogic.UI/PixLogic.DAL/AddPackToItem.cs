using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class AddPackToItem
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void addPackToItem(int itemId, int packId)
        {
            Item item;
            Pack pack;
            item = context.Items.Where(s => s.ReservableId == itemId).FirstOrDefault();
            pack = context.Packs.Where(s => s.ReservableId == packId).FirstOrDefault<Pack>();
            item.pack = pack;
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
