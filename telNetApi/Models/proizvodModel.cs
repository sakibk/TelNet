using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNetApi.Models
{
    public class proizvodModel
    {
        public proizvodModel()
        {
            this.ponudeProizvoda = new List<ponudaProizvodaModel>();
        }
        public int proizvodID { get; set; }
        public int kvalitetaProizvoda { get; set; }
        public float cijenaProizvoda { get; set; }
        public string opisProizvoda { get; set; }

        public int tipProizvodaID { get; set; }
        public string nazivTipa { get; set; }
        public string proizvodjac { get; set; }

        public List<ponudaProizvodaModel> ponudeProizvoda { get; set; }
    }
}