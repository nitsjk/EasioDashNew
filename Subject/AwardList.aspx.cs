using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.BLL;
using Nits.Common;
using Nits.Model;


public partial class Subject_AwardList : System.Web.UI.Page
{
    ClassBLL Cdal = new ClassBLL();
    SectionBLL Sdal = new SectionBLL();
    ExamBLL Edal = new ExamBLL();
    ResultBLL Rdal = new ResultBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblSession.Text = Session["Current_Session"].ToString();
        if (!IsPostBack)
        {
            fillDDLclass();

        }

    }

    public void fillDDLclass()
    {
        string str = Session["Current_Session"].ToString();
        List<ClassModel> classList = Cdal.getAllClasses(str);
        ddlClasses.DataSource = classList;
        ddlClasses.DataBind();
        ddlClasses.Items.Insert(0, new ListItem("--Select Classes--", "-1"));
    }

    public void fillDDLSections()
    {

        try
        {
            long Classid = Convert.ToInt64(ddlClasses.SelectedValue);
            List<Section> classList = Sdal.GetSections(Classid);
            ddlSection.DataSource = classList;
            ddlSection.DataBind();
            ddlSection.Items.Insert(0, new ListItem("--Select Section--", "-1"));

        }
        catch (Exception ex)
        {

            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;
        }

    }

    public void fillDDLSubjects()
    {
        try
        {
            long Classid = Convert.ToInt64(ddlClasses.SelectedValue);

            List<Exam> examList = Edal.getAllSubjects(Classid);

            if (examList.Count > 0)
            {
                ddlSubject.DataSource = examList;
                ddlSubject.DataBind();
                ddlSubject.Items.Insert(0, new ListItem("--Select Subject--", "-1"));
            }
            else
            {
                lblSuccess.Text = "";
                lblError.Text = "No Subjects Found";

            }

        }
        catch (Exception ex)
        {

            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;
        }


    }

    public void fillDDLtype()
    {

        List<Nits.Model.Unit> UList = Rdal.getUnits();
        ddlType.DataSource = UList;
        ddlType.DataBind();
        ddlType.Items.Insert(0, new ListItem("--Select Unit--", "-1"));

    }


    protected void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
    {
        fillDDLtype(); 

    }

    protected void ddlClasses_SelectedIndexChanged(object sender, EventArgs e)
    {
        fillDDLSections();
    }

    protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
    {
        fillDDLSubjects();

    }

    protected void gvAward_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
}