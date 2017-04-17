using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Hotel2.Models
{
    public class HotelDbContext : DbContext
    {
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Billing> Billings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Hotel>().HasMany<Client>(x => x.Clients).WithRequired().WillCascadeOnDelete(false);
            //modelBuilder.Entity<Client>().HasKey<Hotel>(x => x.Hotel).HasRequired().WillCascadeOnDelete(false);
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }
    }
}