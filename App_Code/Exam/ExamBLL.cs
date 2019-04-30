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
/// Summary description for ExamBLL
/// </summary>
/// 
namespace Nits.BLL
{
    public class ExamBLL
    {
        public List<Exam> getAllSubjects(long SubID)
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage response = http.GetAsync("Subject/" + SubID).Result;
            List<Exam> model = response.Content.ReadAsAsync<IEnumerable<Exam>>().Result.ToList();
            return model;

        }
        public string addSubject(Exam Emodel)
        {
            HttpClient http = NitsAPI.apiConnection1();
            var ReturnMessage = http.PostAsJsonAsync("Subject/" + Emodel.subjectID, Emodel).Result;

            if (ReturnMessage.IsSuccessStatusCode)
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
            else
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
        }

        public Exam editSubject(Exam eModel)
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage response = http.GetAsync("Subject/" + eModel.classID).Result;
            List<Exam> Listmodel = response.Content.ReadAsAsync<IEnumerable<Exam>>().Result.ToList();
            Exam model = Listmodel.FirstOrDefault(x => x.subjectID == eModel.subjectID);
            return model;

        }


        public string updateSubject(Exam eModel)
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage response = http.GetAsync("Subject/" + eModel.classID).Result;

            List<Exam> EList = response.Content.ReadAsAsync<IEnumerable<Exam>>().Result.ToList();
            Exam UdpateModel = EList.FirstOrDefault(x => x.subjectID == eModel.subjectID);

            UdpateModel.subjectName = eModel.subjectName;
            UdpateModel.classID = eModel.classID;
            //UdpateModel.current_Session = eModel.current_Session;


            var ReturnMessage = http.PutAsJsonAsync("Subject", UdpateModel).Result;
            if (ReturnMessage.IsSuccessStatusCode)
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
            else
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
        }

        public string deleteSubject(long subjectID)
        {
            HttpClient http = NitsAPI.apiConnection1();
            var ReturnMessage = http.DeleteAsync("Subject/" + subjectID.ToString()).Result;
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

    public class OptionalSubjectsBLL
    { 
        public List<OptionalSubjects> getAllOptionalSubjects(long classID)
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage response = http.GetAsync("OptionalSubject/" + classID).Result;
            List<opti> model = response.Content.ReadAsAsync<IEnumerable<OptionalSubjects>>().Result.ToList();
            return model;

        }

        public string addOptionalSubject(OptionalSubjects model)
        {
            HttpClient http = NitsAPI.apiConnection1();
            var ReturnMessage = http.PostAsJsonAsync("OptionalSubject/" + model.classID, model).Result;

            if (ReturnMessage.IsSuccessStatusCode)
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
            else
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
        }

        public OptionalSubjects editOptionalSubject(OptionalSubjects eModel)
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage response = http.GetAsync("OptionalSubject/" + eModel.classID).Result;

            List<OptionalSubjects> Listmodel = response.Content.ReadAsAsync<IEnumerable<OptionalSubjects>>().Result.ToList();

            OptionalSubjects model = Listmodel.FirstOrDefault(x => x.subjectID == eModel.subjectID);
            return model;

        }

    }
        
    }
    
    