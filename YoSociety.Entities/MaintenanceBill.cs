using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoSociety.Entities
{
    public class MaintenanceBill
    {
        public string SocietyName { get; set; }
        public string RegistrationNo { get; set; }
        public Date RegistrationDate { get; set; }
        public string Address { get; set; }

        public string MemberName { get; set; }
        public int FlatNo { get; set; }
        public string BillMonth { get; set; }
        public Date DueDate { get; set; }

        public short InterestRate { get; set; }

        public float TotalAmount { get; set; }

        public List<Particular> Particulars { get; set; }

        public class Particular
        {
            public string Title { get; set; }
            public float Amount { get; set; }
            public string Remarks { get; set; }
        }
    }
}
