using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class AddReservation
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public void addReservation(Reservation reserv)
        {
            context.Reservations.Add(reserv);
            context.SaveChanges();
        }
        public void removeCredit(User user,int cout)
        {
            if (user != null)
            {
                user.credits -= cout;
                context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
        public bool creditSuffisant(User user,Reservable res)
        {
            if (user.credits >= res.price) return true;
            else return false;
        }
        public bool levelSuffisant(User user,float level)
        {
            if (user.userClass.level >= level) return true;
            else return false;
        }

    }
}
