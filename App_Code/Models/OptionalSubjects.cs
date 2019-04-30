using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OptionalSubjects
/// </summary>
namespace Nits.Model
{
    public class OptionalSubjects
    {
        public long optionalSubjectID { get; set; }
        public long classID { get; set; }
        public long sessionID { get; set; }
        public string optionalSubjectName { get; set; }
        public string current_Session { get; set; }

    }
}