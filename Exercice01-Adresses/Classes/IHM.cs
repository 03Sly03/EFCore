using Exercice01_Adresses.Data;
using Exercice01_Adresses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercice01_Adresses.Classes
{
    internal static class IHM
    {
        public static void Start()
        {
            using var context = new ApplicationDbContext();

            do
            {
                DisplayMenu();
                string choice = Console.ReadLine()!;
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        DisplayAddress(context);
                        break;
                    case "2":
                        Console.Clear();
                        DisplayAddAdresse(context);
                        break;
                    case "3":
                        Console.Clear();
                        UpdateAddress(context);
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        DisplayAdressList(context);
                        DeleteAddress(context);
                        Console.Clear();
                        Console.WriteLine("L'adresse a bien été supprimé\n");
                        break;
                    case "0":
                        Console.WriteLine("Fermage de l'application !");
                        return;
                    default:
                        Console.WriteLine("Erreur de saisie !");
                        break;
                }
            } while (true);
        }

        public static void DisplayAdressList(ApplicationDbContext context)
        {
            context.Adresses.ToList().ForEach(ad => Console.WriteLine(ad));
        }

        public static void DisplayMenu()
        {
            Console.Write(@"=== MENU PRINCIPAL ===

    1. Voir les adresses
    2. Ajouter une adresses
    3. Editer une adresses
    4. Supprimer une adresses
    0. Quitter le programme

Votre choix : ");
        }

        public static void DisplayAddAdresse(ApplicationDbContext context)
        {
            do
            {
                Console.Write(@"=== Ajout d'une adresse ===

    1. Ajouter une adresse
    2. Retour au menu

Votre choix : ");

                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        AddAdress(context);
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        return;

                    default:
                        Console.WriteLine("Erreur de saisie !");
                        break;
                }

            } while (true);

        }

        public static void AddAdress(ApplicationDbContext context)
        {
            int streetNumber;

            Console.WriteLine("=== AJOUTER UNE ADRESSE ===\n");
            Console.Write("Veuillez entrer le numéro de voie : ");
            while (!int.TryParse(Console.ReadLine(), out streetNumber))
            {
                Console.Write("Erreur de saisie ! veuillez recommencer : ");
            };

            Console.Write("Veuillez entrer l'intitulé de voie : ");
            string streetName = Console.ReadLine()!;

            Console.Write("Voulez-vous ajouter un complément d'adresse ? (Oui/Non) : ");
            string answer = Console.ReadLine()!.ToLower();
            string additionalAddress = "";
            if (answer == "o" || answer == "oui")
            {
                Console.Write("Veuillez entrer le complément d'adresse : ");
                additionalAddress = Console.ReadLine()!;
            } 

            Console.Write("Veuillez entrer la commune : ");
            string city = Console.ReadLine()!;

            Console.Write("Veuillez entrer le code postal : ");
            string postalCode = Console.ReadLine()!;

            Address newAddress = new Address()
            {
                StreetNumber = streetNumber,
                StreetName = streetName,
                AdditionalAddress = additionalAddress,
                City = city,
                PostalCode = postalCode
            };

            context.Adresses.Add(newAddress);
            context.SaveChanges();
        }

        public static void DisplayAddress(ApplicationDbContext context)
        {
            Console.WriteLine("=== TOUTES LES ADRESSES ===\n");
            DisplayAdressList(context);
            Console.WriteLine();
        }

        public static void UpdateAddress(ApplicationDbContext context)
        {
            int adressIdToUpdate;

            Console.WriteLine("=== EDITER UNE ADRESSE ===\n");
            DisplayAdressList(context);
            Console.Write("\nSaisissez l'id de l'adresse que vous souhaitez modifier : ");
            while (!int.TryParse(Console.ReadLine()!, out adressIdToUpdate))
            {
                Console.Write("Erreur de saisie ! Veuillez recommencer : ");
            };
            Address addressToUpdate = context.Adresses.Find(adressIdToUpdate)!;

            string userInput;
            Console.WriteLine("\n--- Appuyez sur entrer si vous ne voulez pas modifier le champ ---\n");
            Console.Write("Veuillez entrer le numéro de vois : ");
            userInput = Console.ReadLine()!;
            if (userInput != "")
            {
                int streetNumber;
                while (!int.TryParse(userInput, out streetNumber))
                {
                    Console.Write("Erreur de saisie ! Veuillez recommencer : ");
                    userInput = Console.ReadLine()!;
                    if (userInput == "")
                        break;
                }
                addressToUpdate.StreetNumber = streetNumber;
            }
            Console.Write("Veuillez entrer l'intitulé de voie : ");
            userInput = Console.ReadLine()!;
            if (userInput != "")
                addressToUpdate.StreetName = userInput;
            Console.Write("Veuillez entrer le complément d'adresse : ");
            userInput = Console.ReadLine()!;
            if (userInput != "")
                addressToUpdate.AdditionalAddress = userInput;
            Console.Write("Veuillez entrer la commune : ");
            userInput = Console.ReadLine()!;
            if (userInput != "")
                addressToUpdate.City = userInput;
            Console.Write("Veuillez entrer le code postal : ");
            userInput = Console.ReadLine()!;
            if (userInput != "")
                addressToUpdate.PostalCode = userInput;

            context.Adresses.Update(addressToUpdate);
            context.SaveChanges();
        }

        public static void DeleteAddress(ApplicationDbContext context)
        {
            Console.Write("\nSaisissez l'id de l'adresse que vous voulez supprimer : ");
            int adressIdToDelete = int.Parse(Console.ReadLine()!);
            Address addressToDelete = context.Adresses.Find(adressIdToDelete)!;
            context.Adresses.Remove(addressToDelete);

            context.SaveChanges();
        }
    }
}
