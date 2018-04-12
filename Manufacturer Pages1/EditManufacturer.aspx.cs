using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditManufacturer : System.Web.UI.Page
{
    //var to store the manufacturerno
    Int32 ManufacturerNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the ticket no from the session object
        ManufacturerNo = Convert.ToInt32(Session["ManufacturerNo"]);
        //if this is the first time the page has loaded
       /* if (IsPostBack == true)
        {
            //if we are not adding a new record
            if (ManufacturerNo != -1)
            {
                //update the fields on the page with the data from the record
                //DisplayTickets();
            }
            else//this is a new record
            {
                //set the date to todays date
                txtYearStarted.Text = DateTime.Today.Date.ToString("dd/MM/yyyy"); ;
            }
        }*/
    }
}