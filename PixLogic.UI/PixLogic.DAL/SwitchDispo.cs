using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class SwitchDispo
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public void switchDispo(int id)
        {
            Item item;
            item = context.Items.Where(s => s.ReservableId == id).FirstOrDefault<Item>();

            if (item != null)
            {
                if (item.dispo == true)
                    item.dispo = false;
                else item.dispo = true;
            }
            if (item.pack != null)
            {
                Pack pack;
                pack = context.Packs.Where(s => s.ReservableId == item.pack.ReservableId).FirstOrDefault<Pack>();
                
                    if (pack.dispo == true)
                        pack.dispo = false;
                    else pack.dispo = true;
            }
        }
    }
}
