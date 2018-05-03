using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFCodeFirstCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            //01 
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Toevoegen van nieuw record aan Context via Entity framework

            //using(var context = new EFCFContext())
            //{
            //    var jean = new Instructeur
            //    {
            //        Voornaam = "Jean",
            //        Familienaam = "Smits",
            //        Wedde = 1000,
            //        InDienst = new DateTime(1994, 8, 1)
            //    };

            //    context.Instructeurs.Add(jean);
            //    context.SaveChanges();

            //    jean = context.Instructeurs.Find(1);

            //    Console.WriteLine($"Nieuw toegevoegde instructeur is - Id:{jean.Id} Naam: {jean.Voornaam} {jean.Familienaam} Wedde: {jean.Wedde} Indienst sinds: {jean.InDienst}");
            //    Console.ReadKey();
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            //02
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Toevoegen van een nieuw record aan Context en checken of er geen wijzigingen zijn in de datastructuur van de tabel bv een nieuwe property (kolom) van een class

            //Onderstaande command checkt of de structuur van de table nog steeds dezelfde is als dit niet het geval is zal hij de database WISSEN en HERBOUWEN
            //HOU ER REKENING MEE DAT DIT ALLE DATA DIE IN DE DB WAS OPGESLAGEN WIST EN EEN VOLLEDIG NIEUWE DB OPBOUWT ZONDER ENIGE RECORDS
            //Hou er ook rekening mee dat steeds alle connections naar de database (Zowel in visual studio als in SQL management studio moeten gesloten zijn om dit te laten werken)


            System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFCFContext>());


            using (var context = new EFCFContext())
            {
                //var Belgie = new Land
                //{
                //    Naam = "Belgie",
                //    LandCode = "BE"
                //};

                //context.Landen.Add(Belgie);

                //var Pieter = new Instructeur
                //{
                //    Voornaam = "Pieter",
                //    Familienaam = "Bracke",
                //    Wedde = 3000,
                //    InDienst = new DateTime(2018, 01, 01),
                //    HeeftRijbewijs = true,
                //    Adres = new Adres
                //    {
                //        Straat = "Tolhuislaan",
                //        HuisNr =" 96C",
                //        PostCode = "9000",
                //        Gemeente = "Gent"
                //    }
                //};

                //context.Instructeurs.Add(Pieter);
                //context.SaveChanges();

                var query = from instructeur in context.Instructeurs orderby instructeur.InstructeurNr select instructeur;

                foreach (var instructeur in query)
                {
                    Console.WriteLine($"InstructeurNr:{instructeur.InstructeurNr} \nNaam: {instructeur.Voornaam} {instructeur.Familienaam}");
                    Console.WriteLine($"Adres: ");
                    Console.WriteLine($"\t{instructeur.Adres.Straat}{instructeur.Adres.HuisNr} \n\t{instructeur.Adres.PostCode} \n\t{instructeur.Adres.Gemeente}");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                }

                Console.WriteLine("");
            }

        }
    }
}
