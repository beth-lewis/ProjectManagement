using System;
using PhonePalClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PhonePalTest
{
    [TestClass]
    public class tstContract_NumberOfTexts
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
        public void NumberOfTextsPropertyOK()
        {
            //create some test data to assign to the property
            string TestData = "Unlimited";
            //assign data to the property
            AContract.NumberOfTexts = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.NumberOfTexts, TestData);
        }
    }
}
