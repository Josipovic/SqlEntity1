using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework2
{
    class Ucenik
    {
        public  int Id  { get; set; }
        public string  Ime { get; set; }
        public string Prezime { get; set; }

        public virtual UcenikDetalji Detalji { get; set; }
    }
}
