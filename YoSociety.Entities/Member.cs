using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoSociety.Entities
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short Age  { get; set; }
        public string Sex { get; set; }
    }
}
