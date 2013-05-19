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
    public class MaintenanceController : ApiController
    {
        BusinessApi businessApi = new BusinessApi();

        // GET api/maintenance?societyid=&flato=&month=
        public Maintenance Get(string societyId, int flatNo, string month)
        {
            return businessApi.GetMaintenance();
        }
    }
}
