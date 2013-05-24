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
    public class MaintenanceController : ApiController
    {
        BusinessApi businessApi = new BusinessApi(new BusinessMockRepository());

        // GET api/maintenance/
        public List<MaintenanceInfo> GetList(string societyId)
        {
            societyId = "123:204";
            int flatNo = Int32.Parse(societyId.Split(':')[1]);
            return businessApi.GetMaintenanceList(societyId.Split(':')[0], flatNo);
        }

        // GET api/maintenance/month
        public Maintenance GetDetail(string id, string societyId)
        {
            societyId = "123:204";
            int flatNo = Int32.Parse(societyId.Split(':')[1]);
            return businessApi.GetMaintenance(societyId.Split(':')[0], flatNo, id);
        }
    }
}
