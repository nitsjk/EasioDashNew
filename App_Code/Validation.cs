using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Nits.Common;
using Nits.Model;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;

/// <summary>
/// Summary description for Validation
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Validation : System.Web.Services.WebService
{ 
    [WebMethod]
    public int CategoryExist(string CatName)
    {
        int count = 0;
        SqlParameter[] var =
        {
            new SqlParameter("@CatName",CatName)
        };
        count=Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.Connect, CommandType.Text, "select count(CatName) from StockCategory where CatName=@CatName",var));
        return count;
        StockCategory Category = new StockCategory();
        Category.CatName = CatName;
        Category.CatNameExist = count;
        JavaScriptSerializer js = new JavaScriptSerializer();
        Context.Response.Write(js.Serialize(Category));
    }

}
