using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstCursus
{
    [Table("ASSVerantwoordelijkheden")]
    public class ASSVerantwoordelijkheid
    {
        public int ASSVerantwoordelijkheidId { get; set; }
        public string Naam { get; set; }
        public virtual ICollection<ASSInstructeur> Instructeurs { get; set; }
    }
}
