using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YoSociety.Business;
using YoSociety.Entities;
using YoSociety.Repository.Ado; 

namespace YoSociety.Service.Controllers
{
    public class AccountController : ApiController
    {
        AccountApi accountApi = new AccountApi(new AccountRepository());

        // GET api/account/
        public IEnumerable<UserAccount> GetAll()
        {
            return accountApi.GetAll();
        }

        // GET api/account/id
        public UserAccount GetById(string id)
        {
            var account = accountApi.Get(id);
            if (account == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return account;
        }

        // POST api/account/id
        [HttpPost]
        public UserAccount Verify(string id, string password)
        {
            var account = accountApi.Get(id);
            if (account == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return account;
        }

        // POST api/account/
        public HttpResponseMessage Post(UserAccount account)
        {            
            return Request.CreateResponse<UserAccount>(HttpStatusCode.Created, accountApi.Add(account));            
        }

        // PUT api/account/id
        public void Put(string id, UserAccount account)
        {
            account.UserId = id;
            if (!accountApi.Update(account))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        // DELETE api/account/id
        public void Delete(string id)
        {
            UserAccount account = accountApi.Get(id);
            if (account == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            accountApi.Remove(id);
        }
    }
}
