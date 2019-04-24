using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Users
/// </summary>
namespace Nits.Model
{
    public class Users:Login
    {
        public long UserID { get; set; }
        public string userFullName { get; set; }
        public string userEmail { get; set; }
        public string userPhoto { get; set; }
        public string userAddress { get; set; }
        public string userPhoneNo { get; set; }
        public long userTypeID { get; set; }
        public string controlId { get; set; }
        public string userRemarks { get; set; }
        public string userLogoPath { get; set; }
        public string current_Session { get; set; }
        public string sessionID { get; set; }
        public string activation { get; set; }
        public string dashboard { get; set; }
        public string control1Id { get; set; }
    }
}