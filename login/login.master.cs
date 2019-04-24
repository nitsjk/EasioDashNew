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
            Login Detail=Ldal.login(model);

        }
        catch (Exception ex)
        {
            throw;
        }
    }

    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        try
        {

        }
        catch (Exception ex)
        {
            throw;
        }
    }
}
