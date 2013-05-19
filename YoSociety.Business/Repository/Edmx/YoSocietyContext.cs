using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using YoSociety.Entities;

namespace YoSociety.Repository
{
    public class YoSocietyContext : DbContext
    {
        public YoSocietyContext()
            : base("name=DefaultConnection")
        {

        }

        public Maintenance GetMaintenanceInfo(string societyId, string flatNo, string month)
        {
            return null;// this.Database.ExecuteSqlCommand("", null);
        }

    }
}
