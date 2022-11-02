using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPrakticna
{
    public class ProdavnicUredjaja
    {
        public string Naziv { get; set; }
        public string Sjediste{ get; set; }
        public string JIB { get; set; }
        public string OpisDjelatnosti { get; set; }
        public bool Poreski_Obveznik { get; set; }
        public List<Uredjaj> lista { get; set; }

        public ProdavnicUredjaja(string naziv, string sjediste,string jib,string opis, bool poreski,List<Uredjaj> list)
        {
            lista = new List<Uredjaj>();
            Naziv = naziv;
            Sjediste = sjediste;
            JIB = jib;
            OpisDjelatnosti = opis;
            Poreski_Obveznik = poreski;
            lista = list;
        }
    }
}
