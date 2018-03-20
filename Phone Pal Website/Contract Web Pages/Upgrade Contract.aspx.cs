using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Upgrade_Contract : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGoBack_Click(object sender, EventArgs e)
    {
        //redirects back to the contract home page
        Response.Redirect("Main Page Contract.aspx");
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {

    }
}