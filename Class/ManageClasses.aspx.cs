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
                getClasses();
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;
        }
    }

    //Function To Populate Grid
    public void getClasses()
    {
        try
        {
            ClassModel cm = new ClassModel();
            string Current_Session = "2018-19";
            List<ClassModel> classList = Cdal.getAllClasses(Current_Session);
            gvClasses.DataSource = classList;
            gvClasses.DataBind();
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
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

    //Function To Add A Class
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
    //Function To Reset Controls
    public void reset()
    {
        try
        {
            ddlDepartments.ClearSelection();
            txtName.Text = "";
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

    protected void gvClasses_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "EditCommand")
        {
            EditClass(Convert.ToInt64(e.CommandArgument));
        }
        else if (e.CommandName == "DeleteCommand")
        {
            deleteClass(Convert.ToInt64(e.CommandArgument));
        }
    }
 
    //Function To Delete a Class
    public void deleteClass(long id)
    {
        try
        {
            string message = Cdal.DeleteClass(id);
            getClasses();
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = message;
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }
    }
    //Function To Edit Class
    public void EditClass(long id)
    {
        try
        {
            ClassModel cmodel = Cdal.EditClass(id);
            ViewState["ClassID"] = id;
            ddlDepartments.SelectedValue = cmodel.subdepartmentid.ToString();
            txtName.Text = cmodel.ClassName;
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
    public void updateClass()
    {
        try
        {
            long CID = Convert.ToInt64(ViewState["ClassID"]);
            ClassModel cm = new ClassModel();
            cm.ClassId = CID;
            cm.ClassName = txtName.Text;
            cm.subdepartmentid = Convert.ToInt64(ddlDepartments.SelectedValue);
            cm.UpdatedBy = "NA";
            cm.UpdatedOn = DateTime.Now;
            string message = Cdal.UpdateClass(cm);
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
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }
    }

    //Function To Update A Class
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            updateClass();
            btnUpdate.Visible = false;
            btnSubmit.Visible = true;
            getClasses();
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }
    }


}