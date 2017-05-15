using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNetApi.Models
{
    public class katalogModel
    {
        public katalogModel()
        {
            this.usluge = new List<uslugaModel>();
            this.paketi = new List<paketModel>();
        }
        public int katalogID { get; set; }
        public string nazivKataloga { get; set; }
        public string opis { get; set; }

        public List<uslugaModel> usluge { get; set; }
        public List<paketModel> paketi { get; set; }
    }
}