using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contract : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnViewContract_Click(object sender, EventArgs e)
    {

    }

    protected void btnAddAContract_Click(object sender, EventArgs e)
    {
        //redirects to the add contract page
        Response.Redirect("Add A Contract.aspx");
    }

    protected void btnUpgradeContract_Click(object sender, EventArgs e)
    {
        //redirects to the upgrade contract page
        Response.Redirect("Upgrade Contract.aspx");
    }
    protected void btnCancelContract_Click(object sender, EventArgs e)
    {
        //redirects to the cancel contract page
       Response.Redirect("Cancel Contract.aspx");
    }

    protected void btnFindAContract_Click(object sender, EventArgs e)
    {
        //redirects to the find contract page
        Response.Redirect("Find A Contract.aspx");
    }
}
