using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoSociety.Authentication
{
    public class AuthenticationEdmxRepository : IAuthenticationRepository
    {
        public bool Login(string mobileNo, string password)
        {
            return true;
        }

        public bool Logout(LogoutRequest request)
        {
            throw new NotImplementedException();
        }

        public void Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }

        public void ResetPassword()
        {
            throw new NotImplementedException();
        }

        public void RetrivePassword()
        {
            throw new NotImplementedException();
        }

        public void ChangePassword()
        {
            throw new NotImplementedException();
        }
    }
}
