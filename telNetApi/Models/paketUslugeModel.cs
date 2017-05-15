using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNetApi.Models
{
    public class paketUslugeModel
    {
        public int paketUslugeID { get; set; }
        public int paketID { get; set; }
        public string nazivPaketa { get; set; }
        public float cijenaPaketa { get; set; }
        public string opisPaketa { get; set; }
        public int uslugaID { get; set; }
        public string nazivUsluge { get; set; }
        public string tipUsluge { get; set; }
        public float cijenaUsluge { get; set; }
        public string opisUsluge { get; set; }
        public string opisPaketaUsluge { get; set; }

    }
}