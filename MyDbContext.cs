using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationships2
{
    internal class MyDbContext : DbContext
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFRelationships1;Integrated Security=True";

       public DbSet<Bus> Buses { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We tell the app to use the connectionstring.
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Bus>().HasData(new Bus { Id = 1, Brand = "Volvo", NumberOfSeats = 40 });
            ModelBuilder.Entity<Bus>().HasData(new Bus { Id = 2, Brand = "Mercedes", NumberOfSeats = 45 });

            
            ModelBuilder.Entity<Passenger>().HasData(new Passenger { Id = 1, Name = "John", BusId = 1 });
            ModelBuilder.Entity<Passenger>().HasData(new Passenger { Id = 2, Name = "Mark", BusId = 2 });
            ModelBuilder.Entity<Passenger>().HasData(new Passenger { Id = 3, Name = "Sam", BusId = 1 });
            ModelBuilder.Entity<Passenger>().HasData(new Passenger { Id = 4, Name = "Linda", BusId = 1 });
            ModelBuilder.Entity<Passenger>().HasData(new Passenger { Id = 5, Name = "Frank", BusId = 2 });
        }
    }
}
