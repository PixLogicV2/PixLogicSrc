using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class UpdateItem
    {
        public void updateItem(int id,String nom, String des, bool disp, float prix, String img, String refe, int quant)
        {
            Item item;
            using (var ctx = new DataContext())
            {
                item = ctx.Items.Where(s => s.ReservableId == id).FirstOrDefault<Item>();

                if (item != null)
                {
                    item.name = nom;
                    item.description = des;
                    item.dispo = disp;
                    item.price = prix;
                    item.image = img;
                    item.reference = refe;
                    item.quantity = quant;
                    ctx.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }

        }
    }
}
