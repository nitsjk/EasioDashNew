using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.BLL;
using Nits.Common;
using Nits.Model;
public partial class Result_EditMarks : System.Web.UI.Page
{

    ClassBLL Cdal = new ClassBLL();
    SectionBLL Sdal = new SectionBLL();
    ExamBLL Edal = new ExamBLL();
    ResultBLL Rdal = new ResultBLL();
    MarksBLL Mdal = new MarksBLL();
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

    public void fillDDLclass()
    {
        try
        {
            string str = Session["Current_Session"].ToString();
            List<ClassModel> classList = Cdal.getAllClasses(str);
            ddlClasses.DataSource = classList;
            ddlClasses.DataBind();
            ddlClasses.Items.Insert(0, new ListItem("--Select Classes--", "-1"));

        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
        }
    }

    public void fillDDLSections()
    {

        try
        {
            lblError.Text = "";
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
            lblSuccess.Visible = false;
            lblError.Text = "";
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

        }


    }

    public void fillDDLtype()
    {

        try
        {
            lblSuccess.Visible = false;
            lblError.Text = "";
            List<Nits.Model.Unit> UList = Rdal.getUnits();
            ddlType.DataSource = UList;
            ddlType.DataBind();
            ddlType.Items.Insert(0, new ListItem("--Select Unit--", "-1"));

        }
        catch (Exception ex)
        {

            lblError.Text = ex.ToString();
            lblError.Visible = true;

        }

    }

    protected void ddlClasses_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            fillDDLSections();
            ddlType.SelectedValue = "-1";
            ddlSection.SelectedValue = "-1";
            ddlSubject.SelectedValue = "-1";
            gvEditMarks.DataSource = null;
            gvEditMarks.DataBind();
            btnUpdate.Visible = false;
            lblError.Text = "";
        }
        catch (Exception ex)
        {
            lblError.Text = e.ToString();
        }
    }

    protected void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            fillDDLtype();
            gvEditMarks.DataSource = null;
            gvEditMarks.DataBind();
            lblError.Text = "";
            ddlType.SelectedValue = "-1";
            ddlSubject.SelectedValue = "-1";
            btnUpdate.Visible = false;

        }
        catch (Exception ex)
        {

            lblError.Text = ex.ToString();
        }


    }

    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            gvEditMarks.DataSource = null;
            gvEditMarks.DataBind();
            btnUpdate.Visible = false;
            if (ddlType.SelectedValue != "-1")
            {

                fillDDLSubjects();
            }
            else
            {
                if (!IsPostBack)
                {
                }
                else
                {

                    ddlSubject.SelectedValue = "-1";

                }
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
        }
    }

    protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            FillgvAward();
            lblSuccess.Visible = false;
            //gvEditMarks.DataSource = null;
            //gvEditMarks.DataBind();
            //gvEditMarks.Visible = false;
            if (ddlSubject.SelectedValue != "-1")
            {
               
            }
            else
            {
                if (!IsPostBack)
                {
                }
                else
                {

                }
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = "No Data";
            gvEditMarks.DataSource = null;
            gvEditMarks.DataBind();
            btnUpdate.Visible = false;

        }


    }
    public void FillgvAward()
    {
        lblError.Text = "";
        MarksBLL mDal = new MarksBLL();
        Marks mModel = new Marks();
        mModel.classID = Convert.ToInt64(ddlClasses.SelectedValue);
        mModel.sectionID = Convert.ToInt64(ddlSection.SelectedValue);
        mModel.unitID = Convert.ToInt64(ddlType.SelectedValue);
        mModel.subjectID = Convert.ToInt64(ddlSubject.SelectedValue);
        List<Marks> lmarks = new List<Marks>();
        lmarks = mDal.getAwardRoll(mModel);
        if (lmarks.Count > 0)
        {
            gvEditMarks.DataSource = lmarks;
            gvEditMarks.DataBind();
            gvEditMarks.DataSource = lmarks;
            gvEditMarks.DataBind();
            btnUpdate.Visible = true;

        }
        else
        {
            lblError.Visible = true;
            lblError.Text = "No Data";
            gvEditMarks.DataSource = lmarks;
            gvEditMarks.DataBind();

        }

    }

    public void gvSubmitData()
    {

        try
        {
            lblError.Text = "";
            List<Marks> newModel = new List<Marks>();
            foreach (GridViewRow dr in gvEditMarks.Rows)
            {
                Label lblRollNo = (Label)dr.FindControl("lblRollNo");
                Label lblStudentName = (Label)dr.FindControl("lblStudentName");
                Label lblStudentId = (Label)dr.FindControl("lblStudentId");
                Label lblMaxId = (Label)dr.FindControl("lblMaxId");
                TextBox txtMarks = (TextBox)dr.FindControl("txtMarks");
               
                Marks marksModel = new Marks();

                marksModel.classID= Convert.ToInt64(ddlClasses.SelectedValue);
                marksModel.sectionID = Convert.ToInt64(ddlSection.SelectedValue);
                marksModel.unitID = Convert.ToInt64(ddlType.SelectedValue);
                marksModel.subjectID = Convert.ToInt64(ddlSubject.SelectedValue);
                marksModel.rollno =Convert.ToInt64(lblRollNo.Text);              
                marksModel.marks =Convert.ToDecimal(txtMarks.Text);
                marksModel.current_Session = Session["Current_Session"].ToString();
                marksModel.sessionID = 0;
                marksModel.studentID =Convert.ToInt64(lblStudentId.Text);
                marksModel.maxID = Convert.ToInt64(lblMaxId.Text);

                newModel.Add(marksModel);

            }
            string message = Mdal.updateMarks(newModel, Convert.ToInt64(ddlClasses.SelectedValue), Convert.ToInt64(ddlSection.SelectedValue), Convert.ToInt64(ddlType.SelectedValue), Convert.ToInt64(ddlSubject.SelectedValue));
            lblSuccess.Visible = true;
            lblSuccess.Text = message;
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
        }

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        gvSubmitData();

    }
}