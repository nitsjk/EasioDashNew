using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.BLL;
using Nits.Model;
using Nits.Common;

public partial class Class_ManageSections : System.Web.UI.Page
{
    ClassBLL Cdal = new ClassBLL();
    SectionBLL Sdal = new SectionBLL();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
                if (!IsPostBack)
                {
                    txtSection.Focus();
                    getClasses();
                }        

        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;
        }
    }

    //Function To Populate DropDown
    public void getClasses()
    {
        string str = "2018-19";
        List<ClassModel> classList = Cdal.getAllClasses(str);
        ddlClasses.DataSource = classList;
        ddlClasses.DataBind();
        ddlClasses.Items.Insert(0, new ListItem("--Select Classes--", "-1"));
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            //  check();
            if (ddlClasses.SelectedIndex > 0)
            {
                addsection();
            }
            else
            {
                //lblClass.Text = "Select Class";
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;
        }
    }

    // Function To Add Section 
    public void addsection()
    {
        try
        {
            Section sec = new Section();
            sec.Classid = Convert.ToInt64(ddlClasses.SelectedValue);
            sec.SectionName = txtSection.Text;
            sec.Current_Session = "2018-19";

            string message = Sdal.AddSection(sec);

            if (message.Contains("successfully"))
            {
                lblSuccess.Text = message;
                lblError.Visible = false;
                lblSuccess.Visible = true;
                //lblClass.Text = "";
                txtSection.Text = "";
                getSections();
            }
            else
            {
                lblError.Text = message;
                lblError.Visible = true;
                lblSuccess.Visible = false;
            }
            //addsection();
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
        try
        {
            reset();

        }
        catch (Exception ex)
        {

            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;
        }

    }

    //Function To Reset Controls
    public void reset()
    {

        try
        {
            //lblSection.Text = "";
            //lblClass.Text = "";
            ddlClasses.ClearSelection();
            txtSection.Text = "";
            lblSuccess.Text = "";
            btnUpdate.Visible = false;
            btnSubmit.Visible = true;

        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;

        }

    }

    protected void ddlClasses_SelectedIndexChanged(object sender, EventArgs e)
    {
        getSections();
    }

    //Function To Populate Grid
    public void getSections()
    {

        try
        {
            long Classid = Convert.ToInt64(ddlClasses.SelectedValue);
            List<Section> classList = Sdal.GetSections(Classid);
            gvSections.DataSource = classList;
            gvSections.DataBind();

        }
        catch (Exception ex)
        {

            lblError.Text = ex.ToString();
            lblError.Visible = true;
            lblSuccess.Visible = false;
        }

    }

    protected void gvSections_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "EditCommand")
        {
            editSection(Convert.ToInt64(e.CommandArgument));
        }
        else if (e.CommandName == "DeleteCommand")
        {
            deleteSection(Convert.ToInt64(e.CommandArgument));
        }

    }

    //function For edit
    public void editSection(long secId)
    {

        Section sec= Sdal.EditSectin(secId);
        Session["sectionID"] = secId;
        ddlClasses.SelectedValue = sec.Classid.ToString();
        txtSection.Text = sec.SectionName;
        btnSubmit.Visible = false;
        btnUpdate.Visible = true;

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            updateSection();
            btnUpdate.Visible = false;
            btnSubmit.Visible = true;
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }
    }

    //Function for updating Section
    public void updateSection()
    {
        try
        {
            Section sec = new Section();
            sec.SectionName = txtSection.Text;
            sec.SectionID = Convert.ToInt64(Session["sectionId"]);
            string message = Sdal.UpdateSection(sec);

            if (message.Contains("successfully"))
            {
                lblSuccess.Text = message;
                lblError.Visible = false;
                lblSuccess.Visible = true;
                txtSection.Text = "";
                ddlClasses.SelectedValue = "-1";
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
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }

    }


    //Function for deleting Section
    public void deleteSection(long secId)
    {
        try
        {
            string message = Sdal.DeleteSection(secId);
            getSections();
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = message;

        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }

    }
}