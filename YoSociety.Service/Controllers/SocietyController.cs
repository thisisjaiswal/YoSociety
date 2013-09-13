using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AttributeRouting.Web.Http;
using YoSociety.Business;
using YoSociety.Entities;
using YoSociety.Repository.Ado; 

namespace YoSociety.Service.Controllers
{
    public class SocietyController : ApiController
    {
        SocietyApi societyApi = new SocietyApi(new SocietyRepository());

        // GET api/society/regNo        
        public Society GetByRegistrationNo(string id)
        {
            var society = societyApi.GetByRegistrationNo(id);
            if (society == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return society;
        }

        //// GET api/society/id
        //public Society GetById(string id)
        //{
        //    var society = societyApi.GetById(id);
        //    if (society == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }
        //    return society;
        //}

        // POST api/society/
        public HttpResponseMessage Post(Society society)
        {
            return Request.CreateResponse<Society>(HttpStatusCode.Created, societyApi.Add(society));            
        }

        // PUT api/society/id
        public void Put(int id, Society society)
        {
            society.SocietyId = id;
            if (!societyApi.Update(society))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        // DELETE api/society/id
        public void Delete(string id)
        {
            Society society = societyApi.GetById(id);
            if (society == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            societyApi.Remove(id);
        }
    }
}
