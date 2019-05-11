using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.BLL;
using Nits.Common;
using Nits.Model;
public partial class Result_EditMarksOfIndividualStudent : System.Web.UI.Page
{
    ClassBLL Cdal = new ClassBLL();
    SectionBLL Sdal = new SectionBLL();
    ExamBLL Edal = new ExamBLL();
    ResultBLL Rdal = new ResultBLL();
    MarksBLL Mdal = new MarksBLL();
    OptionalSubjectsBLL ODal = new OptionalSubjectsBLL();
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
    //Fill DropDown Class
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
    //Fill DropDown Section
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
    //Fill DropDown Type
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

    //Fill DropDown Student
    public void fillDDLStudent()
    {

    }

    protected void ddlClasses_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            fillDDLSections();
            ddlType.SelectedValue = "-1";
            ddlSection.SelectedValue = "-1";
            ddlSubject.SelectedValue = "-1";

            //btnSubmit.Visible = false;
            lblError.Text = "";
            lblSuccess.Text = "";
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
            fillDDLStudents();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
        }

    }

    protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            lblSuccess.Text = "";
            lblError.Text = "";
            //ddlSection.SelectedValue = "-1";
            fillDDLtype();
            //btnSubmit.Visible = false;
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = Visible;
        }
    }

    protected void rbtnSubject_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            fillDDLSUbject();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
        }

    }
    //Fill Subject
    public void fillDDLSUbject()
    {
        try
        {
            long classid = Convert.ToInt64(ddlClasses.SelectedValue);
            if (rbtnSubject.SelectedValue == "1")
            {
                List<Exam> exModel = Edal.getAllSubjects(classid);
                ddlSubject.DataSource = exModel;
                ddlSubject.DataBind();
                ddlSubject.Items.Insert(0, new ListItem("--Select Subject--", "-1"));
            }
            else
            {
                List<OptionalSubjects> opModel = ODal.getAllOptionalSubjects(classid);
                ddlSubject.DataSource = opModel;
                ddlSubject.DataBind();
                ddlSubject.Items.Insert(0, new ListItem("--Select Subject--", "-1"));

            }

        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
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
            lblError.Visible = true;
        }
    }


    //Fill Students
    public void fillDDLStudents()
    {
        long classID = Convert.ToInt64(ddlClasses.SelectedValue);
        long sectionID = Convert.ToInt64(ddlSection.SelectedValue);
        List<Student> model = Mdal.getStudents(classID, sectionID);
        if (model.Count > 0)
        {
            ddlStudent.DataSource = model;
            ddlStudent.DataBind();
            ddlStudent.Items.Insert(0, new ListItem("--Select Student--", "-1"));
        }
    }
    protected void ddlStudent_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    //Fill GridView 
    public void fillGrid()
    {
        long sectionId = Convert.ToInt64(ddlSection.SelectedValue);
        long unitId = Convert.ToInt64(ddlType.SelectedValue);
        //long subjectId = Convert.ToInt64(ddlSubject.SelectedValue);
        long type = Convert.ToInt64(ddlType.SelectedValue);
        long studentID = Convert.ToInt64(ddlStudent.SelectedValue);
        List<Award> model = Mdal.getStudentsSubjects(sectionId, unitId, studentID, type);
        if (model.Count > 0)
        {
            gvEditMarks.DataSource = model;
            gvEditMarks.DataBind();
            btnUpdate.Visible = true;

        }
        else
        {
            lblError.Text = "No Data";
            lblError.Visible = true;
        }

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            updateMarks();
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }

    }

    public void updateMarks()
    {

        MarksBLL mDal = new MarksBLL();

        List<Marks> eModel = new List<Marks>();
        foreach (GridViewRow dr in gvEditMarks.Rows)
        {



            Label subjectid = (Label)dr.FindControl("subjectid");
            TextBox txtMarks = (TextBox)dr.FindControl("txtMarks");
            //CheckBox chkBoxAbsent = (CheckBox)dr.FindControl("chkBoxAbsent");

            Marks marksModel = new Marks();

            marksModel.classID = Convert.ToInt64(ddlClasses.SelectedValue);
            marksModel.sectionID = Convert.ToInt64(ddlSection.SelectedValue);
            marksModel.unitID = Convert.ToInt64(ddlType.SelectedValue);
            marksModel.subjectID = Convert.ToInt64(subjectid);
            marksModel.marks = Convert.ToDecimal(txtMarks.Text);
            marksModel.current_Session = Session["Current_Session"].ToString();
            marksModel.studentID = Convert.ToInt64(ddlStudent.SelectedValue);
            //marksModel.marksID = Convert.ToInt64(lblMarksId.Text);
            //    if (chkBoxAbsent.Checked)
            //    {
            //        marksModel.status = 0;
            //    }
            //    else
            //        marksModel.status = 1;
               eModel.Add(marksModel);

        }
        string message = mDal.updateAward(eModel);
            lblSuccess.Visible = true;
            lblSuccess.Text = message;

        
    }
}
