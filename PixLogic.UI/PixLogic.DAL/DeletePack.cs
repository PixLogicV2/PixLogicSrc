using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class DeletePack
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void deletePack(string nameToDelete)
        {
            var pack = (from s in context.Packs
                        where s.name == nameToDelete
                        select s).FirstOrDefault();

            context.Entry(pack).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
