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


public partial class Transport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void grdView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "EditItem")
        {
            MultiView1.ActiveViewIndex = 1;

        }

        //if (e.CommandName == "Delteitem")
        //{


        //}
    }

    protected void grdView_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdView.PageIndex = e.NewPageIndex;
        LoadDataToGrid();
    }
    protected void LoadDataToGrid()
    {

        HttpClient clnt = NitsAPI.apiConnection();

        HttpResponseMessage response = clnt.GetAsync("imran").Result;


        if (response.IsSuccessStatusCode)
        {
            List<ImranData> eL = new List<ImranData>();
            var getclnt = response.Content.ReadAsAsync<IEnumerable<ImranData>>().Result;

            grdView.DataSource = getclnt;
            grdView.DataBind();
            //grdView.Visible = true;
        }
        else
        {
            grdView.DataSource = null;
            grdView.DataBind();
        }

    }
}