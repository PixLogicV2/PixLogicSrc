using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        public void updateItem(string nom, string newName, string des, bool disp, int prix, Image image, string refe, int quant,Categorie cat)
        {
                Item item;
                item = context.Items.Where(s => s.name == nom).FirstOrDefault<Item>();

            if (item != null)
            {
                item.name = newName;
                item.description = des;
                item.dispo = disp;
                item.price = prix;
                if (image != null) item.image = Helper.imageToByteArray(image);
                else item.image = null;
                item.reference = refe;
                item.quantity = quant;
                item.categorie = cat;
                context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
        
    }
}
