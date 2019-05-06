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
    ExamBLL Edal = new ExamBLL();
    
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
            
        }
        
    }
    //Populate DropDownList
    public void getClasses()
    {
        string str = Session["Current_Session"].ToString();
        List<ClassModel> classList = Cdal.getAllClasses(str);
        ddlClasses.DataSource = classList;
        ddlClasses.DataBind();
        ddlClasses.Items.Insert(0, new ListItem("--Select Classes--", "-1"));
    }

    //Populate Grid
    public void getSubjects()
    {
        try
        {
            long Classid = Convert.ToInt64(ddlClasses.SelectedValue);
             
            List<Exam> examList = Edal.getAllSubjects(Classid);
            if (examList.Count > 0)
            {
                gvSubjects.DataSource = examList;
                gvSubjects.DataBind();
            }
            else {
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

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            addSubject();
            getSubjects();
            txtSubject.Text = "";
            txtSubject.Focus();
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
            Exam ex = new Exam();
            ex.classID = Convert.ToInt64(ddlClasses.SelectedValue);
            ex.subjectName = txtSubject.Text;
            ex.current_Session =Session["Current_Session"].ToString();
            string message = Edal.addSubject(ex);
            if (message.Contains("Sucessfully"))
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
       
    }
    //Reset Controls
    public void reset()
    {
        try
        {
            ddlClasses.SelectedIndex = -1;
            txtSubject.Text = "";
            lblError.Text = "";
            lblSuccess.Text = "";
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
      
        try
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
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();

        }
    }
    //Edit Subject
    public void editSubject(long id)
    {

        try
        {
            ViewState["id"] = id;
            Exam Emodel = new Exam();
            Emodel.subjectID = id;
            Emodel.classID = Convert.ToInt64(ddlClasses.SelectedValue);
            Exam Subject = Edal.editSubject(Emodel);
            ddlClasses.SelectedValue = Subject.classID.ToString();
            txtSubject.Text = Subject.subjectName;
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

    //Update Subject
    public void updateSubject()
    {
        
        try
        {
            Exam eModel = new Exam();
            eModel.subjectName = txtSubject.Text;
            eModel.classID = Convert.ToInt64(ddlClasses.SelectedValue);
            eModel.subjectID = Convert.ToInt64(ViewState["id"]);
            string message = Edal.updateSubject(eModel);
            if (message.Contains("successfully"))
            {
                lblSuccess.Text = message;
                lblError.Visible = false;
                lblSuccess.Visible = true;
                txtSubject.Text = "";
                getSubjects();
            }
            btnSubmit.Visible = true;
            btnUpdate.Visible = false;
            txtSubject.Text = "";
            txtSubject.Focus();
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
            string message = Edal.deleteSubject(id);
            getSubjects();
            lblError.Visible = true;
            lblSuccess.Visible =false;
            lblError.Text = message;
            txtSubject.Text = "";
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
            getSubjects();
            txtSubject.Focus();
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            updateSubject();
            getSubjects();
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }
        

    }
}