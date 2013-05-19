using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoSociety.Authentication
{
    public interface IAuthenticationRepository
    {
        bool Login(string mobileNo, string password);
        bool Logout(LogoutRequest request);
        void Register(RegisterRequest request);
        void ResetPassword();
        void RetrivePassword();
        void ChangePassword();
    }
}
