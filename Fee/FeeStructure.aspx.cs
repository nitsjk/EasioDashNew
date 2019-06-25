using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.Model;
using Nits.BLL;
using System.Data;


public partial class FeeStructure : System.Web.UI.Page
{
    FeeBLL dal = new FeeBLL();
    string classid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlClass.Focus();
            try
            {

                if (Request.QueryString != null)
                {
                    GetFeeHeads();
                    GetAllClasses();

                    ddlFeeheads.SelectedValue = "-1";
                    ddlClass.SelectedValue = "-1";
                    btnAddFeeStructure.ValidationGroup = "val";
                    btnUpdate.ValidationGroup = "null";
                }
                else if (Request.QueryString["Action"].ToString() != null)
                {
                    GetFeeHeads();
                    GetAllClasses();

                    ddlFeeheads.SelectedValue = "-1";
                    ddlClass.SelectedValue = Request.QueryString["Action"].ToString();
                }
            }
            catch (Exception ex)
            {

                lblError.Visible = true;
                lblError.Text = ex.ToString();
            }

        }

    }
    public void GetFeeHeads()
    {
        try
        {

            DataSet ds = dal.GetFeeHeads();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlFeeheads.DataSource = ds;
                ddlFeeheads.DataBind();
                ddlFeeheads.Items.Insert(0, new ListItem("Select Fee Heads", "-1"));
            }
            else
            {
                ddlFeeheads.DataSource = null;
                ddlFeeheads.DataBind();
                lblError.Visible = true;
                lblError.Text="No Data FOund";
            }
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    public void GetAllClasses()
    {
        try
        {
            string CurrentSession = Session["Current_Session"].ToString();
            DataSet ds = dal.getClasses(CurrentSession);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlClass.DataSource = ds;
                ddlClass.DataBind();
                ddlClass.Items.Insert(0, new ListItem("Select Class", "-1"));
            }
            else
            {
                ddlClass.DataSource = null;
                ddlClass.DataBind();
                lblError.Visible = true;
                lblError.Text = "No Data FOund";
            }
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void btnAddFeeStructure_Click(object sender, EventArgs e)
    {
        try
        {
            FeeStructuree fStructure = new FeeStructuree();
            fStructure.CIDFK = Convert.ToInt64(ddlClass.SelectedValue);
            fStructure.FHIDFK = Convert.ToInt64(ddlFeeheads.SelectedValue);
            fStructure.Current_Session = Session["Current_Session"].ToString();
            fStructure.Amount = Convert.ToDecimal(txtAmount.Text);
            fStructure.UserName = Session["UserName"].ToString();
            fStructure.Title = txtTitle.Text;
            fStructure.Remarks = txtRemarks.Text;
            string returnMessage = dal.InsertIntoFeeStructure(fStructure);
            if (returnMessage == "Transaction Updated Successful")
            {
                lblSuccess.Visible = true;
                lblError.Visible = false;
                lblSuccess.Text = returnMessage;

                ddlFeeheads.SelectedValue = "-1";
                txtAmount.Text = "";
                txtTitle.Text = "";
                txtRemarks.Text = "";
                lblError.Text = "";
                GetAllFSBI();
            }
            else
            {
                lblSuccess.Visible = false;
                lblError.Visible = true;
                lblError.Text = returnMessage;
            }

        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }

    }
    public void GetAllFSBI()
    {
        try
        {
            long CID = Convert.ToInt64(ddlClass.SelectedValue);

            DataSet ds = dal.GetAllFeeStructure(CID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                gvFeeStructure.DataSource = ds;
                gvFeeStructure.DataBind();
               
            }
            else
            {
                gvFeeStructure.DataSource = null;
                gvFeeStructure.DataBind();
                lblError.Visible = true;
                lblError.Text =  "No Fee Head Assigned yet!";
            }
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlClass.SelectedValue == "-1")
            {
                ddlFeeheads.SelectedValue = "-1";
                txtAmount.Text = "";
                txtTitle.Text = "";
                txtRemarks.Text = "";
                ddlClass.Focus();
                gvFeeStructure.Visible = false;
            }
            else
            {
                ddlFeeheads.Focus();
                gvFeeStructure.Visible = true;
               
                GetAllFSBI();
            }
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    public void editFeeStucture(long FSID)
    {
        DataSet ds =dal.getFeestructure(FSID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow dr = ds.Tables[0].Rows[0];
            ddlClass.SelectedValue = dr["CIDFK"].ToString();
            ddlFeeheads.SelectedValue = dr["FHIDFK"].ToString();
            txtAmount.Text = dr["Amount"].ToString();
            txtTitle.Text = dr["Title"].ToString();
            txtRemarks.Text = dr["Remarks"].ToString();
        }
        else
        {
            lblError.Visible = true;
            lblSuccess.Visible = true;
            lblError.Text = "No Data Found";
        }
    }
    protected void gvFeeStructure_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int rowIndex = ((GridViewRow)(((LinkButton)e.CommandSource).NamingContainer)).RowIndex;
           
            if (e.CommandName == "EditCommand")
            {
                long ID = Convert.ToInt64(e.CommandArgument);
                ViewState["FSID"] = ID;
                
                btnAddFeeStructure.Visible = false;
                btnUpdate.Visible = true;
                btnUpdate.ValidationGroup = "val";
                btnAddFeeStructure.ValidationGroup = "null";
                editFeeStucture(ID);
                txtAmount.Focus();
            }
            else if (e.CommandName == "DeleteCommand")
            {
                long ID = Convert.ToInt64(e.CommandArgument);
           
                DeleteFeeStructure(ID);
                lblSuccess.Visible = false;
            }
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    public void UpdateFeeStructure(long FSID)
    {
        try
        {

            FeeStructuree FStruct = new FeeStructuree();

            FStruct.Amount = Convert.ToDecimal(txtAmount.Text);
            FStruct.Title = txtTitle.Text;
            FStruct.Remarks = txtRemarks.Text;
            FStruct.UpdatedOn = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            FStruct.Updatedby = Session["UserName"].ToString();
            string returnMessage = dal.UpdateFeeStructure(FSID, FStruct);
            if (returnMessage == "Transaction Updated Successful")
            {
                lblError.Visible = false;
                lblSuccess.Visible = true;
                GetAllFSBI();
                lblSuccess.Text = returnMessage;
                
            }
            else
            {
                lblError.Visible = true;
                lblSuccess.Visible = false;
                lblSuccess.Text = returnMessage;
            }
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    public void DeleteFeeStructure(long ID)
    {
        try
        {
            string message = dal.DeleteFeeStructure(ID);
            lblError.Visible = true;
            lblError.Text = message;
            GetAllFSBI();
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void ddlFeeheads_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlFeeheads.SelectedValue == "-1")
        {
            txtTitle.Text ="";
            ddlFeeheads.Focus();
        }
        else
        {
            txtAmount.Focus();
            txtTitle.Text = ddlFeeheads.SelectedItem.Text;
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        UpdateFeeStructure(Convert.ToInt64(ViewState["FSID"]));
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        ddlClass.SelectedValue = "-1";
        ddlFeeheads.SelectedValue = "-1";
        txtAmount.Text = "";
        txtTitle.Text = "";
        txtRemarks.Text = "";
        btnAddFeeStructure.Visible = true;
        btnUpdate.Visible = false;
        lblError.Text = "";
        lblSuccess.Text = "";
        btnUpdate.ValidationGroup = "null";
        btnAddFeeStructure.ValidationGroup = "val";
        ddlClass.Focus();
    }
}