using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/// <summary>
/// Model For Classes
/// </summary>
namespace Nits.Model
{
    public class ClassModel
    {
        public long ClassId { get; set; }
        public long subdepartmentid { get; set; }
        public string SessionID { get; set; }
        public string EduDepartmentName { get; set; }
        public string Current_Session { get; set; }
        public string ClassName { get; set; }
        public string ClassIncharg { get; set; }
        public string UserName { get; set; }
        public string MonthName { get; set; }
        public bool isDeleted { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string SYear { get; set; }
    }
}