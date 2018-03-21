using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhonePalClassLibrary;

public partial class Contract_Web_Pages_Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 ContractNo;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the contract to be deleted from the session object
        ContractNo = Convert.ToInt32(Session["ContractNo"]);
    }

    void DeleteContracts()
    {
        //function to delete the selected record

        //create a new instance of the contracts
        clsContractCollection Contracts = new clsContractCollection();
        //find the record to delete
        Contracts.ThisContract.Find(ContractNo);
        //delete the record
        Contracts.Delete();
    }


    //event handler for the yes button
    protected void btnDeleteYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteContracts();
        //redirect to the main contract page
        Response.Redirect("Main Page Contract.aspx");
    }

    protected void btnDeleteNo_Click(object sender, EventArgs e)
    {
        //redirect to the main contract page
        Response.Redirect("Main Page Contract.aspx");
    }
}