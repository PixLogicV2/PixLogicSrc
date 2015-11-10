using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetAllItems
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public List<Item> getAllItems()
        {
            IQueryable<Item> itemQuery = from Item in context.Items
                                         select Item;
            List<Item> list = new List<Item>();
            foreach (var prod in itemQuery)
            {
                list.Add(prod);
            }
            return list;

        }
        public List<Item> getAllItemsByString(string search)
        {
            List<Item> items = getAllItems();
            List<Item>results = items.FindAll(
            delegate (Item item)
            {
                return item.name.Contains(search);
            }
            );
            return results;
        }
    }
}
