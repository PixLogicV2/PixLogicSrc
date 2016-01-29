using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetItemById
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public Item getItemById(int id)
        {
            IQueryable<Item> itemQuery = from Item in context.Items
                                         where Item.ReservableId == id
                                         select Item;
            return itemQuery.First();
        }
    }
}
