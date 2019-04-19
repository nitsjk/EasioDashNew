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
            HttpClient hc = NitsAPI.apiConnection();


            HttpResponseMessage response = hc.GetAsync("Classes").Result;
          List<ClassModel> ds = response.Content.ReadAsAsync<IEnumerable<ClassModel>>().Result.ToList();

            return ds;
        }
    }

   
}