using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Print : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //if (Session["Log"] == "login")
        //{
        //    Control ctrl = (Control)Session["ctrl"];
        //    PrintHelper.PrintWebControl(ctrl);
        //}
        try
        {
            Control ctrl = (Control)Session["ctrl"];
            PrintHelper.PrintWebControl(ctrl);
        }
        catch(Exception ex)
        {// Response.Write(ex.ToString());
        }
    }
}
