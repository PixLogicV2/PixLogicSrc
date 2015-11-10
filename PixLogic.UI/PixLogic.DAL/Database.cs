using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class Database
    {
        ServiceContainer container;
        public Database()
        {
            container = new ServiceContainer();
        }
        public void AddItem(string name, string description, bool dispo, float price, Image image, string reference, int quantity)
        {
            container.get("add_item").addItem(container.get("item_factory").build(name, description,dispo,price,image,reference,quantity));
        }
        public void AddPack(string name, string description, bool dispo, float price)
        {
            container.get("add_pack").addPack(container.get("pack_factory").build(name, description, dispo, price));
        }
        public void AddItemToPack(string itemName,string packName)
        {
            container.get("add_pack_to_item").addPackToItem(itemName, packName);
        }
        public void ByteArrayToImage(byte[] byteArray)
        {
            container.get("byte_array_to_image").byteArrayToImage(byteArray);
        }
        public bool ContainItem(string itemName)
        {
           return container.get("contain_item").containItem(itemName);
        }
        public void DeleteItem(string nameToDelete)
        {
            container.get("delete_item").deleteItem(nameToDelete);
        }
        public void DeleteItemToPack(string itemName)
        {
            container.get("delete_pack_to_item").deletePackToItem(itemName);
        }
        public Item GetItemByName(string itemName)
        {
            return container.get("get_item_by_name").getItemByName(itemName);
        }
        public List<Item> GetAllItems()
        {
            return container.get("get_all_items").getAllItems();
        }
        public List<Item> GetAllItemsByString(string search)
        {
            return container.get("get_all_items").getAllItemsByString(search);
        }
        public List<Pack> GetAllPacks()
        {
            return container.get("get_all_packs").getAllPacks();
        }
        public List<Item> GetItemsInPack(string packName)
        {
            return container.get("get_items_in_pack").getItemsInPack(packName);
        }
        public void UpdateItem(string nom, string des, bool disp, float prix, Image img, string refe, int quant)
        {
            container.get("update_item").updateItem(nom, des, disp, prix, img, refe, quant);
        }
    }
}
