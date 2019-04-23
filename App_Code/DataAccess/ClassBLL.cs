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
/// Summary description for ClassBLL
/// </summary>
namespace Nits.BLL
{
    public class ClassBLL
    {
        public List<ClassModel> getAllClasses( ClassModel model)
        {
            HttpClient hc = NitsAPI.apiConnection1();


            HttpResponseMessage response = hc.GetAsync("class").Result;
          List<ClassModel> CList = response.Content.ReadAsAsync<IEnumerable<ClassModel>>().Result.ToList();
            CList = ( CList.Where(x => x.Current_Session == model.Current_Session).ToList());

            return CList;
        }

        public string AddClass(ClassModel model)
        {
            HttpClient http = NitsAPI.apiConnection1();
            var ReturnMessage = http.PostAsJsonAsync("class", model).Result;
            
            if (ReturnMessage.IsSuccessStatusCode)
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
            else
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
        }
    }
   
}