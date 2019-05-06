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
    ExamBLL Edal = new ExamBLL();
    OptionalSubjectsBLL Odal = new OptionalSubjectsBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            lblSession.Text = Session["Current_Session"].ToString();
            if (!IsPostBack)
            {
                getClasses();

            }

        }
        catch (Exception)
        {

        }

    }
    //Populate Drop Down List
    public void getClasses()
    {
        string str = "2018-19";
        List<ClassModel> classList = Cdal.getAllClasses(str);
        ddlClasses.DataSource = classList;
        ddlClasses.DataBind();
        ddlClasses.Items.Insert(0, new ListItem("--Select Classes--", "-1"));
    }

    protected void gvOptionalSubjects_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "EditCommand")
            {
                ViewState["OptionalSub"] = Convert.ToInt64(e.CommandArgument);
                editOptionalSubject(Convert.ToInt64(e.CommandArgument));
            }
            else if (e.CommandName == "DeleteCommand")
            {
                deleteOptionalSubject(Convert.ToInt64(e.CommandArgument));
            }

        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();

        }

    }

    //Edit Subject
    public void editOptionalSubject(long id)
    {
        try
        {
            ViewState["id"] = id;
            OptionalSubjects model = new OptionalSubjects();
            model.optionalSubjectID = id;
            model.classID = Convert.ToInt64(ddlClasses.SelectedValue);
            OptionalSubjects Subject = Odal.editOptionalSubject(model);

            ddlClasses.SelectedValue = Subject.classID.ToString();
            txtOpSubject.Text = Subject.optionalSubjectName;
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
    public void deleteOptionalSubject(long id)
    {
        try
        {
            string message = Odal.deleteOptionalSubject(id);
            getAllSubjects();
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = message;
            txtOpSubject.Text = "";
            ddlClasses.SelectedIndex = -1;

        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }

    }
    protected void ddlClasses_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            getAllSubjects();
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }
    }
    //Populate Grid
    public void getAllSubjects()
    {
        OptionalSubjectsBLL opSubject = new OptionalSubjectsBLL();
        long id = Convert.ToInt64(ddlClasses.SelectedValue);
        List<OptionalSubjects> opSubList = opSubject.getAllOptionalSubjects(id);
        if (opSubList.Count > 0)
        {
            gvOptionalSubjects.DataSource = opSubList;
            gvOptionalSubjects.DataBind();
            lblError.Visible = false;
            lblSuccess.Visible = false;
            lblSuccess.Text = "";
        }
        else
        {
            gvOptionalSubjects.DataSource = null;
            gvOptionalSubjects.DataBind();
            lblSuccess.Text = "";
            lblError.Visible = true;
            lblError.Text = "No Subjects Found";

        }

    }

    //Add Subject
    public void addSubject()
    {
        try
        {
            OptionalSubjectsBLL opSubject = new OptionalSubjectsBLL();
            OptionalSubjects ODal = new OptionalSubjects();

            ODal.classID= Convert.ToInt64(ddlClasses.SelectedValue);
            ODal.optionalSubjectName =txtOpSubject.Text;
            ODal.current_Session = Session["Current_Session"].ToString();


            string message = opSubject.addOptionalSubject(ODal);
            if (message.Contains("Sucessfully"))
            {
                lblSuccess.Text = message;
                lblError.Visible = false;
                lblSuccess.Visible = true;
                txtOpSubject.Text = "";
                txtOpSubject.Focus();
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
        addSubject();
        getAllSubjects();
        
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            updateSubject();
            getAllSubjects();
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }
    }

    public void updateSubject()
    {
        try
        {
            OptionalSubjects opSub = new OptionalSubjects();
            opSub.classID = Convert.ToInt64(ddlClasses.SelectedValue);
            opSub.optionalSubjectName = txtOpSubject.Text;
            opSub.optionalSubjectID= Convert.ToInt64(ViewState["OptionalSub"]);
            string message = Odal.updateOptionalSubject(opSub);
            if (message.Contains("successfully"))
            {
                lblSuccess.Text = message;
                lblError.Visible = false;
                lblSuccess.Visible = true;
                 txtOpSubject.Text = "";
                getAllSubjects();
            }
            btnSubmit.Visible = true;
            btnUpdate.Visible = false;
            txtOpSubject.Text = "";
            txtOpSubject.Focus();
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }
    }
}