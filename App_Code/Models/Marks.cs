using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nits.Model
{
    public class Marks
    {
        public string sName { get; set; }
        public long marksID { get; set; }
        public long studentID { get; set; }
        public long classID { get; set; }
        public long sectionID { get; set; }
        public long rollno { get; set; }
        public long maxID { get; set; }
        public long unitID { get; set; }
        public long subjectID { get; set; }
        public string optionalID { get; set; }
        public string current_Session { get; set; }
        public long sessionID { get; set; }
        public long status { get; set; }
        public long marks { get; set; }
        public string date { get; set; }

    }
}