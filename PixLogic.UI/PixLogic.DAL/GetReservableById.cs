using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetReservableById
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public Reservable getReservableById(int id)
        {
            IQueryable<Reservable> itemQuery = from Reservable in context.Reservables
                                         where Reservable.ReservableId == id
                                         select Reservable;
            return itemQuery.First();
        }
    }
}
