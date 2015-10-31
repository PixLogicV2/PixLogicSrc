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
                case "add_item":
                    service = new AjoutItem();
                    service.setContext(this.get("data_context"));
                    break;
                case "data_context":
                    service = new DataContext();
                    break;

            }
            this.arrayContainer[serviceName] = service;

            return this.arrayContainer[serviceName];
        }
    }
}
