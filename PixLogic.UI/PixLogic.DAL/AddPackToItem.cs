using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class AddPackToItem
    {
        public void addPackToItem(int itemId,int packId)
        {
            Item item;
            Pack pack;
            using (var ctx = new DataContext())
            {
                item = ctx.Items.Where(s => s.ReservableId ==itemId).FirstOrDefault();
                pack = ctx.Packs.Where(s => s.ReservableId ==packId).FirstOrDefault<Pack>();
                item.pack = pack;
                ctx.Entry(item).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
