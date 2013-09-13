using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoSociety.Entities;
using YoSociety.Repository;

namespace YoSociety.Business
{
    public class AccountApi
    {
        IRepository<UserAccount> _repository;        

        public AccountApi(IRepository<UserAccount> repository)
        {
            _repository = repository;
        }

        public IEnumerable<UserAccount> GetAll()
        {
            return _repository.GetAll();
        }

        public UserAccount Get(string id)
        {
            return _repository.Get(id);
        }

        public UserAccount Verify(string id, string password)
        {            
            var user = _repository.Get(id);
            if (user == null)
                return null;
            if (user.Password == password)
                return user;
            return null;
        }

        public UserAccount Add(UserAccount account)
        {
            return _repository.Add(account);
        }

        public bool Update(UserAccount account)
        {
            return _repository.Update(account);
        }

        public void Remove(string id)
        {
            _repository.Remove(id);
        }
    }
}
