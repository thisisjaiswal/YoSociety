using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoSociety.Entities;
using YoSociety.Repository;

namespace YoSociety.Repository
{
    public class BusinessEdmxRepository : IBusinessRepository
    {
        YoSocietyContext _context;

        public BusinessEdmxRepository()
        {
            _context = new YoSocietyContext();
        }

        public Maintenance GetMaintenanceInfo(string societyId, string flatNo, string month)
        {
            return _context.GetMaintenanceInfo(societyId, flatNo, month);
        }

        public SocietyInfo GetSocietyInfo(string societyId)
        {
            throw new NotImplementedException();
        }

        public List<MaintenanceInfo> GetMaintenanceList(string societyId, int flatNo)
        {
            throw new NotImplementedException();
        }

        public Maintenance GetMaintenance(string societyId, int flatNo, string month)
        {
            throw new NotImplementedException();
        }
    }
}
