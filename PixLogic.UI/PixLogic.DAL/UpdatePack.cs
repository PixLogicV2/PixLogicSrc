using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class UpdatePack
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void updatePack(string nom, string newName, string des, bool disp, float prix)
        {
            Pack pack;
            pack= context.Packs.Where(s => s.name == nom).FirstOrDefault<Pack>();

            if (pack != null)
            {
                pack.name = newName;
                pack.description = des;
                pack.dispo = disp;
                pack.price = prix;
                context.Entry(pack).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
