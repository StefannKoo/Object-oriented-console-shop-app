using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPrakticna
{
    class Inicijalizacija1264
    {
       public static List<Uredjaj> lista;
       static Uredjaj ur1 = new MobilniUredjaj("S10", "Samsung", "12345", korisnik,StanjeUredjaja.Ok,TipUredjaja.MOBILNI_UREDJAJ, "Korejska", "900");
       static Uredjaj ur2 = new Tablet("Tablet", "Apple", "123444", korisnik,StanjeUredjaja.POKVAREN,TipUredjaja.TABLET, "6", "Dobar");
       static Uredjaj ur3 = new Racunar("Desktop", "Srbija", "11111", korisnik,StanjeUredjaja.Ok,TipUredjaja.Racunar, "Intel", "NVidia 180Tx");
     
       static Uredjaj ur4 = new MobilniUredjaj("S20", "Samsung", "143435", korisnik,StanjeUredjaja.Ok,TipUredjaja.MOBILNI_UREDJAJ, "Korejska", "1020");
       static Uredjaj ur5 = new Tablet("Tablett", "IOs", "1234sa44", korisnik,StanjeUredjaja.Ok,TipUredjaja.TABLET, "8", "Vrh");
       static Uredjaj ur6 = new Racunar("Laptop", "Srbija", "111s11", korisnik,StanjeUredjaja.POKVAREN,TipUredjaja.Racunar, "AMD", "NVidia 2080TI");

       static Uredjaj ur7 = new MobilniUredjaj("Redmi Note 8T", "Xiaomi", "1234s5", korisnik, StanjeUredjaja.POKVAREN, TipUredjaja.MOBILNI_UREDJAJ, "Kineski", "330");
       static Uredjaj ur8 = new Tablet("Tablet", "Huawei", "12ds3444", korisnik, StanjeUredjaja.Ok, TipUredjaja.TABLET, "7.2", "Dobar");
       static Uredjaj ur9 = new Racunar("Desktop", "K-Inel", "1s1111", korisnik, StanjeUredjaja.POKVAREN, TipUredjaja.Racunar, "Lenovo", "NVidia 180Tx");
       static Serviser serviser = new Serviser();
       static ProdavnicUredjaja prodavnica;
       static Korisnik korisnik;
        public static void Meni()
        {
            Popuni();
            korisnik = new Korisnik("Marko", "Markovic", "09091992", "Sokolac", null);
            serviser.lista = new List<Uredjaj>();
            korisnik.uredjaji = new List<Uredjaj>();
            prodavnica = new ProdavnicUredjaja("Sve i svasta", "Istocno Sarajevo", "1234567", "Prodaja raznih uredjaja i opreme", true, lista);
    
            bool izlaz = false;
            while (!izlaz)
            {
                Console.WriteLine("Izaberite ocpiju\n");
                Console.WriteLine("[1]-Kupi uredjaj\n");
                Console.WriteLine("[2]-Predaj serviseru\n");
                Console.WriteLine("[3]-Uredjaji koji se nalaze kod servisera\n");
                Console.WriteLine("[0]-Izlaz\n");
                Console.WriteLine("\nKorisnik posjeduje sljedece uredjaje:\n");
             //   Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (korisnik.uredjaji.Count != 0)
                {
                    foreach (Uredjaj ure in korisnik.uredjaji)
                    {
                        Console.WriteLine(ure.Naziv + " " + ure.Proizvodjac+" Tip "+ure.tip+" Status "+ure.stanje);
                    }
                }
                else
                {
                    Console.WriteLine("0 uredjaja");
                }
                string opcija = Console.ReadLine();
                switch (opcija)
                {
                    case "1":
                        korisnik.KupiUredjaj(prodavnica, TipUredjaja.MOBILNI_UREDJAJ);
                        break;
                    case "2":
                        korisnik.PredajServiseru(serviser);
                        //Console.WriteLine("\nPokvareni uredjaji su\n");
         
                        //int i = 0;
                        //foreach (Uredjaj uredjaj in korisnik.uredjaji)
                        //{
                        //    i++;
                        //    if (uredjaj.stanje == StanjeUredjaja.POKVAREN)
                        //    { 
                        //        Console.WriteLine("["+i+"]"+uredjaj.Naziv + " " + uredjaj.Proizvodjac + " " + uredjaj.stanje);   
                        //    }
                        //}
                        //Console.WriteLine("Izaberite koji uredjaj zelite da proslijedite serviseru na popravku..");
                        //int opc = int.Parse(Console.ReadLine());
                        //if (opc > 0 && opc <= korisnik.uredjaji.Count)
                        //{
                        //    Uredjaj uredj = korisnik.uredjaji[opc - 1];
                        //    korisnik.uredjaji.RemoveAt(opc - 1);
                        //    serviser.Servis(uredj);
                        //}
                        break;
                    case "3":
                        Console.WriteLine("\nUredjaji koji se nalaze kod servisera su\n");
                        if (serviser.lista.Count != 0)
                        {
                            int j = 1;
                            foreach (Uredjaj ur in serviser.lista)
                            {
                                Console.WriteLine("\n[" + j + "]" + ur.Naziv + "-" + ur.Proizvodjac + "-" + ur.tip + "-" + ur.stanje);
                                j++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Kod servisera se ne nalazi ni jedan uredjaj.");
                        }
                        break;
                    case "0":
                        izlaz = true;
                        break;
                }
            }
        }
        static void Popuni()
        {
            lista = new List<Uredjaj>();

            lista.Add(ur1);
            lista.Add(ur2);
            lista.Add(ur3);
            lista.Add(ur4);
            lista.Add(ur5);
            lista.Add(ur6);
            lista.Add(ur7);
            lista.Add(ur8);
            lista.Add(ur9);
        }
    }
}
