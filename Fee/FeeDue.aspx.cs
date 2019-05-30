using Nits.BLL;
using Nits.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Globalization;

public partial class FeeDue : System.Web.UI.Page
{
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

            btnByClass.Visible = false;
            btnSS.Visible = true;
            Classesdiv.Visible = false;
            SectionsDiv.Visible = false;
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
            btnByClass.Visible = true;
            Classesdiv.Visible = true;
            SectionsDiv.Visible = true;
            textboxdiv.Visible = false;
            txtSS.Text = "";
            btnSS.Visible = false;
            gvSearchResult.DataSource = null;
            gvSearchResult.DataBind();
        }
        else
        {
            btnByClass.Visible = false;
            Classesdiv.Visible = false;
            SectionsDiv.Visible = false;
            textboxdiv.Visible = true;
            txtSS.Text = "";
            btnSS.Visible = true;
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
        btnByClass.Visible = false;
        ddlCLasses.SelectedValue = "-1";
        ddlSection.SelectedValue = "-1";
        gvSearchResult.DataSource = null;
        gvSearchResult.DataBind();
        if (ddlStType.SelectedValue == "-1")
        {

            btnByClass.Visible = false;
            btnSS.Visible = true;
            Classesdiv.Visible = false;
            SectionsDiv.Visible = false;
            textboxdiv.Visible = true;
            txtSS.Text = ""; ;

        }
        else if (ddlStType.SelectedValue == "5")
        {
            Classes();
            btnByClass.Visible = true;
            Classesdiv.Visible = true;
            SectionsDiv.Visible = true;
            textboxdiv.Visible = false;
            txtSS.Text = "";
            btnSS.Visible = false;

        }
        else
        {
            btnByClass.Visible = false;
            Classesdiv.Visible = false;
            SectionsDiv.Visible = false;
            textboxdiv.Visible = true;
            txtSS.Text = "";
            btnSS.Visible = true;
        }
    }
    public void GetFeeHeads()
    {
        try
        {
            DataSet ds = dal.getFeeheads();
            ddlFeeHeads.DataSource = ds;
            ddlFeeHeads.DataBind();
            ddlFeeHeads.Items.Insert(0, new ListItem("Select Fee Heads", "-1"));
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
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
                chklMonths.Enabled = false;
                CHECKALL.Enabled = false;
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    public void loadDues(long id)
    {
        try
        {
            if (ddlStType.SelectedValue != "5")
            {
                Feedue feed = new Feedue();
                feed.StudentID = id;
                feed.CSession = Session["Current_Session"].ToString();

                DataSet ds = dal.LoadFeeDue(feed);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Session["Dataset"] = ds;
                    gvChkDueFees.DataSource = ds;
                    gvChkDueFees.DataBind();
                }
                else
                {
                    Session["Dataset"] = null;
                    gvChkDueFees.DataSource = null;
                    gvChkDueFees.DataBind();
                }
            }

        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void gvSearchResult_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "DueFee")
            {
                string[] ids = e.CommandArgument.ToString().Split(',');

                Session["SCode"] = Convert.ToInt64(ids[0]); //Student ID
                Session["ClassID"] = Convert.ToInt64(ids[1]); // Class ID
                if (string.IsNullOrEmpty(ids[2]))
                {
                    Session["BussStopId"] = 0;
                }
                else
                {
                    Session["BussStopId"] = Convert.ToInt64(ids[2]);
                }
                loadDues(Convert.ToInt16(Session["SCode"]));
                GetFeeHeads();
                GetSessionMonths();

                multiview1.SetActiveView(view2);
                ddlFeeHeads.Focus();
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void btnByClass_Click(object sender, EventArgs e)
    {
        Session["Sectionid"] = ddlSection.SelectedValue;
        GetFeeHeads();
        GetSessionMonths();

        multiview1.SetActiveView(view2);
        ddlFeeHeads.Focus();

    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        ddlFeeHeads.SelectedValue = "-1";
        CHECKALL.Checked = false;
        chklMonths.ClearSelection();
        ddlStType.ClearSelection();
        txtAmount.Text = "";
        txtDueDate.Text = "";
        txtRemarks.Text = "";
        txtSS.Text = "";
        ddlBussFee.SelectedValue = "-1";
        ddlBussFee.Visible = false;
        lblSuccess.Text = "";
        lblError.Text = "";
        lblSuccess.Visible = false;
        lblError.Visible = false;
        gvChkDueFees.DataSource = null;
        gvChkDueFees.DataBind();
        gvSearchResult.DataSource = null;
        gvSearchResult.DataBind();
        multiview1.SetActiveView(view1);
    }
    public int getFHType()
    {
        Feedue fhT = new Feedue();
        fhT.FHID = Convert.ToInt32(ddlFeeHeads.SelectedValue);
        DataSet ds = dal.getFHType(fhT);
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow dr = ds.Tables[0].Rows[0];
            int FHID = Convert.ToInt32(dr["FHType"].ToString());
            return FHID;
        }
        else
        {
            return 0;
        }
    }
    protected void CHECKALL_CheckedChanged(object sender, EventArgs e)
    {
        if (getFHType() == 3)
        {
            if (CHECKALL.Checked == true)
            {
                CHECKALL.Checked = false;
                lblError.Visible = true;
                lblSuccess.Visible = false;
                lblError.Text = "select only one month. This is onetime Payable";
            }


        }
        else if (getFHType() == 2)
        {
            if (CHECKALL.Checked == true)
            {
                CHECKALL.Checked = false;
                lblError.Visible = true;
                lblSuccess.Visible = false;
                lblError.Text = "select only one month. This is Annually Payable";
            }
        }
        else if (getFHType() == 1)
        {
            if (CHECKALL.Checked == true)
            {
                foreach (ListItem li in chklMonths.Items)
                {
                    li.Selected = true;
                };
            }
            else
            {
                foreach (ListItem li in chklMonths.Items)
                {
                    li.Selected = false;
                };
            }
        }
    }
    public void rateByStopId()
    {
        try
        {
            long BSID = Convert.ToInt64(Session["BussStopId"].ToString());

            if (BSID > 0)
            {
                string returnValue = Fddal.rateByStopId(BSID);
                if (returnValue=="-1")
                {
                    lblError.Visible = true;
                    lblSuccess.Visible = false;
                    lblSuccess.Text = "";
                    lblError.Text = "Invalid buss route assigned to this student";
                }
                else
                {
                    decimal rate = Convert.ToDecimal(returnValue);
                    if (rate > 0)
                    {
                        txtAmount.Text = returnValue;

                        btnAddFS.Visible = false;
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblSuccess.Visible = false;
                        lblError.Text = "Invalid buss rate";
                    }
                }
            }
            else
            {
                lblError.Visible = true;
                lblSuccess.Visible = false;
                lblError.Text = "No buss assigned to this strudent!";
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
        }
    }
    public void getFSAmount()
    {
        try
        {

            SqlDataReader rdr = null;

            if (ddlStType.SelectedValue == "5")
            {
                Feedue FDdal = new Feedue();
                FDdal.FHID = Convert.ToInt64(ddlFeeHeads.SelectedValue);
                FDdal.CID = Convert.ToInt64(ddlCLasses.SelectedValue);
                rdr = dal.getFSAmountByCID(FDdal);
            }
           
            else
            {
                Feedue FDdal = new Feedue();
                FDdal.FHID = Convert.ToInt64(ddlFeeHeads.SelectedValue);
                FDdal.StudentID = Convert.ToInt64(Session["SCode"].ToString());
                FDdal.CSession = Session["Current_Session"].ToString();
                rdr = dal.GetFSAmount(FDdal);
            }
            if (rdr.HasRows)
            {
                txtAmount.Text = rdr["Amount"].ToString();
                lblError.Visible = false;
                lblSuccess.Visible = false;
                lblError.Text = "";
                lblSuccess.Text = "";
            }
            else
            {
                ddlCLasses.SelectedValue = "-1";
                btnAddFS.Visible = true; btnAddFS.Attributes.Add("onclick", " return OpenPopup(" + Convert.ToInt64(Session["ClassID"]) + ");");
                ddlFeeHeads.SelectedValue = "-1";
                txtAmount.Text = "";
                txtDueDate.Text = "";
                txtRemarks.Text = "";
                ddlBussFee.SelectedValue = "-1";
                ddlBussFee.Visible = false;
                lblError.Visible = true;
                lblSuccess.Visible = false;
                lblSuccess.Text = "";
                lblError.Text = " Fee Structure Not Assigned Yet!";
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void ddlFeeHeads_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblError.Text = "";
        lblSuccess.Text = "";
        lblError.Visible = false;
        lblSuccess.Visible = false;
        ddlBussFee.SelectedValue = "-1";
        CHECKALL.Checked = false;
        chklMonths.ClearSelection();
        if (ddlFeeHeads.SelectedValue == "-1")
        {
            chklMonths.Enabled = false;
            CHECKALL.Enabled = false;
        }
        else
        {
            chklMonths.Enabled = true;
            CHECKALL.Enabled = true;
            if (getFHType() == 3) // annually 
            {

                CHECKALL.Enabled = false;
                chklMonths.AutoPostBack = true;
                txtAmount.Text = "";
                txtDueDate.Text = "";
                txtRemarks.Text = "";
                ddlBussFee.Visible = false;

            }
            else if (getFHType() == 2) // onetime
            {
                CHECKALL.Enabled = false;
                chklMonths.AutoPostBack = true;
                txtAmount.Text = "";
                txtDueDate.Text = "";
                txtRemarks.Text = "";
                ddlBussFee.Visible = false;
            }
            else
            {
                CHECKALL.Enabled = true;
                chklMonths.AutoPostBack = false;
                if (ddlFeeHeads.SelectedValue == "2")
                {
                    txtAmount.Text = "";
                    txtDueDate.Text = "";
                    txtRemarks.Text = "";
                    ddlBussFee.Visible = true;
                }
                else
                {
                    txtAmount.Text = "";
                    txtDueDate.Text = "";
                    txtRemarks.Text = "";
                    ddlBussFee.Visible = false;
                    getFSAmount();
                }
            }
        } 
    }
    public int CheckFHTypeinMonths()
    {
        int count = 0;
        foreach (ListItem li in chklMonths.Items)
        {
            if (li.Selected == true)
            {
                if (count == 0)
                {
                    li.Selected = true;

                }
                else
                {
                    li.Selected = false;
                }
                count++;
            }
        }
        return count;
    }
    protected void chklMonths_SelectedIndexChanged(object sender, EventArgs e)
    {
        int count = 0;
        if (getFHType() == 3)
        {
            if (CheckFHTypeinMonths() > 1)
            {
                lblError.Visible = true;
                lblSuccess.Visible = false;
                lblError.Text = ddlFeeHeads.SelectedItem.Text + " is Onetime payable";
            }

        }
        else if (getFHType() == 2)
        {
            if (CheckFHTypeinMonths() > 1)
            {
                lblError.Visible = true;
                lblSuccess.Visible = false;
                lblError.Text = ddlFeeHeads.SelectedItem.Text + " is Annually payable, select only one month.";
            }
        }
    }
    protected void ddlBussFee_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            lblSuccess.Text = "";
            lblError.Text = "";
            lblSuccess.Visible = false;
            lblError.Visible = false;
            txtAmount.Text = "";
            txtRemarks.Text = "";
            txtDueDate.Text = "";
            if (ddlBussFee.SelectedValue == "1")
            {
                getFSAmount();
            }
            else if (ddlBussFee.SelectedValue == "2")
            {
                rateByStopId();
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    public DateTime CreatDueDate(string Text, string Value)
    {
        string st = "";

        if (Text == "November" || Text == "December")
        {
            string[] Year = Session["Current_Session"].ToString().Split('-');

            int month = DateTime.ParseExact(Text, "MMMM", CultureInfo.CurrentCulture).Month;

            string DueDate = month + "-" + txtDueDate.Text + "-" + Year[0];  /// for server database 

            //string DueDate = txtDueDate.Text + "-" + month + "-" + Year[0]; /// for local database

            DateTime parsedate = DateTime.Parse(DueDate);
            return parsedate;
        }

        else
        {
            string[] Year = Session["Current_Session"].ToString().Split('-');
            int month = DateTime.ParseExact(Text, "MMMM", CultureInfo.CurrentCulture).Month;
            string DueDate = month + "-" + txtDueDate.Text + "-" + "20" + Year[1]; // for server database
                                                                                   //string DueDate = txtDueDate.Text + "-" + month + "-" + "20" + Year[1]; // for local database

            DateTime parsedate = DateTime.Parse(DueDate);
            return parsedate;
            //st = Convert.ToDateTime(DueDate).ToString("MM-dd-yyyy");
        }
    }
    private void Student()
    {
        try
        {
            Feedue bo = new Feedue();
            int count = 0;
            if (ddlBussFee.SelectedValue == "2")
            {
                bo.CSession = Session["Current_Session"].ToString();
                bo.StudentID = Convert.ToInt64(Session["SCode"].ToString());
                bo.FHID = Convert.ToInt64(ddlFeeHeads.SelectedValue);
                bo.Check = 2;
            }
            else
            {
                bo.CSession = Session["Current_Session"].ToString();
                bo.StudentID = Convert.ToInt64(Session["SCode"].ToString());
                bo.FHID = Convert.ToInt64(ddlFeeHeads.SelectedValue);
                if (ddlFeeHeads.SelectedValue == "2")
                {
                    if (ddlBussFee.SelectedValue == "1")
                    {
                        bo.Check = 1;
                    }
                    else
                    {
                        bo.Check = 2;
                    }

                }
                else
                {
                    bo.Check = 1;
                }
            }
            DataSet dsStudents = Fddal.studentInfobyID(bo);
            foreach (ListItem li in chklMonths.Items)
            {
                if (li.Selected)
                {
                    if (dsStudents.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in dsStudents.Tables[0].Rows)
                        {
                            Feedue fdModel = new Feedue();
                            fdModel.CID = Convert.ToInt64(dr["classid"].ToString());
                            fdModel.SecID = Convert.ToInt64(dr["SectionID"].ToString());
                            fdModel.StudentID = Convert.ToInt64(dr["StudentID"].ToString());
                            fdModel.StudentInfoID = Convert.ToInt64(dr["StudentInfoID"].ToString());
                            fdModel.FHID = Convert.ToInt64(ddlFeeHeads.SelectedValue);
                            fdModel.DID = Convert.ToInt64(dr["SubDepartmentID"]);
                            fdModel.CSession = Session["Current_Session"].ToString();
                            if (ddlFeeHeads.SelectedValue == "3")
                            {
                                fdModel.FeeMonth = "Annual Fee";
                            }
                            else
                            {
                                fdModel.FeeMonth = li.Text;
                            }
                            fdModel.FYear = "2018-19"; //Session["FYear"].ToString();
                            fdModel.SystemMonth = DateTime.Now.ToString("MMMM");
                            fdModel.SystemYear = DateTime.Now.ToString("yyyy");
                            fdModel.FeeRate = Convert.ToDecimal(txtAmount.Text);
                            fdModel.Rebate = 0;
                            fdModel.UserName = Session["UserName"].ToString();
                            fdModel.IsApplicable = 0;
                            fdModel.Remarks = txtRemarks.Text;
                            fdModel.FeeHeadName = ddlFeeHeads.SelectedItem.Text;
                            fdModel.TType = 0;
                            fdModel.IsPaid = 0;
                            fdModel.FHType = getFHType();
                            fdModel.BillDate = DateTime.Now;
                            fdModel.DueDate = Convert.ToDateTime((CreatDueDate(li.Text, li.Value)));
                            if (ddlBussFee.SelectedValue == "2")
                            {
                                fdModel.FSID = 0;
                            }
                            else
                            {
                                fdModel.FSID = Convert.ToInt64(dr["FSID"].ToString());
                            }
                            string var = Fddal.feeDueInduviual(fdModel);
                            if (var == "1" || var == "0")
                            {
                                if (var == "1")
                                {
                                    count++;
                                }
                            }
                            else
                            {
                                lblError.Visible = true;
                                lblSuccess.Visible = false;
                                lblError.Text = var;
                            }
                        }
                        if (count > 0)
                        {
                            lblError.Visible = false;
                            lblSuccess.Visible = true;
                            lblSuccess.Text = "Fee assigned for " + count + " Months";
                            loadDues(Convert.ToInt64(Session["SCode"]));
                            
                            //  txtAmount.Text = "";
                        }
                        else
                        {
                            lblError.Visible = true;
                            lblSuccess.Visible = false;
                            lblSuccess.Text = "Transaction Failed or Alredy assigned !.";
                            loadDues(Convert.ToInt64(Session["SCode"]));
                        }
                    }
                }
            }
        }

        catch (Exception ex)
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = ex.ToString();
            lblError.ForeColor = System.Drawing.Color.Red;
        }
    }
    private void StudentByClass()
    {
        //try
        //{
      
        Feedue bo = new Feedue();
        int cc = 0;
        int count = 0;
        int countN = 0;
        bo.CSession = Session["Current_Session"].ToString();
        bo.CID = Convert.ToInt64(ddlCLasses.SelectedValue);
        bo.SecID = Convert.ToInt64(ddlSection.SelectedValue);
        bo.FHID = Convert.ToInt64(ddlFeeHeads.SelectedValue);
        if (ddlFeeHeads.SelectedValue == "2")
        {
            if (ddlBussFee.SelectedValue == "1")
            {
                bo.Check = 1;
            }
            else
            {
                bo.Check = 2;
            }
        }
        else
        {
            bo.Check = 1;
        }
        DataSet dsStudents = Fddal.studentInfobyCID(bo);

        foreach (ListItem li in chklMonths.Items)
        {
            if (li.Selected)
            {
                if (ddlBussFee.SelectedValue == "2")
                {
                    if (dsStudents.Tables[0].Rows.Count > 0)
                    {
                        DataRow ddrr = dsStudents.Tables[0].Rows[0];
                        if (Convert.ToInt64(ddrr["BusStopID"].ToString()) != 0)
                        {
                            if (string.IsNullOrEmpty(ddrr["BusRate"].ToString()))
                            {
                                cc++;
                                lblError.Text = cc.ToString();
                            }
                            else
                            {
                                foreach (DataRow dr in dsStudents.Tables[0].Rows)
                                {
                                    if (Convert.ToDecimal(dr["BusRate"]) != 0)
                                    {
                                        Feedue fdModel = new Feedue();
                                        fdModel.CID = Convert.ToInt64(ddlCLasses.SelectedValue);
                                        fdModel.SecID = Convert.ToInt64(dr["SectionID"].ToString());
                                        fdModel.StudentID = Convert.ToInt64(dr["StudentID"].ToString());
                                        fdModel.StudentInfoID = Convert.ToInt64(dr["StudentInfoID"].ToString());
                                        fdModel.FHID = Convert.ToInt64(ddlFeeHeads.SelectedValue);
                                        fdModel.DID = Convert.ToInt64(dr["SubDepartmentID"]);
                                        fdModel.CSession = Session["Current_Session"].ToString();

                                        fdModel.FeeMonth = li.Text;

                                        fdModel.FYear = Session["FYear"].ToString();
                                        fdModel.SystemMonth = DateTime.Now.ToString("MMMM");
                                        fdModel.SystemYear = DateTime.Now.ToString("yyyy");
                                        fdModel.FeeRate = Convert.ToDecimal(dr["BusRate"]);
                                        fdModel.Rebate = 0;
                                        fdModel.UserName = Session["UserName"].ToString();
                                        fdModel.IsApplicable = 0;
                                        fdModel.Remarks = txtRemarks.Text;
                                        fdModel.FeeHeadName = ddlFeeHeads.SelectedItem.Text;
                                        fdModel.TType = 0;
                                        fdModel.IsPaid = 0;
                                        fdModel.FHType = getFHType();
                                        fdModel.BillDate = DateTime.Now;
                                        fdModel.DueDate = CreatDueDate(li.Text, li.Value);
                                        fdModel.FSID = 0;

                                        string var = Fddal.feeDueInduviual(fdModel);
                                        if (var == "1" || var == "0")
                                        {
                                            if (var == "1")
                                            {
                                                count++;
                                            }
                                            else
                                            {
                                                countN++;
                                            }
                                        }
                                        else
                                        {
                                            lblError.Visible = true;
                                            lblSuccess.Visible = false;
                                            lblError.Text = var;
                                        }
                                    }
                                }
                            }

                            if (count > 0)
                            {
                                lblError.Visible = false;
                                lblSuccess.Visible = true;
                                lblSuccess.Text = "Fee assigned for '" + count + "' Students ";
                                btnAddFS.Visible = false;
                                //  txtAmount.Text = "";
                                //ddlFeeHeads.SelectedValue = "-1";
                            }
                            else
                            {
                                lblError.Visible = true;
                                lblSuccess.Visible = false;
                                lblError.Text = "transaction Failed or Alredy assigned !.";
                                //  txtAmount.Text = "";

                            }
                        }
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblSuccess.Visible = false;
                        lblError.Text = "No students found !";
                    }
                }
                else
                {
                    if (dsStudents.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in dsStudents.Tables[0].Rows)
                        {
                            Feedue fdModel = new Feedue();
                            fdModel.CID = Convert.ToInt64(ddlCLasses.SelectedValue);
                            fdModel.SecID = Convert.ToInt64(dr["SectionID"].ToString());
                            fdModel.StudentID = Convert.ToInt64(dr["StudentID"].ToString());
                            fdModel.StudentInfoID = Convert.ToInt64(dr["StudentInfoID"].ToString());
                            fdModel.FHID = Convert.ToInt64(ddlFeeHeads.SelectedValue);
                            fdModel.DID = Convert.ToInt64(dr["SubDepartmentID"]);
                            fdModel.CSession = Session["Current_Session"].ToString();
                            if (ddlFeeHeads.SelectedValue == "3")
                            {
                                fdModel.FeeMonth = "Annual Fee";
                            }
                            else
                            {
                                fdModel.FeeMonth = li.Text;
                            }
                            fdModel.FYear = Session["FYear"].ToString();
                            fdModel.SystemMonth = DateTime.Now.ToString("MMMM");
                            fdModel.SystemYear = DateTime.Now.ToString("yyyy");
                            fdModel.FeeRate = Convert.ToDecimal(txtAmount.Text);
                            fdModel.Rebate = 0;
                            fdModel.UserName = Session["UserName"].ToString();
                            fdModel.IsApplicable = 0;
                            fdModel.Remarks = txtRemarks.Text;
                            fdModel.FeeHeadName = ddlFeeHeads.SelectedItem.Text;
                            fdModel.TType = 0;
                            fdModel.IsPaid = 0;
                            fdModel.FHType = getFHType();
                            fdModel.BillDate = DateTime.Now;
                            fdModel.DueDate = CreatDueDate(li.Text, li.Value);
                            fdModel.FSID = Convert.ToInt64(dr["FSID"].ToString());

                            string var = Fddal.feeDueInduviual(fdModel);
                            if (var == "1" || var == "0")
                            {
                                if (var == "1")
                                {
                                    count++;
                                }
                                else
                                {
                                    countN++;
                                }
                            }
                            else
                            {
                                lblError.Visible = true;
                                lblSuccess.Visible = false;
                                lblError.Text = var;
                            }
                        }
                        if (count > 0)
                        {
                            lblError.Visible = false;
                            lblSuccess.Visible = true;
                            lblSuccess.Text = "Fee assigned for '" + count + "' Students ";
                            btnAddFS.Visible = false;
                        }
                        else
                        {
                            lblError.Visible = true;
                            lblSuccess.Visible = false;
                            lblError.Text = "transaction Failed or Alredy assigned !.";

                        }
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblSuccess.Visible = false;
                        lblError.Text = "No students found !";
                    }
                }
            }
        }
        //}

        //catch (Exception ex)
        //{
        //    lblError.Visible = true;
        //    lblMessage.Visible = false;
        //    lblError.Text = ex.ToString();
        //    lblError.ForeColor = System.Drawing.Color.Red;
        //}
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            foreach (ListItem item in chklMonths.Items)
            {
                if (item.Selected)
                {
                    if (ddlStType.SelectedValue == "5")
                    {
                        StudentByClass();
                        txtAmount.Text = "";
                        break;
                    }
                    else
                    {
                        Student();
                        txtAmount.Text = "";
                        break;
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblSuccess.Visible = false;
                    lblError.Text = "Select atlest One Month";
                }
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    public void deleteFeeDueById(long SFHLID)
    {
        string returnString = dal.deleteFeeDueById(SFHLID);
        if (returnString == "1")
        {
            lblSuccess.Visible = true;
            lblError.Visible = false;
            lblSuccess.Text = "Transection Updated Successfully";
        }
        else if (returnString == "0")
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = "Transection Faild to Upload";
        }
        else
        {
            lblError.Visible = true;
            lblSuccess.Visible = false;
            lblError.Text = returnString;
        }
    }
    protected void gvChkDueFees_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteCommand")
        {
            long SFHLID = Convert.ToInt64(e.CommandArgument);
            deleteFeeDueById(SFHLID);
            if (ddlStType.SelectedValue != "5")
            {
                loadDues(Convert.ToInt16(Session["SCode"]));
            }
        }
    }
    protected void btnFDReset_Click(object sender, EventArgs e)
    {
        ddlFeeHeads.SelectedValue = "-1";
        ddlBussFee.SelectedValue = "-1";
        txtDueDate.Text = "";
        txtRemarks.Text = "";
        txtAmount.Text = "";
        gvChkDueFees.DataSource = null;
        gvChkDueFees.DataBind();
        CHECKALL.Checked = false;
        chklMonths.ClearSelection();
        CHECKALL.Enabled = false;
        chklMonths.Enabled = false;
        
    }
}