﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstCursus
{
    [Table("TPCZelfstudiecursussen")]
    public class TPCZelfstudieCursus : TPCCursus
    {
        public int AantalDagen { get; set; }
    }
}
