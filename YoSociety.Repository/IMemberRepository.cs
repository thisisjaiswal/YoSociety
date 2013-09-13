using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoSociety.Entities;

namespace YoSociety.Repository
{
    public interface IMemberRepository : IRepository<SocietyMember>
    {
        List<SocietyMember> GetSocieties(int memberId);
        SocietyMember AddSociety(SocietyMember society);
    }
}
