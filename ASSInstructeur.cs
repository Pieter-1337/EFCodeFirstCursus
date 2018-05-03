using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstCursus
{
    public class ASSInstructeur
    {
        [Key]//Dit zorgt ervoor dat Instructeur nummer de primary Key van de table is
        public int InstructeurNr { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public Adres Adres { get; set; }
        [Column("maandwedde")] //using System.ComponentModel.DataAnnotations.Schema; //Dit set de Column name manueel
        public decimal Wedde { get; set; }
        [Column(TypeName = "date")] //TypeName="" zorgt ervoor dat een column van een bepaald type moet zijn hier bv een datetime
        public DateTime InDienst { get; set; }
        public bool? HeeftRijbewijs { get; set; } //Deze property werd nullable gemaakt (via ? voor de property naam)dit zorgt ervoor dat deze column NIET verplicht in te vullen is!

        public void Opslag(decimal percentage)
        {
            Wedde *= (1M + percentage / 100M);
        }

        public virtual ICollection<ASSVerantwoordelijkheid> Verantwoordelijkheden { get; set; }

        //ASSOCIATIES//
        //Deze property stelt de campus van de instructeur voor
        public virtual ASSCampus Campus { get; set; }
        //Deze property stelt het campus nummer voor de property naam MOET hetzelfde zijn als de primary key in de geassocieerde class!
        public int ASSCampusId { get; set; }

        
    }
}
