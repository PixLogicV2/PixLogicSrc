using System;
namespace PixLogic.DAL
{
    public class ItemFactory
    {
        public static Item build(String name, String description, bool dispo, float price, String image, string reference, int quantity)
        {
            Item item = new Item();
            item.name=name;
            item.description = description;
            item.dispo = dispo;
            item.price = price;
            item.image = image;
            item.reference = reference;
            item.quantity=quantity;

            return item;
        }
    }
}
