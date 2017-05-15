using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNetApi.Models
{
    public class narudzbeUslugaModel
    {
        public int narudzbeUslugaID { get; set; }
        public DateTime periodUsluge { get; set; }
        public DateTime datumPocetkaUsluge { get; set; }
        public int odobreno { get; set; }
        public DateTime datumOdobrenja { get; set; }

        public int kupacID { get; set; }
        public string adresaKupca { get; set; }
        public string imeKupca { get; set; }
        public string prezimeKupca { get; set; }
        public string telefonKupca { get; set; }


        public int statusUslugeID { get; set; }
        public string nazivStatusa { get; set; }
        public int uposlenikID { get; set; }
        public string imeUposlenika { get; set; }
        public string prezimeUposlenika { get; set; }

        public int UslugaID { get; set; }
        public string nazivUsluge { get; set; }
        public string tipUsluge { get; set; }
        public float cijenaUsluge { get; set; }
        public string opisUsluge { get; set; }

        public int paketID { get; set; }
        public string nazivPaketa { get; set; }
        public float cijenaPaketa { get; set; }
        public string opisPaketa { get; set; }
    }
}