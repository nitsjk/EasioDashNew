using Nits.BLL;
using Nits.Model;
using Nits.SMS;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Fee_Defaulters : System.Web.UI.Page
{
    Defaulters Ddal = new Defaulters();
    string Message = "Asalam u Alaikum " + Environment.NewLine + "Dear Parent," + Environment.NewLine + "Payment Reminder " + Environment.NewLine + "    This is to remind you that the last day of fee submission is 5th of every month. *Requesting you to clear your dues in time." + Environment.NewLine + "Thank You " + Environment.NewLine + "Admin -Walkin" + Environment.NewLine + "* Kindly ignore if already paid.";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Session["Current_Session"] = "2018-19";
            TxtMessage.Text = Message;
            Classes();
            msg.Visible = false;
            GetSessionMonths();
        }
    }
    public void GetSessionMonths()
    {
        try
        {
            DataSet ds = Ddal.getSessionMonths();
            if (ds.Tables[0].Rows.Count > 0)
            {
                chklMonths.DataSource = ds;
                chklMonths.DataTextField = "MonthName";
                chklMonths.DataValueField = "Smid";
                chklMonths.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    public void Classes()
    {
        try
        {
            Feedue cfd = new Feedue();
            cfd.CSession = Session["Current_Session"].ToString();
            DataSet ds = Ddal.classes(cfd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlclasses.DataSource = ds;
                ddlclasses.DataTextField = "ClassName";
                ddlclasses.DataValueField = "ClassID";
                ddlclasses.DataBind();
                ddlclasses.Items.Insert(0, new ListItem("Select Class", "-1"));
               Session["ClassID"] = ddlclasses.SelectedValue;
               Sections();

            }
            else
            {
                ddlclasses.DataSource = null;
                ddlclasses.DataBind();
                ddlclasses.Items.Insert(0, new ListItem("No Class Found", "-1"));
            }
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }

    }
    public void Sections()
    {
        try
        {
            Session["ClassiD"] = ddlclasses.SelectedValue;
            Feedue sfd = new Feedue();
            sfd.CID = Convert.ToInt64(ddlclasses.SelectedValue);
            DataSet ds = Ddal.Sections(sfd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlsection.DataSource = ds;
                ddlsection.DataTextField = "SectionName";
                ddlsection.DataValueField = "SectionID";
                ddlsection.DataBind();
              
                ddlsection.Items.Insert(0, new ListItem("Select Section", "-1"));
            }
            else
            {
                ddlsection.DataSource = null;
                ddlsection.DataBind();
                ddlsection.Items.Insert(0, new ListItem("No Section Found", "-1"));
            }
        }
        catch (Exception ex)
        {

            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }

    protected void ddlclasses_SelectedIndexChanged(object sender, EventArgs e)
    {
        Sections();
    }
    
    protected void CHECKALL_CheckedChanged(object sender, EventArgs e)
    {
        if (SelectAllMonths.Checked == true)
        {
            foreach (ListItem item in chklMonths.Items)
            {
                item.Selected = true;
            }
        }
        else
        {
            foreach (ListItem item in chklMonths.Items)
            {
                item.Selected = false;
            }
        }
    }
    public DataSet SDetails()
    {
        DefaultersMOdel Dmodel = new DefaultersMOdel();
        Dmodel.CSession = Session["Current_Session"].ToString();
        Dmodel.Classid = Convert.ToInt64(ddlclasses.SelectedValue);
        Dmodel.Sectionid = Convert.ToInt64(ddlsection.SelectedValue);

        DataSet ds = Ddal.getStudentDetails(Dmodel);
        if (ds.Tables[0].Rows.Count > 0)
        {
            return ds;
        }
        else
        {
            return ds = null;
        }
    }
    public string getUnpaidMOnths(long SID, string mon)
    {
        string Months = null;
        long FHID = 1; // 1 is for tution Fee  this is as per Requirment
        DataSet ds = Ddal.getUnpaidMonths(SID, Session["Current_Session"].ToString(), mon, FHID);

        //DataRow dr = Months.Tables[0].Rows[0];
        if (ds.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Months = Months + dr["FeeMonth"].ToString() + " |";
            }
        }
        else
        {
            Months = "1";
        }

        return Months;
    }
    public DataSet getAmount(int FHIDFK, long Studentid, string Csession, string Month)
    {
        DefaultersMOdel model = new DefaultersMOdel();
        model.FHIDFK = FHIDFK;
        model.StudentIDFK = Studentid;
        model.CSession = Csession;
        model.Months = Month;
        DataSet ds = Ddal.totalAmount(model);
        if (ds.Tables[0].Rows.Count > 0)
        {
            return ds;
        }
        else
        {
            return ds = null;
        }
    }
    private decimal GetAmount(int FHIDFK, long Studentid, string Month)
    {

        try
        {
            string SFHIDs = "";

            decimal totDue = 0, totPay = 0, totOutstanding = 0;




            DataSet dsDue = getAmount(FHIDFK, Studentid, Session["Current_Session"].ToString(), Month);
            //ORIGINAL CODE WITHOUT PREVIOUS SESSION
            //"select (isnull(sum(FeeRate),0) - isnull(sum(Rebate),0)) as Due from studentfeeheads where studentIdfk =@studentid and current_Session = @session and DepartmentProductIdfk = @didfk and Monthid in (" + Montid + ")", var);

            DataRow drDue = dsDue.Tables[0].Rows[0];
            totDue = Convert.ToDecimal(drDue["Due"].ToString());


            // GET SFHID's from StudentFeeHeads

            DataSet dsSfhids = Ddal.getSFHLID(Month, Studentid, FHIDFK, Session["Current_Session"].ToString());

            //Original. Commented one does not include Previous Sesssion
            //"select SFHID from studentfeeheads where studentIdfk = @studentid and current_Session = @session and DepartmentProductIdfk = @didfk and Monthid in (" + Montid + ")", var);



            if (dsSfhids.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow drsf in dsSfhids.Tables[0].Rows)
                {
                    SFHIDs = SFHIDs + drsf["SFHLID"].ToString() + ",";
                }
            }

            if (SFHIDs.Length > 0)
            {
                SFHIDs = SFHIDs.Substring(0, SFHIDs.Length - 1);


                DataSet dsPay = Ddal.getreceiptItems(SFHIDs, FHIDFK);


                DataRow drPay = dsPay.Tables[0].Rows[0];
                totPay = Convert.ToDecimal(drPay["Pay"].ToString());
            }

            //



            totOutstanding = totDue - totPay;
            if (totOutstanding > 0)
            {
                return (totOutstanding);
            }
            else
            {
                return 0;
            }


        }
        catch (Exception ex)
        {
        //    lblerror.Visible = true;
            lblError.Text = ex.ToString();
            return 0;
        }



    }
    private void GetOutStanding(string Mid)
    {
        DataTable dt = new DataTable();
        //dt.Columns.Add("S.No", typeof(int));
        dt.Columns.Add("Phone.No", typeof(string));
     //   dt.Columns.Add("Code", typeof(string));

        dt.Columns.Add("Name", typeof(string));
        dt.Columns.Add("Class", typeof(string));
        dt.Columns.Add("Section", typeof(string));
        dt.Columns.Add("Months", typeof(string));
        //dt.Columns.Add("Tution", typeof(decimal));
        //dt.Columns.Add("Transport", typeof(decimal));


        DataSet dsFeeHead = Ddal.getFeeHeads();
        if (dsFeeHead.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow drProduct in dsFeeHead.Tables[0].Rows)
            {

                dt.Columns.Add(drProduct["FHName"].ToString(), typeof(decimal));

            }
        }
        else
        {
            lblError.Visible = true;
           // lblmessage.Visible = false;
            lblError.Text = "No Fee Head Created Yet!,";
        }

        dt.Columns.Add("Total", typeof(decimal));




        DataSet dsStudetns = SDetails(); // Student Details 

        if (dsStudetns.Tables[0].Rows.Count > 0)
        {
            int count = 0;
            decimal tutadv = 0, transpadv = 0;
            string[] Months = null;
            string returnValue = null;
            foreach (DataRow drStu in dsStudetns.Tables[0].Rows)
            {
                DataRow dr = dt.NewRow();
                //dr["S.No"] = ++count;
               // dr["Code"] = drStu["StudentCode"].ToString();
                dr["Name"] = drStu["StudentName"].ToString();
                dr["Class"] = drStu["ClassName"].ToString();
                dr["Section"] = drStu["SectionName"].ToString();

                dr["Phone.No"] = drStu["PhoneNo"].ToString();

                returnValue = getUnpaidMOnths(Convert.ToInt64(drStu["StudentID"]), Mid);
                if (returnValue != "1")
                {
                    Months = returnValue.Split('|');
                    int mLeng = Months.Length;
                    if (mLeng <= 2)
                    {
                        dr["Months"] = Months[0];
                    }
                    else
                    {
                        dr["Months"] = Months[0] + "-" + Months[Months.Length - 2];
                    }

                }


                //  = "November - December";

                //dr["Tution"] = GetAmount(1, Convert.ToInt64(drStu["StudentId"].ToString()),Mid);
                //dr["Transport"] = GetAmount(2, Convert.ToInt64(drStu["StudentId"].ToString()),Mid);

                DataSet dsFee = Ddal.getFeeHeads();

                int i;
                decimal Sum = 0, Total = 0;
                if (dsFee.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow drFee in dsFee.Tables[0].Rows)
                    {
                        i = Convert.ToInt32(drFee["FHID"].ToString());

                        dr[drFee["FHName"].ToString()] = GetAmount(i, Convert.ToInt64(drStu["StudentId"].ToString()), Mid);
                        //i++;
                        Sum = Convert.ToDecimal(dr[drFee["FHName"].ToString()]);
                        //if (Sum < 0)
                        //{
                        //    Sum = 0;
                        //}
                        //else
                        //{
                        //    Total += Sum;
                        //}
                        Total += Sum;
                        //totalFeeRate += Convert.ToDecimal(drFee["FeeRate"].ToString());
                        //totalRebate += Convert.ToDecimal(drFee["Rebate"].ToString());
                        //GrandTotal += totalFeeRate - totalRebate;
                    }

                }
                dr["Total"] = Total;
                if (Total == 0)
                    continue;
                dt.Rows.Add(dr);
            }
        }

        if (dt.Rows.Count > 0)
        {
            //   Panel5.Visible = true;
            Session["ctrl"] = Panel1;
            GridView1.DataSource = dt;
            GridView1.DataBind();

          //  btnPrint.Visible = true;
           // btnExcel.Visible = true;

            //GridView1.FooterRow.Cells[5].Text=  dt.AsEnumerable().Sum(row => row.Field<decimal>("Tution")).ToString();
            //GridView1.FooterRow.Cells[6].Text = dt.AsEnumerable().Sum(row => row.Field<decimal>("Transport")).ToString();
            GridView1.FooterRow.Cells[1].Text = "Total";
            //casher.InnerText = Session["UserName"].ToString();



            int i = 7;

            foreach (DataRow drProduct in dsFeeHead.Tables[0].Rows)
            {
                decimal FeeHead = 0;
                FeeHead = dt.AsEnumerable().Sum(row => row.Field<decimal>(drProduct["FHName"].ToString()));
                GridView1.FooterRow.Cells[i++].Text = FeeHead.ToString();
            }
            decimal Total = 0;
            Total = dt.AsEnumerable().Sum(row => row.Field<decimal>("Total"));
           GridView1.FooterRow.Cells[i++].Text = Total.ToString();
        }
    }

    protected void chkAll_CheckedChanged1(object sender, EventArgs e)
    {
        try
        {
            CheckBox chkAll = (GridView1.HeaderRow.FindControl("chkAll") as CheckBox);

            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox cchk = (row.FindControl("cchk") as CheckBox);
                if (chkAll.Checked)
                {

                    cchk.Checked = true;
                }
                else
                {
                    cchk.Checked = false;
                }
            }

        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    private string GetMonthId()
    {
        string months = "";

        foreach (ListItem item in chklMonths.Items)
        {
            if (item.Selected == true)
            {
                months += "'" + item + "',";
            }

        }
        if (months.Length > 0)
        {
            return months.Substring(0, months.Length - 1);
        }
        else
        {
            return "1";
        }


    }
  

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            msg.Visible = true;
            if (chklMonths.SelectedValue == null)
            {
                lblError.Visible = true;
                // lblmessage.Visible = false;
                GridView1.DataSource = null;
                GridView1.DataBind();
                lblError.Text = "please select atleast one month !.";
            }
            else
            {
                // lblOutstandingReportDate.Text = DateTime.Now.ToShortDateString();
                string Month = GetMonthId();
                if (Month == "1")
                {
                    lblError.Visible = true;
                    // lblmessage.Visible = false;
                    lblError.Text = "please select atleast one month !.";
                }
                else
                {
                    lblError.Visible = false;
                    //   lblmessage.Visible = false;
                    lblError.Text = "";
                    //   lblmessage.Text = "";
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                    GetOutStanding(Month);
                }

            }
        }
        catch (Exception ex)
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
        }
    }
    private void ExportGridToExcel()
    {
        HtmlForm form = new HtmlForm();
        Response.Clear();
        Response.Buffer = true;
        Response.ClearContent();
        Response.ClearHeaders();
        Response.Charset = "";
        string FileName = "Defaulters" + DateTime.Now.ToShortDateString() + ".xls";
        StringWriter strwritter = new StringWriter();
        HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.ContentType = "application/vnd.ms-excel";
        Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
        GridView1.GridLines = GridLines.Both;
        GridView1.HeaderStyle.Font.Bold = true;
        GridView1.RenderControl(htmltextwrtter);
        GridView1.AllowPaging = false;
        form.Attributes["runat"] = "server";
        form.Controls.Add(GridView1);
        this.Controls.Add(form);
        form.RenderControl(htmltextwrtter);
        Response.Write(strwritter.ToString());
        Response.End();

    }
    protected void btnexporttoexcel_Click(object sender, EventArgs e)
    {
        try
        {
            ExportGridToExcel();
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.ToString();
            lblmsg.ForeColor = System.Drawing.Color.Green;
        }
    }

    protected void sndmsg_Click(object sender, EventArgs e)
    {
        string mobnoms = "";
        foreach (GridViewRow gvro in GridView1.Rows)
        {
            if (gvro.RowType == DataControlRowType.DataRow)
            {
                //TextBox txt =(TextBox)gvro.FindControl("txt");
                CheckBox cko = new CheckBox();
                cko = (CheckBox)gvro.FindControl("cchk");
                if (cko.Checked == true)
                {
                    mobnoms += gvro.Cells[2].Text + ",";
                    //mobnoms += txt.Text + ",";
                }
            }
        }
        // Send sms
        if (mobnoms.Length > 0)
        {

            mobnoms = mobnoms.Substring(0, mobnoms.Length - 1);// Remove last ,

            sms Snd = new sms();
            Snd.SendSMS(mobnoms, TxtMessage.Text);
            lblSuccess.Text = "Message has been sent successfully";
           // lblmessage.Visible = true;
        }
    }
}