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
        public bool containItem(string name  )
        {
            IQueryable<Item> itemQuery = from Item in context.Items
                                         where Item.name == name
                                         select Item;
            if (itemQuery.Any()) return true;
            return false;

        }
    }
}
