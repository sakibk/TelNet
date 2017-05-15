using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNetApi.Models
{
    public class statusPonudeModel
    {
        public statusPonudeModel()
        {
            this.ponude = new List<ponudaModel>();
            this.narudzbeUsluga = new List<narudzbeUslugaModel>();
        }
        public int statusPonudeID { get; set; }
        public string nazivStatusa { get; set; }
        public DateTime datumStatusa { get; set; }

        public int uposlenikID { get; set; }
        public string imeUposlenika { get; set; }
        public string prezimeUposlenika { get; set; }

        public List<ponudaModel> ponude { get; set; }
        public List<narudzbeUslugaModel> narudzbeUsluga { get; set; }
    }
}