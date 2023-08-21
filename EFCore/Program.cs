using Demo01.Data;
using Demo01.Models;

//Console.WriteLine(student1.Firstname);

using var context = new ApplicationDbContext(); // using permet de gérer la fermeture de la connexion après la fin du bloc de code

Student student = new Student()
{
    Firstname = "Albert",
    Lastname = "Dup",
    Phone = "0707070707",
    Email = "rem@dum.com"
};

//CREATE
//ajout d'un étudiant
//Console.WriteLine("Création d'un étudiant...");
//context.Students.Add(student); // préparation de l'ajout d'un étudiant (INSERT)
//context.SaveChanges(); // éxécution des commandes de modification préparées

// READ
//Console.WriteLine("Récupération des données : ");
//List<Student> students = context.Students.ToList(); // comme un SELCT * Students
//foreach (var s in students)
//{
//    Console.WriteLine($"Etudiant {s.Id} : {s.Firstname} {s.Lastname}");
//}

//Console.WriteLine("\nRécupération par l'ID : ");
//Student student1 = context.Students.Find(1)!;
//Console.WriteLine($"Etudiant 1 : {student1.Id}, {student1.Firstname} {student1.Lastname}");

//Console.WriteLine("\nRécupération d'une entité avec un prédicat (delegate qui retroune un booléen) : ");
//Student student2 = context.Students.FirstOrDefault(s => s.Lastname == "Sma")!;
//Console.WriteLine($"Etudiant : {student2.Id}, {student2.Firstname} {student2.Lastname}");

//Console.WriteLine("\nRécupération de plusieurs entitées avec un prédicat (delegate qui retourne un booléen : ");
//List<Student> students2 = context.Students.Where(s => s.Lastname!.StartsWith("D")).ToList();
//foreach (var s in students2)
//{
//    Console.WriteLine($"Etudiant {s.Id} : {s.Firstname} {s.Lastname}");
//}

// UPDATE
//Console.WriteLine("\nMise à jour de données : ");

//Console.WriteLine("Récupération par l'id... Le numéro 2...");
//Student studentToUpdate = context.Students.Find(2)!;
//Console.WriteLine("Mise à jour ...");
//studentToUpdate.Firstname = "Fatm";
//studentToUpdate.Lastname = "Sma";
//context.Students.Update(studentToUpdate);
//context.SaveChanges();

// DELETE
//Console.WriteLine("Suppression de l'étudiant avec l'id 3...");
//context.Students.Remove(context.Students.Find(3)!);
//context.SaveChanges();