using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstCursus
{
    [Table("TPTZelfstudiecursussen")]
    public class TPTZelfstudieCursus : TPTCursus
    {
        public int AantalDagen { get; set; }
    }
}
