using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class UpdateCategorie
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void updateCategorie(string nom,string newnom, int lvl)
        {
            Categorie cat;
            cat = context.Categories.Where(s => s.name == nom).FirstOrDefault<Categorie>();

            if (cat != null)
            {
                cat.name = newnom;
                cat.level = lvl;
                context.Entry(cat).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
