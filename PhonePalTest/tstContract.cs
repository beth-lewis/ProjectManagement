using System;
using PhonePalClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PhonePalTest
{
    [TestClass]
    public class tstContract
    {
        //boolean variable to store the result of the validation
        String Error = "";
        //create some test data to assign to the properties
        string SomeContractType = "Pay As You Go";
        string SomeDataAllowance = "5gb";
        string SomeNumberOfMinutes = "600 Mins";
        string SomeNumberOfTexts = "Unlimited";
        int SomePricePerMonth = 30;
        string SomeDuration = "2 Years";
        int SomeContractNo = 1;
        int SomeCustomerNo = 1;
        int SomeManufacturerNo = 1;
        int SomeStaffNo = 1;
        DateTime TheStartDate = DateTime.Now.Date;
        //create an instance of the class we want to create
        clsContracts AContract = new clsContracts();
        [TestMethod]
        public void InstanceOK()
        {

            //test to see if that exists
            Assert.IsNotNull(AContract);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
   
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance, 
                SomeNumberOfMinutes,SomeNumberOfTexts,
                SomePricePerMonth,SomeDuration,
                SomeContractNo,SomeCustomerNo,SomeManufacturerNo,
                SomeStaffNo,TheStartDate
                );
            //test to see that the result is correct
            Assert.IsTrue(OK);
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
        public void ContractTypeMinLessOne()
        {
            string SomeContractType = "";
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance,
                SomeNumberOfMinutes, SomeNumberOfTexts,
                SomePricePerMonth, SomeDuration,
                SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
                SomeStaffNo, TheStartDate
                );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ContractTypeMinBoundary()
        {
          
            //pad the string with a single 'a' character
            SomeContractType = SomeContractType.PadRight(1, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ContractTypeMinPlusOne()
        {
            //pad the string with two 'a' characters
            SomeContractType = SomeContractType.PadRight(2, 'a');
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance,
                SomeNumberOfMinutes, SomeNumberOfTexts,
                SomePricePerMonth, SomeDuration,
                SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
                SomeStaffNo, TheStartDate
                );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ContractTypeMaxLessOne()
        {
            //pad the string with 29 'a' characters
            SomeContractType = SomeContractType.PadRight(29, 'a');
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance, 
                SomeNumberOfMinutes,SomeNumberOfTexts,
                SomePricePerMonth,SomeDuration,
                SomeContractNo,SomeCustomerNo,SomeManufacturerNo,
                SomeStaffNo,TheStartDate
                );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ContractTypeMaxBoundary()
        {
            //pad the string with 30 'a' characters
            SomeContractType = SomeContractType.PadRight(30, 'a');
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance,
                SomeNumberOfMinutes, SomeNumberOfTexts,
                SomePricePerMonth, SomeDuration,
                SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
                SomeStaffNo, TheStartDate
                );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ContractTypeMaxPlusOne()
        {
            //pad the string with 31 'a' characters
            SomeContractType = SomeContractType.PadRight(31, 'a');
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance,
                SomeNumberOfMinutes, SomeNumberOfTexts,
                SomePricePerMonth, SomeDuration,
                SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
                SomeStaffNo, TheStartDate
                );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ContractTypeMid()
        {
            //pad the string with 15 'a' characters
            SomeContractType = SomeContractType.PadRight(15, 'a');
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance,
                SomeNumberOfMinutes, SomeNumberOfTexts,
                SomePricePerMonth, SomeDuration,
                SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
                SomeStaffNo, TheStartDate
                );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ContractTypeMaxExtreme()
        {
            //pad the string with 300 'a' characters
            SomeContractType = SomeContractType.PadRight(300, 'a');
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance,
                SomeNumberOfMinutes, SomeNumberOfTexts,
                SomePricePerMonth, SomeDuration,
                SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
                SomeStaffNo, TheStartDate
                );
            //test to see that the result is correct
            Assert.IsFalse(OK);
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
        public void DataAllowanceMinLessOne()
        {
            SomeDataAllowance = "";
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DataAllowanceMinBoundary()
        {
            //pad the string with a 2 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(1, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DataAllowanceMinPlusOne()
        {
            //pad the string with 2 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(2, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DataAllowanceMaxLessOne()
        {
            //pad the string with 9 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(9, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DataAllowanceMaxBoundary()
        {
            //pad the string with 10 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(10, 'a');
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance,
                SomeNumberOfMinutes, SomeNumberOfTexts,
                SomePricePerMonth, SomeDuration,
                SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
                SomeStaffNo, TheStartDate
                );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DataAllowanceMaxPlusOne()
        {
            //pad the string with 11 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(11, 'a');
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance,
                SomeNumberOfMinutes, SomeNumberOfTexts,
                SomePricePerMonth, SomeDuration,
                SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
                SomeStaffNo, TheStartDate
                );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DataAllowanceMaxExtreme()
        {
            SomeDataAllowance = SomeDataAllowance.PadRight(100, 'a');
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance,
                SomeNumberOfMinutes, SomeNumberOfTexts,
                SomePricePerMonth, SomeDuration,
                SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
                SomeStaffNo, TheStartDate
                );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DataAllowanceMid()
        {
            //pad the string with 5 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(5, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
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
        public void NumberOfMinutesMinLessOne()
        {
            SomeNumberOfMinutes = "";
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NumberOfMinutesMinBoundary()
        {
            //pad the string with a single 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(1, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfMinutesMinPlusOne()
        {
            //pad the string with 2 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(2, 'a');
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance,
                SomeNumberOfMinutes, SomeNumberOfTexts,
                SomePricePerMonth, SomeDuration,
                SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
                SomeStaffNo, TheStartDate
                );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfMinutesMaxLessOne()
        {
            //pad the string with 49 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(49, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfMinutesMaxBoundary()
        {
            //pad the string with 50 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(50, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfMinutesMaxPlusOne()
        {
            //pad the string with 51 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(51, 'a');
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance,
                SomeNumberOfMinutes, SomeNumberOfTexts,
                SomePricePerMonth, SomeDuration,
                SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
                SomeStaffNo, TheStartDate
                );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NumberOfMinutesMaxExtreme()
        {
            //pad the string with 500 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(500, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NumberOfMinutesMid()
        {
            //pad the string with 25 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(25, 'a');
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance,
                SomeNumberOfMinutes, SomeNumberOfTexts,
                SomePricePerMonth, SomeDuration,
                SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
                SomeStaffNo, TheStartDate
                );
            //test to see that the result is correct
            Assert.IsTrue(OK);
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
        public void NumberOfTextsMinLessOne()
        {
            SomeNumberOfTexts = "";
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NumberOfTextsMinBoundary()
        {
            //pad the string with 1 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(1, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfTextsMinPlusOne()
        {
            //pad the string with 2 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(2, 'a');
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance,
                SomeNumberOfMinutes, SomeNumberOfTexts,
                SomePricePerMonth, SomeDuration,
                SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
                SomeStaffNo, TheStartDate
                );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfTextsMaxLessOne()
        {
            //pad the string with 49 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(49, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfTextsMaxBoundary()
        {
            //pad the string with 50 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(50, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfTextsMaxPlusOne()
        {
            //pad the string with 51 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(51, 'a');
            //invoke the method
            OK = AContract.Valid(
                SomeContractType, SomeDataAllowance,
                SomeNumberOfMinutes, SomeNumberOfTexts,
                SomePricePerMonth, SomeDuration,
                SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
                SomeStaffNo, TheStartDate
                );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NumberOfTextsMaxExtreme()
        {
            //pad the string with 500 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(500, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NumberOfTextsMid()
        {
            SomeNumberOfTexts = "";
            //pad the string with 25 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(25, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
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
        public void PricePerMonthMinLessOne()
        {
            int SomePricePerMonth = 0;
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void PricePerMonthMinBoundary()
        {
            int SomePricePerMonth = 1;
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PricePerMonthMinPlusOne()
        {
            int SomePricePerMonth = 11;
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PricePerMonthMaxLessOne()
        {
            int SomePricePerMonth = 999;
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PricePerMonthMaxBoundary()
        {
            int SomePricePerMonth = 9999;
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PricePerMonthMaxPlusOne()
        {
            SomePricePerMonth = 99999;
            //invoke the method
            OK = AContract.Valid(
              SomeContractType, SomeDataAllowance,
              SomeNumberOfMinutes, SomeNumberOfTexts,
              SomePricePerMonth, SomeDuration,
              SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
              SomeStaffNo, TheStartDate
              );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void PricePerMonthMaxExtreme()
        {
            int SomePricePerMonth = 999999999;
            //invoke the method
            OK = AContract.Valid(
              SomeContractType, SomeDataAllowance,
              SomeNumberOfMinutes, SomeNumberOfTexts,
              SomePricePerMonth, SomeDuration,
              SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
              SomeStaffNo, TheStartDate
              );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PricePerMonthMid()
        {
            int SomePricePerMonth = 10;
            //invoke the method
            OK = AContract.Valid(
              SomeContractType, SomeDataAllowance,
              SomeNumberOfMinutes, SomeNumberOfTexts,
              SomePricePerMonth, SomeDuration,
              SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
              SomeStaffNo, TheStartDate
              );
            //test to see that the result is correct
            Assert.IsTrue(OK);
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
        public void DurationMinLessOne()
        {
            SomeDuration = "";
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DurationMinBoundary()
        {
            //pad the string with 6 'a' character
            SomeDuration = SomeDuration.PadRight(6, 'a');
            //invoke the method
            OK = AContract.Valid(
               SomeContractType, SomeDataAllowance,
               SomeNumberOfMinutes, SomeNumberOfTexts,
               SomePricePerMonth, SomeDuration,
               SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
               SomeStaffNo, TheStartDate
               );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DurationMinPlusOne()
        {
            //pad the string with 8 'a' character
            SomeDuration = SomeDuration.PadRight(8, 'a');
            //invoke the method
            OK = AContract.Valid(
              SomeContractType, SomeDataAllowance,
              SomeNumberOfMinutes, SomeNumberOfTexts,
              SomePricePerMonth, SomeDuration,
              SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
              SomeStaffNo, TheStartDate
              );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DurationMaxLessOne()
        {
            SomeDuration = "";
            //pad the string with 19 'a' character
            SomeDuration = SomeDuration.PadRight(19, 'a');
            //invoke the method
            OK = AContract.Valid(
              SomeContractType, SomeDataAllowance,
              SomeNumberOfMinutes, SomeNumberOfTexts,
              SomePricePerMonth, SomeDuration,
              SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
              SomeStaffNo, TheStartDate
              );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DurationMaxBoundary()
        {
            SomeDuration = "";
            //pad the string with 20 'a' character
            SomeDuration = SomeDuration.PadRight(20, 'a');
            //invoke the method
            OK = AContract.Valid(
              SomeContractType, SomeDataAllowance,
              SomeNumberOfMinutes, SomeNumberOfTexts,
              SomePricePerMonth, SomeDuration,
              SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
              SomeStaffNo, TheStartDate
              );
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DurationMaxPlusOne()
        {
            //pad the string with 20 'a' character
            SomeDuration = SomeDuration.PadRight(21, 'a');
            //invoke the method
            OK = AContract.Valid(
              SomeContractType, SomeDataAllowance,
              SomeNumberOfMinutes, SomeNumberOfTexts,
              SomePricePerMonth, SomeDuration,
              SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
              SomeStaffNo, TheStartDate
              );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DurationMaxExtreme()
        {
            //pad the string with 20 'a' character
            SomeDuration = SomeDuration.PadRight(1000, 'a');
            //invoke the method
            OK = AContract.Valid(
              SomeContractType, SomeDataAllowance,
              SomeNumberOfMinutes, SomeNumberOfTexts,
              SomePricePerMonth, SomeDuration,
              SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
              SomeStaffNo, TheStartDate
              );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DurationMid()
        {
            SomeDuration = "";
            //pad the string with 20 'a' character
            SomeDuration = SomeDuration.PadRight(10, 'a');
            //invoke the method
            OK = AContract.Valid(
              SomeContractType, SomeDataAllowance,
              SomeNumberOfMinutes, SomeNumberOfTexts,
              SomePricePerMonth, SomeDuration,
              SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
              SomeStaffNo, TheStartDate
              );
            //test to see that the result is correct
            Assert.IsTrue(OK);
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
        [TestMethod]
        public void StartDateMinusOneDay()
        {
            //set to yesterdays date
            TheStartDate = TheStartDate.AddDays(-1);
            //invoke the method
            OK = AContract.Valid(
              SomeContractType, SomeDataAllowance,
              SomeNumberOfMinutes, SomeNumberOfTexts,
              SomePricePerMonth, SomeDuration,
              SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
              SomeStaffNo, TheStartDate
              );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void StartDatePlusOneDay()
        {
            TheStartDate = TheStartDate.AddDays(1);
            //invoke the method
            OK = AContract.Valid(
              SomeContractType, SomeDataAllowance,
              SomeNumberOfMinutes, SomeNumberOfTexts,
              SomePricePerMonth, SomeDuration,
              SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
              SomeStaffNo, TheStartDate
              );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void StartDateExtremePlus()
        {
            TheStartDate = TheStartDate.AddYears(100);
            //invoke the method
            OK = AContract.Valid(
              SomeContractType, SomeDataAllowance,
              SomeNumberOfMinutes, SomeNumberOfTexts,
              SomePricePerMonth, SomeDuration,
              SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
              SomeStaffNo, TheStartDate
              );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void StartDateExtremeMinus()
        {
            TheStartDate = TheStartDate.AddYears(-100);
            //invoke the method
            OK = AContract.Valid(
              SomeContractType, SomeDataAllowance,
              SomeNumberOfMinutes, SomeNumberOfTexts,
              SomePricePerMonth, SomeDuration,
              SomeContractNo, SomeCustomerNo, SomeManufacturerNo,
              SomeStaffNo, TheStartDate
              );
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

    }
}
