using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoSociety.Entities;
using YoSociety.Repository;

namespace YoSociety.Business
{
    public class MemberApi
    {
        IMemberRepository _repository;

        public MemberApi(IMemberRepository repository)
        {
            _repository = repository;
        }
        
        public List<SocietyMember> GetSocieties(int memberId)
        {
            return _repository.GetSocieties(memberId);
        }

        public SocietyMember AddSociety(SocietyMember society)
        {
            return _repository.AddSociety(society);
        }
    }
}
