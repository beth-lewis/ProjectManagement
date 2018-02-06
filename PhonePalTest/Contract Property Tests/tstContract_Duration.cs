using System;
using PhonePalClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PhonePalTest
{
    [TestClass]
    public class tstContract_Duration
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
        public void DurationPropertyOK()
        {
            //create some test data to assign to the property
            string TestData = "12 Months";
            //assign data to the property
            AContract.Duration = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.Duration, TestData);
        }
    }
}
