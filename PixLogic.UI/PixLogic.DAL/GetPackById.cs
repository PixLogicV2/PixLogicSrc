using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
   public class GetPackById
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public Pack getPackById(int id)
        {
            IQueryable<Pack> itemQuery = from Pack in context.Packs
                                         where Pack.ReservableId == id
                                         select Pack;
            return itemQuery.First();
        }
        public int getLastPackId()
        {
            IQueryable<int> query = from Reservable in context.Reservables
                                    orderby Reservable.ReservableId descending
                                    select Reservable.ReservableId;
            return query.First();
        }
    }
}
