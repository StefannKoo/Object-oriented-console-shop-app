using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPrakticna
{
    class Racunar:Uredjaj
    {
        public string Procesor { get; set; }
        public string Graficka { get; set; }
        public Racunar(string naziv, string proiz, string jib, Korisnik k,StanjeUredjaja st, TipUredjaja tip,string proc,string graficka):base( naziv,  proiz, jib,  k,st,tip)
        {
            Procesor = proc;
            Graficka = graficka;
        }
    }
}
