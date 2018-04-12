using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manufacturer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate a new record
        Session["ManufacturerNo"] = -1;
        //redirect to the add page
        Response.Redirect("AddManufacturer.aspx");
    }



    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ManufacturerNo;
        //if a record has been selected from the list
        if (lstManufacturers.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ManufacturerNo = Convert.ToInt32(lstManufacturers.SelectedValue);
            //store the data in the session object
            Session["ManufacturerNo"] = ManufacturerNo;
            //redirect to the edit page
            Response.Redirect("EditManufacturer.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}