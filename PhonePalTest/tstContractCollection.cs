using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhonePalClassLibrary;
using System.Collections.Generic;

namespace PhonePalTest
{
    [TestClass]
    public class tstContractCollection
    {   
        //create some test data to assign to the property
        List<clsContracts> TestList = new List<clsContracts>();
      


        [TestMethod]
        public void ContractListOK()
        {
            clsContractCollection AllContracts = new clsContractCollection();
            List<clsContracts> TestList = new List<clsContracts>();
            //create the item of test data
            clsContracts TestItem = new clsContracts();
            TestItem.ContractType = "Pay As You Go";
            TestItem.DataAllowance = "5gb";
            TestItem.NumberOfMinutes = "600 Mins";
            TestItem.NumberOfTexts = "Unlimited";
            TestItem.PricePerMonth = 30;
            TestItem.Duration = "2 Years";
            TestItem.ContractNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.ManufacturerNo = 1;
            TestItem.StaffNo = 1;
            TestItem.StartDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllContracts.ContractList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllContracts.ContractList, TestList);
        }
        [TestMethod]
        public void ThisContractPropertyOK()
        {
            //create an instance of the class 
            clsContractCollection AllContracts = new clsContractCollection();
            //create some test data to assign to the property
            clsContracts TestContract = new clsContracts();
            //set the properties of the test object
            TestContract.ContractNo = 1;
            TestContract.ContractType = "Pay As You Go";
            TestContract.CustomerNo = 1;
            TestContract.DataAllowance = "5gb";
            TestContract.Duration = "2 Years";
            TestContract.ManufacturerNo = 1;
            TestContract.NumberOfMinutes = "600 Mins";
            TestContract.NumberOfTexts = "Unlimited";
            TestContract.PricePerMonth = 30;
            TestContract.StaffNo = 1;
            TestContract.StartDate = DateTime.Now.Date;
            //assign the data to the property
            AllContracts.ThisContract = TestContract;
           //test to see that the two values are the same
           Assert.AreEqual(AllContracts.ThisContract, TestContract);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create the item of test data
            clsContracts TestItem = new clsContracts();
            //create an instance of the class we want to create 
            clsContractCollection AllContracts = new clsContractCollection();
            //create an item for the test data
            //here is the test data
            TestItem.ContractNo = 1;
            TestItem.ContractType = "Pay As You Go";
            TestItem.CustomerNo = 1;
            TestItem.DataAllowance = "5gb";
            TestItem.Duration = "2 Years";
            TestItem.ManufacturerNo = 1;
            TestItem.NumberOfMinutes = "600 Mins";
            TestItem.NumberOfTexts = "Unlimited";
            TestItem.PricePerMonth = 30;
            TestItem.StaffNo = 1;
            TestItem.StartDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllContracts.ContractList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllContracts.Count, TestList.Count);
        }
        [TestMethod]
        public void AllContractsOK()
        {
            //create an instance of the class
            clsContractCollection Contracts = new clsContractCollection();
            List<clsContracts> TestList = new List<clsContracts>();
            //add an item to the list
            clsContracts TestItem = new clsContracts();
            //set it's properties
            TestItem.ContractNo = 1;
            TestItem.ContractType = "Pay As You Go";
            TestItem.CustomerNo = 1;
            TestItem.DataAllowance = "5gb";
            TestItem.Duration = "2 Years";
            TestItem.ManufacturerNo = 1;
            TestItem.NumberOfMinutes = "600 Mins";
            TestItem.NumberOfTexts = "Unlimited";
            TestItem.PricePerMonth = 30;
            TestItem.StaffNo = 1;
            TestItem.StartDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign data to the property
            Contracts.AllContracts = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Contracts.AllContracts, TestList);
        }
        [TestMethod]
        public void CountMatchesList()
        {
      
            clsContractCollection Contracts = new clsContractCollection();
            //create some test to assign to the property
            //in this case the data needs to be a list of objects
            List<clsContracts> TestList = new List<clsContracts>();
            //add an item to the list 
            //create the item of test data
            clsContracts TestItem = new clsContracts();
            //set its properties
            TestItem.ContractNo = 1;
            TestItem.ContractType = "Pay As You Go";
            TestItem.CustomerNo = 1;
            TestItem.DataAllowance = "5gb";
            TestItem.Duration = "2 Years";
            TestItem.ManufacturerNo = 1;
            TestItem.NumberOfMinutes = "600 Mins";
            TestItem.NumberOfTexts = "Unlimited";
            TestItem.PricePerMonth = 30;
            TestItem.StaffNo = 1;
            TestItem.StartDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Contracts.AllContracts = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Contracts.Count, TestList.Count);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsContracts AContract = new clsContracts();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ContractNo = 1;
            //invoke the method
            Found = AContract.Find(ContractNo);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsContractCollection AllContracts = new clsContractCollection();
            ////create the item of test data
            clsContracts TestItem = new clsContracts();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ContractNo = 0;
            TestItem.ContractType = "Pay As You Go";
            TestItem.CustomerNo = 0;
            TestItem.DataAllowance = "5gb";
            TestItem.Duration = "2 Years";
            TestItem.ManufacturerNo = 0;
            TestItem.NumberOfMinutes = "600 Mins";
            TestItem.NumberOfTexts = "Unlimited";
            TestItem.PricePerMonth = 30;
            TestItem.StaffNo = 0;
            TestItem.StartDate = DateTime.Now.Date;
            //set ThisContract to the test data 
            AllContracts.ThisContract = TestItem;
            //add the record
            PrimaryKey = AllContracts.Add();
            //set the primary key of the test data
            TestItem.ContractNo = PrimaryKey;
            //find the record
            AllContracts.ThisContract.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllContracts.ThisContract, TestItem);
        }

    }
}
