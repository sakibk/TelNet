using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNetApi.Models
{
    public class tipProizvodaModel
    {
        public tipProizvodaModel()
        {
            this.proizvodi = new List<proizvodModel>();
        }
        public int tipProizvodaID { get; set; }
        public string nazivTipa { get; set; }
        public string proizvodjac { get; set; }

        public List<proizvodModel> proizvodi { get; set; }
    }
}