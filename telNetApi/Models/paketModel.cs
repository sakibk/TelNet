using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNetApi.Models
{
    public class paketModel
    {
        public paketModel()
        {
            this.paketiUsluga = new List<paketUslugeModel>();
            this.narudzbeUsluga = new List<narudzbeUslugaModel>();
        }
        public int paketID { get; set; }
        public string nazivPaketa { get; set; }
        public float cijenaPaketa { get; set; }
        public string opis { get; set; }

        public int katalogID { get; set; }
        public string nazivKataloga { get; set; }
        public string opisKataloga { get; set; }

        public List<paketUslugeModel> paketiUsluga { get; set; }
        public List<narudzbeUslugaModel> narudzbeUsluga { get; set; }
    }
}