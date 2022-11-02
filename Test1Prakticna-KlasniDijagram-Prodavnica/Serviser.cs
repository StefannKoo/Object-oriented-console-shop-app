using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPrakticna
{
    public interface IServiser
    {
        void Servis(Uredjaj uredjaj);
        void ObavjestiKorisnika(Uredjaj uredjaj);
    }
    public class Serviser: IServiser
    {
        public List<Uredjaj> lista { get; set; }
        public void Servis(Uredjaj uredjaj)
        {           
                lista.Add(uredjaj);
        }
        public void ObavjestiKorisnika(Uredjaj uredjaj)
        {
          
        }
    }
}
