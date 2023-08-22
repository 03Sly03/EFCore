using Exercice02_Hotel.Classes;
using Exercice02_Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02_Hotel.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationRoom> ReservationsRooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\efcoredbexohotel;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(new Client()
            {
                Id = 1,
                Lastname = "Enrique",
                Firstname = "Alberto",
                Phone = "0612234578"
            },
            new Client()
            {
                Id = 2,
                Lastname = "Patoulacy",
                Firstname = "Marcel",
                Phone = "1234567890"
            },
            new Client()
            {
                Id = 3,
                Lastname = "Sanchez",
                Firstname = "Edwardo",
                Phone = "9876543210"
            },
            new Client()
            {
                Id = 4,
                Lastname = "Doe",
                Firstname = "Jane",
                Phone = "0689564578"
            },
            new Client()
            {
                Id = 5,
                Lastname = "New",
                Firstname = "Sahra",
                Phone = "0789564512"
            });

            modelBuilder.Entity<Room>().HasData(new Reservation()
            {
                Id = 1,
                Status = 2,
                ClientId = 1
            });
            
            modelBuilder.Entity<Room>().HasData(new Room()
            {
                Id = 1,
                Status = 1,
                NumberOfBed = 2,
                Price = 44.99M
            },
            new Room()
            {
                Id = 2,
                Status = 2,
                NumberOfBed = 1,
                Price = 31.99M
            },
            new Room()
            {
                Id = 3,
                Status = 3,
                NumberOfBed = 1,
                Price = 31.99M
            },
            new Room()
            {
                Id = 4,
                Status = 2,
                NumberOfBed = 1,
                Price = 31.99M
            },
            new Room()
            {
                Id = 5,
                Status = 2,
                NumberOfBed = 1,
                Price = 31.99M
            },
            new Room()
            {
                Id = 6,
                Status = 2,
                NumberOfBed = 2,
                Price = 44.99M
            },
            new Room()
            {
                Id = 7,
                Status = 3,
                NumberOfBed = 2,
                Price = 44.99M
            },
            new Room()
            {
                Id = 8,
                Status = 2,
                NumberOfBed = 3,
                Price = 64.99M
            });
        }
    }
}
