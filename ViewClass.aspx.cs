﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nits.Model;
using Nits.BLL;

public partial class ViewClass : System.Web.UI.Page
{
    ClassBLL dal = new ClassBLL();

    protected void Page_Load(object sender, EventArgs e)
    {
        getAllClasses();
    }

    public void getAllClasses()
    {
        try
        {
            List<ClassModel> ds = dal.getAllClasses();
            if (ds.Count > 0)
            {
                grdView.DataSource = ds;
                grdView.DataBind();
            }
        }

        catch (Exception ex)

        {
            Response.Write(ex);
        }
        Response.Write("Failed");

    }
}