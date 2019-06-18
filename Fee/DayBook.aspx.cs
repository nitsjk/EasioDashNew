using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.BLL;
using Nits.Common;
using Nits.Model;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI.HtmlControls;

public partial class Fee_DayBook : System.Web.UI.Page
{
    DayBook CCDal = new DayBook();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["Current_Session"] = "2018-19";
            multiview1.SetActiveView(view1);
            getallUsers();
        }
    }
         public void getallUsers()
          {
        DataSet ds = CCDal.GetUsers();
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddluser.DataSource = ds;
            ddluser.DataBind();
            ddluser.Items.Insert(0, new ListItem("Select Users", "-1"));
            ddluser.Items.Insert(0, new ListItem("All Users", "all User"));
        }
        else
        {
            lblError.Text = "No Record Found";
            lblError.ForeColor = System.Drawing.Color.Red;
        }
    }
    public void DayBookby(int check)
    {
        try
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("UID", typeof(long));
            dt.Columns.Add("StudentName", typeof(string));
            dt.Columns.Add("Class", typeof(string));
            dt.Columns.Add("Section", typeof(string));
            dt.Columns.Add("RecptNo", typeof(long));
            dt.Columns.Add("Receipt_Date", typeof(string));
            dt.Columns.Add("Cashier", typeof(string));
            DataSet dsFeeHead = CCDal.getFeeHeads();
            foreach (DataRow drProduct in dsFeeHead.Tables[0].Rows)
            {

                dt.Columns.Add(drProduct["FHName"].ToString(), typeof(decimal));

            }
            dt.Columns.Add("Advance", typeof(decimal));
            dt.Columns.Add("Total", typeof(decimal));
            CashCollectionMOdel Cmodel = new CashCollectionMOdel();
            Cmodel.DateFrom = Convert.ToDateTime(txtdatefrom.Text);
            Cmodel.DateTo = Convert.ToDateTime(txtdateto.Text);
            Cmodel.CSession = Session["Current_Session"].ToString();
            Cmodel.DIDFK = Convert.ToInt64(ddlDepartment.SelectedValue);
            Cmodel.UserName = ddluser.SelectedValue;
            Cmodel.Check = check;

            DataSet dsFeeReceipt = CCDal.getReceiptDetails(Cmodel);

            if (dsFeeReceipt.Tables[0].Rows.Count > 0)
            {

                int count = 0;
                foreach (DataRow drFeeReceipt in dsFeeReceipt.Tables[0].Rows)
                {
                    Session["FRID"] = drFeeReceipt["FRID"];
                    DataRow FeeRow = dt.NewRow();
                   // FeeRow["UID"] = drFeeReceipt["StudentCode"].ToString();
                    FeeRow["StudentName"] = drFeeReceipt["StudentName"].ToString();
                    FeeRow["Class"] = drFeeReceipt["ClassName"].ToString();
                    FeeRow["Section"] = drFeeReceipt["SectionName"].ToString();
                    FeeRow["Recptno"] = drFeeReceipt["Recptno"].ToString();
                    FeeRow["Receipt_Date"] = Convert.ToDateTime(drFeeReceipt["ReceiptDate"].ToString()).ToShortDateString();
                    FeeRow["Total"] = drFeeReceipt["Cashin"].ToString();
                    FeeRow["Cashier"] = drFeeReceipt["Username"].ToString();
                    DataSet dsFeeHeads = CCDal.getFeeHeads();

                    if (dsFeeHeads.Tables[0].Rows.Count > 0)
                    {




                        foreach (DataRow drFeeHeads in dsFeeHeads.Tables[0].Rows)
                        {
                            SqlParameter[] var2 =
                            {
                                    new SqlParameter ("@FHID",drFeeHeads ["FHID"]),
                                    new SqlParameter ("@FeeReceiptID",drFeeReceipt ["RecptNo"]),
                                    new SqlParameter ("@DIDFK",Convert.ToInt64(drFeeReceipt ["DIDFK"]))

                            };
                            DataSet dsFee = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select  isnull(Sum (Cashin),0)  as CashIn  from FeeReceiptItems where FeeHeadIDFK =@FHID and FeeReceiptIDFK =@FeeReceiptID and DIDFK=@DIDFK and isdeleted=0 ", var2);

                            DataRow drFee = dsFee.Tables[0].Rows[0];


                            FeeRow[drFeeHeads["FHName"].ToString()] = drFee["CashIn"];
                            foreach (DataRow drr in dsFee.Tables[0].Rows)
                            {
                                SqlParameter[] var3 =
                                {
                                    new SqlParameter ("@RecNo",drFeeReceipt ["RecptNo"]),
                                    new SqlParameter ("@ID",drFeeReceipt["StudentID"]),
                                };
                                DataSet dsSFHL = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select FAAmount from FeeAdvance where RecIDFK=@RecNo and SIDFK=@ID and IsDeleted=0", var3);

                                if (dsSFHL.Tables[0].Rows.Count > 0)
                                {
                                    DataRow row = dsSFHL.Tables[0].Rows[0];
                                    FeeRow["Advance"] = row["FAAmount"];
                                }
                                else
                                {
                                    FeeRow["Advance"] = "0";
                                }
                            }
                        }
                    }

                    foreach (DataRow drProduct in dsFeeHead.Tables[0].Rows)
                    {
                        if (FeeRow[drProduct["FHName"].ToString()].ToString() == "")
                        {
                            FeeRow[drProduct["FHName"].ToString()] = "0";
                        }
                    }
                    dt.Rows.Add(FeeRow);
                }
                gvdaybook.DataSource = dt;
                gvdaybook.DataBind();
                //PanelReport.Visible = true;
                //lblmsg.Text = "";
                ////  lblSchoolName.Text = Session["CompanyName"].ToString();
                //spFrom.InnerText = /*DateFrom.SelectedDate.ToString("dd/MM/yyyy");*/ Convert.ToDateTime(txtdatefrom.Text);
                //spTo.InnerText = /*DateTo.SelectedDate.ToString("dd/MM/yyyy");*/ Convert.ToDateTime(txtdateto.Text);
                //gvFeeCollection.FooterRow.Cells[3].Text = "Total";
                //casher.InnerText = Session["UserName"].ToString();

                /////////////
                int i = 8;


                foreach (DataRow drProduct in dsFeeHead.Tables[0].Rows)
                {
                    decimal FeeHead = 0;
                    FeeHead = dt.AsEnumerable().Sum(row => row.Field<decimal>(drProduct["FHName"].ToString()));
                    gvdaybook.FooterRow.Cells[i++].Text = FeeHead.ToString();
                }

                decimal adv = 0;
                adv = dt.AsEnumerable().Sum(row => row.Field<decimal>("Advance"));
                gvdaybook.FooterRow.Cells[i++].Text = adv.ToString();
                decimal Total = 0;

                Total = dt.AsEnumerable().Sum(row => row.Field<decimal>("Total"));
                gvdaybook.FooterRow.Cells[i++].Text = Total.ToString();
                Session["Ctrl"] = PanelReport;
            }
            else
            {
                lblError.Text = "No Record Found";
                lblError.ForeColor = System.Drawing.Color.Red;
                gvdaybook.DataSource = null;
                gvdaybook.DataBind();
                PanelReport.Visible = false;
            }
        }
        catch (Exception ex)
        {
            lblError.Text = lblError.Text + ex.ToString();
        }
    }

    protected void gvFeeCollection_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }

    protected void btnget_Click(object sender, EventArgs e)
    {
        try
        {
            DayBookby(2);
        }
        catch (Exception)
        {

            throw;
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
        gvdaybook.GridLines = GridLines.Both;
        gvdaybook.HeaderStyle.Font.Bold = true;
        gvdaybook.RenderControl(htmltextwrtter);
        gvdaybook.AllowPaging = false;
        form.Attributes["runat"] = "server";
        form.Controls.Add(gvdaybook);
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
            lblError.Text = ex.ToString();
            lblError.ForeColor = System.Drawing.Color.Green;
        }
    }
}
