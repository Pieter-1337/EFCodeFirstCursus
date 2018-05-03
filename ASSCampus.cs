using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstCursus
{
    [Table("ASSCampussen")] // using System.ComponentModel.DataAnnotations.Schema; //Dit set de table naam manueel naar ASSCampussen
    public class ASSCampus
    {
        public int ASSCampusId { get; set; }

        [Required] // using System.ComponentModel.DataAnnotations; //Dit zorgt ervoor dat een column verplicht in te vullen is
        [StringLength(50)] //Dit set het maximaal aantal tekens op 50 voor property Naam
        public string Naam { get; set; }
        public Adres Adres { get; set; }

        //ASSOCIATIES//
        //Een ICollection property dient virtual te zijn om Lazy Loading te enablen
        public virtual ICollection<ASSInstructeur> ASSInstructeurs { get; set; }
    }
}
