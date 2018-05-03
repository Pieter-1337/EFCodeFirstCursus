using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFCodeFirstCursus
{
    class EFCFContext : DbContext
    {
        public DbSet<Instructeur> Instructeurs { get; set; }
        public DbSet<Campus> Campussen { get; set; }
        public DbSet<Land> Landen { get; set; }
        
        //Tabel per hierarchy
        public DbSet<TPHCursus> TPHCursussen { get; set; }

        //Table per Type
        public DbSet<TPTCursus> TPTCursussen { get; set; }

        //Table per concrete
        public DbSet<TPCCursus> TPCCursussen { get; set; }

        public DbSet<ASSInstructeur> ASSInstructeurs { get; set; }
        public DbSet<ASSCampus> ASSCampussen { get; set; }
        public DbSet<ASSVerantwoordelijkheid> ASSVerantwoordelijkheden { get; set; }

        public DbSet<Cursist> Cursisten { get; set; }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Via deze functie kan je de discriminator kolom aanpassen die gaat kijken welke soort (bv een cursus is) in geval van inheritance
            modelBuilder.Entity<TPHKlassikaleCursus>().Map(m => m.Requires("Soort").HasValue("Klassikale cursus"));

            modelBuilder.Entity<TPHZelfstudieCursus>().Map(m => m.Requires("Soort").HasValue("Zelfstudie cursus"));


            //Je geeft met de method MapInheritedProperties aan dat Code First alle properties (ook de geërfde properties) in de table moet plaatsen die bij de class hoort.
            modelBuilder.Entity<TPCKlassikaleCursus>().Map(m => m.MapInheritedProperties());

            modelBuilder.Entity<TPCZelfstudieCursus>().Map(m => m.MapInheritedProperties());


            ///////////////////:
           //INSTELLEN VAN DE NAAM VAN DE TUSSENTABEL EN DE KOLOMNAMEN VAN DE TUSSENTABEL

            //Je vermeldt bij Entity tussen<en> de naam van één van beide classes.
            //Je vermeldt bij HasMany de property in de class bij die verwijst naar de tweede class. 
            //Je vermeldt bij WithMany de property in de tweede class die verwijst naar de class bij .Entity 
            //Je vermeldt bij ToTable de naam van de tussentabel.
            //Je vermeldt bij MapLeftKey de kolomnaam die hoort bij de tweede class in de tussentabel. 
            //Je vermeldt bij MapRightKey de kolomnaam die hoort bij de class bij .Entity in de tussentabel.
            modelBuilder.Entity<ASSInstructeur>()
                            .HasMany(i => i.Verantwoordelijkheden)
                            .WithMany(v => v.Instructeurs)
                            .Map(c => c.ToTable("InstructeursVerantwoordelijkheden")
                            .MapLeftKey("VerantwoordelijkheidID")
                            .MapRightKey("InstructeurNr"));
                            
        }
    }
}
