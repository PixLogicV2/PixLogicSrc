using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class RequeteFactory
    {
        public Requete Build(string name, string text)
        {
            Requete query = new Requete();
            query.name = name;
            query.text = text;

            return query;
        }
    }
}
