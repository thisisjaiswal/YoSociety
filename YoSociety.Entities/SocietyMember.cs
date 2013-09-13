using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoSociety.Entities
{
    public class SocietyMember
    {        
        public int SocietyId { get; set; }
        public string SocietyName { get; set; }
        public int MemberId { get; set; }        
        public short FlatNo { get; set; }
        public short MemberType { get; set; }
    }    
}
