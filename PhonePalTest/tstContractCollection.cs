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
            TestItem.contractType = "Pay As You Go";
            TestItem.dataAllowance = "5gb";
            TestItem.numberOfMinutes = "600 Mins";
            TestItem.numberOfTexts = "Unlimited";
            TestItem.pricePerMonth = 30;
            TestItem.duration = "2 Years";
            TestItem.contractNo = 1;
            TestItem.customerNo = 1;
            TestItem.manufacturerNo = 1;
            TestItem.staffNo = 1;
            TestItem.startDate = DateTime.Now.Date;
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
            TestContract.contractNo = 1;
            TestContract.contractType = "Pay As You Go";
            TestContract.customerNo = 1;
            TestContract.dataAllowance = "5gb";
            TestContract.duration = "2 Years";
            TestContract.manufacturerNo = 1;
            TestContract.numberOfMinutes = "600 Mins";
            TestContract.numberOfTexts = "Unlimited";
            TestContract.pricePerMonth = 30;
            TestContract.staffNo = 1;
            TestContract.startDate = DateTime.Now.Date;
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
            TestItem.contractNo = 1;
            TestItem.contractType = "Pay As You Go";
            TestItem.customerNo = 1;
            TestItem.dataAllowance = "5gb";
            TestItem.duration = "2 Years";
            TestItem.manufacturerNo = 1;
            TestItem.numberOfMinutes = "600 Mins";
            TestItem.numberOfTexts = "Unlimited";
            TestItem.pricePerMonth = 30;
            TestItem.staffNo = 1;
            TestItem.startDate = DateTime.Now.Date;
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
            TestItem.contractNo = 1;
            TestItem.contractType = "Pay As You Go";
            TestItem.customerNo = 1;
            TestItem.dataAllowance = "5gb";
            TestItem.duration = "2 Years";
            TestItem.manufacturerNo = 1;
            TestItem.numberOfMinutes = "600 Mins";
            TestItem.numberOfTexts = "Unlimited";
            TestItem.pricePerMonth = 30;
            TestItem.staffNo = 1;
            TestItem.startDate = DateTime.Now.Date;
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
            TestItem.contractNo = 1;
            TestItem.contractType = "Pay As You Go";
            TestItem.customerNo = 1;
            TestItem.dataAllowance = "5gb";
            TestItem.duration = "2 Years";
            TestItem.manufacturerNo = 1;
            TestItem.numberOfMinutes = "600 Mins";
            TestItem.numberOfTexts = "Unlimited";
            TestItem.pricePerMonth = 30;
            TestItem.staffNo = 1;
            TestItem.startDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Contracts.AllContracts = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Contracts.Count, TestList.Count);

        }
       
    }
}
