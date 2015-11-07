using System;

namespace PixLogic.DAL
{
    public class AjoutItem
    {
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
