using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Formatting;
using NITS.API;
using System.Net.Http.Headers;
using Nits.Model;
using System.Data;
using System.Data.SqlClient;
public partial class MasterPageMain : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //asv();
            //string Jurisdiction = "one,two,three,four,five,six";
            //string IssueDate = "12/10/2015";
            ////FillJurisdictionGrid(Jurisdiction, IssueDate);\

            //MultiView1.ActiveViewIndex = 0;

            //LoadDataToGrid();

            //profilePic();
        }

    }
   


    private void LoadGridData()
    {
        throw new NotImplementedException();
    }

    private void EditItem()
    {


    }
   
}
