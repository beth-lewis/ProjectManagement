using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cancel_Contract : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGoBack_Click(object sender, EventArgs e)
    {
        //redirects to the upgrade contract page
        Response.Redirect("Contract.aspx");
    }

    protected void btnFindContract_Click(object sender, EventArgs e)
    {
        
    }

    protected void btnSearchForContract_Click(object sender, EventArgs e)
    {

    }
}