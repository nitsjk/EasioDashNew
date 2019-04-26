using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nits.Model;
using System.Data.SqlClient;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using NITS.API;
using System.Data;
using Nits.BLL;
using System.Web.UI;
public partial class login_login : System.Web.UI.MasterPage
{
    LoginBLL Ldal = new LoginBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }

    public void LoginUser()
    {
        try
        {
            Login model = new Login();
            model.UserName = txtUserName.Text;
            model.UserPassword = txtUserPassword.Text;
            User Detail=Ldal.login(model);
            liveSessionBLL LSdal = new liveSessionBLL();
            Session["Current_Session"] = LSdal.Session();
           
            //Session["CompanyName"]=Detail.
            if (string.IsNullOrEmpty(Detail.UserName))
            {
                lblError.Visible = true;
                lblSuccess.Visible = false;
                lblError.Text = "Invalid username or password !";
                Session["username"] = null;
                Session["Login"] = null;
            }
            else
            {
                Session["Current_Session"] = Detail.current_Session;
                Session["username"] = Detail.UserName;
                Session["Login"] = "%$#%$fYguyUk";
                Response.Redirect("~/Default.aspx?Id="+Detail.UserID);
                
                //Session["CompanyName"]=Detail.
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }
    }

    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        try
        {
            LoginUser();
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}
