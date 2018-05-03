using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstCursus
{
    [Table("TPCKlassikalecursussen")]
    public class TPCKlassikaleCursus : TPCCursus
    {
        public DateTime Van { get; set; }
        public DateTime Tot { get; set; }
    }
}
