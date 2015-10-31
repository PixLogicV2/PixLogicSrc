using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class Programm
    {
        public static void Main(string[] args)
        {
            /*
             AjoutItem item = new AjoutItem();
            item.setContext(new DataContext());
            item.addItem(ItemFactory.build("troll", "item cool", false, 23, "ddldldl", "111111", 1));

            GetAllItems getter = new GetAllItems();
            List<Item> list = getter.getItems();
            foreach(var it in list)
            {
                Console.WriteLine(it.name);
            }
            */
            Container container = new Container();
            container.get("add_item").addItem(ItemFactory.build("aveccontainertabu", "item cool", false, 23, "ddldldl", "111111", 1));
        }
    }
}
