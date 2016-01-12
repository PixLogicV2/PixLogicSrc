using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using PixLogic;
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
            IQueryable<Item> itemQuery = from Item in context.Items.Include(c => c.pack).Include(c => c.categorie)
                                         select Item;
            return itemQuery.ToList();
        }
        public List<Item> getAllItemsByString(string search)
        {
            search.ToLower();
            List<Item> items = getAllItems();
            List<Item>results = items.FindAll(
            delegate (Item item)
            {
                if (item.name.ToLower().Contains(search)) return item.name.ToLower().Contains(search);
                else return item.reference.ToLower().Contains(search);
            }
            );
            return results;
        }
        public bool existReference(string reference)
        {
            IQueryable<Item> itemQuery = from Item in context.Items
                                         where Item.reference == reference
                                         select Item;
            if (itemQuery.Any()) return true;
            return false;
        }
    }
}
