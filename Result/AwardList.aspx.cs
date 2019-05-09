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


    protected void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            btnSubmit.Visible = false;
            FillgvAward();
            lblSuccess.Text = "";
            lblError.Text = "";           
            
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
                ddlType.SelectedValue = "-1";
                ddlSection.SelectedValue = "-1";
                ddlSubject.SelectedValue = "-1";
                gvAddAward.DataSource = null;
                gvAddAward.DataBind();
                btnSubmit.Visible = false;
                lblError.Text = "";
                lblSuccess.Text = "";      
        }
        catch (Exception ex)
        {
            lblError.Text = e.ToString();
        }
    }

    public void getCheckRecord()
    {
        try
        {
            Result re = new Result();
            re.classid = Convert.ToInt64(ddlClasses.SelectedValue);
            re.unitid = Convert.ToInt64(ddlType.SelectedValue);
            re.subjectid = Convert.ToInt64(ddlSubject.SelectedValue);

            Result checkRecord = Mdal.getRecord(re);
            if (checkRecord.classid.ToString() == null)
            {
                lblError.Text = "No Record Found";
                lblError.Visible = true;
            }
            else
            {
                fillDDLSections();
            }


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
            gvAddAward.DataSource = null;
            gvAddAward.DataBind();
            getCheckRecord();
            btnSubmit.Visible = false;
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = Visible;
        }

    }

    public void FillgvAward()
    {

        try
        {
            long classId = Convert.ToInt64(ddlClasses.SelectedValue);
            long SectionId = Convert.ToInt64(ddlSection.SelectedValue);
            long UnitId = Convert.ToInt64(ddlType.SelectedValue);
            long Subjectid = Convert.ToInt64(ddlSubject.SelectedValue);
            long type = Convert.ToInt64(rbtnSubject.SelectedValue);
            List<Award> aModel = Mdal.getAwardRollForAwardList(classId, SectionId, UnitId, Subjectid, type);

            if (aModel.Count > 0)
            {
                foreach (GridViewRow dr in gvAddAward.Rows)
                {
                    CheckBox chkBoxAbsent = (CheckBox)dr.FindControl("chkBoxAbsent");
                    Label lblStatus = (Label)dr.FindControl("lblStatus");

                    if (lblStatus.Text == "0")
                    {
                    }
                    else
                        chkBoxAbsent.Checked = true;

                }
                gvAddAward.DataSource = aModel;
                gvAddAward.DataBind();
                btnSubmit.Visible = true;

            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "No Data";

                gvAddAward.DataBind();

            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }

    }
    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            gvAddAward.DataSource = null;
            gvAddAward.DataBind();
            btnSubmit.Visible = false;
            ddlSubject.SelectedValue = "-1";
            ddlSection.SelectedValue = "-1";
            lblError.Text = "";
            lblSuccess.Text = "";
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
        }

    }

    protected void gvAward_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            addMarks();
            

        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
        }
    }
    public void addMarks()
    {
        MarksBLL mDal = new MarksBLL();

        List<Marks> eModel = new List<Marks>();
        foreach (GridViewRow dr in gvAddAward.Rows)
        {

            Label lblRollNo = (Label)dr.FindControl("lblRollNo");
            Label lblStudentId = (Label)dr.FindControl("lblStudentId");
            Label lblStudentName = (Label)dr.FindControl("lblStudentName");
            TextBox txtMarks = (TextBox)dr.FindControl("txtMarks");
            CheckBox chkBoxAbsent = (CheckBox)dr.FindControl("chkBoxAbsent");
            Marks marksModel = new Marks();

            marksModel.classID = Convert.ToInt64(ddlClasses.SelectedValue);
            marksModel.sectionID = Convert.ToInt64(ddlSection.SelectedValue);
            marksModel.unitID = Convert.ToInt64(ddlType.SelectedValue);
            marksModel.subjectID = Convert.ToInt64(ddlSubject.SelectedValue);
            marksModel.rollno = Convert.ToInt64(lblRollNo.Text);
            marksModel.marks = Convert.ToDecimal(txtMarks.Text);
            marksModel.current_Session = Session["Current_Session"].ToString();
            marksModel.studentID = Convert.ToInt64(lblStudentId.Text);
            if (chkBoxAbsent.Checked)
            {
                marksModel.status = 0;
            }
            else
                marksModel.status = 1;
            eModel.Add(marksModel);

        }
        string message = mDal.addMarks(eModel);
        lblSuccess.Visible = true;
        lblSuccess.Text = message;

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

}