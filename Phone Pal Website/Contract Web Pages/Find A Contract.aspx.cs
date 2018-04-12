using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhonePalClassLibrary;

public partial class Cancel_Contract : System.Web.UI.Page
{        
    //var to store the primary key value of the record to be deleted
    Int32 ContractNo;
    protected void Page_Load(object sender, EventArgs e)
    {
       //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            lstContractsFiltered.ClearSelection();
            //update the list box
            //DisplayContractsFiltered();

        }

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
        //the text will be used to search for the data
        string ContractType = txtContractTypeFilter.Text;
        //creates an instance of clsContract Colletion
        clsContractCollection FilteredContracts = new clsContractCollection();
        FilteredContracts.FilterByContractType(ContractType);
        //clear list box before data is added to it
        lstContractsFiltered.ClearSelection();
        //data source will use contract list but with the filtered data
        lstContractsFiltered.DataSource = FilteredContracts.ContractList;
        //this data will be shown on the list box
        lstContractsFiltered.DataTextField = "ContractType";
        //this is our data value field used for other stuff
        lstContractsFiltered.DataValueField = "ContractNo";
        //bind the data to the list box
        lstContractsFiltered.DataBind();
    }
    void DisplayContractsFiltered(string ContractTypeFilter)
    {
       
        //create an instance of our clsContract
        clsContractCollection AllContracts = new clsContractCollection();
        ContractTypeFilter = txtContractTypeFilter.Text;
        AllContracts.FilterByContractType(ContractTypeFilter);
        //point the list
        lstContractsFiltered.DataSource = AllContracts.ContractList;
        lstContractsFiltered.DataTextField = "ContractType";
        lstContractsFiltered.DataValueField = "ContractNo";
        lstContractsFiltered.DataBind();
        

    }
    void FilterContracts()
    {
        String FilterContractType;
        //function to filter records by contract type
        //create a new instance of the contracts
        clsContractCollection Contracts = new clsContractCollection();
        FilterContractType = txtContractTypeFilter.Text;
        //find the records
        
    }

    protected void btnUpgradeContract_Click(object sender, EventArgs e)
    {
 
        //if a record has been selected from the list
        if (lstContractsFiltered.SelectedIndex != -1)
        {
            //get the primary key vale of the record to edit
            ContractNo = Convert.ToInt32(lstContractsFiltered.SelectedValue);
            //store the data in the session object
            Session["ContractNo"] = ContractNo;
            //redirect to upgrade contract page
            Response.Redirect("A Contract.aspx");
        }
        else//if no contract has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDeleteContract_Click(object sender, EventArgs e)
    {

        //if a record has been selected from the list
        if (lstContractsFiltered.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            ContractNo = Convert.ToInt32(lstContractsFiltered.SelectedValue);
            //store the data in the session object
            Session["ContractNo"] = ContractNo;
            //redirects to the cancel contract page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}