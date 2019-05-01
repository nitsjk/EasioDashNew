using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.BLL;
using Nits.Common;
using Nits.Model;

public partial class Subject_ManageMarks : System.Web.UI.Page
{
    ResultBLL Rdal = new ResultBLL();
    ClassBLL Cdal = new ClassBLL();

    protected void Page_Load(object sender, EventArgs e)
    {
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
        //long classID = Convert.ToInt64(ddlClasses.SelectedValue);
        List<Nits.Model.Unit> UList = Rdal.getUnits();
        ddlType.DataSource = UList;
        ddlType.DataBind();
        ddlType.Items.Insert(0, new ListItem("--Select Unit--", "-1"));

    }

    public void fillGrid()
    {
        try
        {
            Result reModel = new Result();
            reModel.classid = Convert.ToInt64(ddlClasses.SelectedValue);
            reModel.unitid = Convert.ToInt64(ddlType.SelectedValue);

            List<Result> reList = Rdal.getAllResults(reModel);
            if (reList.Count > 0)
            {
                gvMarks.DataSource = reList;
                gvMarks.DataBind();
                lblSuccess.Text = "";
                lblError.Text = "";
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

    }

    protected void ddlClasses_SelectedIndexChanged(object sender, EventArgs e)
    {
        fillDDLtype();
    }

    
}