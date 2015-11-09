using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PixLogic.DAL
{
    public class Container
    {
        Dictionary<string, dynamic> arrayContainer;
        public Container()
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
                    service = new AjoutItem();
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
                case "add_pack_to_item":
                    service = new AddPackToItem();
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

            }
            this.arrayContainer[serviceName] = service;

            return this.arrayContainer[serviceName];
        }
    }
}
