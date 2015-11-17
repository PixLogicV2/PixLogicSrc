using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PixLogic.DAL
{
    public class DataContext : DbContext
    {
        public DataContext() : base()
        {

        }
        public DbSet<Reservable> Reservables { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Pack> Packs { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
