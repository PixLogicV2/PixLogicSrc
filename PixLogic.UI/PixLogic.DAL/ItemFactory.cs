using System;
using System.Drawing;
using System.IO;

namespace PixLogic.DAL
{
    public class ItemFactory
    {
        public Item build(string name, string description, bool dispo, float price, Image image, string reference, int quantity)
        {
            Item item = new Item();
            item.name=name;
            item.description = description;
            item.dispo = dispo;
            item.price = price;
            if (image != null) item.image = imageToByteArray(image);
            else item.image = null;
            item.reference = reference;
            item.quantity=quantity;

            return item;
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
