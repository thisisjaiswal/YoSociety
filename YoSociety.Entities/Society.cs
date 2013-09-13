using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoSociety.Entities
{
    public class Society
    {
        public int SocietyId { get; set; }
        public string SocietyName { get; set; }
        public string RegistrationNo { get; set; }
        public Date RegistrationDate { get; set; }
        public string  Address { get; set; }
    }
}
