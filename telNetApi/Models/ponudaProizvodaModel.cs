using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNetApi.Models
{
    public class ponudaProizvodaModel
    {
        public int ponudaProizvodaID { get; set; }
        public int proizvodID { get; set; }
        public int kvalitetaProizvoda { get; set; }
        public float cijenaProizvoda { get; set; }
        public string opisProizvoda { get; set; }
        public int tipProizvodaID { get; set; }
        public int ponudaID { get; set; }
        public int ponudaProizvoda { get; set; }
        public float ukupnaCijena { get; set; }
        public DateTime datumIsporuke { get; set; }
        public int statusPonudeID { get; set; }
        public int dobavljacID { get; set; }
        public string opis { get; set; }
    }
}