using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNet.Models
{
    public class paket
    {
        public paket()
        {
            this.paketiUsluga = new HashSet<paketUsluge>();
            this.narudzbeUsluga = new HashSet<narudzbeUsluga>();
        }

        public int paketID { get; set; }
        public string nazivPaketa { get; set; }
        public float cijenaPaketa { get; set; }
        public string opis { get; set; }

        public int katalogID { get; set; }

        public virtual katalog katalog { get; set; }

        public ICollection<paketUsluge> paketiUsluga { get; set; }
        public ICollection<narudzbeUsluga> narudzbeUsluga { get; set; }
    }
}