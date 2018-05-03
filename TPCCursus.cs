using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstCursus
{
    //[Table("TPCCursussen")] Wordt verwijderd omdat er met een Guid gewerkt wordt
    public abstract class TPCCursus
    {
        //public int Id { get; set; } // Wordt verwijderd omdat er met een Guid gewerkt wordt


        //Je geeft aan dat de inhoud van de primary key bij een nieuw record door de database wordt ingevuld (en niet in je code).
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // dit vervangt de [Table("....")] van bovenaan de class

        //Je kiest Guid als type van de property. SQL Server zal bij een nieuw record een unieke string invullen in de primary key.
        public Guid Id { get; set; } //Dit vervangt de standaard int Id

        public string Naam { get; set; }
    }
}
