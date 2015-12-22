using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
   public class GetUserClass
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public UserClass getUserClassById(int id)
        {
            IQueryable<UserClass> itemQuery = from UserClass in context.UserClasses
                                              where UserClass.UserClassId == id
                                              select UserClass;
            return itemQuery.First();
        }
        public UserClass getUserClassByName(string name)
        {
            IQueryable<UserClass> itemQuery = from UserClass in context.UserClasses
                                              where UserClass.name == name
                                              select UserClass;
            return itemQuery.First();
        }
        public List<UserClass> getAllUserClass()
        {
            IQueryable<UserClass> itemQuery = from UserClass in context.UserClasses
                                              select UserClass;
            return itemQuery.ToList();
        }
        public List<UserClass> getAllUserClassByString(string search)
        {
            search.ToLower();
            List<UserClass> items = getAllUserClass();
            List<UserClass> results = items.FindAll(
            delegate (UserClass item)
            {
                return item.name.ToLower().Contains(search);
            }
            );
            return results;
        }
    }
}
