using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoSociety.Entities;
using YoSociety.Repository;

namespace YoSociety.Repository
{
    public class EdmxRepository //: IRepository
    {
        YoSocietyContext _context;

        public EdmxRepository()
        {
            _context = new YoSocietyContext();
        }

        public Maintenance GetMaintenanceInfo(string societyId, string flatNo, string month)
        {
            return _context.GetMaintenanceInfo(societyId, flatNo, month);
        }
    }
}
