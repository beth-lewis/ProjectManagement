using System;
using PhonePalClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PhonePalTest
{
    [TestClass]
    public class tstContract_CustomerNo
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
        public void CustomerNoPropertyOK()
        {
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign data to the property
            AContract.CustomerNo = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.CustomerNo, TestData);
        }
    }
}
