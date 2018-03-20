﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contract : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayContracts();
        }
    }
    void DisplayContracts()
    {
        //create an instance of the contract collection
        PhonePalClassLibrary.clsContractCollection Contracts = new PhonePalClassLibrary.clsContractCollection();
        //set the data source to the list of contracts in the collection
        lstContracts.DataSource = Contracts.ContractList;
        //set the name of the primary key
        lstContracts.DataValueField = "ContractNo";
        //set the data field to display
        lstContracts.DataTextField = "ContractType";
        //bind the data to the list
        lstContracts.DataBind();
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
