using Domain.models.entities;
using Domain.Models.Entities;
using Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DbInitializer
    {

        public static void Initialize(SortirContext context)
        {
            Console.WriteLine("Initialisation des données...");


            if (!context.EventStatus.Any())
            {
                Console.WriteLine("Ajout des statuts des événements...");

                var eventStatus = new EventStatus[]
                {
new EventStatus {Name="In_Progress" },
new EventStatus {Name="Draft" },
new EventStatus {Name="Closed" },
new EventStatus {Name="Cancelled" },
new EventStatus {Name="Finished" },
new EventStatus {Name="Open" },

                };
                context.EventStatus.AddRange(eventStatus);
                context.SaveChanges();

            }
            if (!context.Cities.Any())
            {
                Console.WriteLine("Ajout des villes...");

                var cities = new City[]
                {
                new City { Name = "Paris", Zipcode = "75000" },
                new City { Name = "Marseille", Zipcode = "13000" },
                new City { Name = "Lyon", Zipcode = "69000" },
                new City { Name = "Toulouse", Zipcode = "31000" },
                new City { Name = "Nice", Zipcode = "06000" },
                new City { Name = "Nantes", Zipcode = "44000" },
                new City { Name = "Strasbourg", Zipcode = "67000" },
                new City { Name = "Montpellier", Zipcode = "34000" },
                new City { Name = "Bordeaux", Zipcode = "33000" },
                new City { Name = "Lille", Zipcode = "59000" },
                new City { Name = "Rennes", Zipcode = "35000" },
                new City { Name = "Reims", Zipcode = "51100" },
                new City { Name = "Le Havre", Zipcode = "76600" },
                new City { Name = "Saint-Étienne", Zipcode = "42000" },
                new City { Name = "Toulon", Zipcode = "83000" },
                new City { Name = "Angers", Zipcode = "49000" },
                new City { Name = "Clermont-Ferrand", Zipcode = "63000" },
                new City { Name = "Le Mans", Zipcode = "72000" },
                new City { Name = "Aix-en-Provence", Zipcode = "13090" },
                new City { Name = "La Rochelle", Zipcode = "17000" },
                };
                context.Cities.AddRange(cities);
              context.SaveChanges();
            }
            if (!context.Campuses.Any())
            {
                Console.WriteLine("Ajout des campus...");

                var campuses = new Campus[]
                {
                new Campus { Name = "Campus Lumière" },
                new Campus { Name = "Campus Horizon" },
                new Campus { Name = "Campus Étoile" },
                new Campus { Name = "Campus Horizon Bleu" },
                new Campus { Name = "Campus Verger" },
                new Campus { Name = "Campus Zenith" },
                new Campus { Name = "Campus Terra Nova" },
                new Campus { Name = "Campus Albatros" },
                new Campus { Name = "Campus Nova" },
                new Campus { Name = "Campus Métropole" },
                new Campus { Name = "Campus Aurora" },
                new Campus { Name = "Campus Émeraude" },
                new Campus { Name = "Campus Atlas" },
                new Campus { Name = "Campus Arcadia" },
                new Campus { Name = "Campus Solstice" },
                new Campus { Name = "Campus Orléans" },
                new Campus { Name = "Campus Vortex" },
                new Campus { Name = "Campus Montaigne" },
                new Campus { Name = "Campus Élysée" },
                new Campus { Name = "Campus Phoenix" },
                };
                context.Campuses.AddRange(campuses);
               context.SaveChanges();
            }
            /* if (!context.Users.Any())
             {
                        Console.WriteLine("Ajout des utilisateurs...");

                 var users = new User[]
                 {
                 new User { Email = "jean.dupont@example.com", FirstName = "Jean", LastName = "Dupont", PhoneNumber = "0601234567", CampusId = 1 },
                 new User { Email = "marie.durand@example.com", FirstName = "Marie", LastName = "Durand", PhoneNumber = "0607654321", CampusId = 2 },
                 new User { Email = "pierre.martin@example.com", FirstName = "Pierre", LastName = "Martin", PhoneNumber = "0612345678", CampusId = 3 },
                 new User { Email = "nathalie.bernard@example.com", FirstName = "Nathalie", LastName = "Bernard", PhoneNumber = "0618765432", CampusId = 4 },
                 new User { Email = "lucas.leclerc@example.com", FirstName = "Lucas", LastName = "Leclerc", PhoneNumber = "0623456789", CampusId = 5 },
                 new User { Email = "laura.roux@example.com", FirstName = "Laura", LastName = "Roux", PhoneNumber = "0629876543", CampusId = 6 },
                 new User { Email = "julien.toussaint@example.com", FirstName = "Julien", LastName = "Toussaint", PhoneNumber = "0634567890", CampusId = 7 },
                 new User { Email = "caroline.paul@example.com", FirstName = "Caroline", LastName = "Paul", PhoneNumber = "0632109876", CampusId = 8 },
                 new User { Email = "antoine.dupuis@example.com", FirstName = "Antoine", LastName = "Dupuis", PhoneNumber = "0643210987", CampusId = 9 },
                 new User { Email = "emilie.moreau@example.com", FirstName = "Emilie", LastName = "Moreau", PhoneNumber = "0645678901", CampusId = 10 },
                 new User { Email = "mathieu.david@example.com", FirstName = "Mathieu", LastName = "David", PhoneNumber = "0656789012", CampusId = 11 },
                 new User { Email = "sophie.rivier@example.com", FirstName = "Sophie", LastName = "Rivier", PhoneNumber = "0654321098", CampusId = 12 },
                 new User { Email = "olivier.lambert@example.com", FirstName = "Olivier", LastName = "Lambert", PhoneNumber = "0667890123", CampusId = 13 },
                 new User { Email = "claire.marchand@example.com", FirstName = "Claire", LastName = "Marchand", PhoneNumber = "0665432109", CampusId = 14 },
                 new User { Email = "alexandre.henry@example.com", FirstName = "Alexandre", LastName = "Henry", PhoneNumber = "0678901234", CampusId = 15 },
                 new User { Email = "marie-laure.moulin@example.com", FirstName = "Marie-Laure", LastName = "Moulin", PhoneNumber = "0676543210", CampusId = 16 },
                 new User { Email = "jean-paul.garcia@example.com", FirstName = "Jean-Paul", LastName = "Garcia", PhoneNumber = "0689012345", CampusId = 17 },
                 new User { Email = "sandra.fabre@example.com", FirstName = "Sandra", LastName = "Fabre", PhoneNumber = "0687654321", CampusId = 18 },
                 new User { Email = "thomas.gillet@example.com", FirstName = "Thomas", LastName = "Gillet", PhoneNumber = "0690123456", CampusId = 19 },
                 new User { Email = "lisa.caron@example.com", FirstName = "Lisa", LastName = "Caron", PhoneNumber = "0698765432", CampusId = 20 },
                 new User { Email = "vincent.pelletier@example.com", FirstName = "Vincent", LastName = "Pelletier", PhoneNumber = "0612345670", CampusId = 1 },
                 };
                 context.Users.AddRange(users);
                 context.SaveChanges();
             } */


        }
    }
}
