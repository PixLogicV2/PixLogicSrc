using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class GetAllPacks
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public List<Pack> getAllItems()
        {
            IQueryable<Pack> itemQuery = from Pack in context.Packs
                                         select Pack;
            List<Pack> list = new List<Pack>();
            foreach (var prod in itemQuery)
            {
                list.Add(prod);
            }
            return list;

        }
    }
}
