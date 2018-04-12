﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhonePalClassLibrary;

public partial class Contract : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted or updated
    Int32 ContractNo;
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            lstContracts.ClearSelection();
            //update the list box
            DisplayContracts();
            
        }
    }
    void DisplayContracts()
    {
        //create an instance of the contract collection
        clsContractCollection Contracts = new clsContractCollection();
        //set the data source to the list of contracts in the collection
        lstContracts.DataSource = Contracts.ContractList;
        //set the name of the primary key
        lstContracts.DataValueField = "ContractNo";
        //set the data field to display
        lstContracts.DataTextField = "ContractType";
        //bind the data to the list
        lstContracts.DataBind();
        
    }
 
    //event handler for the add a Contract Button
    protected void btnAddAContract_Click(object sender, EventArgs e)
    {
        //stores -1 into the session object which indicates it's a new record
        Session["ContractNo"] = -1;
        //redirects to the add contract page
        Response.Redirect("A Contract.aspx");
    }
    //event handler for upgrade contract
    protected void btnUpgradeContract_Click(object sender, EventArgs e)
    {
        //if a record has been selected from the list
        if (lstContracts.SelectedIndex != -1)
        {
            //get the primary key vale of the record to edit
            ContractNo = Convert.ToInt32(lstContracts.SelectedValue);
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

    protected void btnFindAContract_Click(object sender, EventArgs e)
    {
        //redirects to the find contract page
        Response.Redirect("Find A Contract.aspx");
    }

    protected void btnDeleteContract_Click(object sender, EventArgs e)
    {
        //if a record has been selected from the list
        if (lstContracts.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            ContractNo = Convert.ToInt32(lstContracts.SelectedValue);
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
