﻿using Nits.BLL;
using Nits.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class StudentLedger : System.Web.UI.Page
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
            txtdatefrom.Text = DateTime.Now.ToString();
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
            ddlStType.Focus();
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
            txtSS.Focus();
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
            btnSubmit.Focus();
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
            else if (ddlStType.SelectedValue=="5")
            {
                if (ddlStType.SelectedValue=="-1")
                {
                    lblError.Visible = true;
                    lblSuccess.Visible = false;
                    lblError.Text = "Enter Student Name";
                }
                else
                {
                    gvSearchResult.DataSource = null;
                    gvSearchResult.DataBind();

                    SS.sCode =Convert.ToInt64(ddlStudent.SelectedValue);
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
        ddlStType.Focus();
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
            NameDiv.Visible =false;
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
    protected void gvSearchResult_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "ViewLedger")
            {
                long UID = Convert.ToInt64(e.CommandArgument);
                Session["UID"] = UID;
              
                multiview1.SetActiveView(view2);
                txtdatefrom.Focus();
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
            ddlSection.Focus();
        }
    }
    public void StudentAccountDetails()
    {

        try
        {
            Ledger Ldal = new Ledger();

            StudentLaderModel stdLadger = new StudentLaderModel();

            DateTime FromDate = Convert.ToDateTime(txtdatefrom.Text);
            string DateForm = FromDate.Date.ToString("yyyy-MM-dd");
            stdLadger.FromDate = Convert.ToDateTime(DateForm);

            DateTime ToDate = Convert.ToDateTime(txtdateto.Text);
            string DateTo = ToDate.Date.ToString("yyyy-MM-dd");
            stdLadger.ToDate = Convert.ToDateTime(DateTo);
            stdLadger.UID = Convert.ToInt64(Session["UID"].ToString());
            DataSet ds = Ldal.studentLedger(stdLadger);

            if (ds.Tables[0].Rows.Count > 0)
            {
                gvLadger.DataSource = ds.Tables[0];
                gvLadger.DataBind();
            }
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            StudentAccountDetails();
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        try
        {
            multiview1.SetActiveView(view1);
            gvSearchResult.DataSource = null;
            gvSearchResult.DataBind();
            //txtName.Text = "";
            //txtUID.Text = "";
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
}