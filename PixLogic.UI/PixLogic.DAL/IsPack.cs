using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class IsPack
    {
        public bool isPack(Reservable res)
        {
            if (res.isPack == true) return true;
            else return false;
        }
    }
}
