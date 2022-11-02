using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPrakticna
{
    class MobilniUredjaj:Uredjaj
    {
        public string Marka { get; set; }
        public string Cijena { get; set; }
        public MobilniUredjaj(string naziv, string proiz, string jib, Korisnik k,StanjeUredjaja st, TipUredjaja tip,string marka, string cijena):base(naziv,proiz,jib,k,st,tip)
        {
            Marka = marka;
            Cijena = cijena;
        }
        public override string ToString()
        {
            return Naziv+"-"+Proizvodjac+"-"+tip+"-"+stanje;
        }
    }
}
