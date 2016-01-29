using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class ManagerFactory
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public Manager build(string name, string nickname, string mdp,string phone,string pseudo)
        {
            Manager manag=new Manager();
            manag.name = name;
            manag.nickname = nickname;
            manag.phone = phone;
            manag.pseudo = pseudo;
            manag.mdp = mdp;
            return manag;
        }
    }
}
