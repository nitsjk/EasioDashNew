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

public partial class Inventory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblSession.Text = Session["Current_Session"].ToString();
            asv();
            string Jurisdiction = "one,two,three,four,five,six";
            string IssueDate = "12/10/2015";
            //FillJurisdictionGrid(Jurisdiction, IssueDate);\

            MultiView1.ActiveViewIndex = 0;

            LoadDataToGrid();

            profilePic();
        }

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
    public void profilePic()
    {
        //if (filepic.HasFile)
        //{

        //    filepic.SaveAs(Server.MapPath("img/" + filepic.FileName));
        //    Response.Redirect(Request.Url.ToString());

        //}

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

    public void asv()
    {
        lblstudentroll.Text = "200: 150(M),50(F)";



        stndlbl.Text = "5,000: 3000(M),2000(F)";
        lblstaffroll.Text = "7000: 5000(M),2000(F)";
        lblstaffatt.Text = "10000: 4000(M),6000(F)";
    }

    private void FillJurisdictionGrid(string Jurisdiction, string IssueDate)
    {


        if (Jurisdiction != "")
        {
            grdView.Visible = true;
            //grid.Visible = true;
            //txtJurisdiction.Enabled = false;
            string[] jurisdictionData = Jurisdiction.Split(',');
            grdView.DataSource = jurisdictionData;

            grdView.DataBind();

            for (int i = 0; i < grdView.Rows.Count; i++)
            {
                TextBox txtEffectiveDate = (TextBox)grdView.Rows[i].FindControl("txtEffectiveDate");
                txtEffectiveDate.Text = IssueDate;//By chance you want to pass the Textbox Value

            }

        }
        else
        {
            //  grid.Visible = false;
            grdView.Visible = false;
        }
    }

    protected void grdView_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdView.PageIndex = e.NewPageIndex;
        LoadDataToGrid();
    }
}