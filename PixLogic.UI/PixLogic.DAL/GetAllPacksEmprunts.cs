using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetAllPacksEmprunts
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public List<Reservation> getAllPacksEmprunts(List<Reservation> list)
        {
            List<Reservation> result = new List<Reservation>();
            foreach (var l in list)
            {
                if (l.isPack == true) result.Add(l);
            }
            return result;
        }
    }
}
