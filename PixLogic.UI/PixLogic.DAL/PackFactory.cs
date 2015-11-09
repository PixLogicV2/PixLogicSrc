using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class PackFactory
    {
        public Item build(String name, String description, bool dispo, float price)
        {
            Item pack = new Item();
            pack.name = name;
            pack.description = description;
            pack.dispo = dispo;
            pack.price = price;

            return pack;
        }
    }
}
