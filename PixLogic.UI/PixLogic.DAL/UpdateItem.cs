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
        public void updateItem(String nom, String des, bool disp, float prix, Image image, String refe, int quant)
        {
            Item item;
            item = context.Items.Where(s => s.name == nom).FirstOrDefault<Item>();

            if (item != null)
            {
                item.name = nom;
                item.description = des;
                item.dispo = disp;
                item.price = prix;
                if (image != null) item.image = imageToByteArray(image);
                else item.image = null;
                item.reference = refe;
                item.quantity = quant;
                context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
    }
}
