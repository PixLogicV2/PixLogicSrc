﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class AddReservation
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public void addReservation(Reservation reserv)
        {
            context.Reservations.Add(reserv);
            context.SaveChanges();
        }

    }
}