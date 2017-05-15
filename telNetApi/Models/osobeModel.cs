using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNetApi.Models
{
    public class osobeModel
    {
        public osobeModel()
        {
            this.statusPonuda = new List<statusPonudeModel>();
            this.narudzbeUsluga = new List<narudzbeUslugaModel>();
            
        }
        public int osobeID { get; set; }
        public string adresa { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string telefon { get; set; }

        public int tipID { get; set; }
        public string nazivTipa { get; set; }


        public List<statusPonudeModel> statusPonuda { get; set; }
        public List<narudzbeUslugaModel> narudzbeUsluga { get; set; }
    }
}