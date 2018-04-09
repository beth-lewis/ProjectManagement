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
        string SomePricePerMonth = "30";
        string SomeDuration = "2 Years";
        string TheStartDate = DateTime.Now.Date.ToString();
        string SomeStaffNo = "1";
        string SomeManufacturerNo = "1";
        string SomeCustomerNo = "1";
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
            Error = AContract.Valid(
              SomeContractType, 
              SomeDataAllowance,
              SomeNumberOfMinutes, 
              SomeNumberOfTexts,
              SomePricePerMonth, 
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
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
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ContractTypeMinBoundary()
        {
          
            //pad the string with a single 'a' character
            SomeContractType = SomeContractType.PadRight(1, 'a');
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContractTypeMinPlusOne()
        {
            //pad the string with two 'a' characters
            SomeContractType = SomeContractType.PadRight(2, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContractTypeMaxLessOne()
        {
            //pad the string with 29 'a' characters
            SomeContractType = SomeContractType.PadRight(29, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContractTypeMaxBoundary()
        {
            //pad the string with 30 'a' characters
            SomeContractType = SomeContractType.PadRight(30, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContractTypeMaxPlusOne()
        {
            //pad the string with 31 'a' characters
            SomeContractType = SomeContractType.PadRight(31, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ContractTypeMid()
        {
            //pad the string with 15 'a' characters
            SomeContractType = SomeContractType.PadRight(15, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContractTypeMaxExtreme()
        {
            //pad the string with 300 'a' characters
            SomeContractType = SomeContractType.PadRight(300, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
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
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DataAllowanceMinBoundary()
        {
            //pad the string with a 2 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(1, 'a');
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DataAllowanceMinPlusOne()
        {
            //pad the string with 2 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(2, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DataAllowanceMaxLessOne()
        {
            //pad the string with 9 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(9, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DataAllowanceMaxBoundary()
        {
            //pad the string with 10 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(10, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DataAllowanceMaxPlusOne()
        {
            //pad the string with 11 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(11, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DataAllowanceMaxExtreme()
        {
            SomeDataAllowance = SomeDataAllowance.PadRight(100, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DataAllowanceMid()
        {
            //pad the string with 5 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(5, 'a');
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
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
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NumberOfMinutesMinBoundary()
        {
            //pad the string with a single 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(1, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NumberOfMinutesMinPlusOne()
        {
            //pad the string with 2 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(2, 'a');
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NumberOfMinutesMaxLessOne()
        {
            //pad the string with 49 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(49, 'a');
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NumberOfMinutesMaxBoundary()
        {
            //pad the string with 50 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(50, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NumberOfMinutesMaxPlusOne()
        {
            //pad the string with 51 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(51, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NumberOfMinutesMaxExtreme()
        {
            //pad the string with 500 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(500, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NumberOfMinutesMid()
        {
            //pad the string with 25 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(25, 'a');
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
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
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NumberOfTextsMinBoundary()
        {
            //pad the string with 1 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(1, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NumberOfTextsMinPlusOne()
        {
            //pad the string with 2 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(2, 'a');
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NumberOfTextsMaxLessOne()
        {
            //pad the string with 49 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(49, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NumberOfTextsMaxBoundary()
        {
            //pad the string with 50 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(50, 'a');
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NumberOfTextsMaxPlusOne()
        {
            //pad the string with 51 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(51, 'a');
            //invoke the method
            Error = AContract.Valid(
                SomeContractType,
                SomeDataAllowance,
                SomeNumberOfMinutes,
                SomeNumberOfTexts,
                SomePricePerMonth,
                SomeDuration,
               TheStartDate,
               SomeStaffNo,
               SomeManufacturerNo,
               SomeCustomerNo
                );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NumberOfTextsMaxExtreme()
        {
            //pad the string with 500 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(500, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NumberOfTextsMid()
        {
            SomeNumberOfTexts = "";
            //pad the string with 25 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(25, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
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
            string SomePricePerMonth = "0";
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PricePerMonthMinBoundary()
        {
            string SomePricePerMonth = "1";
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PricePerMonthMinPlusOne()
        {
            string SomePricePerMonth = "11";
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PricePerMonthMaxLessOne()
        {
            string SomePricePerMonth = "999";
            //invoke the method
            Error = AContract.Valid(
                SomeContractType,
                SomeDataAllowance,
                SomeNumberOfMinutes,
                SomeNumberOfTexts,
                SomePricePerMonth,
                SomeDuration,
               TheStartDate,
               SomeStaffNo,
               SomeManufacturerNo,
               SomeCustomerNo
                );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PricePerMonthMaxBoundary()
        {
            string SomePricePerMonth = "9999";
            //invoke the method
            Error = AContract.Valid(
                SomeContractType,
                SomeDataAllowance,
                SomeNumberOfMinutes,
                SomeNumberOfTexts,
                SomePricePerMonth,
                SomeDuration,
               TheStartDate,
               SomeStaffNo,
               SomeManufacturerNo,
               SomeCustomerNo
                );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PricePerMonthMaxPlusOne()
        {
            SomePricePerMonth = "99999";
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PricePerMonthMaxExtreme()
        {
            SomePricePerMonth = "999999999";
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PricePerMonthMid()
        {
            SomePricePerMonth = "10";
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
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
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DurationMinBoundary()
        {
            //pad the string with 6 'a' character
            SomeDuration = SomeDuration.PadRight(6, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DurationMinPlusOne()
        {
            //pad the string with 8 'a' character
            SomeDuration = SomeDuration.PadRight(8, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DurationMaxLessOne()
        {
            SomeDuration = "";
            //pad the string with 19 'a' character
            SomeDuration = SomeDuration.PadRight(19, 'a');
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DurationMaxBoundary()
        {
            SomeDuration = "";
            //pad the string with 20 'a' character
            SomeDuration = SomeDuration.PadRight(20, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DurationMaxPlusOne()
        {
            //pad the string with 20 'a' character
            SomeDuration = SomeDuration.PadRight(21, 'a');
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DurationMaxExtreme()
        {
            //pad the string with 20 'a' character
            SomeDuration = SomeDuration.PadRight(1000, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DurationMid()
        {
            SomeDuration = "";
            //pad the string with 20 'a' character
            SomeDuration = SomeDuration.PadRight(10, 'a');
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
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
        public void StartDateMin()
        {
            //set to todays date
            TheStartDate = DateTime.Now.Date.ToString();
            //convert the date variable to a string variable
            string StartDate = TheStartDate.ToString();
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StartDateMinLessOne()
        { 
            //set to yesterdays date
            //TheStartDate 
            DateTime TempDate =Convert.ToDateTime(TheStartDate).AddDays(-1);
            TheStartDate = TempDate.ToString();
            //convert the date variable to a string variable
            string StartDate = TheStartDate.ToString();
            //invoke the method
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartDateMinPlusOne()
        {
            //set to todays date plus one day
            DateTime TempDate = Convert.ToDateTime(TheStartDate).AddDays(1);
            TheStartDate = TempDate.ToString();
            //convert the date variable to a string variable
            string StartDate = TheStartDate.ToString();
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartDateExtremeMin()
        {
            //set date to todays date minus 100 years
            DateTime TempDate = Convert.ToDateTime(TheStartDate).AddYears(-100);
            TheStartDate = TempDate.ToString();
            //convert the date variable to a string variable
            string StartDate = TheStartDate.ToString();
            //invoke the method
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartDateExtremeMax()
        {
            //set date to todays date plus 100 years
            DateTime TempDate = Convert.ToDateTime(TheStartDate).AddYears(100);
            TheStartDate = TempDate.ToString();
            //convert the date variable to a string variable
            string StartDate = TheStartDate.ToString();
            //invoke the method
            Error = AContract.Valid(
              SomeContractType,
              SomeDataAllowance,
              SomeNumberOfMinutes,
              SomeNumberOfTexts,
              SomePricePerMonth,
              SomeDuration,
             TheStartDate,
             SomeStaffNo,
             SomeManufacturerNo,
             SomeCustomerNo
              );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartDateInvalidData()
        {
            //set the start date to a non date value
            string TheStartDate = "this is not a date";
            Error = AContract.Valid(
               SomeContractType,
               SomeDataAllowance,
               SomeNumberOfMinutes,
               SomeNumberOfTexts,
               SomePricePerMonth,
               SomeDuration,
              TheStartDate,
              SomeStaffNo,
              SomeManufacturerNo,
              SomeCustomerNo
               );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
     [TestMethod]
      public void TestContractNoFound()
        {
            //boolean to store the result of the search
            Boolean Found = false;
            //boolean variable to sorre the result of the searc
            Boolean OK = true;
            //create some test data
            Int32 ContractNo = 1;
            //invoke method
            Found = AContract.Find(ContractNo);
            //check the contract no
            if (AContract.ContractNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestContractTypeFound()
        {
            //boolean to store the result of the search
            Boolean Found = false;
            //boolean variable to sorre the result of the searc
            Boolean OK = true;
            //create some test data
            Int32 ContractNo = 1;
            //invoke method
            Found = AContract.Find(ContractNo);
            //check the contract type
            if (AContract.ContractType != "Pay As You Go")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDataAllowanceFound()
        {
            //boolean to store the result of the search
            Boolean Found = false;
            //boolean variable to sorre the result of the searc
            Boolean OK = true;
            //create some test data
            Int32 ContractNo = 1;
            //invoke method
            Found = AContract.Find(ContractNo);
            //check the data allowance
            if (AContract.DataAllowance != "6Gb")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDurationFound()
        {
            //boolean to store the result of the search
            Boolean Found = false;
            //boolean variable to sorre the result of the searc
            Boolean OK = true;
            //create some test data
            Int32 ContractNo = 1;
            //invoke method
            Found = AContract.Find(ContractNo);
            //check the duration
            if (AContract.Duration != "1 Year")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestNumberOfMinutesFound()
        {
            //boolean to store the result of the search
            Boolean Found = false;
            //boolean variable to sorre the result of the searc
            Boolean OK = true;
            //create some test data
            Int32 ContractNo = 1;
            //invoke method
            Found = AContract.Find(ContractNo);
            //check the Number Of Minutes
            if (AContract.NumberOfMinutes != "600 Mins")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestNumberOfTextsFound()
        {
            //boolean to store the result of the search
            Boolean Found = false;
            //boolean variable to sorre the result of the searc
            Boolean OK = true;
            //create some test data
            Int32 ContractNo = 1;
            //invoke method
            Found = AContract.Find(ContractNo);
            //check the Number Of Texts
            if (AContract.NumberOfTexts != "5000 Texts")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestPricePerMonthFound()
        {
            //boolean to store the result of the search
            Boolean Found = false;
            //boolean variable to sorre the result of the searc
            Boolean OK = true;
            //create some test data
            Int32 ContractNo = 1;
            //invoke method
            Found = AContract.Find(ContractNo);
            //check the price per month
            if (AContract.PricePerMonth != 20)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStartDateFound()
        {
            //boolean to store the result of the search
            Boolean Found = false;
            //boolean variable to sorre the result of the searc
            Boolean OK = true;
            //create some test data
            Int32 ContractNo = 1;
            //invoke method
            Found = AContract.Find(ContractNo);
            //check the startdate
            if (AContract.StartDate != Convert.ToDateTime("09/04/2018"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
    }
}
