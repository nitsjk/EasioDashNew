using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.BLL;
using Nits.Common;
using Nits.Model;
using System.Data;

public partial class Subject_EditMinMaxMarks : System.Web.UI.Page
{
    ClassBLL Cdal = new ClassBLL();
    ResultBLL Rdal = new ResultBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            lblSession.Text = Session["Current_Session"].ToString();
            if (!IsPostBack)
            {
                fillDDLclass();
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
        }

    }

    //Fill Drop Down Class
    public void fillDDLclass()
    {
        try
        {
            
            lblSuccess.Text = "";
            lblError.Text = "";
            string str = Session["Current_Session"].ToString();
            List<ClassModel> classList = Cdal.getAllClasses(str);
            ddlClasses.DataSource = classList;
            ddlClasses.DataBind();
            ddlClasses.Items.Insert(0, new ListItem("--Select Classes--", "-1"));
                    }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
        }
    }


    //Fill drop Down Type
    public void fillDDLtype()
    {

        try
        {
            btnSubmit.Visible = false;
            if (ddlType.SelectedValue != "-1")
            {
                lblError.Text = "";
                lblSuccess.Text = "";
                List<Nits.Model.Unit> UList = Rdal.getUnits();
                ddlType.DataSource = UList;
                ddlType.DataBind();
                ddlType.Items.Insert(0, new ListItem("--Select Unit--", "-1"));
                btnSubmit.Visible = false;
            }
            else {
                gvMarks.DataSource = null;
                gvMarks.DataBind();
                btnSubmit.Visible = false;
                
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
        }

    }


    //Fill Grid Unit
    public void fillGrid()
    {
        try
        {
            btnSubmit.Visible = true;
            lblError.Text = "";
            gvMarks.DataSource = null;
            gvMarks.DataBind();
            Result reModel = new Result();
            reModel.classid = Convert.ToInt64(ddlClasses.SelectedValue);
            reModel.unitid = Convert.ToInt64(ddlType.SelectedValue);
            if (Convert.ToInt64(ddlClasses.SelectedValue) != -1 && Convert.ToInt64(ddlType.Text) != -1)
            {
                List<Result> ds = Rdal.getAllMinMaxResults(reModel);
                gvMarks.DataSource = ds;
                gvMarks.DataBind();
                btnSubmit.Visible = true;
            }
            else
            {
                lblError.Text = "Select Class";
                gvMarks.DataSource = null;
                gvMarks.DataBind();
                lblError.Text = "";
            }
        }
        catch (Exception ex)
        {
            lblError.Text = "No Data Found";
            lblError.Visible = true;
            lblSuccess.Visible = false;
            btnSubmit.Visible = false;
        }

    }

    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
    {
        fillGrid();

    }

    protected void ddlClasses_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            fillDDLtype();

        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
        }

    }

    public void gvSubmitData()
    {

        try
        {
            lblError.Text = "";
            List<Result> eModel = new List<Result>();
            foreach (GridViewRow dr in gvMarks.Rows)
            {
                Label lblSubjects = (Label)dr.FindControl("lblSubjects");
                Label lblMaxID = (Label)dr.FindControl("lblMaxID");
                TextBox txtMaxMarks = (TextBox)dr.FindControl("txtMaxMarks");
                TextBox txtMinMarks = (TextBox)dr.FindControl("txtMinMarks");
                Result ex = new Result();
                ex.subjectid = Convert.ToInt64(lblSubjects.Text);
                ex.maxID = Convert.ToInt64(lblMaxID.Text);
                ex.minMarks = Convert.ToDecimal(txtMinMarks.Text);
                ex.maxMarks = Convert.ToDecimal(txtMaxMarks.Text);
                ex.unitid = Convert.ToInt64(ddlType.SelectedValue);
                ex.classid = Convert.ToInt64(ddlClasses.SelectedValue);
                eModel.Add(ex);

            }
            string message = Rdal.UpdateMinMaxMarks(eModel);
            lblSuccess.Visible = true;
            lblSuccess.Text = message;
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
        }

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {

            gvSubmitData();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
        }

    }
}