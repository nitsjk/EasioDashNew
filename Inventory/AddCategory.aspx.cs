using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.Model;
using Nits.BLL;
using System.Data;

public partial class Inventory_AddCategory : System.Web.UI.Page
{
    Category Cdal = new Category();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            try
            {
                GetCategories();
                txtCategory.Focus();
            }
            catch (Exception ex)
            {
                lblSuccess.Visible = false;
                lblError.Visible = true;
                lblError.Text = ex.ToString();
                lblSuccess.Text = "";
            }
        }
    }

    public void GetCategories()
    {
        try
        {
            DataSet ds = Cdal.getCategories();
            if (ds.Tables[0].Rows.Count > 0)
            {
                gvCategory.DataSource = ds;
                gvCategory.DataBind();
            }
            else
            {
                lblError.Visible = true;
                lblSuccess.Visible = false;
                lblError.Text = "No records found";
                lblSession.Text = "";
                gvCategory.DataSource = null;
                gvCategory.DataBind();
            }
        }
        catch (Exception ex )
        {
            lblSuccess.Visible = false;
            lblError.Visible = true;
            lblError.Text = ex.ToString();
            lblSuccess.Text = "";
        }
    }


    public void addCategory()
    {
        try
        {
            StockCategory Cmodel = new StockCategory();
            Cmodel.CatName = txtCategory.Text;
            Cmodel.UserName = Session["username"].ToString();
            string ReturnMessage = Cdal.AddCategory(Cmodel);
            if (ReturnMessage.Contains("Successfully"))
            {
                lblSuccess.Visible = true;
                lblError.Visible = false;
                lblError.Text = "";
                lblSuccess.Text = ReturnMessage;
                GetCategories();
            }
            else
            {
                lblSuccess.Visible = false;
                lblError.Visible = true;
                lblError.Text = ReturnMessage;
                lblSuccess.Text = "";
            }
        }
        catch (Exception ex)
        {
            lblSuccess.Visible = false;
            lblError.Visible = true;
            lblError.Text = ex.ToString();
            lblSuccess.Text = "";
        }
    }



    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            addCategory();
        }
        catch (Exception ex )
        {
            lblError.Visible = true;
            lblError.Text = ex.ToString();
            lblSuccess.Text = "";
        }
    }
}