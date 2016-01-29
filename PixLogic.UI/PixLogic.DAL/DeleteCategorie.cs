using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class DeleteCategorie
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void deleteCategorie(int id)
        {
            var cat = (from s in context.Categories
                        where s.CategorieId == id
                        select s).FirstOrDefault();

            context.Entry(cat).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
