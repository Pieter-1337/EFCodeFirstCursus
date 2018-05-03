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

            //System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFCFContext>());

            //using(var context = new EFCFContext())
            //{
            //    context.TPCCursussen.Add(new TPCKlassikaleCursus
            //    {
            //        Naam = "Frans in 24 uur",
            //        Van = DateTime.Today,
            //        Tot = DateTime.Today
            //    });

            //    context.TPCCursussen.Add(new TPCZelfstudieCursus
            //    {
            //        Naam = "Engels in 24 uur",
            //        AantalDagen = 1
            //    });

            //    context.SaveChanges();

            //    Console.WriteLine("Klassikale cursussen: ");

            //    var query = from cursus in context.TPCCursussen where cursus is TPCKlassikaleCursus select cursus;

            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine($"{cursus.Id} : {cursus.Naam}");
            //    }

            //    Console.WriteLine("");
            //    Console.WriteLine("");


            //    Console.WriteLine("Zelfstudie cursussen: ");

            //    query = from cursus in context.TPCCursussen where cursus is TPCZelfstudieCursus select cursus;

            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine($"{cursus.Id} : {cursus.Naam}");
            //    }
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////:
            //4.0
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Data opvragen van tables die geassocieert zijn met elkaar

            //Een-op-veel associaties

            //System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFCFContext>());

            //using(var context = new EFCFContext())
            //{
            //    var NewCampus = new ASSCampus
            //    {
            //        Naam = "Delos",
            //        Adres = new Adres
            //        {
            //            Straat = "Vlamingstraat",
            //            HuisNr = "10",
            //            PostCode = "8560",
            //            Gemeente = "Wevelgem"
            //        }
            //    };

            //    var NewInstructeur = new ASSInstructeur
            //    {
            //        Voornaam = "Marcel",
            //        Familienaam = "Kiekeboe",
            //        Adres = new Adres
            //        {
            //            Straat = "Merholaan",
            //            HuisNr = "1B",
            //            PostCode = "2981",
            //            Gemeente = "Zoersel-Parwijs"
            //        },
            //        Wedde = 100,
            //        InDienst = new DateTime(1955, 1, 1),
            //        HeeftRijbewijs = true,
            //        Campus = NewCampus //de campus van de instructeur wordt hier gelijk gezet met nieuw aangemaakte campus hierboven

            //    };

            //    context.ASSCampussen.Add(NewCampus);
            //    context.ASSInstructeurs.Add(NewInstructeur);

            //    context.SaveChanges();

            //    var query = from instructeur in context.ASSInstructeurs orderby instructeur.Familienaam select instructeur;

            //    foreach(var instructeur in query)
            //    {
            //        Console.WriteLine($"Id: {instructeur.InstructeurNr} - \nNaam: {instructeur.Voornaam} {instructeur.Familienaam}\nWedde: {instructeur.Wedde}\nCampus: {instructeur.Campus.Naam}");
            //    }
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////:
            //5.0
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Data opvragen van tables die geassocieert zijn met elkaar

            //Veel-op-veel associaties

            //System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFCFContext>());

            //using(var context = new EFCFContext())
            //{
            //    var verantwoordelijkheid = new ASSVerantwoordelijkheid
            //    {
            //        Naam = "EHBO"
            //    };

            //    var NewInstructeur = new ASSInstructeur
            //    {
            //        Voornaam = "Pieter",
            //        Familienaam = "Bracke",
            //        Adres = new Adres
            //        {
            //            Straat = "Tolhuislaan",
            //            HuisNr = "96C",
            //            PostCode = "9000",
            //            Gemeente = "Gent"
            //        },
            //        Wedde = 2000,
            //        HeeftRijbewijs = true,
            //        InDienst = new DateTime(2018, 1, 1),
            //        Campus = new ASSCampus { Naam = "Pieter's Campus", Adres = new Adres { Straat = "Tolhuislaan", HuisNr = "96C", PostCode = "9000", Gemeente = "Gent" } },
            //        Verantwoordelijkheden = new List<ASSVerantwoordelijkheid> { verantwoordelijkheid}
            //    };

            //    context.ASSInstructeurs.Add(NewInstructeur);
            //    context.ASSVerantwoordelijkheden.Add(verantwoordelijkheid);

            //    context.SaveChanges();

            //    var query = from instructeur in context.ASSInstructeurs orderby instructeur.Familienaam select instructeur;

            //    foreach (var instructeur in query)
            //    {
            //        Console.WriteLine($"Id: {instructeur.InstructeurNr} - \nNaam: {instructeur.Voornaam} {instructeur.Familienaam}\nWedde: {instructeur.Wedde}\nCampus: {instructeur.Campus.Naam}");

            //        foreach(var eenVerantwoordelijkheid in instructeur.Verantwoordelijkheden)
            //        {
            //            Console.WriteLine(eenVerantwoordelijkheid.Naam);
            //        }
            //    }

            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////:
            //6.0
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Data opvragen van tables die geassocieert zijn met elkaar

            //Associaties naar dezelfde table (Bv een table cursisten waar cursisten ook mentors kunnen zijn van andere cursisten

            System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFCFContext>());

            using(var context = new EFCFContext())
            {
                // ================================== 
                //Een associatie naar dezelfde tabel 
                // ================================== 
                //Cursist joe = new Cursist { Voornaam = "Joe", Familienaam = "Dalton", };
                //Cursist averell = new Cursist { Voornaam = "Averell", Familienaam = "Dalton", Mentor = joe};

                //context.Cursisten.Add(joe);
                //context.Cursisten.Add(averell);
                //context.SaveChanges();


                //Om Lazy Loading problemen te verhelpen is het aangewezen om in geval van dubbele of meerdere foreach loops
                //de objecten in een List te pushen en vandaaruit de foreachen te doen zoals hieronder
                var query = from cursist in context.Cursisten where (cursist.Beschermelingen.Count > 0) select cursist;
                List<Cursist> CursistenLijst = new List<Cursist>(); 
                foreach(var cursist in query)
                {
                    CursistenLijst.Add(cursist);
                }

                foreach(var cursist in CursistenLijst)
                {
                    Console.WriteLine($"Naam: {cursist.Voornaam} {cursist.Familienaam} - Beschermelingen: ");
                    foreach(var beschermeling in cursist.Beschermelingen)
                    {
                        Console.WriteLine($"{beschermeling.Voornaam} {beschermeling.Familienaam}");
                    }
                }
               
            }

        }
    }
}
