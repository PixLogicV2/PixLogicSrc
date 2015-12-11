using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class ContainUserClass
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public bool containUserClass(string name)
        {
            IQueryable<UserClass> itemQuery = from UserClass in context.UserClasses
                                              where UserClass.name == name
                                              select UserClass;
            if (itemQuery.Any()) return true;
            return false;

        }
    }
}
