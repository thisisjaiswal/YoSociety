using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
 

namespace YoSociety.Service.Controllers
{
    public class LoginRequest
    {
        public string MobileNo { get; set; }
        public string Password { get; set; }
    }

    public class AccountController : ApiController
    {
        //AuthenticationApi authenticationApi = new AuthenticationApi(new AuthenticationEdmxRepository());
        //BusinessApi businessApi = new BusinessApi(new BusinessEdmxRepository());

        // POST api/account/{requestType}/
        public HttpResponseMessage PostRequest(string id, LoginRequest data)
        {
            
            HttpResponseMessage response;

            switch (id)
            {

                case "login":
                    LoginRequest loginRequest = (LoginRequest)data;
                    //var isSuccess = authenticationApi.Login(loginRequest.MobileNo, loginRequest.Password);
                    response = Request.CreateResponse(HttpStatusCode.OK, true);
                    break;

                default:
                    response = Request.CreateErrorResponse(HttpStatusCode.BadRequest, new HttpError("Invalid request type!!!"));
                    break;
            }

            return response;
        }
    }
}
