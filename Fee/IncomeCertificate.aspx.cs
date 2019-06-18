using Nits.BLL;
using Nits.Model;
using Nits.NumberToWords;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Fee_IncomeCertificate : System.Web.UI.Page
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

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            ConvertNumberToWords CNTW = new ConvertNumberToWords();
            lbltotalPaid.Text = txtSetAmount.Text;
            string inwords = CNTW.ConvertNumbertoWords(Convert.ToInt64(lbltotalPaid.Text));
            lblwords.Text = inwords;
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
            //lblMessage.Visible = false;

        }
    }
    protected void Unnamed_Click(object sender, EventArgs e)
    {
        multiview1.SetActiveView(view1);
    }
    protected void gvSearchResult_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ViewLedger")
        {
            try
            {
                long UID;
                Session["UID"] = UID = Convert.ToInt64(e.CommandArgument);
                Session["UID"] = UID;

               multiview1.SetActiveView(view2);
            }
            catch (Exception ex)
            {

                lblError.Visible = true;
                lblError.Text = ex.ToString();
            }

        }
    }
    public void getCertificateData()
    {
        try
        {
            ConvertNumberToWords CNTW = new ConvertNumberToWords();
            IncomeCertificate ICdal = new IncomeCertificate();
            IncomeCertificateModel ICModel = new IncomeCertificateModel();
            ICModel.UID = Convert.ToInt64(Session["UID"]);
            ICModel.DateFrom = Convert.ToDateTime(txtdatefrom.Text);
            ICModel.DateTo = Convert.ToDateTime(txtdateto.Text);
            DataSet ds = ICdal.getICD(ICModel);
            if (ds.Tables[0].Rows.Count > 0)
            {

                Label1.Text = DateTime.Now.ToShortDateString();
                DataSet sdDS = (DataSet)(ViewState["StudentDetail"]);
                DataRow sddr = sdDS.Tables[0].Rows[0];
                DataRow dr = ds.Tables[0].Rows[0];
                if (string.IsNullOrEmpty(dr["total"].ToString()))
                {
                    lblError.Visible = true;
                    // lblMessage.Visible = false;
                    lblError.Text = "No Fee paid from " + txtdatefrom.Text + " To " + txtdateto.Text;
                    //lblError.Text = "No Fee paid from " + DateFrom.SelectedDate.ToShortDateString() + " To " + DateTo.SelectedDate.ToShortDateString();
                }
                else
                {


                    Label3.Text = sddr["StudentName"].ToString();//students Name
                    Label2.Text = sddr["FathersName"].ToString();//Fathers Name
                    Label4.Text = sddr["PresentAddress"].ToString();//R/o
                    Label5.Text = sddr["ClassName"].ToString(); ;//Class name 
                    Label6.Text = sddr["SectionName"].ToString(); ;//Class name 
                                                                   // lblFeeHeads.Text = "tution";//fee Head




                    lbltotalPaid.Text = dr["total"].ToString();
                    string inwords = CNTW.ConvertNumbertoWords(Convert.ToInt64(dr["total"]));
                    lblwords.Text = inwords;// Amount in words
                    lblDateFrom.Text = txtdatefrom.Text; /*DateFrom.SelectedDate.ToShortDateString();*///from date
                    lblDateTo.Text = txtdateto.Text; /*DateTo.SelectedDate.ToShortDateString();*///to date

                }
            }
            else
            {
                lblError.Visible = true;
                //   lblMessage.Visible = false;
                //lblError.Text = "No Fee paid from " + DateFrom.SelectedDate.ToShortDateString() + " To " + DateTo.SelectedDate.ToShortDateString();
                lblError.Text = "No Fee paid from " + txtdatefrom.Text + " To " + txtdateto.Text;
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            //lblMessage.Visible = false;
            lblError.Text = ex.ToString();
        }

    }
    protected void btnGet_Click(object sender, EventArgs e)
    {
        getCertificateData();
        Session["ctrl"] = Panel1;
    }

}