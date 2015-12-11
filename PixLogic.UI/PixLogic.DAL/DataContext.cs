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
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Requete> Requetes { get; set; }
        public DbSet<MailConfig> MailConfigs { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<UserClass> UserClasses { get; set; }
    }
}
