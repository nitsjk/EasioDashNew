using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nits.Model;
using Nits.Common;
using System.Data.SqlClient;

/// <summary>
/// Data Access Leayer fro student
/// </summary>
namespace Nits.BLL
{
    public class StudentBLL
    {
        public string StudentDetail(StudentsModel Model)
        {
            string returnMessage = null;
            if (string.IsNullOrEmpty(Model.StudentName))
            {
                returnMessage = "Student Name is required";
            }
            else
            {
                if (string.IsNullOrEmpty(Model.Gender))
                {
                    returnMessage = "gender is required";
                }
                else
                {
                    if (Model.Gender == "-1")
                    {
                        returnMessage = "gender is required";
                    }
                    else
                    {
                        returnMessage = "Student Added Successfully";
                    }
                }
            }

            return returnMessage;
            ;
        }

        public string Department(DepartMentModel Model)
        {
            string returnMessage = "true";
             if(Model.ClassName=="" && Model.Department == "-1")
            {
                returnMessage = "false";
            }
        
            else if (Model.ClassName=="")
            
            {
                returnMessage = "0";
            }
            else if (Model.Department == "-1")
            {
                returnMessage = "-1";
            }

            return returnMessage;
        }
    }
}