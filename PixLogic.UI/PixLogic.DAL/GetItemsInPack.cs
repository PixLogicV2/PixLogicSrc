using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetItemsInPack
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public List<Item> getItemsInPack(int packId)
        {
            IQueryable<Item> itemQuery = from Item in context.Items
                                         where Item.pack.ReservableId==packId
                                         select Item;
            return itemQuery.ToList();

        }
        public List<Item> getItemsInPackByName(string name)
        {
            IQueryable<Item> itemQuery = from Item in context.Items
                                         where Item.pack.name == name
                                         select Item;
            return itemQuery.ToList();

        }
    }
}
