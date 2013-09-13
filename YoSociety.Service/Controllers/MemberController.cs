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
    public class MemberController : ApiController
    {
        MemberApi societyApi = new MemberApi(new MemberRepository());

        // GET api/member/id
        public List<SocietyMember> GetAll(string id)
        {
            var societies = societyApi.GetSocieties(Int32.Parse(id));
            if (societies == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return societies;
        }
        
        // POST api/member
        public HttpResponseMessage Post(SocietyMember society)
        {            
            return Request.CreateResponse<SocietyMember>(HttpStatusCode.Created, societyApi.AddSociety(society));
        }        
    }
}
