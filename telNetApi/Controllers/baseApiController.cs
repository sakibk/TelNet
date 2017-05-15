using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using telNet;

namespace telNetApi.Controllers
{
    public class baseApiController<T> : ApiController
    {
        private baseInterface<T> depo;
        private Models.Factory fact;

        public baseApiController(baseInterface<T> _depo)
        {
            depo = _depo;
        }

        protected baseInterface<T> tnDepo
        {
            get { return depo; }
        }

        protected Models.Factory tnFact
        {
            get
            {
                if (fact == null)
                {
                    fact = new Models.Factory();
                }
                return fact;
            }
        }
    }
}
