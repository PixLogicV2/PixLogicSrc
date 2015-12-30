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
        public List<Pack> getAllPacks()
        {
            IQueryable<Pack> itemQuery = from Pack in context.Packs
                                         select Pack;
            return itemQuery.ToList();

        }
        public List<Pack> getAllPacksByString(string search)
        {
            search.ToLower();
            List<Pack> packs = getAllPacks();
            List<Pack> results = packs.FindAll(
            delegate (Pack pack)
            {
                return pack.name.ToLower().Contains(search);
            }
            );
            return results;
        }
    }
}
