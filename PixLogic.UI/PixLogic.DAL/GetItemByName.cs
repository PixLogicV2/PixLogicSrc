using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
   public class GetItemByName
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public Item getItemByName(string itemName)
        {
            IQueryable<Item> itemQuery = from Item in context.Items
                                         where Item.name == itemName
                                         select Item;
            List<Item> list = new List<Item>();
            foreach (var prod in itemQuery)
            {
                list.Add(prod);
            }
            return list.First<Item>();
        }
    }
}
