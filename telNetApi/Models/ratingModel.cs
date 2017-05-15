using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNetApi.Models
{
    public class ratingModel
    {
        public ratingModel()
        {
            this.dobavljaci = new List<dobavljacModel>();
        }
        public int ratingID { get; set; }
        public float rate { get; set; }
        public string overview { get; set; }
        public DateTime datumRatinga { get; set; }
        public DateTime datumIstekaRatinga { get; set; }

        public List<dobavljacModel> dobavljaci { get; set; }
    }
}