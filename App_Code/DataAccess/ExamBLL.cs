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
 
namespace Nits.BLL
{
    //Data Access Class For Subjects
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

    //Data Access Class For Optional Subjects
    public class OptionalSubjectsBLL
    { 
        public List<OptionalSubjects> getAllOptionalSubjects(long classID)
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage response = http.GetAsync("OptionalSubject/" + classID).Result;
            List<OptionalSubjects> model = response.Content.ReadAsAsync<List<OptionalSubjects>>().Result.ToList();
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

            OptionalSubjects model = Listmodel.FirstOrDefault(x => x.optionalSubjectID == eModel.optionalSubjectID);

            return model;

        }

        public string deleteOptionalSubject(long subjectID)
        {
            HttpClient http = NitsAPI.apiConnection1();
            var ReturnMessage = http.DeleteAsync("OptionalSubject/" + subjectID.ToString()).Result;
            if (ReturnMessage.IsSuccessStatusCode)
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
            else
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
        }

        public string updateOptionalSubject(OptionalSubjects Model)
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage response = http.GetAsync("OptionalSubject/" + Model.optionalSubjectID).Result;

            List<OptionalSubjects> EList = response.Content.ReadAsAsync<IEnumerable<OptionalSubjects>>().Result.ToList();
            OptionalSubjects UdpateModel = EList.FirstOrDefault(x => x.optionalSubjectID == Model.optionalSubjectID);

            UdpateModel.optionalSubjectName = Model.optionalSubjectName;
            //UdpateModel.current_Session = eModel.current_Session;


            var ReturnMessage = http.PutAsJsonAsync("OptionalSubject/"+Model.classID, UdpateModel).Result;
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

    //Data Access Class For Manage Marks
    public class ResultBLL
    {
        //Fill Grid Subjects
        public List<Result> getAllSubjects(long classId)
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage response = http.GetAsync("maxmarks/" + "/"+classId).Result;
            List<Result> model = response.Content.ReadAsAsync<IEnumerable<Result>>().Result.ToList();
            model = model.Where(x => x.classid == classId ).ToList();
            return model;
        }

        // Fill Grid Units
        public List<Result> getAllMinMaxResults(Result reModel)
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage response = http.GetAsync("maxmarks/" + reModel.classid + "/" + reModel.unitid).Result;

            List<Result> model = response.Content.ReadAsAsync<IEnumerable<Result>>().Result.ToList();
             model = model.Where(x => x.unitid == reModel.unitid).ToList();
            return model;
        }

        //For DropDown Units
        public List<Unit> getUnits()
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage response = http.GetAsync("unit").Result;
            List<Unit> model = response.Content.ReadAsAsync<List<Unit>>().Result.ToList();
            return model;
        }

        //Add Max Min Marks In gvSubjects
        public string addMarks(List<Result> Emodel, long Clasid,long UnitID)
        {
            HttpClient http = NitsAPI.apiConnection1();
            var ReturnMessage = http.PostAsJsonAsync("maxmarks/", Emodel).Result;

            if (ReturnMessage.IsSuccessStatusCode)
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
            else
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
        }

        //Update Min Max Marks
        public string UpdateMinMaxMarks(List<Result> Emodel)
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage response = http.GetAsync("maxmarks/").Result;
            var ReturnMessage = http.PutAsJsonAsync("maxmarks/", Emodel).Result;
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

    //Data Access Class For Award Roll

    public class MarksBLL
    {
        public List<Marks> getAwardRoll(Marks mModel)
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage response = http.GetAsync("marks/" + mModel.classID + "/" + mModel.sectionID+"/"+mModel.unitID+"/"+mModel.subjectID).Result;

            List<Marks> model = response.Content.ReadAsAsync<IEnumerable<Marks>>().Result.ToList();
           // model = model.Where(x => x.subjectID == mModel.subjectID).ToList();
            return model;
        }


        public string addMarks(List<Marks> lModel)
        {
            HttpClient http = NitsAPI.apiConnection1();
            var ReturnMessage = http.PostAsJsonAsync("marks/", lModel).Result;

            if (ReturnMessage.IsSuccessStatusCode)
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }
            else
            {
                return ReturnMessage.Content.ReadAsAsync<string>().Result;
            }

        }

        public string updateAwardRoll(List<Result> Emodel)
        {
            HttpClient http = NitsAPI.apiConnection1();
            HttpResponseMessage response = http.GetAsync("marks/").Result;
            var ReturnMessage = http.PutAsJsonAsync("marks/", Emodel).Result;
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
    
    