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
        public void updateCategorie(int id,string nom, int lvl,string description)
        {
            Categorie cat;
            cat = context.Categories.Where(s => s.CategorieId == id).FirstOrDefault<Categorie>();

            if (cat != null)
            {
                cat.name = nom;
                cat.level = lvl;
                cat.description = description;
                context.Entry(cat).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            List<Item> items;
            GetAllItemsInCategorie getter = new GetAllItemsInCategorie();
            items =getter.getAllItemsInCategorie(nom);
            foreach(Item i in items)
            {
                i.categorie = cat;
                context.Entry(cat).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
