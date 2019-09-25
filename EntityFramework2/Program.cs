using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Skola1Context db = new Skola1Context();
            Ucenik a = new Ucenik();
            a.Ime = "Katarina";
            a.Prezime = "Jos";
            
            UcenikDetalji d = new UcenikDetalji();
            d.Adresa = "adresa";
            d.Email = "email@gmail.com";
            d.Telefon = "213424";
            a.Detalji = d;
            db.Ucenici.Add(a);
            db.SaveChanges();

            //eager loading -ucitava sve podatke od jednom
            //foreach(var u in db.Ucenici.Include("Detalji")){Console.Writeline(u.Ime + u.Detalji.Email);


            //lazy loading
            foreach (var u in db.Ucenici) {

                Console.WriteLine(u.Ime + u.Detalji.Email);
            }
            Console.Read();
        }
    }
}
