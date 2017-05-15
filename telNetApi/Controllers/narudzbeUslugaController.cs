﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using telNet;
using telNet.Models;
using telNetApi.Models;

namespace telNetApi.Controllers
{
    public class narudzbeUslugaController : baseApiController<narudzbeUsluga>
    {
        public narudzbeUslugaController(baseInterface<telNet.Models.narudzbeUsluga> depo) : base(depo){ }

        public IHttpActionResult Get()
        {
            try
            {
                return Ok(tnDepo.Get().ToList().Select(x => Factory.Create(x)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public HttpResponseMessage Get(int id)
        {
            try
            {

                var entity = tnDepo.get(id);
                if (entity != null)
                    return Request.CreateResponse(HttpStatusCode.OK, Factory.Create(entity));
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage Post(narudzbeUslugaModel dm)
        {
            try
            {
                var entity = tnFact.Parse(dm);
                if (entity == null)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "No data");
                tnDepo.Insert(entity);
                tnDepo.Commit();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        //[DisableCors]
        //public HttpResponseMessage Put(int id, CityModel city)
        //{
        //    try
        //    {
        //        var newCity = SDRFact.Parse(city);
        //        if (newCity == null)
        //            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "No data");
        //        var oldCity = SDRDepo.get(id);
        //        newCity.CityId = oldCity.CityId;
        //        SDRDepo.Update(oldCity, newCity);
        //        SDRDepo.Commit();
        //        return Request.CreateResponse(HttpStatusCode.OK);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
        //    }
        //}

        //[DisableCors]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                narudzbeUsluga entity = tnDepo.get(id);
                if (entity == null)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "No data");
                tnDepo.Delete(entity);
                tnDepo.Commit();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
