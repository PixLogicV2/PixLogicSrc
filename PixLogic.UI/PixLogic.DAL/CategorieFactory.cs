using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
   public class CategorieFactory
    {
        public Categorie build(string name, int level)
        {
            Categorie categorie = new Categorie();
            categorie.name = name;
            categorie.level = level;

            return categorie;
        }
    }
}
