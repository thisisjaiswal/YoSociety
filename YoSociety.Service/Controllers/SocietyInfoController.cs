using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YoSociety.Business;
using YoSociety.Entities;

namespace YoSociety.Service.Controllers
{
    public class SocietyInfoController : ApiController
    {
        BusinessApi _businessApi = new BusinessApi();

        // GET api/societyinfo
        public IEnumerable<SocietyInfo> Get()
        {
            return null;
        }

        // GET api/societyinfo/5
        public SocietyInfo Get(string id)
        {
            var r =  _businessApi.GetSocietyInfo(id);
            r.Years = new string[] { "2013","2012" };
            return r;
        }
    }
}
