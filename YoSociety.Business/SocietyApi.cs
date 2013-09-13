using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoSociety.Entities;
using YoSociety.Repository;

namespace YoSociety.Business
{
    public class SocietyApi
    {
        ISocietyRepository _repository;

        public SocietyApi(ISocietyRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Society> GetAll()
        {
            return _repository.GetAll();
        }

        public Society GetById(string id)
        {
            return _repository.Get(id);
        }

        public Society GetByRegistrationNo(string regNo)
        {
            var result = _repository.Search(regNo);
            if (result == null)
                return null;
            return result.FirstOrDefault();
        }
        
        public Society Add(Society account)
        {
            return _repository.Add(account);
        }

        public bool Update(Society account)
        {
            return _repository.Update(account);
        }

        public void Remove(string id)
        {
            _repository.Remove(id);
        }
    }
}
