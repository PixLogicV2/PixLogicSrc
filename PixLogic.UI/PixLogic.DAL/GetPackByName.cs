using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetPackByName
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public Pack getPackByName(string packName)
        {
            IQueryable<Pack> itemQuery = from Pack in context.Packs
                                         where Pack.name == packName
                                         select Pack;
            List<Pack> list = new List<Pack>();
            foreach (var prod in itemQuery)
            {
                list.Add(prod);
            }
            return list.First();
        }
    }
}
