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
        public void addItem(string name, string description, bool dispo, float price, Image image, string reference, int quantity)
        {
            container.get("add_item").addItem(container.get("item_factory").build(name, description,dispo,price,image,reference,quantity));
        }
        public void AddPack(String name, String description, bool dispo, float price)
        {
            container.get("add_pack").addPack(container.get("pack_factory").build(name, description, dispo, price));
        }
        public void AddPackToItem(int itemId,int packId)
        {
            container.get("add_pack_to_item").addPackToItem(itemId, packId);
        }
        public void ByteArrayToImage(byte[] byteArray)
        {
            container.get("byte_array_to_image").byteArrayToImage(byteArray);
        }
        public bool ContainItem(int itemId)
        {
           return container.get("contain_item").containItem(itemId);
        }
        public void DeleteItem(string nameToDelete)
        {
            container.get("delete_item").deleteItem(nameToDelete);
        }
        public void DeletePackToItem(int itemId)
        {
            container.get("delete_pack_to_item").deletePackToItem(itemId);
        }
        public void GetItemByName(string itemName)
        {
            container.get("get_item_by_name").getItemByName(itemName);
        }
        public List<Item> GetAllItems()
        {
            return container.get("get_all_items").getAllItems();
        }
        public List<Item> GetAllItemsByString(String search)
        {
            return container.get("get_all_items").getAllItemsByString(search);
        }
        public List<Pack> GetAllPacks()
        {
            return container.get("get_all_packs").getAllPacks();
        }
        public List<Item> GetItemsInPack(int packId)
        {
            return container.get("get_items_in_pack").getItemsInPack(packId);
        }
        public void UpdateItem(int id, String nom, String des, bool disp, float prix, Image img, String refe, int quant)
        {
            container.get("update_item").updateItem(id, nom, des, disp, prix, img, refe, quant);
        }
    }
}
