using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class DeleteItem
    {
        public void deleteItem(int idToDelete)
        {
            using (var ctx = new DataContext())
            {
                var item = (from s in ctx.Items
                            where s.ReservableId == idToDelete
                            select s).FirstOrDefault();

                ctx.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }
        }
    }
}
