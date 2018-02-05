using System;
using PhonePalClassLibrary;
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
            string TestData = "Pay As You Go";
            //assign data to the property
            AContract.ContractType = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.ContractType, TestData);
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
        [TestMethod]
        public void PricePerMonthPropertyOK()
        {
            //create some test data to assign to the property
            decimal TestData = 30;
            //assign data to the property
            AContract.PricePerMonth = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.PricePerMonth, TestData);
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
        [TestMethod]
        public void ContractNoPropertyOK()
        {
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign data to the property
            AContract.ContractNo = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.ContractNo, TestData);
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
        [TestMethod]
        public void ManufacturerNoPropertyOK()
        {
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign data to the property
            AContract.ManufacturerNo = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.ManufacturerNo, TestData);
        }
        [TestMethod]
        public void StaffNoPropertyOK()
        {
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign data to the property
            AContract.StaffNo = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.StaffNo, TestData);
        }
        [TestMethod]
        public void StartDatePropertyOK()
        {
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AContract.StartDate = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AContract.StartDate, TestData);
        }
    }
}
