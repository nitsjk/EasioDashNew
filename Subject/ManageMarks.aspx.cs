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
    

    public void fillDDLtype()
    {
        
        List<Nits.Model.Unit> UList = Rdal.getUnits();
        ddlType.DataSource = UList;
        ddlType.DataBind();
        ddlType.Items.Insert(0, new ListItem("--Select Unit--", "-1"));

    }

    //public void fillDDLsubject()
    //{
    //    try
    //    {
    //        long Classid = Convert.ToInt64(ddlClasses.SelectedValue);
    //        ExamBLL Edal = new ExamBLL();
    //        List<Exam> examList = Edal.getAllSubjects(Classid);
    //        if (examList.Count > 0)
    //        {
    //            //ddlSubject.DataSource = examList;
    //            //ddlSubject.DataBind();
    //            //ddlSubject.Items.Insert(0, new ListItem("--Select Subject--", "-1"));
    //        }
    //        else
    //        {
    //            lblSuccess.Text = "";
    //            lblError.Text = "No Subjects Found";

    //        }

    //    }
    //    catch (Exception ex)
    //    {

    //        lblError.Text = ex.ToString();
    //        lblError.Visible = true;
    //        lblSuccess.Visible = false;
    //    }


    //}

    public void fillGrid()
    {
        lblError.Text = "";
        gvMarks.DataSource = null;
        gvMarks.DataBind();
        
        try
        {
            Result reModel = new Result();
            reModel.classid = Convert.ToInt64(ddlClasses.SelectedValue);
            reModel.unitid = Convert.ToInt64(ddlType.SelectedValue);
            if (Convert.ToInt64(ddlClasses.SelectedValue) != -1 && Convert.ToInt64(ddlType.Text) != -1)
            {
                List<Result> ds = Rdal.getSomeResults(reModel);
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

                List<Result> re = Rdal.getAllMarks(Convert.ToInt64(ddlClasses.SelectedValue));

                gvSubject.DataSource = examList;
                gvSubject.DataBind();
                btnSubmit.Visible = true;
                //btnResetTextBox.Visible = true;
            }
            else
                gvSubject.DataSource = null;
                gvSubject.DataBind();
                gvMarks.DataSource = null;
                gvMarks.DataBind();
           // btnSubmit.Visible = false;
            //ddlType.Enabled = false;

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

    protected void gvMarks_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
           int RowIndex = ((GridViewRow)(((LinkButton)e.CommandSource).NamingContainer)).RowIndex;
            Label lblMinMarks = (Label) gvMarks.Rows[RowIndex].FindControl("lblMinMarks");
            Label lblMaxMarks = (Label) gvMarks.Rows[RowIndex].FindControl("lblMaxMarks");
            TextBox txtMinMarks = (TextBox) gvMarks.Rows[RowIndex].FindControl("txtMinMarks");
            TextBox txtMaxMarks = (TextBox) gvMarks.Rows[RowIndex].FindControl("txtMaxMarks");
            LinkButton lbtnEdit = (LinkButton)gvMarks.Rows[RowIndex].FindControl("lbtnEdit");
            LinkButton lbtnDelete = (LinkButton)gvMarks.Rows[RowIndex].FindControl("lbtnDelete");
            LinkButton lbtnUpdate = (LinkButton)gvMarks.Rows[RowIndex].FindControl("lbtnUpdate");
            LinkButton lbtnCancel = (LinkButton)gvMarks.Rows[RowIndex].FindControl("lbtnCancel");

            if (e.CommandName == "EditCommand")
            {
                editMarks(Convert.ToInt64(e.CommandArgument));

                lblMinMarks.Visible = false;
                txtMinMarks.Visible = true;
                lblMaxMarks.Visible = false;
                txtMaxMarks.Visible = true;
                lbtnCancel.Visible = true;
                lbtnUpdate.Visible = true;
                lbtnEdit.Visible = false;
                lbtnDelete.Visible = false;
                lblError.Text = "";
                lblSuccess.Text = "";



            }
            else if (e.CommandName == "UpdateCommand")
            {
                lblMinMarks.Visible = true;
                txtMinMarks.Visible = false;
                lblMaxMarks.Visible = true;
                txtMaxMarks.Visible = false;
                lbtnCancel.Visible = false;
                lbtnUpdate.Visible = false;
                lbtnEdit.Visible = true;
                lbtnDelete.Visible = true;
                lblSuccess.Text = "";
                lblError.Text = "";
                decimal minMarks =Convert.ToDecimal(txtMinMarks.Text);
                decimal maxMarks = Convert.ToDecimal(txtMaxMarks.Text);
                updateMinMaxMarks(Convert.ToInt64(e.CommandArgument), minMarks, maxMarks);
            }

            else if (e.CommandName == "DeleteCommand")
            {
                lblMinMarks.Visible = true;
                txtMinMarks.Visible = false;
                lblMaxMarks.Visible = true;
                txtMaxMarks.Visible = false;
                lbtnCancel.Visible = false;
                lbtnUpdate.Visible = false;
                lbtnEdit.Visible = true;
                lbtnDelete.Visible = true;
                lblError.Text = "";
                lblSuccess.Text = "";
                deleteMarks(Convert.ToInt64(e.CommandArgument));
            }
            else if (e.CommandName == "CancelCommand")
            {
                lblMinMarks.Visible = true;
                txtMinMarks.Visible = false;
                lblMaxMarks.Visible = true;
                txtMaxMarks.Visible = false;
                lbtnCancel.Visible = false;
                lbtnUpdate.Visible = false;
                lbtnEdit.Visible = true;
                lbtnDelete.Visible = true;
                lblError.Text = "";
                lblSuccess.Text = "";
                
            } 

        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();

        }

    }

    public void updateMinMaxMarks(long SubId, decimal minMarks, decimal maxMarks)
    {
        lblError.Text = "";
        lblSuccess.Text = "";
        Result reModel = new Result();
        reModel.subjectid = SubId;
        reModel.classid = Convert.ToInt64(ddlClasses.SelectedValue);
        reModel.minMarks = Convert.ToInt64(minMarks);
        reModel.maxMarks = Convert.ToInt64(maxMarks);
        reModel.current_Session = Session["Current_Session"].ToString();
        string message = Rdal.updateMarks(reModel);

        if (message.Contains("successfully"))
        {
            lblSuccess.Text = message;
            lblError.Visible = false;
            lblSuccess.Visible = true;

            fillGrid();
        }
        //btnSubmit.Visible = true;
        //btnUpdate.Visible = false;
        


    }
    
    public void editMarks(long id)
    {


    }

    public void deleteMarks(long id)
    {
        try
        {
            Result reModel = new Result();
            reModel.classid = Convert.ToInt64(ddlClasses.SelectedValue);
            reModel.unitid = Convert.ToInt64(ddlType.SelectedValue);
            reModel.subjectid = id;
            string message=Rdal.deleteMarks(reModel);
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = message;
            ddlType.SelectedIndex = -1;
            ddlClasses.SelectedIndex = -1;

        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }

    }

    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
    {
        fillGrid();
        //fillDDLsubject();
    }

    protected void ddlClasses_SelectedIndexChanged(object sender, EventArgs e)
    {
        fillDDLtype();



            fillGridSubjects();
        
      
           
    }

    protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
    {
        
       // txtMaxMarks.Focus();
    }

    //protected void btnSubmit_Click(object sender, EventArgs e)
    //{
    //    addMinMaxMarks();
    //}

    //public void addMinMaxMarks()
    //{
    //    Result reModel = new Result();
    //    reModel.classid = Convert.ToInt64(ddlClasses.SelectedValue);
    //    reModel.unitid = Convert.ToInt64(ddlType.SelectedValue);
    //    //reModel.minMarks =Convert.ToInt64(txtMinMarks.Text);
    //    //reModel.maxMarks = Convert.ToInt64(txtMaxMarks.Text);

    //    string message = Rdal.addMarks(reModel);
    //    if (message.Contains("Sucessfully"))
    //    {
    //        lblSuccess.Text = message;
    //        lblError.Visible = false;
    //        lblSuccess.Visible = true;
    //        //txtMaxMarks.Text = "";
    //        //txtMinMarks.Focus();
    //    }
    //    else
    //    {
    //        lblError.Text = message;
    //        lblError.Visible = true;
    //        lblSuccess.Visible = false;
    //    }

    //}

    
    public void resetControls()
    {
        ddlClasses.SelectedIndex = -1;
        //ddlSubject.SelectedIndex = -1;
        //ddlSubject.Enabled = false;
        ddlType.SelectedIndex = -1;
        //ddlType.Enabled = false;
        //txtMinMarks.Text = "";
        //txtMaxMarks.Text = "";
        lblError.Text = "";
        lblSuccess.Text = "";
        gvMarks.DataSource = null;
        Response.Redirect(Request.Url.ToString());

    }

    protected void gvSubject_RowCommand(object sender, GridViewCommandEventArgs e)
    {
         deleteMarks(Convert.ToInt64(e.CommandArgument));
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        resetControls();
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {

    }

    protected void btnReset_Click1(object sender, EventArgs e)
    {
        foreach (GridViewRow gv in gvSubject.Rows)
        {
            TextBox box1 = (TextBox)gvSubject.FindControl("txtMaxMarks");


            if (box1.Text == null)
            {
                box1.Text = "";
            }
        }
    }
}