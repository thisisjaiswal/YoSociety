using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoSociety.Entities;
using YoSociety.Repository;

namespace YoSociety.Business
{
    public class MaintenanceApi
    {
        IMaintenaceRepository _repository;

        public MaintenanceApi(IMaintenaceRepository repository)
        {
            _repository = repository;
        }

        public MaintenanceBill GetBill(int societyId, int memberId, string month)
        {
            return _repository.GetBill(societyId, memberId, month);
        }
    }
}
