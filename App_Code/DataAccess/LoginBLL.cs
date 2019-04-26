using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nits.Model;
using System.Data.SqlClient;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using NITS.API;
using System.Data;

/// <summary>
/// Summary description for LoginBLL
/// </summary>
namespace Nits.BLL
{
    public class LoginBLL
    {
        public User login(Login Lmodel)
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage Response = http.PostAsJsonAsync("Login", Lmodel).Result;
            User UModel =Response.Content.ReadAsAsync<User>().Result;
            return UModel;
        }
    }
    public class liveSessionBLL
    {
        public string Session()
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage Response = http.GetAsync("livesession").Result;
            string Current_Session = Response.Content.ReadAsAsync<string>().Result;
            if (string.IsNullOrEmpty(Current_Session))
            {
                return "Cannot Load Session";
            }
            else
            {
                return Current_Session;
            }
            
        }
    }
}