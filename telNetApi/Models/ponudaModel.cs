using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNetApi.Models
{
    public class ponudaModel
    {
        public ponudaModel()
        {
            this.ponudeProizvoda = new List<ponudaProizvodaModel>();
        }
        public int ponudaID { get; set; }
        public int ponudaProizvoda { get; set; }
        public float ukupnaCijena { get; set; }
        public DateTime datumIsporuke { get; set; }

        public int statusPonudeID { get; set; }
        public string nazivStatusa { get; set; }
        public DateTime datumStatusa { get; set; }
        public int uposlenikID { get; set; }
        public string imeUposlenika { get; set; }
        public string prezimeUposlenika { get; set; }
        public int dobavljacID { get; set; }
        public string imeDobavljaca { get; set; }
        public string adresaDobavljaca { get; set; }
        public int ratingID { get; set; }
        public float rate { get; set; }

        public List<ponudaProizvodaModel> ponudeProizvoda { get; set; }
    }
}