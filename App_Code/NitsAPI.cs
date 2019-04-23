using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
namespace NITS.API
{
    public class NitsAPI
    {
        public static HttpClient apiConnection1()
        {

            //Hosted web API REST Service base url  
            //testing fwcore.easio.in/api/  

            string BaseUrl = "http://coreapi.easio.in/api/";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Clear();
            //Define request data format  
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           
            //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
            // HttpResponseMessage response = client.GetAsync("api/str").Result;

            return client;
        }
        public static HttpClient apiConnection()
        {

            //Hosted web API REST Service base url  

            
            string BaseUrl = "http://timetable.easio.in/api/";


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Clear();
            //Define request data format  
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
            // HttpResponseMessage response = client.GetAsync("api/str").Result;

            return client;
        }
       

    }
}