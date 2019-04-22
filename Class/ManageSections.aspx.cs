using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.BLL;
using Nits.Model;
using Nits.Common;

public partial class Class_ManageSections : System.Web.UI.Page
{
    ClassBLL Cdal = new ClassBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            txtSection.Focus();
            getClasses();
        }
    }

    public void getClasses()
    {
        List<ClassModel> classList = Cdal.getAllClasses();
        ddlClasses.DataSource = classList;
        ddlClasses.DataBind();
        

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        check();
    }

    public void check()
    {
        lblClass.Text = "";
        lblSection.Text = "";
        //txtName.Text = "";
        //ddlDepartments.ClearSelection();

        DepartMentModel dm = new DepartMentModel();
        StudentBLL sb = new StudentBLL();
        dm.Department =  ddlClasses.SelectedValue;
        dm.ClassName = txtSection.Text;

        string message = sb.Department(dm);

        if (message == "-1")
        {
            lblClass.Text = "  *";
        }
        else if (message == "0")
        {
            lblSection.Text = "  *";
            txtSection.Focus();

        }

        else if (message == "false")
        {
            lblClass.Text = "  *";
            lblSection.Text = "  *";

        }

        else if (message == "true")
        {
            lblSuccess.Text = "Record Added Successfully!";
        }
        //Response.Write(message);
        else
            lblSuccess.Text = "Record Added Successfully!";
        txtSection.Text = "";

    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        reset();

    }
    public void reset()
    {
        
            lblSection.Text = "";
            lblClass.Text = "";
            //ddlDepartments.SelectedItem.Text = "--Select Department--";
            ddlClasses.ClearSelection();
            txtSection.Text = "";
            lblSuccess.Text = "";
           
    }
}