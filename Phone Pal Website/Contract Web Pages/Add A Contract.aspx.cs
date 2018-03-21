using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhonePalClassLibrary;

public partial class Add_A_Contract : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnView_Click(object sender, EventArgs e)
    {

    }


    protected void btnGoBack_Click(object sender, EventArgs e)
    {
        //redirects back to the contract home page
        Response.Redirect("Main Page Contract.aspx");
    }
    //function for adding new contracts
    void Add()
    {
        DateTime DateTemp;
        DateTemp = DateTime.Now.Date;
        //create an instance of the contracts
        clsContractCollection Contracts = new clsContractCollection();
        //validate the data on the web form
        String Error = Contracts.ThisContract.Valid(
             ddlContractType.Text,
             ddlDataAllowance.Text,
             ddlNumberOfMins.Text,
             ddlNumberOfTexts.Text,
             txtPricePerMonth.Text,
             ddlDuration.Text,
             DateTemp.ToString(),
             txtStaffNo.Text,
             txtManufacturerNo.Text,
             txtCustomerNo.Text);
        //if the data is OK add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            Contracts.ThisContract.PricePerMonth = Convert.ToDecimal(txtPricePerMonth.Text);
            Contracts.ThisContract.ContractType = ddlContractType.SelectedItem.Text;
            Contracts.ThisContract.Duration = ddlDuration.SelectedItem.Text;
            Contracts.ThisContract.DataAllowance = ddlDataAllowance.SelectedItem.Text;
            Contracts.ThisContract.NumberOfMinutes = ddlNumberOfMins.SelectedItem.Text;
            Contracts.ThisContract.NumberOfTexts = ddlNumberOfTexts.SelectedItem.Text;
            Contracts.ThisContract.StartDate = DateTemp.Date;
            Contracts.ThisContract.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
            Contracts.ThisContract.ManufacturerNo = Convert.ToInt32(txtManufacturerNo.Text);
            Contracts.ThisContract.StaffNo = Convert.ToInt32(txtStaffNo.Text);
            //add the record
            Contracts.Add();
            //redirect back to the main contract page
            Response.Redirect("Main Page Contract.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + " " + Error;
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        //add the new record
        Add();
        //redirect back to the main contract page
        Response.Redirect("Main Page Contract.aspx");
    }
}