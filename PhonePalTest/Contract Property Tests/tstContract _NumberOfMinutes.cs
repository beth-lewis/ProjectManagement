using System;
using PhonePalClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PhonePalTest
{
    //test class for Number of Minutes
    [TestClass]
    public class tstContract_NumberOfMinutes
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
        public void NumberOfMinutesPropertyOK()
        {
            //create some test data to assign to the property
            string TestData = "600 Mins";
            //assign data to the property
            AContract.NumberOfMinutes = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.NumberOfMinutes, TestData);
        }
    }
}
