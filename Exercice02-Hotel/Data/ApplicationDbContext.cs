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

            modelBuilder.Entity<Room>().HasData(new Room()
            {
                Id = 1,
                Status = RoomStatus.Occupy,
                NumberOfBed = 2,
                Price = 44.99M
            },
            new Room()
            {
                Id = 2,
                Status = RoomStatus.Occupy,
                NumberOfBed = 1,
                Price = 31.99M
            },
            new Room()
            {
                Id = 3,
                Status = RoomStatus.Occupy,
                NumberOfBed = 1,
                Price = 31.99M
            },
            new Room()
            {
                Id = 4,
                Status = RoomStatus.Occupy,
                NumberOfBed = 1,
                Price = 31.99M
            },
            new Room()
            {
                Id = 5,
                Status = RoomStatus.Occupy,
                NumberOfBed = 1,
                Price = 31.99M
            },
            new Room()
            {
                Id = 6,
                Status = RoomStatus.Free,
                NumberOfBed = 2,
                Price = 44.99M
            },
            new Room()
            {
                Id = 7,
                Status = RoomStatus.Free,
                NumberOfBed = 2,
                Price = 44.99M
            },
            new Room()
            {
                Id = 8,
                Status = RoomStatus.Cleaning,
                NumberOfBed = 3,
                Price = 64.99M
            });

            //modelBuilder.Entity<ReservationRoom>()
            //    .HasKey(rc => new { rc.RoomId, rc.ReservationId });

            //modelBuilder.Entity<Reservation>().HasData(new Reservation()
            //{
            //    Id = 1,
            //    Status = 2,
            //    ClientId = 1
            //},
            //new Reservation()
            //{
            //    Id = 2,
            //    Status = 2,
            //    ClientId = 2
            //},
            //new Reservation()
            //{
            //    Id = 3,
            //    Status = 2,
            //    ClientId = 3
            //},
            //new Reservation()
            //{
            //    Id = 4,
            //    Status = 2,
            //    ClientId = 4
            //},
            //new Reservation()
            //{
            //    Id = 5,
            //    Status = 2,
            //    ClientId = 5
            //},
            //new Reservation()
            //{
            //    Id = 6,
            //    Status = 2,
            //    ClientId = 6
            //},
            //new Reservation()
            //{
            //    Id = 7,
            //    Status = 2,
            //    ClientId = 7
            //},
            //new Reservation()
            //{
            //    Id = 8,
            //    Status = 2,
            //    ClientId = 8
            //});


            //modelBuilder.Entity<ReservationRoom>().HasData(new ReservationRoom()
            //{
            //    Id = 1,
            //    RoomId = 1,
            //    ReservationId = 1
            //},
            //new ReservationRoom()
            //{
            //    Id = 2,
            //    RoomId = 2,
            //    ReservationId = 2
            //},
            //new ReservationRoom()
            //{
            //    Id = 3,
            //    RoomId = 3,
            //    ReservationId = 3
            //},
            //new ReservationRoom()
            //{
            //    Id = 4,
            //    RoomId = 4,
            //    ReservationId = 4
            //},
            //new ReservationRoom()
            //{
            //    Id = 5,
            //    RoomId = 5,
            //    ReservationId = 5
            //},
            //new ReservationRoom()
            //{
            //    Id = 6,
            //    RoomId = 6,
            //    ReservationId = 6
            //},
            //new ReservationRoom()
            //{
            //    Id = 7,
            //    RoomId = 7,
            //    ReservationId = 7
            //},
            //new ReservationRoom()
            //{
            //    Id = 8,
            //    RoomId = 8,
            //    ReservationId = 8
            //});

        }
    }
}
