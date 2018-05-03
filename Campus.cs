using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstCursus
{
    [Table("Campussen")] // using System.ComponentModel.DataAnnotations.Schema; //Dit set de table naam manueel naar Campussen
    public class Campus
    {
        public int CampusId { get; set; }

        [Required] // using System.ComponentModel.DataAnnotations; //Dit zorgt ervoor dat een column verplicht in te vullen is
        [StringLength(50)] //Dit set het maximaal aantal tekens op 50 voor property Naam
        public string Naam { get; set; }
        public Adres Adres { get; set; }
    }
}
