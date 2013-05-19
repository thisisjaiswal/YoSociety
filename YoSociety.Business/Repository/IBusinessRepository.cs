using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoSociety.Entities;

namespace YoSociety.Repository
{
    public interface IBusinessRepository
    {
        SocietyInfo GetSocietyInfo(string societyId);

        List<MaintenanceInfo> GetMaintenanceList(string societyId, int flatNo);

        Maintenance GetMaintenance(string societyId, int flatNo, string month);
    }
}
