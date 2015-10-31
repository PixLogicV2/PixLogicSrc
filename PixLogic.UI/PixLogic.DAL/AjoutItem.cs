using System;

namespace PixLogic.DAL
{
    public class AjoutItem
    {
        /*
       public void ajoutItem(String nom, String des, bool disp,float prix ,String img,String refe,int quant) {
            using (var ctx = new DataContext())
            {
                Item item = new Item() { name =nom, description=des,dispo=disp,price=prix,image=img,reference=refe,quantity=quant };
                ctx.Items.Add(item);
                ctx.SaveChanges();
            }
        }
        */
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public void addItem(Item item)
        {
            context.Items.Add(item);
            context.SaveChanges();
        }

    }
}
