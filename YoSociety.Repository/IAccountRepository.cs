using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoSociety.Entities;

namespace YoSociety.Repository
{
    public interface IAccountRepository : IRepository<UserAccount>
    {
        bool Verify(string id, string password);
    }
}
