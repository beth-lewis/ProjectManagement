using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminHomepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnUpdateStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffUpdateDetails.aspx");
    }

    protected void btnDisplayStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffDisplayDetails.aspx");
    }

    protected void btnSearchAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminSearchStaff.aspx");
    }

    protected void btnAddAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffAddDetails.aspx");
    }
}