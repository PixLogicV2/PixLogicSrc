using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class ContainItem
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public bool containItem(int idItem  )
        {
            IQueryable<Item> itemQuery = from Item in context.Items
                                         where Item.ReservableId == idItem
                                         select Item;
            if (itemQuery.Any()) return true;
            return false;

        }
    }
}
