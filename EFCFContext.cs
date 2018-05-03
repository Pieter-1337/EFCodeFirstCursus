using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFCodeFirstCursus
{
    class EFCFContext : DbContext
    {
        public DbSet<Instructeur> Instructeurs { get; set; }
        public DbSet<Campus> Campussen { get; set; }
        public DbSet<Land> Landen { get; set; }
    }
}
