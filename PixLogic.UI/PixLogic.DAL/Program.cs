using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            using (var ctx = new DataContext())
            {
                Pack pack = new Pack() { name = "pack2" };
                ctx.Packs.Add(pack);
                Item item = new Item() { name = "appareilavec" ,pack=pack};
                ctx.Items.Add(item);
                ctx.SaveChanges();
            }
            */
            /*
            //CHANGE ITEM 1 POUR LUI ASSIGNER PACK 3
            Item item;
            Pack pack;
            using (var ctx = new DataContext())
            {
                item = ctx.Items.Where(s => s.ReservableId == 4).FirstOrDefault();
                pack = ctx.Packs.Where(s => s.ReservableId == 3).FirstOrDefault<Pack>();
                item.pack = pack;
                ctx.Entry(item).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
            */
            /*
            AjoutItem Item = new AjoutItem();
            Item.ajoutItem("ilvasetreen1", "appareil zoom x100", false, 37, "11111", "1919191991", 1);
            */
            /*
            UpdateItem item = new UpdateItem();
            item.updateItem(6,"canon185", "appareil modifié sa marche", false, 37, "11111", "1919191991", 1);
            */
            /*
            AddPackToItem addpacktoitem = new AddPackToItem();
            addpacktoitem.addPackToItem(6, 3);
            */
            /*
            DeleteItem dlt = new DeleteItem();
            dlt.deleteItem(1);
            */
        }
    }
}
