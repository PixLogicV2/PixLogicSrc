using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class UserClassFactory
    {
        public UserClass build(string name, int credits)
        {
            UserClass user = new UserClass();
            user.name = name;
            user.credits = credits;
            return user;
        }
    }
}
