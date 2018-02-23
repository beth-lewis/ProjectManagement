using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using PhonePalClassLibrary;
using System.Collections.Generic;

namespace PhonePalTest
{
    [TestClass]
    public class tstContractCollection
    {   //create an instance of the class 
        clsContractCollection AllContracts = new clsContractCollection();
        [TestMethod]
        public void InstanceOK()
        {
         
            //create some test data to assign to the property
            Int32 SomeCount = 1;
            //assign data to the property
            AllContracts.Count = SomeCount;
            //test to see that it exists
            Assert.AreEqual(AllContracts.Count, SomeCount);
        }
        [TestMethod]
        public void AllContractsOK()
        {
            //create some test to assign to the property
            //in this case the data needs to be a list of objects
            List<clsContract> TestList = new List<clsContract>();
            //add an item to the list 
            //create the item of test data
            clsContract TestItem = new clsContract();
            //set its properties

        }
    }
}
