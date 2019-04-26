using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.BLL;
using Nits.Model;
using Nits.Common;

public partial class Subject_OptionalSubjects : System.Web.UI.Page
{
    ClassBLL Cdal = new ClassBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                getClasses();

            }

        }
        catch (Exception)
        {

            throw;
        }

    }
    public void getClasses()
    {
        string str = "2018-19";
        List<ClassModel> classList = Cdal.getAllClasses(str);
        ddlClasses.DataSource = classList;
        ddlClasses.DataBind();
        ddlClasses.Items.Insert(0, new ListItem("--Select Classes--", "-1"));
    }

}