using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Section
/// </summary>
namespace Nits.Model
{
    public class Section
    {
        public long SectionID { get; set; }
        public long Classid { get; set; }
        public string SectionName { get; set; }
        public string ClassName { get; set; }
        public string Current_Session { get; set; }
        //public string SessionId { get; set; }
        //public string IsFL { get; set; }
    }
}