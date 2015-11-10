using System.Collections.Generic;

namespace PixLogic.DAL
{
    public class ServiceContainer
    {
        Dictionary<string, dynamic> arrayContainer;
        public ServiceContainer()
        {
            this.arrayContainer = new Dictionary<string, dynamic>();
        }
        public dynamic get(string serviceName)
        {
            if (this.arrayContainer.ContainsKey(serviceName))
            {
               return this.arrayContainer[serviceName];
            }
            dynamic service=null;
            switch (serviceName)
            {
                case "item_factory":
                    service = new ItemFactory();
                    break;
                case "pack_factory":
                    service = new PackFactory();
                    break;

                case "add_item":
                    service = new AddItem();
                    service.setContext(this.get("data_context"));
                    break;
                case "add_pack":
                    service = new AddPack();
                    service.setContext(this.get("data_context"));
                    break;
                case "data_context":
                    service = new DataContext();
                    break;
                case "get_all_items":
                    service = new GetAllItems();
                    service.setContext(this.get("data_context"));
                    break;
                case "get_all_items_by_string":
                    service = this.get("get_all_items");
                    break;
                case "get_all_packs":
                    service = new GetAllPacks();
                    service.setContext(this.get("data_context"));
                    break;
                case "add_pack_to_item":
                    service = new AddPackToItem();
                    service.setContext(this.get("data_context"));
                    break;
                case "delete_pack_to_item":
                    service = new DeletePackToItem();
                    service.setContext(this.get("data_context"));
                    break;
                case "contain_item":
                    service = new ContainItem();
                    service.setContext(this.get("data_context"));
                    break;
                case "update_item":
                    service = new UpdateItem();
                    service.setContext(this.get("data_context"));
                    break;
                case "delete_item":
                    service = new DeleteItem();
                    service.setContext(this.get("data_context"));
                    break;
                case "get_items_in_pack":
                    service = new GetItemsInPack();
                    service.setContext(this.get("data_context"));
                    break;
                case "byte_array_to_image":
                    service = new ByteArrayToImage();
                    break;


            }
            this.arrayContainer[serviceName] = service;

            return this.arrayContainer[serviceName];
        }
    }
}
