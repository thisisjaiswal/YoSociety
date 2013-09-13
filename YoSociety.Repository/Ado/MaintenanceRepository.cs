using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using YoSociety.Entities;


namespace YoSociety.Repository.Ado
{
    public class MaintenanceRepository : BaseRepository, IMaintenaceRepository
    {
        public MaintenanceBill GetBill(int societyId, int memberId, string month)
        {
            return new MaintenanceBill
            {
                SocietyName = "NG Shelter",
                RegistrationNo = "TNA (TNA) ABSBS 1234",
                RegistrationDate = new Date(2011, 9, 1),
                Address = "Beverly Park, Near Cinemax, Miraroad, Thane - 401107",
                MemberName = "Sandeep Jaiswal",
                FlatNo = 204,
                BillMonth = "201308",
                DueDate = new Date(2013, 08, 10),
                InterestRate = 18,
                TotalAmount = 1350,
                Particulars = new List<MaintenanceBill.Particular>
                {
                    new MaintenanceBill.Particular{ Title = "Maintenace", Amount = 1000},
                    new MaintenanceBill.Particular{ Title = "Seed Fund", Amount = 200},
                    new MaintenanceBill.Particular{ Title = "Sinking Fund", Amount = 100},
                    new MaintenanceBill.Particular{ Title = "Parking", Amount = 50},
                }
            };
        }
    }
}
