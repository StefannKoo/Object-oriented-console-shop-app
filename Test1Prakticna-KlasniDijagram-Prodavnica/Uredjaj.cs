using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPrakticna
{
    public enum StanjeUredjaja
    {
        Ok,POKVAREN
    }
    public enum TipUredjaja
    {
        MOBILNI_UREDJAJ,TABLET,Racunar
    }
    public abstract class Uredjaj
    {
        public string Naziv { get; set; }
        public string Proizvodjac{ get; set; }
        public string Jib { get; set; }
        public StanjeUredjaja stanje { get; set; }
        public TipUredjaja tip { get; set; }
        public Korisnik korisnik { get; set; }
        public Uredjaj(string naziv, string proiz, string jib, Korisnik k, StanjeUredjaja st, TipUredjaja tip)
        {
            Naziv = naziv;
            Proizvodjac = proiz;
            Jib = jib;
            korisnik = k;
            stanje = st;
            this.tip = tip;
        }
    }
}
