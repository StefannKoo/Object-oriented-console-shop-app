using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPrakticna
{
    class Tablet:Uredjaj
    {
        public string Dijagonala { get; set; }
        public string Kvalitet { get; set; }
        public Tablet(string naziv, string proiz, string jib, Korisnik k,StanjeUredjaja st, TipUredjaja tip,string dijag,string kvalitet): base(naziv,proiz,jib,k,st,tip)
        {
            Dijagonala = dijag;
            Kvalitet = kvalitet;
        }
    }
}
