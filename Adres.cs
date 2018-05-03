using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstCursus
{
    [ComplexType] //Dit stelt dat onderstaande class een complex type is die in meerdere andere classes zal terug komen
    public class Adres
    {
        [Column("Straat")] //Dit zorgt ervoor dat de kolom naam in de table manueel geset is op Straat en niet op Adres_Straat
        public string Straat { get; set; }
        [Column("HuisNr")]
        public string HuisNr { get; set; }
        [Column("Postcode")]
        public string PostCode { get; set; }
        [Column("Gemeente")]
        public string Gemeente { get; set; }


    }
}
