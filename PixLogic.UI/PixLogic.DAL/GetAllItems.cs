using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class GetAllItems
    {
        /*
        public void getAllItems() {
            using (DataContext context = new DataContext())
            {
                IQueryable<Item> itemQuery = from Item in context.Items
                                             select Item;

                Console.WriteLine("Product Names:");
                foreach (var prod in itemQuery)
                {
                    Console.WriteLine(prod.name);
                }
            }
        }
        */
        public List<Item> getItems()
        {
            using (DataContext context = new DataContext())
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
        }
    }
}
