using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using PlakApp.Entities.Concrete;

namespace PlakApp.DataAccess
{
    public class PlakAppContext: DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Saler> Salers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=PlakAppDB;uid=**;pwd=***; TrustServerCertificate = True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().Property(p => p.Name).HasMaxLength(150);
            modelBuilder.Entity<Album>().Property(p => p.Singer).HasMaxLength(150);
            modelBuilder.Entity<Saler>().Property(p => p.UserName).HasMaxLength(50);
            modelBuilder.Entity<Saler>().HasData(

                new Saler() { ID = Guid.NewGuid(), UserName = "Sila", Password = "SSsssaa++" },
                new Saler()
                {
                    ID = Guid.NewGuid(),
                    
                    UserName = "Sila",
                    Password = "217212SSsss++"
                });
            modelBuilder.Entity<Album>().HasData(

                new Album()
                {
                    ID = Guid.NewGuid(),
                    AlbumDate = DateTime.Now,
                    
                    Name = "Karma",
                    Singer = "Tarkan",
                    Price = 200,
                    Discount = 20,
                    IsContinued = true
                });



            base.OnModelCreating(modelBuilder);
        }
    }
}
