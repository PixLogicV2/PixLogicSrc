using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
   public class DeleteItem
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void deleteItem(string nameToDelete)
        {
            var item = (from s in context.Items
                        where s.name == nameToDelete
                        select s).FirstOrDefault();

            context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
