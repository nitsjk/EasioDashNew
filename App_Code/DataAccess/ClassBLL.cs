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

/// <summary>
/// Summary description for ClassBLL
/// </summary>
namespace Nits.BLL
{
    public class ClassBLL
    {
        public List<ClassModel> getAllClasses()
        {
            HttpClient hc = NitsAPI.apiConnection1();


            HttpResponseMessage response = hc.GetAsync("class").Result;
          List<ClassModel> ds = response.Content.ReadAsAsync<IEnumerable<ClassModel>>().Result.ToList();

            return ds;
        }

        public string AddClass(ClassModel model)
        {
            HttpClient http = NitsAPI.apiConnection1();
            var ReturnMessage = http.PostAsJsonAsync("class", model).Result;

            if (ReturnMessage.IsSuccessStatusCode)
            {
                return ReturnMessage.ToString();
            }
            else
            {
                return ReturnMessage.ToString();
            }
        }
    }

   
}