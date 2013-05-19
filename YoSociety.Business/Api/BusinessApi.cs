using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoSociety.Entities;
using YoSociety.Repository;

namespace YoSociety.Business
{
    public class BusinessApi
    {
        IBusinessRepository _repository;

        public  BusinessApi(IBusinessRepository repository)
        {
            _repository = repository;
        }
         
        public SocietyInfo GetSocietyInfo(string societyId)
        {
            return _repository.GetSocietyInfo(societyId);
        }

        public List<MaintenanceInfo> GetMaintenanceList(string societyId,int flatNo)
        {
            return _repository.GetMaintenanceList(societyId, flatNo);
        }

        public Maintenance GetMaintenance(string societyId, int flatNo,string month)
        {
            return _repository.GetMaintenance(societyId, flatNo, month);
        }
    }
}
