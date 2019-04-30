using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ExamModel
/// </summary>
namespace Nits.Model
{
    public class Exam {
        public long subjectID { get; set; }
        public long classID { get; set; }
        public long sessionID { get; set; }
        public string subjectName { get; set; }
        public string current_Session { get; set; }
        public string sectionID { get; set; }

    }
}