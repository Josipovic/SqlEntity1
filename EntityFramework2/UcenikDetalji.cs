using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework2
{
    class UcenikDetalji
    {
        [ForeignKey("Ucenik")]
        public int Id { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public  string  Telefon { get; set; }

        public virtual Ucenik Ucenik { get; set; }
    }
}
