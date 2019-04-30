using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for StudentsBO
/// </summary>
namespace Nits.Model 
{
    public class StudentsModel
    {
        public long StudentID { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }

    }


    public class DepartMentModel
    {
        public string  ClassName { get; set; }
        public  String Department { get; set; }
    }
}