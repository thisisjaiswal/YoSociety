using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoSociety.Entities;

namespace YoSociety.Repository
{
    public class BusinessMockRepository : IBusinessRepository
    {
        public SocietyInfo GetSocietyInfo(string societyId)
        {
            return new SocietyInfo { RegistrationDate = new Date(2010, 09, 01) };
        }

        public List<MaintenanceInfo> GetMaintenanceList(string societyId, int flatNo)
        {
            return new List<MaintenanceInfo>
            {
                new MaintenanceInfo { BillNo = 201304204, BillFor = "201304", Amount = 1250, DueDate = new DateTime(2013, 04, 10), PaymetStatus = "Pending" },
                new MaintenanceInfo {BillNo = 201304204, BillFor = "201303", Amount = 1250, DueDate = new DateTime(2013, 03, 10), PaymetStatus = "Paid"},
                new MaintenanceInfo {BillNo = 201304204, BillFor = "201302", Amount = 1250, DueDate = new DateTime(2013, 02, 10), PaymetStatus = "Paid"},
                new MaintenanceInfo {BillNo = 201304204, BillFor = "201301", Amount = 1250, DueDate = new DateTime(2013, 01, 10), PaymetStatus = "Paid"},
                new MaintenanceInfo {BillNo = 201304204, BillFor = "201212", Amount = 1250, DueDate = new DateTime(2012, 12, 10), PaymetStatus = "Paid"},
                new MaintenanceInfo {BillNo = 201304204, BillFor = "201211", Amount = 1250, DueDate = new DateTime(2012, 11, 10), PaymetStatus = "Paid"},
                new MaintenanceInfo {BillNo = 201304204, BillFor = "201210", Amount = 1250, DueDate = new DateTime(2012, 10, 10), PaymetStatus = "Paid"},
                new MaintenanceInfo {BillNo = 201304204, BillFor = "201209", Amount = 1250, DueDate = new DateTime(2012, 09, 10), PaymetStatus = "Paid"},
                new MaintenanceInfo {BillNo = 201304204, BillFor = "201208", Amount = 1250, DueDate = new DateTime(2012, 08, 10), PaymetStatus = "Paid"},
            };
        }

        public Maintenance GetMaintenance(string societyId, int flatNo, string month)
        {
            return new Maintenance { BillNo = Int32.Parse(month), BillFor = month, Amount = 1250, DueDate = new DateTime(2013, 04, 10), PaymetStatus = "Pending" };
        }
    }
}
