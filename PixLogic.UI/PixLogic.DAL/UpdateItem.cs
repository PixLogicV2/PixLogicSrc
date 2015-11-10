using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class UpdateItem
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void updateItem(int id, String nom, String des, bool disp, float prix, byte[] img, String refe, int quant)
        {
            Item item;
            item = context.Items.Where(s => s.ReservableId == id).FirstOrDefault<Item>();

            if (item != null)
            {
                item.name = nom;
                item.description = des;
                item.dispo = disp;
                item.price = prix;
                item.image = img;
                item.reference = refe;
                item.quantity = quant;
                context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
