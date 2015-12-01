﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class GetAllItemsEmprunts
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }
        public List<Reservation> getAllItemEmprunts(List<Reservation> list)
        {
            List<Reservation> result = new List<Reservation>();
            foreach (var l in list)
            {
                if (l.isPack == false) result.Add(l);
            }
            return result;
        }
    }
}