using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.BLL;
using Nits.Model;
using Nits.Common;

public partial class Subject_addSubject : System.Web.UI.Page
{
    ClassBLL Cdal = new ClassBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            lblSession.Text = Session["Current_Session"].ToString();
            if (!IsPostBack)
            {
                getClasses();
                lblSession.Text = Session["Current_Session"].ToString(); 
               
            }

        }
        catch (Exception)
        {

            throw;
        }
        
    }
    //Populate DropDownList and Grid
    public void getClasses()
    {
        string str = "2018-19";
        List<ClassModel> classList = Cdal.getAllClasses(str);
        ddlClasses.DataSource = classList;
        ddlClasses.DataBind();
        ddlClasses.Items.Insert(0, new ListItem("--Select Classes--", "-1"));
        gvSubjects.DataSource = classList;
        gvSubjects.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            addSubject();
        }
        catch (Exception ex)
        {

            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;
        }
    }
    //Add Subject
    public void addSubject()
    {
        try
        {
            ClassModel cm = new ClassModel();
            cm.ClassName = txtSubject.Text;
            cm.subdepartmentid = Convert.ToInt64(ddlClasses.SelectedValue);
            cm.Current_Session = "2018-19";
            cm.UserName = "NA";

            string message = Cdal.AddClass(cm);
            if (message.Contains("successfully"))
            {
                lblSuccess.Text = message;
                lblError.Visible = false;
                lblSuccess.Visible = true;
                txtSubject.Text = "";
                txtSubject.Focus();
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
    protected void btnReset_Click(object sender, EventArgs e)
    {
        try
        {
            reset();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;
        }
    }
    //Reset Controls
    public void reset()
    {
        try
        {
            ddlClasses.ClearSelection();
            txtSubject.Text = "";
            lblSuccess.Text = "";
            btnUpdate.Visible = false;
            btnSubmit.Visible = true;

        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;

        }
    }

    protected void gvSubjects_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "EditCommand")
        {
            editSubject(Convert.ToInt64(e.CommandArgument));
        }
        else if (e.CommandName == "DeleteCommand")
        {
            deleteSubject(Convert.ToInt64(e.CommandArgument));
        }
    }
    //Edit Subject
    public void editSubject(long id)
    {

        try
        {
            
            Session["SubjectID"] = id;
            ddlClasses.SelectedValue = "";
            txtSubject.Text = "";
            btnSubmit.Visible = false;
            btnUpdate.Visible = true;

        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }
    }
    //Delete Subject
    public void deleteSubject(long id)
    {
        try
        {
           // string message = Cdal.DeleteClass(id);
           // getSubjects();
            lblError.Visible = true;
            lblSuccess.Visible = false;
           // lblError.Text = message;
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }

    }
}