using Exercice01_Adresses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01_Adresses.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {
        }

        public DbSet<Address> Adresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\efcoredb;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Address> adressesDefault = new List<Address>()
            {
                new Address { Id = 1, StreetNumber = 15, StreetName = "rue de la sorbonne", City = "Maz", PostalCode = "62670" },
                new Address { Id = 2, StreetNumber = 45, StreetName = "Avenue du poulet", City = "Paris", PostalCode = "75000" },
                new Address { Id = 3, StreetNumber = 12, StreetName = "rue Victor Hugo", City = "Marseille", PostalCode = "13000" },
                new Address { Id = 4, StreetNumber = 22, StreetName = "Boulevard des coqs", City = "Lens", PostalCode = "62800" },
                new Address { Id = 5, StreetNumber = 15, StreetName = "rue du sapin", City = "Arras", PostalCode = "62000" },
                new Address { Id = 6, StreetNumber = 58, StreetName = "rue des choux", City = "Lille", PostalCode = "59000" },
                new Address { Id = 7, StreetNumber = 89, StreetName = "rue Vigny", City = "Maz", PostalCode = "62670" }
            };

            modelBuilder.Entity<Address>().HasData(adressesDefault);
        }
    }
}
