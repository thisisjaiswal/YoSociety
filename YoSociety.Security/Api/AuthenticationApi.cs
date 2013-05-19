using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoSociety.Authentication
{
    public class AuthenticationApi
    {
        IAuthenticationRepository _repository;

        public AuthenticationApi(IAuthenticationRepository repository)
        {
            _repository = repository;
        }

        public bool Login(string mobileNo, string password)
        {
            return _repository.Login(mobileNo, password);
        }

        public bool Logout(LogoutRequest request)
        {
            return true;
        }

        public void Register(RegisterRequest request)
        {

        }

        public void Deregister(DeRegisterRequest request)
        {

        }

        public void ResetPassword()
        {
        }

        public void RetrivePassword()
        {
        }

        public void ChangePassword()
        {

        }
    }
}
