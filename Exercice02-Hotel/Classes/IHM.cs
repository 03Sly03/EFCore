using Exercice02_Hotel.Data;
using Exercice02_Hotel.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02_Hotel.Classes
{
    internal static class IHM
    {
        public static void Start(ApplicationDbContext context)
        {
            do
            {
                DisplayMenu();
                string choice = Console.ReadLine()!;
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        AddClient(context);
                        break;
                    case "2":
                        Console.Clear();
                        DisplayClients(context);
                        break;
                    //case "3":
                    //    Console.Clear();
                    //    UpdateAddress(context);
                    //    Console.Clear();
                    //    break;
                    case "4":
                        Console.Clear();
                        AddReservation(context);
                        //Console.Clear();
                        break;
                    //case "4":
                    //    Console.Clear();
                    //    DisplayAdressList(context);
                    //    DeleteAddress(context);
                    //    Console.Clear();
                    //    Console.ForegroundColor = ConsoleColor.Red;
                    //    Console.WriteLine("L'adresse a bien été supprimé\n");
                    //    Console.ResetColor();
                    //    break;
                    case "0":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Fermage de l'application !");
                        Console.ResetColor();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erreur de saisie !");
                        Console.ResetColor();
                        break;
                }
            } while (true);
        }

        public static void DisplayMenu()
        {
            Console.Write("\t=== MENU PRINCIPAL ===\n\n" +
                "\t1. Ajouter un client\n" +
                "\t2. Efficher la liste des clients\n" +
                "\t3. Afficher les réservations d'un client\n" +
                "\t4. Ajouter une réservation\n" +
                "\t5. Annuler une réservation\n" +
                "\t6. Afficher la liste desréservations\n" +
                "\t0. Quitter\n\n" +

                "Votre choix : "
            );

        }


        // AFFICHAGES & LISTES
        public static void ClientsList(ApplicationDbContext context)
        {
            context.Clients.ToList().ForEach(client => Console.WriteLine("\t" + client));
        }
        public static void RoomsList(ApplicationDbContext context)
        {
            context.Rooms.ToList().ForEach(room => Console.WriteLine("\t" + room));
        }

        public static void DisplayClients(ApplicationDbContext context)
        {
            Console.WriteLine("\t=== LISTE DES CLIENTS ===\n");
            ClientsList(context);
            Console.WriteLine();
        }

        // CONTROLE DES ID
        public static bool isClientId(int idToCheck, ApplicationDbContext context)
        {
            return context.Clients.Find(idToCheck) != null;
        }
        public static bool isRoomId(int idToCheck, ApplicationDbContext context)
        {
            return context.Rooms.Find(idToCheck) != null;
        }

        // AJOUTS
        public static void AddClient(ApplicationDbContext context)
        {
            Console.WriteLine("\t=== AJOUTER UN CLIENT ===\n");
            Console.Write("Nom : ");
            string lastname = Console.ReadLine()!;

            Console.Write("Prénom : ");
            string firstname = Console.ReadLine()!;

            Console.Write("Téléphone : ");
            string phone = Console.ReadLine()!;

            Client newClient = new Client()
            {
                Lastname = lastname,
                Firstname = firstname,
                Phone = phone
            };

            context.Clients.Add(newClient);
            context.SaveChanges();
        }
        public static void AddReservation(ApplicationDbContext context)
        {
            Console.WriteLine("\t=== FAIRE UNE RESERVATION ===\n");
            Console.WriteLine("Pour quel Client voulez-vous faire une réservation ? : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            ClientsList(context);
            Console.ResetColor();
            Console.Write("\nSaisissez l'indentifiant du client : ");
            int clientId = int.Parse(Console.ReadLine()!);
            while (!isClientId(clientId, context))
            {
                Console.Write("Il'n'y a pas de client avec cette identifiant. Recommencez : ");
                clientId = int.Parse(Console.ReadLine()!);
            }
            Client client = context.Clients.Find(clientId)!;

            Console.WriteLine("Pour quel Chambre voulez-vous faire la réservation ? : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            RoomsList(context);
            Console.ResetColor();
            Console.Write("\nSaisissez l'indentifiant de la chambre : ");
            int roomId = int.Parse(Console.ReadLine()!);
            while (!isRoomId(roomId, context))
            {
                Console.Write("Il'n'y a pas de chambre avec cette identifiant. Recommencez : ");
                roomId = int.Parse(Console.ReadLine()!);
            }
            Room room = context.Rooms.Find(roomId)!;

            Reservation newReservation = new Reservation()
            {
                Status = ReservationStatus.Done,
                ClientId = clientId
            };
            context.Reservations.Add(newReservation);
            context.SaveChanges();

            ReservationRoom newReservationsRooms = new ReservationRoom()
            {
                ReservationId = newReservation.Id,
                RoomId = roomId
            };
            context.ReservationsRooms.Add(newReservationsRooms);
            context.SaveChanges();
        }
    }
}
