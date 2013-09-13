using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoSociety.Entities;

namespace YoSociety.Repository
{
    public interface IMaintenaceRepository 
    {        
        MaintenanceBill GetBill(int societyId, int memberId, string month);        
    }
}
