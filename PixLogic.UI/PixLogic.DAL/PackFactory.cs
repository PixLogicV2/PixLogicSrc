using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class PackFactory
    {
        public Pack build(String name, String description, bool dispo, int price)
        {
            Pack pack = new Pack();
            pack.name = name;
            pack.description = description;
            pack.dispo = dispo;
            pack.price = price;
            return pack;
        }
    }
}
