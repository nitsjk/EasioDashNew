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
        try
        {
            if (!IsPostBack)
            {
                txtName.Focus();

            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;
        }
    }

    public void addClass()
    {

        try
        {
            ClassModel cm = new ClassModel();
            cm.ClassName = txtName.Text;
            cm.subdepartmentid = Convert.ToInt64(ddlDepartments.SelectedValue);
            cm.Current_Session = "2018-19";
            cm.UserName = "NA";

            string message = Cdal.AddClass(cm);
            if (message.Contains("successfully"))
            {
                lblSuccess.Text = message;
                lblError.Visible = false;
                lblSuccess.Visible = true;
                txtName.Text = "";
                ddlDepartments.SelectedValue = "-1";
            }
            else
            {
                lblError.Text = message;
                lblError.Visible = true;
                lblSuccess.Visible = false;
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;
        }
        
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            addClass();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;

        }   
    }  
   
    protected void btnReset_Click(object sender, EventArgs e)
    {
        reset();
    }
    public void reset()
    {
        try
        {

            if (IsPostBack)
            {
                lblClassStatus.Text = "";
                lblDepartmentStatus.Text = "";
                
                ddlDepartments.ClearSelection();
                txtName.Text = "";
                lblSuccess.Text = "";

            }

        }
        catch (Exception ex)
        {

            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;
        }
       
    }
}