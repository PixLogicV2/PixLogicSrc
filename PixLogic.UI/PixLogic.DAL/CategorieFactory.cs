using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
   public class CategorieFactory
    {
        public Categorie build(string name, int level,string description)
        {
            Categorie categorie = new Categorie();
            categorie.name = name;
            categorie.level = level;
            categorie.description = description;

            return categorie;
        }
    }
}
