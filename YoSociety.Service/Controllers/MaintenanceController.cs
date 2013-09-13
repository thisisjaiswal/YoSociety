using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YoSociety.Business;
using YoSociety.Entities;
using YoSociety.Repository.Ado; 

namespace YoSociety.Service.Controllers
{
    public class MaintenanceController : ApiController
    {
        MaintenanceApi maintenanceApi = new MaintenanceApi(new MaintenanceRepository());

        // GET api/maintenance/
        public MaintenanceBill GetBill(int id, int memberId, string month)
        {
            return maintenanceApi.GetBill(id, memberId, month);
        }
    }
}
