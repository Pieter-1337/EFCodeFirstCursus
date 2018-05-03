using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstCursus
{
    [Table("TPTCursussen")]
    public abstract class TPTCursus
    {
        public int Id { get; set; }
        public string Naam { get; set; }
    }
}
