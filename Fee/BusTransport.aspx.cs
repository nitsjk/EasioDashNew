using Nits.BLL;
using Nits.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Fee_BusTransport : System.Web.UI.Page
{
    FeeBLL dal = new FeeBLL();
    SFeeDue Fddal = new SFeeDue();
    MagangeTransFee MTFdal = new MagangeTransFee();
    EditReceiptBLL EFdal = new EditReceiptBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Current_Session"] = "2018-19";
        if (!IsPostBack)
        {
            Session["Current_Session"] = "2018-19";
            multiview1.SetActiveView(view1);
            txtSS.Focus();
            //btnSS.ValidationGroup = "var";

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
                ddlCLasses.Items.Insert(0, new ListItem("Select Class", "-1"));
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
    //public void StudentInfoByUID()
    //{
    //    try
    //    {

    //        FeeBLL dal = new FeeBLL();
    //        SearchStudent SS = new SearchStudent();
    //        if (rdbsearch.SelectedValue == "1")
    //        {
    //            if (string.IsNullOrEmpty(txtUID.Text))
    //            {
    //                lblError.Visible = true;
    //                lblMessage.Visible = false;
    //                lblError.Text = "Enter the UID ";
    //            }
    //            else
    //            {
    //                SS.sCode = Convert.ToInt64(txtUID.Text);
    //                SS.Current_Session = Session["Current_Session"].ToString();
    //                SS.Check = 4;
    //                DataSet ds = dal.searchStudent(SS);
    //                if (ds.Tables[0].Rows.Count > 0)

    //                {
    //                    ViewState["StudentDetail"] = ds;
    //                    lblError.Visible = false;
    //                    lblMessage.Visible = false;
    //                    gvSearchResult.DataSource = ds;
    //                    gvSearchResult.DataBind();
    //                }
    //                else
    //                {
    //                    gvSearchResult.DataSource = null;
    //                    gvSearchResult.DataBind();
    //                    lblError.Visible = true;
    //                    lblMessage.Visible = false;
    //                    lblError.Text = "No student Found !.";
    //                }
    //            }
    //        }

    //    }
    //    catch (Exception ex)
    //    {

    //        lblError.Visible = true;
    //        lblError.Text = ex.ToString();
    //    }

    //}
    protected void ddlBuss_SelectedIndexChanged(object sender, EventArgs e)
    {

        try
        {
            getBussStops();
            txtRate.Text = "0";
        }
        catch (Exception ex)
        {
            //lblMessage.Visible = false;
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }

    protected void ddlBussStop_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            long Sid = Convert.ToInt64(ddlBuss.SelectedValue);
            long Rid = Convert.ToInt64(ddlBussStop.SelectedValue);
            getRateByRoute(Rid, Sid);
        }
        catch (Exception ex)
        {
            //lblMessage.Visible = false;
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void chkAll_CheckedChanged(object sender, EventArgs e)
    {
        string SFHLID = null, SFHLID2 = null;

        CheckBox chkAll = (CheckBox)gvTF.HeaderRow.FindControl("chkAll");
        foreach (GridViewRow row in gvTF.Rows)
        {
            CheckBox ItemCHeck = (CheckBox)row.FindControl("ItemCHeck");
            Label lbl = (Label)row.FindControl("lbl");
            if (chkAll.Checked)
            {
                ItemCHeck.Checked = true;
                SFHLID = SFHLID + lbl.Text + ",";
            }
            else
            {
                ItemCHeck.Checked = false;
            }
        }
        //ApplicableSelected(SFHLID);

    }
    public void Applicable(long SFHLID, bool Active)
    {
        string rs = MTFdal.applicable(SFHLID, Active);
        if (rs == "1")
        {
         //   lblMessage.Visible = true;
            lblError.Visible = false;
            lblSuccess.Text = "successfully Updated";
        }
        else if (rs == "0")
        {
           // lblMessage.Visible = false;
            lblError.Visible = true;
            lblError.Text = "Fee already Paid/pleaese try again later";
        }
        else
        {
            //lblMessage.Visible = false;
            lblError.Visible = true;
            lblError.Text = rs;
        }
    }

    protected void gvTF_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ActiveCommand")
        {
            long SFHLID = Convert.ToInt64(e.CommandArgument);
            Applicable(SFHLID, false);
            getTransportFee(Convert.ToInt64(Session["UID"]));
        }
        else if (e.CommandName == "BlockCommaned")
        {
            long SFHLID = Convert.ToInt64(e.CommandArgument);
            Applicable(SFHLID, true);
            getTransportFee(Convert.ToInt64(Session["UID"]));
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
                        ViewState["StudentDetail"] = ds;
                        DataRow dr = ds.Tables[0].Rows[0];
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
                        ViewState["StudentDetail"] = ds;
                        DataRow dr = ds.Tables[0].Rows[0];
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
                        ViewState["StudentDetail"] = ds;
                        DataRow dr = ds.Tables[0].Rows[0];
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
                        ViewState["StudentDetail"] = ds;
                        DataRow dr = ds.Tables[0].Rows[0];
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
        }
        else
        {
            ddlStudent.DataSource = null;
            ddlStudent.DataBind();
            ddlStudent.Items.Insert(0, new ListItem("No Student Found", "-1"));
        }
    }
    public void getBusses()
    {
        DataSet ds = MTFdal.getAllBUsses(Session["Current_Session"].ToString());
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlBuss.DataSource = ds;
            ddlBuss.DataBind();
            ddlBuss.Items.Insert(0, new ListItem("Select Buss", "-1"));
        }

    }
    public void getBussStops()
    {
        long BSID = Convert.ToInt64(ddlBuss.SelectedValue);
        DataSet ds = MTFdal.getAllBUssStops(BSID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlBussStop.DataSource = ds;
            ddlBussStop.DataBind();
            ddlBussStop.Items.Insert(0, new ListItem("Select Buss Stop", "-1"));
        }

    }
    public void getTransportFee(long UID)
    {
        DataSet ds = MTFdal.allTransFee(UID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            gvTF.DataSource = ds;
            gvTF.DataBind();
        }
        else
        {
            gvTF.DataSource = null;
            gvTF.DataBind();
           // FeePannel.Visible = false;
           // btnSubmit.Visible = false;
            lblError.Text = "No Transport Fee Assigned yet!";
            lblError.Visible = true;
        }
    }

    public void getRateByRoute(long BussID, long RouteID)
    {
        DataSet ds = MTFdal.getAllBUssStops(BussID, RouteID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow dr = ds.Tables[0].Rows[0];
            if (string.IsNullOrEmpty(dr["BusRate"].ToString()))
            {
                txtRate.Text = "0";
            }
            else
            {
                txtRate.Text = dr["BusRate"].ToString();
            }
        }
        else
        {
            txtRate.Text = "0";
        }

    }
    protected void gvSearchResult_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "ViewFee")
            {
               
                string[] agr = null;
                long UID = 0, RouteID = 0, StopID = 0;
                agr = e.CommandArgument.ToString().Split(',');

                Session["UID"] = UID = Convert.ToInt64(agr[0]);
                getTransportFee(UID);
                if (agr[1].ToString() != null)
                {
                    if (agr[2].ToString() != null)
                    {
                        RouteID = Convert.ToInt64(agr[1]);
                        StopID = Convert.ToInt64(agr[2]);
                        getBusses();
                        ddlBuss.SelectedValue = RouteID.ToString();
                        getBussStops();
                        ddlBussStop.SelectedValue = StopID.ToString();
                        getRateByRoute(StopID, RouteID);
                        multiview1.SetActiveView(View2);
                       
                       // FeePannel.Visible = true;
                    }
                    else
                    {
                        getBusses();
                        getBussStops();
                      
                        //FeePannel.Visible = true;
                    }
                }
                else
                {
                    if (agr[2].ToString() != null)
                    {
                        RouteID = Convert.ToInt64(agr[1]);
                        StopID = Convert.ToInt64(agr[2]);
                        getBusses();
                        ddlBuss.SelectedValue = RouteID.ToString();
                        getBussStops();
                        ddlBussStop.SelectedValue = StopID.ToString();
                        getRateByRoute(StopID, RouteID);
                       
                         // FeePannel.Visible = true;
                    }
                    else
                    {
                        getBusses();
                        getBussStops();
                        
                     //   FeePannel.Visible = true;
                    }
                }
                ddlBuss.SelectedValue = RouteID.ToString();
                getBussStops();
                ddlBussStop.SelectedValue = StopID.ToString();
                getRateByRoute(StopID, RouteID);
               
               //  FeePannel.Visible = true;
            }
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    public void UpdateFeeRate(long SFHLID, Decimal Feerate)
    {
        string returnString = MTFdal.UpdateFeerate(SFHLID, Feerate);
        if (returnString == "1")
        {

           // lblMessage.Visible = true;
            lblError.Visible = false;
            lblSuccess.Text = "Successfully Updated";
        }
        else if (returnString == "0")
        {

            lblError.Visible = true;
           // lblMessage.Visible = false;
            lblError.Text = "transection failed to update";
        }
        else
        {
            lblError.Visible = true;
         //   lblMessage.Visible = false;
            lblError.Text = returnString;
        }
    }
    public int getSessionMonths(int date)
    {

        int Month = MTFdal.getcurrentMonths(date);
        return Month;

    }
    public DataSet FeeDueDetails(long UID, string Csession, int SMID)
    {
        DataSet ds = null;
        if (ddlcurrentsession.SelectedValue == "1")
        {
            ds = MTFdal.getFDueDetailsOfAllSession(UID, Csession, SMID);


        }
        else if (ddlcurrentsession.SelectedValue == "2")
        {
            ds = MTFdal.getFDueDetailsFromCurrentMonth(UID, Csession, SMID);

        }
        return ds;
    }

    protected void UpdateStudentFeeHeads()
    {
        try
        {
            decimal FeeRate = 0;
            decimal Rebate = 0;
            if (ddlBussStop.SelectedIndex == 0)
            {
                FeeRate = 0;
            }
            else
            {
                /// FeeRate = getrate(Convert.ToInt64(ddlBussStop.SelectedValue));
                FeeRate = Convert.ToDecimal(txtRate.Text);
            }

            int SMID = getSessionMonths(DateTime.Now.Month);

            //for Transport UPDATE MONTHS WHICH ARE UNPAID CURRENT MONTH PLUS NEXT UNPAID
            DataSet dsFeeMonths = FeeDueDetails(Convert.ToInt64(Session["UID"]), Session["Current_Session"].ToString(), SMID);
            if (dsFeeMonths.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow drfeemonth in dsFeeMonths.Tables[0].Rows)
                {
                    UpdateFeeRate(Convert.ToInt64(drfeemonth["SFHLID"].ToString()), FeeRate);
                }
            }
        }
        catch (Exception ex)
        {
            //lblMessage.Visible = false;
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    public void UpdateBuss()
    {
        long Sid = Convert.ToInt64(ddlBuss.SelectedValue);
        long Rid = Convert.ToInt64(ddlBussStop.SelectedValue);
        long UID = Convert.ToInt64(Session["UID"]);
        string CSession = Session["Current_Session"].ToString();
        string rs = MTFdal.UpdateBuss(Rid, Sid, UID, CSession);
        if (rs == "1")
        {
            UpdateStudentFeeHeads();
        }
        else if (rs == "0")
        {
           // lblMessage.Visible = false;
            lblError.Visible = true;
            lblError.Text = "Transection failed to Updated";
        }
        else
        {
           // lblMessage.Visible = false;
            lblError.Visible = true;
            lblError.Text = rs;
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            UpdateBuss();
            getTransportFee(Convert.ToInt64(Session["UID"]));
        }
        catch (Exception ex)
        {

           // lblMessage.Visible = false;
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }


    protected void ddlcurrentsession_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

    protected void btnback_Click(object sender, EventArgs e)
    {
        multiview1.SetActiveView(view1);
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        bool active;

        foreach (GridViewRow row in gvTF.Rows)
        {
            long SFHLID = 0;
            CheckBox ItemCHeck = (CheckBox)row.FindControl("ItemCHeck");
            Label lbl = (Label)row.FindControl("lbl");
            SFHLID = Convert.ToInt64(lbl.Text);
            if (ItemCHeck.Checked)
            {
                active = false;
            }
            else
            {
                active = true;
            }

            Applicable(SFHLID, active);

        }
        getTransportFee(Convert.ToInt64(Session["UID"]));
    }

    protected void btnrst_Click(object sender, EventArgs e)
    {

        ddlBuss.SelectedValue = "-1";
        ddlBussStop.SelectedValue = "-1";
        ddlcurrentsession.SelectedValue = "-1";
    }
}