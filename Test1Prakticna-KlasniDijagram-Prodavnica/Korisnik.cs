using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPrakticna
{
    public interface IKorisnik
    {
         void KupiUredjaj(ProdavnicUredjaja prodavnica, TipUredjaja tip);
         void PredajServiseru( Serviser serviser);
    }
   public  class Korisnik:IKorisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Datum_Rodjenja { get; set; }
        public string Mjesto_Prebivalista { get; set; }
        public List<Uredjaj> uredjaji { get; set; } 
        public Korisnik(string ime,string prezime,string datum,string mjesto, List<Uredjaj> ured)
        {
            //uredjaji = new List<Uredjaj>();
            Ime = ime;
            Prezime = prezime;
            Datum_Rodjenja = datum;
            Mjesto_Prebivalista = mjesto;
            uredjaji = ured;
        }
        public void KupiUredjaj(ProdavnicUredjaja prodavnica, TipUredjaja tip)
        {
            Console.WriteLine("Dostupni uredjaji su:");
            int i = 1;
            foreach (Uredjaj ure in prodavnica.lista)
            {
                Console.WriteLine("["+i+"] "+ure.Naziv + " - " + ure.Proizvodjac+" ");
                i++;
            }
          
            Console.WriteLine("\nKoji uredjaj zelite da kupite?");
            int opcija = int.Parse(Console.ReadLine());
            if (opcija > 0 && opcija <= prodavnica.lista.Count)
            {
                uredjaji.Add(prodavnica.lista[opcija-1]);
                prodavnica.lista.RemoveAt(opcija-1);
            }
        }
        public void PredajServiseru(Serviser serviser)
        {
            Console.WriteLine("\nPokvareni uredjaji su - >\n");
            int i = 0;
            foreach (Uredjaj ur in uredjaji)
            {
                i++;
                if (ur.stanje == StanjeUredjaja.POKVAREN)
                {
                    Console.WriteLine("["+i+"]"+ur.Naziv + "-" + ur.Proizvodjac + "-" + ur.tip + "-" + ur.stanje);
                }
            }
            Console.WriteLine("\nIzaberite koji uredjaj zelite da proslijedite serviseru.");
            int opc = int.Parse(Console.ReadLine());
            if (opc > 0 && opc <= i)
            {
                Uredjaj ure = uredjaji[opc - 1];
                uredjaji.RemoveAt(opc - 1);
                serviser.Servis(ure);
            }

        }
    
    }
}
