using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoSociety.Authentication
{
    public interface IAuthenticationApi
    {
        bool Login(LoginRequest request);
        bool Logout(LogoutRequest request);
        void Register(RegisterRequest request);
        void ResetPassword();
        void RetrivePassword();
        void ChangePassword();
    }
}
