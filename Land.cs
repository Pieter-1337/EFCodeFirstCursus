﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstCursus
{
    [Table("Landen")]
    public class Land
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string LandCode { get; set; }
        public string Naam { get; set; }
    }
}
