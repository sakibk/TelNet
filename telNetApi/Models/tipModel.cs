using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNetApi.Models
{
    public class tipModel
    {
        public tipModel()
        {
            this.Osobe = new List<osobeModel>();
        }
        public int tipID { get; set; }
        public string nazivTipa { get; set; }

        public List<osobeModel> Osobe { get; set; }
    }
}