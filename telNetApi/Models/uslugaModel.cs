using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNetApi.Models
{
    public class uslugaModel
    {
        public uslugaModel()
        {
            this.paketiUsluga = new List<paketUslugeModel>();
        }
        public int uslugaID { get; set; }
        public string nazivUsluge { get; set; }
        public string tipUsluge { get; set; }
        public float cijenaUsluge { get; set; }
        public string opis { get; set; }

        public int katalogID { get; set; }

        public List<paketUslugeModel> paketiUsluga { get; set; }
        public List<narudzbeUslugaModel> narudzbeUsluga { get; set; }
    }
}