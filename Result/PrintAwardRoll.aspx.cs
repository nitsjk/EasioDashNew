using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.BLL;
using Nits.Common;
using Nits.Model;


public partial class Result_PrintAwardRoll : System.Web.UI.Page
{
    ClassBLL Cdal = new ClassBLL();
    SectionBLL Sdal = new SectionBLL();
    ExamBLL Edal = new ExamBLL();
    ResultBLL Rdal = new ResultBLL();
    OptionalSubjectsBLL ODal = new OptionalSubjectsBLL();
    MarksBLL Mdal = new MarksBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            pnlAward.Visible = false;
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

    //Fill Labels
    public void getDataForLabels()
    {
        Result reModel = new Result();
        reModel.classid = Convert.ToInt64(ddlClasses.SelectedValue);
        reModel.sectionid = ddlSection.SelectedValue;
        reModel.unitid = Convert.ToInt64(ddlType.SelectedValue);
        reModel.subjectid = Convert.ToInt64(ddlSubject.SelectedValue);

        Result model = Rdal.fillLabels(reModel);
        if (model != null)
        {
            lblMinMarks.Text = model.minMarks.ToString();
            lblMaxMarks.Text = model.maxMarks.ToString();
        }
        else
        {
            lblError.Text = "No Max Marks Assigned";
            lblError.Visible = true;

        }

        

    }
    protected void btnPrint_Click(object sender, EventArgs e)
    {

    }

    protected void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            
            FillgvAward();
            lblSuccess.Text = "";
            //lblError.Text = "";

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
            lblSuccess.Text = "";
            lblError.Text = "";
            fillDDLSections();
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
    gvAddAward.DataSource = null;
            gvAddAward.DataBind();

            
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

    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddlClasses_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            fillDDLtype();
            ddlType.SelectedValue = "-1";
            ddlSection.SelectedValue = "-1";
            ddlSubject.SelectedValue = "-1";
            pnlAward.Visible = false;
            gvAddAward.DataSource = null;
            gvAddAward.DataBind();
            
            lblError.Text = "";
            lblSuccess.Text = "";
        }
        catch (Exception ex)
        {
            lblError.Text = e.ToString();
        }

    }
    public void FillgvAward()
    {

        try
        {
           
            pnlAward.Visible = true;
            getDataForLabels();
            lblClass.Text = ddlClasses.SelectedItem.Text;
            lblSection.Text = ddlSection.SelectedItem.Text;
            lblUnit.Text = ddlType.SelectedItem.Text;
            lblSubject.Text=ddlSubject.SelectedItem.Text;
            long classId = Convert.ToInt64(ddlClasses.SelectedValue);
            long SectionId = Convert.ToInt64(ddlSection.SelectedValue);
            long UnitId = Convert.ToInt64(ddlType.SelectedValue);
            long Subjectid = Convert.ToInt64(ddlSubject.SelectedValue);
            long type = Convert.ToInt64(rbtnSubject.SelectedValue);
            List<Award> aModel = Mdal.getAwardRollForAwardList(classId, SectionId, UnitId, Subjectid, type);

            if (aModel.Count > 0)
            {
                lblError.Text = "";
                gvAddAward.DataSource = aModel;
                gvAddAward.DataBind();
                Session["Ctrl"] = pnlAward;
              

            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "No Data";

            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = "No Max Marks Assigned";
            pnlAward.Visible = false;
        }

    }
}