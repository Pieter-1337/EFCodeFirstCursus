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


            //System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFCFContext>());


            //using (var context = new EFCFContext())
            //{
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

            //var query = from instructeur in context.Instructeurs orderby instructeur.InstructeurNr select instructeur;

            //foreach (var instructeur in query)
            //{
            //    Console.WriteLine($"InstructeurNr:{instructeur.InstructeurNr} \nNaam: {instructeur.Voornaam} {instructeur.Familienaam}");
            //    Console.WriteLine($"Adres: ");
            //    Console.WriteLine($"\t{instructeur.Adres.Straat}{instructeur.Adres.HuisNr} \n\t{instructeur.Adres.PostCode} \n\t{instructeur.Adres.Gemeente}");
            //    Console.WriteLine("--------------------------------------------------------------------------------------");
            //}

            //Console.WriteLine("");
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////:
            //3.0
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Table per hierarchy Inheritance

            //System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFCFContext>());

            //using(var context = new EFCFContext())
            //{


            //context.TPHCursussen.Add(new TPHKlassikaleCursus
            //{
            //    Naam = "Frans in 24 uur",
            //    Van = DateTime.Today,
            //    Tot = DateTime.Today
            //});

            //context.TPHCursussen.Add(new TPHZelfstudieCursus
            //{
            //    Naam = "Engels in 24 uur",
            //    AantalDagen = 1
            //});

            //context.SaveChanges();

            //Console.WriteLine("Klassikale cursussen: ");

            //var query = from cursus in context.TPHCursussen where cursus is TPHKlassikaleCursus select cursus;

            //foreach(var cursus in query)
            //{
            //    Console.WriteLine($"{cursus.Id} : {cursus.Naam}");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("");


            //Console.WriteLine("Zelfstudie cursussen: ");

            //query = from cursus in context.TPHCursussen where cursus is TPHZelfstudieCursus select cursus;

            //foreach (var cursus in query)
            //{
            //    Console.WriteLine($"{cursus.Id} : {cursus.Naam}");
            //}
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////:
            //4.0
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Table per Type Inheritance

            //System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFCFContext>());

            //using(var context = new EFCFContext())
            //{
            //    context.TPTCursussen.Add(new TPTKlassikaleCursus
            //    {
            //        Naam = "Frans in 24 uur",
            //        Van = DateTime.Today,
            //        Tot = DateTime.Today
            //    });

            //    context.TPTCursussen.Add(new TPTZelfstudieCursus
            //    {
            //        Naam = "Engels in 24 uur",
            //        AantalDagen = 1
            //    });

            //    context.SaveChanges();

            //    Console.WriteLine("Klassikale cursussen: ");

            //    var query = from cursus in context.TPTCursussen where cursus is TPTKlassikaleCursus select cursus;

            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine($"{cursus.Id} : {cursus.Naam}");
            //    }

            //    Console.WriteLine("");
            //    Console.WriteLine("");


            //    Console.WriteLine("Zelfstudie cursussen: ");

            //    query = from cursus in context.TPTCursussen where cursus is TPTZelfstudieCursus select cursus;

            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine($"{cursus.Id} : {cursus.Naam}");
            //    }
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////:
            //4.0
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Table per Concrete Inheritance

            System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFCFContext>());

            using(var context = new EFCFContext())
            {
                context.TPCCursussen.Add(new TPCKlassikaleCursus
                {
                    Naam = "Frans in 24 uur",
                    Van = DateTime.Today,
                    Tot = DateTime.Today
                });

                context.TPCCursussen.Add(new TPCZelfstudieCursus
                {
                    Naam = "Engels in 24 uur",
                    AantalDagen = 1
                });

                context.SaveChanges();

                Console.WriteLine("Klassikale cursussen: ");

                var query = from cursus in context.TPCCursussen where cursus is TPCKlassikaleCursus select cursus;

                foreach (var cursus in query)
                {
                    Console.WriteLine($"{cursus.Id} : {cursus.Naam}");
                }

                Console.WriteLine("");
                Console.WriteLine("");


                Console.WriteLine("Zelfstudie cursussen: ");

                query = from cursus in context.TPCCursussen where cursus is TPCZelfstudieCursus select cursus;

                foreach (var cursus in query)
                {
                    Console.WriteLine($"{cursus.Id} : {cursus.Naam}");
                }
            }

        }
    }
}
