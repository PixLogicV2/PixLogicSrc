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
            List<UserClass> list = new List<UserClass>();
            foreach (var prod in itemQuery)
            {
                list.Add(prod);
            }
            return list.First();
        }
        public UserClass getUserClassByName(string name)
        {
            IQueryable<UserClass> itemQuery = from UserClass in context.UserClasses
                                              where UserClass.name == name
                                              select UserClass;
            List<UserClass> list = new List<UserClass>();
            foreach (var prod in itemQuery)
            {
                list.Add(prod);
            }
            return list.First();
        }
        public List<UserClass> getAllUserClass()
        {
            IQueryable<UserClass> itemQuery = from UserClass in context.UserClasses
                                              select UserClass;
            List<UserClass> list = new List<UserClass>();
            foreach (var prod in itemQuery)
            {
                list.Add(prod);
            }
            return list;
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
