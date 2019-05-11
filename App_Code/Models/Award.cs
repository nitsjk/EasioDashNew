using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nits.Model
{
    public class Award
    {
        public long StudentID { get; set; }
        public long Rollno { get; set; }
        public string StudentName { get; set; }
        public string Marks { get; set; }
        public string status { get; set; }
        public string subjectName { get; set; }
        public long subjectid { get; set; }

    }

}