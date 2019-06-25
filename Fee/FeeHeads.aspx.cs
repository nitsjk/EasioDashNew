using Nits.BLL;
using Nits.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FeeHeads : System.Web.UI.Page
{
    FeeBLL dal = new FeeBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlFHT.Focus();
            getFeeHeads();
            btnAddFH.ValidationGroup = "var";
        }
    }
    protected void btnAddFH_Click(object sender, EventArgs e)
    {
        try
        {
            FeeModel FeeHead = new FeeModel();
            FeeHead.FHName = txtFHN.Text;
            FeeHead.FHType = ddlFHT.SelectedIndex;
            FeeHead.UserName = Session["UserName"].ToString();
            FeeHead.FRate = 0;
            FeeHead.IsPrimary = 0;

            string ReturnMessage = dal.InsertIntoFeeHead(FeeHead);

            if (ReturnMessage == "Transaction Successful")
            {
                lblError.Visible = false;
                lblSuccess.Visible = true;
                lblSuccess.Text = ReturnMessage;

                getFeeHeads();
                txtFHN.Text = "";
                ddlFHT.SelectedValue = "-1";
            }
            else
            {
                lblError.Visible = true;
                lblSuccess.Visible = false;
                lblError.Text = ReturnMessage;
            }

        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }

    }
    protected void ddlFHT_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtFHN.Focus();
    }
    public void getFeeHeads()
    {
        try
        {
            DataSet ds = dal.getFeeHeads();
            if (ds.Tables[0].Rows.Count > 0)
            {
               
                gvFeeHeads.DataSource = ds;
                gvFeeHeads.DataBind();

            }
            else
            {
                gvFeeHeads.DataSource = null;
                gvFeeHeads.DataBind();
                lblSuccess.Visible = true;
                lblSuccess.Text = "No Data Found!";
            }
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    public void editFeehead(long FHID)
    {
        DataSet ds = dal.editFeehead(FHID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow dr = ds.Tables[0].Rows[0];
            txtFHN.Text = dr["FHName"].ToString();
            ddlFHT.SelectedValue = dr["FHType"].ToString();
            ViewState["FHID"] = dr["FHID"];
        }
        else
        {
            lblSuccess.Visible = false;
            lblError.Visible = true;
            lblError.Text = "No record found";
        }
    }
    public void UpdateFeeHeads()
    {
        try
        {

            FeeModel FM = new FeeModel();
            FM.FHName = txtFHN.Text;
            FM.UpdatedBy = Session["UserName"].ToString();
            FM.UpdatedOn = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            FM.FHID=Convert.ToInt64(ViewState["FHID"]);

            string returnMessage = dal.UpdateFeeHeads(FM);
            if (returnMessage == "Transaction Updated Successful")
            {
                lblError.Visible = false;
                lblSuccess.Visible = true;
                getFeeHeads();
                lblSuccess.Text = returnMessage;
                btnUpdate.Visible = false;
                btnAddFH.Visible = true;
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
    public void DeleteFeeHeads(long id)
    {
        try
        {

            string UpMessage = dal.DeleteFeeHEads(id);
            lblSuccess.Visible = false;
            lblError.Visible = true;
            lblError.Text = UpMessage;
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void gvFeeHeads_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int rowIndex = ((GridViewRow)(((LinkButton)e.CommandSource).NamingContainer)).RowIndex;

           

            if (e.CommandName == "EditCommand")
            {

                editFeehead(Convert.ToInt64(e.CommandArgument));
                btnUpdate.Visible = true;
                btnAddFH.ValidationGroup = null;
                btnUpdate.ValidationGroup = "var";
                btnAddFH.Visible = false;
                txtFHN.Focus();
            }
            else if (e.CommandName == "DeleteCommand")
            {
                long FHID = Convert.ToInt64(e.CommandArgument);
               
               
                DeleteFeeHeads(FHID);
                getFeeHeads();
            }
            
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        UpdateFeeHeads();
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        ddlFHT.SelectedValue = "-1";
        txtFHN.Text = "";
        btnAddFH.Visible = true;
        btnUpdate.Visible = false;
        lblError.Text = "";
        lblSuccess.Text = "";
        lblSuccess.Visible = false;
        lblError.Visible = false;
        btnAddFH.ValidationGroup = "var";
        btnUpdate.ValidationGroup = null;
        ddlFHT.Focus();
    }
}