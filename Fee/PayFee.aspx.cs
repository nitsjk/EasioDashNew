using Nits.BLL;
using Nits.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class PayFee : System.Web.UI.Page
{
    PayFeeBLL PFdal = new PayFeeBLL();
    FeeBLL dal = new FeeBLL();
    SFeeDue Fddal = new SFeeDue();
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Current_Session"] = "2018-19";
        if (!IsPostBack)
        {
            Session["Current_Session"] = "2018-19";
            multiview1.SetActiveView(view1);
            txtSS.Focus();
            btnSS.ValidationGroup = "var";
        }
    }
    protected void ddlStType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlStType.SelectedValue == "-1")
        {
            Classesdiv.Visible = false;
            SectionsDiv.Visible = false;
            NameDiv.Visible = false;
            textboxdiv.Visible = true;
            txtSS.Text = ""; ;
            ddlCLasses.SelectedValue = "-1";
            ddlSection.SelectedValue = "-1";
            gvSearchResult.DataSource = null;
            gvSearchResult.DataBind();
        }
        else if (ddlStType.SelectedValue == "5")
        {
            Classes();
            Classesdiv.Visible = true;
            SectionsDiv.Visible = true;
            NameDiv.Visible = true;
            NameDiv.Visible = true;
            textboxdiv.Visible = false;
            txtSS.Text = "";
            gvSearchResult.DataSource = null;
            gvSearchResult.DataBind();
        }
        else
        {
            Classesdiv.Visible = false;
            SectionsDiv.Visible = false;
            NameDiv.Visible = false;
            textboxdiv.Visible = true;
            txtSS.Text = "";
            ddlCLasses.SelectedValue = "-1";
            ddlSection.SelectedValue = "-1";
            gvSearchResult.DataSource = null;
            gvSearchResult.DataBind();
        }
    }
    public void Classes()
    {
        try
        {
            Feedue cfd = new Feedue();
            cfd.CSession = Session["Current_Session"].ToString();
            DataSet ds = Fddal.classes(cfd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlCLasses.DataSource = ds;
                ddlCLasses.DataBind();
                ddlCLasses.Items.Insert(0, new ListItem("Select Section", "-1"));
                Session["ClassID"] = ddlCLasses.SelectedValue;
                ddlCLasses.Focus();
            }
            else
            {
                ddlCLasses.DataSource = null;
                ddlCLasses.DataBind();
                ddlCLasses.Items.Insert(0, new ListItem("No Section Found", "-1"));
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void ddlCLasses_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            Session["ClassiD"] = ddlCLasses.SelectedValue;
            Feedue sfd = new Feedue();
            sfd.CID = Convert.ToInt64(ddlCLasses.SelectedValue);
            DataSet ds = Fddal.Sections(sfd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlSection.DataSource = ds;
                ddlSection.DataBind();
                ddlSection.Items.Insert(0, new ListItem("Select Section", "-1"));
                ddlSection.Focus();
            }
            else
            {
                ddlSection.DataSource = null;
                ddlSection.DataBind();
                ddlSection.Items.Insert(0, new ListItem("No Section Found", "-1"));
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    public void SearchStudent()
    {
        try
        {
            SearchStudent SS = new SearchStudent();

            if (ddlStType.SelectedValue == "1")
            {
                if (string.IsNullOrEmpty(txtSS.Text))
                {
                    lblError.Visible = true;
                    lblSuccess.Visible = false;
                    lblError.Text = "Enter Student ID";
                }
                else
                {
                    gvSearchResult.DataSource = null;
                    gvSearchResult.DataBind();


                    SS.sCode = Convert.ToInt64(txtSS.Text);
                    SS.Current_Session = Session["Current_Session"].ToString();
                    SS.Check = 4;
                    DataSet ds = dal.searchStudent(SS);
                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        DataRow dr = ds.Tables[0].Rows[0];
                        txtname.Text = dr["StudentName"].ToString();
                        txtParentage.Text = dr["FathersName"].ToString();
                        txtRollNo.Text = dr["RollNo"].ToString();
                        txtClass.Text = dr["ClassName"].ToString();
                        txtSection.Text = dr["SectionName"].ToString();
                        txtUID.Text = dr["StudentCode"].ToString();
                        gvSearchResult.DataSource = ds;
                        gvSearchResult.DataBind();
                        txtSS.Text = "";
                        lblError.Visible = false;
                        lblSuccess.Visible = false;

                    }
                    else
                    {

                        gvSearchResult.DataSource = null;
                        gvSearchResult.DataBind();
                        lblError.Visible = true;
                        lblSuccess.Visible = false;
                        lblError.Text = "No Record Found";
                    }
                }
            }
            else if (ddlStType.SelectedValue == "2")
            {
                if (string.IsNullOrEmpty(txtSS.Text))
                {
                    lblError.Visible = true;
                    lblSuccess.Visible = false;
                    lblError.Text = "Enter Admissin No. ";
                }
                else
                {
                    gvSearchResult.DataSource = null;
                    gvSearchResult.DataBind();

                    SS.AdminNo = Convert.ToInt64(txtSS.Text);
                    SS.Current_Session = Session["Current_Session"].ToString();
                    SS.Check = Convert.ToInt32(ddlStType.SelectedValue);
                    DataSet ds = dal.searchStudent(SS);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = ds.Tables[0].Rows[0];
                        txtname.Text = dr["StudentName"].ToString();
                        txtParentage.Text = dr["FathersName"].ToString();
                        txtRollNo.Text = dr["RollNo"].ToString();
                        txtClass.Text = dr["ClassName"].ToString();
                        txtSection.Text = dr["SectionName"].ToString();
                        txtUID.Text = dr["StudentCode"].ToString();
                        gvSearchResult.DataSource = ds;
                        gvSearchResult.DataBind();
                        txtSS.Text = "";
                        lblError.Visible = false;
                        lblSuccess.Visible = false;
                    }
                    else
                    {
                        gvSearchResult.DataSource = null;
                        gvSearchResult.DataBind();
                        lblError.Visible = true;
                        lblSuccess.Visible = false;
                        lblError.Text = "No Record Found";
                    }
                }
            }
            else if (ddlStType.SelectedValue == "3")
            {
                if (string.IsNullOrEmpty(txtSS.Text))
                {
                    lblError.Visible = true;
                    lblSuccess.Visible = false;
                    lblError.Text = "Enter Student Name";
                }
                else
                {
                    gvSearchResult.DataSource = null;
                    gvSearchResult.DataBind();

                    SS.SName = txtSS.Text;
                    SS.Current_Session = Session["Current_Session"].ToString();
                    SS.Check = Convert.ToInt32(ddlStType.SelectedValue);
                    DataSet ds = dal.searchStudent(SS);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = ds.Tables[0].Rows[0];
                        txtname.Text = dr["StudentName"].ToString();
                        txtParentage.Text = dr["FathersName"].ToString();
                        txtRollNo.Text = dr["RollNo"].ToString();
                        txtClass.Text = dr["ClassName"].ToString();
                        txtSection.Text = dr["SectionName"].ToString();
                        txtUID.Text = dr["StudentCode"].ToString();
                        gvSearchResult.DataSource = ds;
                        gvSearchResult.DataBind();
                        txtSS.Text = "";
                        lblError.Visible = false;
                        lblSuccess.Visible = false;

                    }
                    else
                    {

                        gvSearchResult.DataSource = null;
                        gvSearchResult.DataBind();
                        lblError.Visible = true;
                        lblSuccess.Visible = false;
                        lblError.Text = "No Record Found";
                    }
                }
            }
            else if (ddlStType.SelectedValue == "5")
            {
                if (ddlStType.SelectedValue == "-1")
                {
                    lblError.Visible = true;
                    lblSuccess.Visible = false;
                    lblError.Text = "Enter Student Name";
                }
                else
                {
                    gvSearchResult.DataSource = null;
                    gvSearchResult.DataBind();

                    SS.sCode = Convert.ToInt64(ddlStudent.SelectedValue);
                    SS.Current_Session = Session["Current_Session"].ToString();
                    SS.Check = 4;
                    DataSet ds = dal.searchStudent(SS);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = ds.Tables[0].Rows[0];
                        txtname.Text = dr["StudentName"].ToString();
                        txtParentage.Text = dr["FathersName"].ToString();
                        txtRollNo.Text = dr["RollNo"].ToString();
                        txtClass.Text = dr["ClassName"].ToString();
                        txtSection.Text = dr["SectionName"].ToString();
                        txtUID.Text = dr["StudentCode"].ToString();
                        gvSearchResult.DataSource = ds;
                        gvSearchResult.DataBind();
                        txtSS.Text = "";
                        lblError.Visible = false;
                        lblSuccess.Visible = false;
                    }
                    else
                    {
                        gvSearchResult.DataSource = null;
                        gvSearchResult.DataBind();
                        lblError.Visible = true;
                        lblSuccess.Visible = false;
                        lblError.Text = "No Record Found";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void btnSS_Click(object sender, EventArgs e)
    {
        SearchStudent();
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        ddlStType.SelectedValue = "-1";
        txtSS.Text = "";
        btnSS.Visible = true;
        ddlStudent.SelectedValue = "-1";
        ddlCLasses.SelectedValue = "-1";
        ddlSection.SelectedValue = "-1";
        gvSearchResult.DataSource = null;
        gvSearchResult.DataBind();
        if (ddlStType.SelectedValue == "-1")
        {
            btnSS.Visible = true;
            Classesdiv.Visible = false;
            NameDiv.Visible = false;
            SectionsDiv.Visible = false;
            textboxdiv.Visible = true;
            txtSS.Text = ""; ;

        }
        else if (ddlStType.SelectedValue == "5")
        {
            Classes();
            Classesdiv.Visible = true;
            SectionsDiv.Visible = true;
            NameDiv.Visible = true;
            textboxdiv.Visible = false;
            txtSS.Text = "";
            btnSS.Visible = false;

        }
        else
        {
            Classesdiv.Visible = false;
            SectionsDiv.Visible = false;
            NameDiv.Visible = false;
            textboxdiv.Visible = true;
            txtSS.Text = "";
            btnSS.Visible = true;
        }
        ddlStType.Focus();
    }
    protected void gvSearchResult_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "DueFee")
            {
                string[] ids = e.CommandArgument.ToString().Split(',');

                Session["UID"] = Session["SCode"] = Convert.ToInt64(ids[0]); //Student ID
                Session["ClassID"] = Convert.ToInt64(ids[1]); // Class ID
                if (string.IsNullOrEmpty(ids[2]))
                {
                    Session["BussStopId"] = 0;
                }
                else
                {
                    Session["BussStopId"] = Convert.ToInt64(ids[2]);
                }
                GetSessionMonths();
                multiview1.SetActiveView(view2);
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["Sectionid"] = ddlSection.SelectedValue;

        Feedue sfd = new Feedue();
        sfd.CID = Convert.ToInt64(ddlCLasses.SelectedValue);
        sfd.SecID = Convert.ToInt64(ddlSection.SelectedValue);
        DataSet ds = Fddal.gStudent(sfd);
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlStudent.DataSource = ds;
            ddlStudent.DataBind();
            ddlStudent.Items.Insert(0, new ListItem("Select Student", "-1"));
            ddlStudent.Focus();
        }
        else
        {
            ddlStudent.DataSource = null;
            ddlStudent.DataBind();
            ddlStudent.Items.Insert(0, new ListItem("No Student Found", "-1"));
        }
    }
    public void GetSessionMonths()
    {
        try
        {
            DataSet ds = dal.getSessionMonths();
            if (ds.Tables[0].Rows.Count > 0)
            {
                chklMonths.DataSource = ds;
                chklMonths.DataBind();
                chklMonths.Items.Insert(0, new ListItem("Annual Fee", "Annual Fee"));
                chklMonths.AutoPostBack = true;

            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void gvFeeDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            decimal deletedRate = 0;
            int index = Convert.ToInt32(e.RowIndex);

            DataTable dt = (DataTable)Session["DataTable"];
            if (dt != null && dt.Rows.Count > 0)
            {
                deletedRate = Convert.ToDecimal(dt.Rows[index]["Paid"]);
                dt.Rows[index].Delete();

            }
            gvFeeDetails.DataSource = dt;
            gvFeeDetails.DataBind();
            Session["DataTable"] = dt;
            txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) - deletedRate).ToString();
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void rdbPayMode_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            if (rdbPayMode.SelectedValue == "1")
            {
                refnodiv.Visible = true;
                carddiv.Visible = false;
                chequenodiv.Visible = false;
                chequedatediv.Visible = false;
                txtTotal.Text = Session["txtFee"].ToString();
                // ChangeFeeRate();
            }
            else if (rdbPayMode.SelectedValue == "2")
            {
                carddiv.Visible = true;
                refnodiv.Visible = true;
                BankNamediv.Visible = false;
                chequenodiv.Visible = false;
                chequedatediv.Visible = false;
                txtTotal.Text = Session["txtFee"].ToString();
                //  ChangeFeeRate();
            }
            else if (rdbPayMode.SelectedValue == "3")
            {
                chequenodiv.Visible = true;
                chequedatediv.Visible = true;
                BankNamediv.Visible = true;
                carddiv.Visible = false;
                refnodiv.Visible = false;
                BankNamediv.Visible = false;
                txtTotal.Text = Session["txtFee"].ToString();
                //  ChangeFeeRate();
            }
            else if (rdbPayMode.SelectedValue == "4")
            {
                refnodiv.Visible = true;
                BankNamediv.Visible = true;
                carddiv.Visible = false;
                chequenodiv.Visible = false;
                chequedatediv.Visible = false;
                txtTotal.Text = Session["txtFee"].ToString();
                //   ChangeFeeRate();
            }

        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    public void AddAnnualFeeInMonths(long UID)
    {
        DataSet ds = PFdal.AnnualMonthByUID(UID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow dr = ds.Tables[0].Rows[0];
            //chkMonths.DataTextFormatString = dr["FeeMonth"].ToString();
            //chkMonths.DataTextFormatString = "0";
            chklMonths.Items.Insert(0, new ListItem(dr["FeeMonth"].ToString(), "-1"));
        }
    }
    public void monthListStatusByUID(long UID)
    {
        try
        {

            DataSet ds = PFdal.monthListStatusByUID(UID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                chklMonths.DataSource = ds;
                chklMonths.DataBind();
                AddAnnualFeeInMonths(UID);
            }
            else
            {
                AddAnnualFeeInMonths(UID);
                lblError.Visible = true;
                lblError.Text = " Fee Cleared";
            }
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void txtTotal_TextChanged(object sender, EventArgs e)
    {
        try
        {
            // btncalc.Enabled = true;
            //btnPay.Enabled = false;
            txtBalance.Text = "0";
            txtAdvance.Text = "0";
            Session["txtFee"] = txtTotal.Text;
            monthListStatusByUID(Convert.ToInt64(Session["UID"]));
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    public void getFeeOnMonths()
    {
        try
        {
            decimal Advance = 0;
            gvFeeDetails.DataSource = null;
            gvFeeDetails.DataBind();


            string monthname = "";
            int count = 0;
            PayFeeModel pf = new PayFeeModel();
            pf.UID = Convert.ToInt64(Session["UID"]);
            pf.Current_Session = Session["Current_Session"].ToString();
            foreach (ListItem item in chklMonths.Items)
            {
                if (item.Selected)
                {
                    monthname = monthname + item.Text.ToString() + ",";
                    count++;
                }
            }
            if (count > 0)
            {

                pf.MonthName = monthname.Substring(0, monthname.Length - 1);

                DataSet ds = PFdal.getFeeOnMonths(pf);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("SFHLID", typeof(long));
                    dt.Columns.Add("FeeHeadName", typeof(string));
                    dt.Columns.Add("MonthName", typeof(string));
                    dt.Columns.Add("Current_Session", typeof(string));
                    dt.Columns.Add("FeeRate", typeof(decimal));
                    dt.Columns.Add("Rebate", typeof(decimal));
                    dt.Columns.Add("FeeAdvance", typeof(decimal));
                    dt.Columns.Add("FeeDiscount", typeof(decimal));
                    dt.Columns.Add("LateFee", typeof(decimal));
                    dt.Columns.Add("Previous", typeof(decimal));
                    dt.Columns.Add("Payable", typeof(decimal));
                    dt.Columns.Add("Paid", typeof(decimal));
                    dt.Columns.Add("FHID", typeof(long));
                    dt.Columns.Add("Remarks", typeof(string));
                    dt.Columns.Add("AdvanceTotal", typeof(decimal));


                    //decimal advance = Convert.ToDecimal(ds.Tables[0].Rows[0]["FeeAdvance"].ToString());
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        DataRow dtrow = dt.NewRow();
                        dtrow["SFHLID"] = dr["SFHLID"].ToString();
                        dtrow["FeeHeadName"] = dr["FeeHeadName"].ToString();
                        dtrow["MonthName"] = dr["MonthName"].ToString();
                        dtrow["Current_Session"] = dr["Current_Session"].ToString();
                        dtrow["FeeRate"] = Convert.ToDecimal(dr["FeeRate"]);
                        dtrow["Rebate"] = Convert.ToDecimal(dr["Rebate"]);
                        dtrow["FeeAdvance"] = Convert.ToDecimal(dr["FeeAdvance"]);
                        dtrow["FeeDiscount"] = Convert.ToDecimal(dr["FeeDiscount"]);
                        dtrow["Previous"] = Convert.ToDecimal(dr["Previous"]);
                        dtrow["LateFee"] = 0.0;
                        dtrow["Payable"] = Convert.ToDecimal(dr["Payable"]);
                        dtrow["Paid"] = Convert.ToDecimal(dr["Paid"]);
                        dtrow["FHID"] = Convert.ToDecimal(dr["FHID"]);
                        dtrow["Remarks"] = dr["Remarks"].ToString();
                        dtrow["AdvanceTotal"] = dr["AdvanceTotal"].ToString();
                        /// txtTotal.Text = dr["Paid"].ToString();

                        dt.Rows.Add(dtrow);
                    }

                    decimal FeeRate = 0, Rebate = 0, FeeAdvance = 0, FeeDiscount = 0, Previous = 0, LateFee = 0, Payable = 0, paid = 0;

                    foreach (DataRow dr in dt.Rows)
                    {
                        FeeRate = FeeRate + Convert.ToDecimal(dr["FeeRate"].ToString());
                        Rebate = Rebate + Convert.ToDecimal(dr["Rebate"].ToString());
                        FeeAdvance = FeeAdvance + Convert.ToDecimal(dr["FeeAdvance"].ToString());
                        FeeDiscount = FeeDiscount + Convert.ToDecimal(dr["FeeDiscount"].ToString());
                        Previous = Previous + Convert.ToDecimal(dr["Previous"].ToString());
                        LateFee = LateFee;
                        Payable = Payable + Convert.ToDecimal(dr["Payable"].ToString());
                        paid = paid + Convert.ToDecimal(dr["Paid"].ToString());
                    }
                    if (FeeAdvance == Payable || FeeAdvance > paid)
                    {
                        txtTotal.Enabled = true;
                        //btncalc.Enabled = true;
                        //btnPay.Enabled = false;
                        //btnPByAdvance.Enabled = true;
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow row = ds.Tables[0].Rows[0];
                            txtTotal.Text = row["AdvanceTotal"].ToString();
                        }
                    }
                    Session["Payable"] = Payable.ToString();
                    Session["Paid"] = paid.ToString();
                    Session["DataTable"] = dt;
                    gvFeeDetails.DataSource = dt;
                    gvFeeDetails.DataBind();
                    gvFeeDetails.FooterRow.Cells[4].Text = FeeRate.ToString();
                    gvFeeDetails.FooterRow.Cells[5].Text = Rebate.ToString();
                    gvFeeDetails.FooterRow.Cells[6].Text = FeeAdvance.ToString();
                    gvFeeDetails.FooterRow.Cells[7].Text = FeeDiscount.ToString();
                    gvFeeDetails.FooterRow.Cells[8].Text = Previous.ToString();
                    gvFeeDetails.FooterRow.Cells[9].Text = Previous.ToString();
                    gvFeeDetails.FooterRow.Cells[10].Text = Payable.ToString();
                    gvFeeDetails.FooterRow.Cells[11].Text = paid.ToString();

                    txtTotal.Text = paid.ToString();
                    //btndiv.Visible = true;
                    Paydiv.Visible = true;
                    lblError.Visible = false;
                    //   lblMessage.Visible = false;
                }
                else
                {
                    gvFeeDetails.DataSource = ds;
                    gvFeeDetails.DataBind();
                    // txtTotal.Text = lblTotal.InnerText;
                    lblError.Visible = true;
                    // btndiv.Visible = false;
                    Paydiv.Visible = false;
                    lblError.Text = "Fee Clear / Not Assigned";
                }
            }
            else
            {
                lblError.Visible = true;
                lblSuccess.Visible = false;
                lblError.Text = "Please select Month";
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void chkMonths_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlStType.SelectedValue == "1" || ddlStType.SelectedValue == "2" || ddlStType.SelectedValue == "3")
            {
                getFeeOnMonths();
            }
            txtTotal.Focus();
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
}