using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNetApi.Models
{
    public class dobavljacModel
    {
        public dobavljacModel()
        {
            this.ponude = new List<ponudaModel>();
        }
        public int dobavljacID { get; set; }
        public string naziv { get; set; }
        public string adresa { get; set; }
        public int ratingID { get; set; }
        public float dobavljacRate { get; set; }
        public string dobavljacOverview { get; set; }
        public DateTime datumRatinga { get; set; }
        public DateTime datumIstekaRatinga { get; set; }
        public List<ponudaModel> ponude { get; set; }
    }
}