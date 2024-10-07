using System;
using Hotel_Riwi.Models;
using Hotel_Riwi.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Riwi.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Guest> Guests { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            RoomSeeder.Seed(modelBuilder);
            RoomTypeSeeder.Seed(modelBuilder);
        }
    }
}
