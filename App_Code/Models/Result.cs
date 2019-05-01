using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Result
/// </summary>
namespace Nits.Model { 
    public class  Result
    {
        public long maxID { get; set; }
        public long maxMarks { get; set; }
        public long minMarks { get; set; }
        public long classid { get; set; }
        public long subjectid { get; set; }
        public string subDepartmentid { get; set; }
        public string sectionid { get; set; }
        public long unitid { get; set; }
        public string optionalid { get; set; }
        public string current_Session { get; set; }
        public long sessionID { get; set; }

        public string subjectName { get; set; }
    }
}