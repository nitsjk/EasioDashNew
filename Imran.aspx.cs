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
using Nits.Common;
using System.Data;

public partial class Imran : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loaddata();
        }
    }
    public void loaddata()
    {
        HttpClient clt = NitsAPI.apiConnection();
        HttpResponseMessage response = clt.GetAsync("imran").Result;
        if (response.IsSuccessStatusCode)
        {
            List<ImranData> eL = new List<ImranData>();
            var get = response.Content.ReadAsAsync<IEnumerable<ImranData>>().Result;
            GridView1.DataSource = get;
            GridView1.DataBind();
        }

        else
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
        }

    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        loaddata();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpClient client = NitsAPI.apiConnection();

        HttpResponseMessage response = client.GetAsync("imran").Result;


        ImranData imr = new ImranData();

        imr.Name = txtname.Text;
        imr.Address = txtaddress.Text;
        imr.Phone = txtphone.Text;

        var x = client.PostAsJsonAsync("imran", imr).Result;

        if (response.IsSuccessStatusCode)
        {
            ImranData ds = new ImranData();
            var data = response.Content.ReadAsAsync<IEnumerable<ImranData>>().Result;


            GridView1.DataSource = data;
            GridView1.DataBind();

            loaddata();
            txtname.Text = "";
            txtaddress.Text = "";
            txtphone.Text = "";


        }
        else
        {
            GridView1.DataSource = null;
            GridView1.DataBind();

        }
    }




    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        Int64 id = Convert.ToInt64(e.CommandArgument);
        Session["dd"] = id;
        if (e.CommandName == "Edit")
        {


            HttpClient client = NitsAPI.apiConnection();

            HttpResponseMessage response = client.GetAsync("imran").Result;
               List<ImranData> dls = response.Content.ReadAsAsync<IEnumerable<ImranData>>().Result.ToList();

            var get = response.Content.ReadAsAsync<IEnumerable<ImranData>>().Result;


            if (response.IsSuccessStatusCode)
            {

                 // ImranData eL = new ImranData();

               dls.RemoveAll(s => s.ID != id);
               
                foreach (var s in dls)
                {
                    txtname.Text = s.Name;
                    txtaddress.Text = s.Address;
                    txtphone.Text = s.Phone;
                    var x = client.PutAsJsonAsync("imran", s).Result;
                }

            }



            else
            {
                GridView1.DataSource = null;
                GridView1.DataBind();

            }

        }



    }
    protected void update_Click(object sender, EventArgs e)
    {

        HttpClient client = NitsAPI.apiConnection();

        HttpResponseMessage response = client.GetAsync("imran").Result;
        ImranData imr = new ImranData();
        imr.ID = Convert.ToInt64(Session["dd"].ToString());
        imr.Name = txtname.Text;
        imr.Address = txtaddress.Text;
        imr.Phone = txtphone.Text;


        var x = client.PutAsJsonAsync("imran", imr).Result;
        if (response.IsSuccessStatusCode)
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
            loaddata();
            txtname.Text = "";
            txtaddress.Text = "";
            txtphone.Text = "";

        }

        else
        {
            //Label1.Text = "not updated";
        }
    }


    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
}