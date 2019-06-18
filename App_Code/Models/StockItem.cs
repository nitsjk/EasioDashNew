using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nits.Model
{
    public class StockItem
    {
        public  long ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public long StockCatIDFK { get; set; }
        public long BrandIDFK { get; set; }
        public long UnitP { get; set; }
        public long UnitS { get; set; }
        public int IsExpiry { get; set; }
        public int IsUnique { get; set; }
        public decimal ReorderLevel { get; set; }
        public string Location { get; set; }
        public string BCode { get; set; }
        public decimal PRate { get; set; }
        public decimal SRate { get; set; }
        public decimal Gst { get; set; }
        public decimal GstAmount { get; set; }
        public string HSNCode { get; set; }
        public string UserName { get; set; }
        public DateTime Itemdate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }


    }

}