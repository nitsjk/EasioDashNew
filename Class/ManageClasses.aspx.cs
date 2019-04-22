using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.BLL;
using Nits.Common;
using Nits.Model;

public partial class Class_ManageClasses : System.Web.UI.Page
{

    ClassBLL Cdal = new ClassBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtName.Focus();

        }
    }

    public void addClass()
    {
        ClassModel cm = new ClassModel();
        cm.ClassName = txtName.Text;
        cm.subdepartmentid = Convert.ToInt64(ddlDepartments.SelectedValue);
        string message = Cdal.AddClass(cm);
        lblSuccess.Text = message;

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // check();
        addClass();
    }

    public void check()
    {
        lblClassStatus.Text = "";
        lblDepartmentStatus.Text = "";
        //txtName.Text = "";
        //ddlDepartments.ClearSelection();

        DepartMentModel dm = new DepartMentModel();
        StudentBLL sb = new StudentBLL();
        dm.Department = ddlDepartments.SelectedValue;
        dm.ClassName = txtName.Text;

        string message = sb.Department(dm);

        if (message == "-1")
        {
            lblDepartmentStatus.Text = "  *";
        }
        else if (message == "0")
        { 
            lblClassStatus.Text = "  *";
            txtName.Focus();

        }

        else if (message == "false")
        {
            lblDepartmentStatus.Text = "  *";
            lblClassStatus.Text = "  *";

        }

        else if(message=="true")
        {
            lblSuccess.Text = "Record Added Successfully!"; 
        }
        //Response.Write(message);
        else
        lblSuccess.Text = "Record Added Successfully!";
        txtName.Text = "";

    }

   
    protected void btnReset_Click(object sender, EventArgs e)
    {
        reset();
    }
    public void reset()
    {
        if (IsPostBack)
        {
            lblClassStatus.Text = "";
            lblDepartmentStatus.Text = "";
            //ddlDepartments.SelectedItem.Text = "--Select Department--";
            ddlDepartments.ClearSelection();
            txtName.Text = "";
            lblSuccess.Text = "";
            
        }
    }

    protected void ddlDepartments_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}