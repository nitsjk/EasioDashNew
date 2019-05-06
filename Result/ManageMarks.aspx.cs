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

public partial class Subject_ManageMarks : System.Web.UI.Page
{
    ResultBLL Rdal = new ResultBLL();
    ClassBLL Cdal = new ClassBLL();
    
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
            lblError.Text = "";
            lblSuccess.Text = "";
            List<Nits.Model.Unit> UList = Rdal.getUnits();
            ddlType.DataSource = UList;
            ddlType.DataBind();
            ddlType.Items.Insert(0, new ListItem("--Select Unit--", "-1"));
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
        }

    }

    //Fill Grid Subject
    public void fillGridSubjects()
    {       
        try
        {            
            lblError.Text = "";
            long Classid = Convert.ToInt64(ddlClasses.SelectedValue);
            ExamBLL Edal = new ExamBLL();
            if (Classid != -1)
            {
                List<Exam> examList = Edal.getAllSubjects(Classid);

                List<Result> re = Rdal.getAllSubjects(Convert.ToInt64(ddlClasses.SelectedValue));
                Session["grd"] = examList;

                gvSubject.DataSource = examList;
                gvSubject.DataBind();
                btnSubmit.Visible = true;
            }
            else
                gvSubject.DataSource = null;
                gvSubject.DataBind();
                gvMarks.DataSource = null;
                gvMarks.DataBind();
        }
        catch (Exception ex)
        {
            lblError.Text = "No Data Found";
            lblError.Visible = true;
            lblSuccess.Visible = false;
            gvSubject.DataSource = null;
            gvSubject.DataBind();
        }
    }

    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            fillGrid();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
        }
    }

    protected void ddlClasses_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            fillDDLtype();
            fillGridSubjects();

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
            foreach (GridViewRow dr in gvSubject.Rows)
            {
                Label lblSubjects = (Label)dr.FindControl("lblSubjects");
                TextBox txtMaxMarks = (TextBox)dr.FindControl("txtMaxMarks");
                TextBox txtMinMarks = (TextBox)dr.FindControl("txtMinMarks");
                Result ex = new Result();
                ex.subjectid = Convert.ToInt64(lblSubjects.ToolTip);
                ex.minMarks = Convert.ToDecimal(txtMinMarks.Text);
                ex.maxMarks = Convert.ToDecimal(txtMaxMarks.Text);
                ex.unitid = Convert.ToInt64(ddlType.SelectedValue);
                ex.classid = Convert.ToInt64(ddlClasses.SelectedValue);
                eModel.Add(ex);

            }
            string message = Rdal.addMarks(eModel, Convert.ToInt64(ddlClasses.SelectedValue), Convert.ToInt64(ddlType.SelectedValue));
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
            fillGrid();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
        }
    }

    protected void gvSubject_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {

            int index = Convert.ToInt32(e.RowIndex);
            List<Exam> dt = (List<Exam>)Session["grd"];
            if (dt != null && dt.Count > 0)
            {
                dt.RemoveAt(index);
            }
            gvSubject.DataSource = dt;
            gvSubject.DataBind();

        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
        }

    }


  
}