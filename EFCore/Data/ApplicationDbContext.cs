using Demo01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.Data
{
    internal class ApplicationDbContext : DbContext // /!\ permet d'établir le lien entre l'application et la BDD
    {
        // 2 manière de l'utiliser selon web ou appli console
        // pour l'applic console, on utilise le constructeur de base

        public ApplicationDbContext() : base()
        {  
        }

        public DbSet<Student> Students { get; set; } // On créer et lie des tables de base de donnée avec notre application

        // la méthode 'OnConfiguring' est appelé au moment de la configuration de l'appli on peut changer son fonctionement via la surcharge de cette méthode.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // des options qu'on peut appliqué et le optionBuilder est le constructeur.
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\efcoredb;Integrated Security=True"); // sert à préciser une connexion à une BDD SQL Server avec sa chaîne de connexion
        }

        // créer certaines données qui seront injecté au moment du lancement de l'appli
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data Seed => "graine" de la bdd, des données initiales lors de l'application de la migration correspondante.
            var studentDefault = new Student()
            {
                Id = 1000,
                Firstname = "John",
                Lastname = "Doe",
                Phone = "0101010101",
                Email = "john@doe.com"
            };

            modelBuilder.Entity<Student>().HasData(studentDefault);
        }
    }
}
