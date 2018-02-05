using System;
using PhonePalClassLibrary
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PhonePalTest
{
    [TestClass]
    public class tstContract
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
        public void ContractTypePropertyOK()
        {
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            //assign data to the property
            AContract.ContractType = SomeContractType;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.ContractType, SomeContractType);
        }
        [TestMethod]
        public void DataAllowancePropertyOK()
        {
            //create some test data to assign to the property
            string SomeDataAllowance = "5GB";
            //assign data to the property
            AContract.DataAllowance = SomeDataAllowance;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.DataAllowance, SomeDataAllowance);
        }
        [TestMethod]
        public void NumberOfMinutesPropertyOK()
        {
            //create some test data to assign to the property
            string SomeNumberOfMinutes = "600 Mins";
            //assign data to the property
            AContract.NumberOfMinutes = SomeNumberOfMinutes;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.NumberOfMinutes, SomeNumberOfMinutes);
        }
        [TestMethod]
        public void NumberOfTextsPropertyOK()
        {
            //create some test data to assign to the property
            string SomeNumberOfTexts = "Unlimited";
            //assign data to the property
            AContract.NumberOfTexts = SomeNumberOfTexts;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.NumberOfTexts, SomeNumberOfTexts);
        }
    }
}
