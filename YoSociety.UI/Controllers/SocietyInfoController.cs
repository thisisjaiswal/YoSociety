using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YoSociety.Business;
using YoSociety.Entities;
using YoSociety.Repository;

namespace YoSociety.Service.Controllers
{
    public class SocietyInfoController : ApiController
    {
        BusinessApi _businessApi = new BusinessApi(new BusinessMockRepository());

        // GET api/societyinfo
        public IEnumerable<SocietyInfo> Get()
        {
            return null;
        }

        // GET api/societyinfo/123
        public SocietyInfo Get(string id)
        {
            return _businessApi.GetSocietyInfo(id);
        }
    }
}
