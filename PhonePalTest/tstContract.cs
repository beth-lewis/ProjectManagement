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
        public void ValidMethodOK()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property 
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
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
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes, SomeNumberOfTexts, SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ContractTypeMinBoundary()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with a single 'a' character
            SomeContractType = SomeContractType.PadRight(1, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ContractTypeMinPlusOne()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with two 'a' characters
            SomeContractType = SomeContractType.PadRight(2, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ContractTypeMaxLessOne()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 29 'a' characters
            SomeContractType = SomeContractType.PadRight(29, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ContractTypeMaxBoundary()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 30 'a' characters
            SomeContractType = SomeContractType.PadRight(30, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ContractTypeMaxPlusOne()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 31 'a' characters
            SomeContractType = SomeContractType.PadRight(31, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ContractTypeMid()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 15 'a' characters
            SomeContractType = SomeContractType.PadRight(15, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ContractTypeMaxExtreme()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 300 'a' characters
            SomeContractType = SomeContractType.PadRight(300, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
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
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes, SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DataAllowanceMinBoundary()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with a 2 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(1, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DataAllowanceMinPlusOne()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 2 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(2, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DataAllowanceMaxLessOne()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 9 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(9, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DataAllowanceMaxBoundary()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 10 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(10, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DataAllowanceMaxPlusOne()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 11 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(11, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DataAllowanceMaxExtreme()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            SomeDataAllowance = SomeDataAllowance.PadRight(100, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DataAllowanceMid()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 5 'a' character
            SomeDataAllowance = SomeDataAllowance.PadRight(5, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
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
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes, SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NumberOfMinutesMinBoundary()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with a single 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(1, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfMinutesMinPlusOne()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 2 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(2, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfMinutesMaxLessOne()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 49 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(49, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfMinutesMaxBoundary()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 50 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(50, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfMinutesMaxPlusOne()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 51 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(51, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NumberOfMinutesMaxExtreme()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "";
            string SomeNumberOfTexts = "Unlimited";
            int SomePricePerMonth = 30;
            //pad the string with 500 'a' character
            SomeNumberOfMinutes = SomeNumberOfMinutes.PadRight(500, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType,SomeDataAllowance,SomeNumberOfMinutes,SomeNumberOfTexts,SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsFalse(OK);
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
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "";
            int SomePricePerMonth = 30;
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes,SomeNumberOfTexts, SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NumberOfTextsMinBoundary()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "";
            int SomePricePerMonth = 30;
            //pad the string with 1 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(1, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes, SomeNumberOfTexts, SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfTextsMinPlusOne()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "";
            int SomePricePerMonth = 30;
            //pad the string with 2 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(2, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes, SomeNumberOfTexts, SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfTextsMaxLessOne()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "";
            int SomePricePerMonth = 30;
            //pad the string with 49 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(49, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes, SomeNumberOfTexts, SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfTextsMaxBoundary()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "";
            int SomePricePerMonth = 30;
            //pad the string with 50 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(50, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes, SomeNumberOfTexts, SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NumberOfTextsMaxPlusOne()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "";
            int SomePricePerMonth = 30;
            //pad the string with 51 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(51, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes, SomeNumberOfTexts, SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NumberOfTextsMaxExtreme()
        {
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeContractType = "Pay As You Go";
            string SomeDataAllowance = "5gb";
            string SomeNumberOfMinutes = "600 Mins";
            string SomeNumberOfTexts = "";
            int SomePricePerMonth = 30;
            //pad the string with 500 'a' character
            SomeNumberOfTexts = SomeNumberOfTexts.PadRight(500, 'a');
            //invoke the method
            OK = AContract.Valid(SomeContractType, SomeDataAllowance, SomeNumberOfMinutes, SomeNumberOfTexts, SomePricePerMonth);
            //test to see that the result is correct
            Assert.IsFalse(OK);
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
