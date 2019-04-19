using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.Common;
using Nits.Model;
using Nits.BLL; 


public partial class AddStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        getDetails();  

    }
    public void getDetails()
    {
        try
        {
            StudentBLL sb = new StudentBLL();
            StudentsModel sm = new StudentsModel();
            sm.StudentName = txtName.Text;
            //sm.Gender = txtGender.Text;

            sm.Gender = dllGender.SelectedValue;
            string s = sb.StudentDetail(sm);
            lblSucess.Text = s;        }
        catch (Exception ex)
        {
/*           vv*/ lblDanger.Text = ex.ToString();
        }

        


    }
}