using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class AddPack
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public void addPack(Pack pack)
        {
            context.Packs.Add(pack);
            context.SaveChanges();
        }
    }
}
