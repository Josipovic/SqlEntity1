using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework2
{
    class Skola1Context:DbContext
    {
        public  DbSet<Ucenik>Ucenici { get; set; }
        public DbSet<UcenikDetalji> Detalji { get; set; }

    }
}
