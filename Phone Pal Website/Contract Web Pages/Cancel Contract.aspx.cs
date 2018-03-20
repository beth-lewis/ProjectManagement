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
        Response.Redirect("Main Page Contract.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        
    }
}