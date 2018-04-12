using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhonePalClassLibrary;


public partial class A_Contract : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 ContractNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the contract to be processed
        ContractNo = Convert.ToInt32(Session["ContractNo"]);
        if (IsPostBack == false)
        {
            if (ContractNo != -1)
            {
                DisplayContractsForUpdate();
            }
        }
            
        

    }

    protected void btnView_Click(object sender, EventArgs e)
    {

    }


    protected void btnGoBack_Click(object sender, EventArgs e)
    {
        //redirects back to the contract home page
        Response.Redirect("Main Page Contract.aspx");
    }
    void DisplayContractsForAdding()
    {
       
    }
    void DisplayContractsForUpdate()
    {
       
        //create an instance of the contract list
        clsContractCollection ContractList = new clsContractCollection();
        //find the record to update 
        ContractList.ThisContract.Find(ContractNo);
        //display the data for this record
        txtContractType.Text = ContractList.ThisContract.ContractType.ToString();
        txtDataAllowance.Text = ContractList.ThisContract.DataAllowance.ToString();
        txtNumberOfMins.Text = ContractList.ThisContract.NumberOfMinutes.ToString();
        txtNumberOfTexts.Text = ContractList.ThisContract.NumberOfTexts.ToString();
        txtPricePerMonth.Text = ContractList.ThisContract.PricePerMonth.ToString();
        txtDuration.Text = ContractList.ThisContract.Duration.ToString();
        txtStaffNo.Text = ContractList.ThisContract.StaffNo.ToString();
        txtManufacturerNo.Text = ContractList.ThisContract.ManufacturerNo.ToString();
        txtCustomerNo.Text = ContractList.ThisContract.CustomerNo.ToString();
        txtStartDate.Text = ContractList.ThisContract.StartDate.ToShortDateString();



    }
    //function for updating records
    void Update()
    {
        //create an instance of the contracts 
        PhonePalClassLibrary.clsContractCollection ContractList = new PhonePalClassLibrary.clsContractCollection();
        //validate the data for the web form
        String Error = ContractList.ThisContract.Valid(
             txtContractType.Text,
             txtDataAllowance.Text,
             txtNumberOfMins.Text,
             txtNumberOfTexts.Text,
             txtPricePerMonth.Text,
             txtDuration.Text,
             txtStartDate.Text,
             txtStaffNo.Text,
             txtManufacturerNo.Text,
             txtCustomerNo.Text);
        //if the data is ok add to the object
        if (Error == "")
        {
            //find the records to update
            ContractList.ThisContract.Find(ContractNo);
            //get the data entered by the user
            ContractList.ThisContract.PricePerMonth = Convert.ToDecimal(txtPricePerMonth.Text);
            ContractList.ThisContract.ContractType = txtContractType.Text.ToString();
            ContractList.ThisContract.Duration = txtDuration.Text.ToString();
            ContractList.ThisContract.NumberOfMinutes = txtNumberOfMins.Text.ToString();
            ContractList.ThisContract.NumberOfTexts = txtNumberOfTexts.Text.ToString();
            ContractList.ThisContract.StaffNo = Convert.ToInt32(txtStaffNo.Text);
            ContractList.ThisContract.ManufacturerNo = Convert.ToInt32(txtManufacturerNo.Text);
            ContractList.ThisContract.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
            ContractList.ThisContract.StartDate = Convert.ToDateTime(txtStartDate.Text);
            ContractList.ThisContract.DataAllowance = txtDataAllowance.Text.ToString();
            //update the record 
            ContractList.Update();
            //redirect to our main page 
            Response.Redirect("Main Page Contract.aspx");
        }
        else//if data isn't inputted correctly or missing inputs
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + " " + Error;
        }
    }
    //function for adding new contracts
    void Add()
    {
       
        //create an instance of the contracts
        PhonePalClassLibrary.clsContractCollection ContractList = new PhonePalClassLibrary.clsContractCollection();
        //validate the data on the web form
        String Error = ContractList.ThisContract.Valid(
             txtContractType.Text,
             txtDataAllowance.Text,
             txtNumberOfMins.Text,
             txtNumberOfTexts.Text,
             txtPricePerMonth.Text,
             txtDuration.Text,
             txtStartDate.Text,
             txtStaffNo.Text,
             txtManufacturerNo.Text,
             txtCustomerNo.Text);
        //if the data is OK add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            ContractList.ThisContract.PricePerMonth = Convert.ToDecimal(txtPricePerMonth.Text);
            ContractList.ThisContract.ContractType = txtContractType.Text.ToString();
            ContractList.ThisContract.Duration = txtDuration.Text.ToString();
            ContractList.ThisContract.NumberOfMinutes = txtNumberOfMins.Text.ToString();
            ContractList.ThisContract.NumberOfTexts = txtNumberOfTexts.Text.ToString();
            ContractList.ThisContract.StaffNo = Convert.ToInt32(txtStaffNo.Text);
            ContractList.ThisContract.ManufacturerNo = Convert.ToInt32(txtManufacturerNo.Text);
            ContractList.ThisContract.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
            ContractList.ThisContract.StartDate = Convert.ToDateTime(txtStartDate.Text);
            ContractList.ThisContract.DataAllowance = txtDataAllowance.Text.ToString();
            //add the record
            ContractList.Add();
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
        if (ContractNo == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }

    }
}