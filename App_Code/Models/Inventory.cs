using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Inventory
/// </summary>
namespace Nits.Model
{
    public class StockCategory
    {
        public long CatID { get; set; }
        public string CatName { get; set; }
        public bool IsDeleted { get; set; }
        public string UserName { get; set; }
        public int CatNameExist { get; set; }
    }
}