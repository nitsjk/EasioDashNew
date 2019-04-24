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
/// Data Access Leayer from sections 
/// </summary>
namespace Nits.BLL
{
    public class SectionBLL
    {
        public List<Section> GetSections(long Classid)
        {
            HttpClient hc = NitsAPI.apiConnection1();
            HttpResponseMessage response = hc.GetAsync("Section/" + Classid).Result;
            List<Section> SList = response.Content.ReadAsAsync<IEnumerable<Section>>().Result.ToList();
            return SList;
        }
        public string AddSection(Section model)
        {
            HttpClient http = NitsAPI.apiConnection1();
            var ReturnMessage = http.PostAsJsonAsync("Section",model).Result;

            if (ReturnMessage.IsSuccessStatusCode)
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
            else
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
        }
        public string DeleteSection(long SectionID)
        {
            HttpClient http = NitsAPI.apiConnection1();
            var ReturnMessage = http.DeleteAsync("Section/"+ SectionID.ToString()).Result;
            if (ReturnMessage.IsSuccessStatusCode)
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
            else
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// edit section  angain changed
        /// <returns></returns>
        public Section EditSectin(long SectionID)
        {
            HttpClient hc = NitsAPI.apiConnection1();

            HttpResponseMessage response = hc.GetAsync("SectionEdit/"+SectionID).Result;
            Section SecModel = response.Content.ReadAsAsync<Section>().Result;

            return SecModel;
        }
        public string UpdateSection(Section model)
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage response = http.GetAsync("Section/"+model.Classid.ToString()).Result;
            List<Section> SList = response.Content.ReadAsAsync<IEnumerable<Section>>().Result.ToList();
            Section Smodel = SList.FirstOrDefault(x => x.SectionID == model.SectionID);
            Smodel.ClassName = model.ClassName;
            Smodel.SectionName = model.SectionName;
            var ReturnMessage = http.PutAsJsonAsync("Section", Smodel).Result;
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