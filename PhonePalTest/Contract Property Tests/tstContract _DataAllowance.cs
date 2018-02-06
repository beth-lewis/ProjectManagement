using System;
using PhonePalClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PhonePalTest
{
    //test class for Data Allowance 
    [TestClass]
    public class tstContract_DataAllowance
    {
        //create an instance of the class we want to create
        clsContract AContract = new clsContract();
        [TestMethod]
        public void InstanceOK()
        {

            //test to see if that exists
            Assert.IsNotNull(AContract);
        }
        
        [TestMethod]
        public void DataAllowancePropertyOK()
        {
            //create some test data to assign to the property
            string TestData = "5GB";
            //assign data to the property
            AContract.DataAllowance = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.DataAllowance, TestData);
        }
    }
}
