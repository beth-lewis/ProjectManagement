using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace PhonePalTest
{
    [TestClass]
    public class tstManufacturer
    {
        string ManufacturerName = "Nokia";
        string ManufacturerLocation = "Sweden";
        string YearStarted = "1/1/2011";
        string EMail="blah@nokia.com";
        string Telephone = "12345678901";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsManufacturer AManufacturer = new clsManufacturer();
            //test to see if it exists
            Assert.IsNotNull(AManufacturer);
        }

        [TestMethod]
        public void VaildMethodOK()
            {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            //ManufacturerName = "Apple";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
            }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AManufacturer.Active = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AManufacturer.Active, TestData);
        }

        [TestMethod]
        public void DateAdded()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AManufacturer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AManufacturer.DateAdded, TestData);
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to 100 years ago
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string YearStarted = TestDate.ToString();
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see result ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ManufacturerNoOK()
        {
            //create an insatnce of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AManufacturer.ManufacturerNo = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AManufacturer.ManufacturerNo, TestData);
        }

        [TestMethod]
        public void LocationPropertyOk()
        {
            //create an instance
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //create some test data
            string ManufacturerLocation = "Leeds";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationPropertyMin()
        {
            //create an instance
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //create some test data
            string ManufacturerLocation = "L";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LoctionPropertyBlank()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string ManufacturerLocation = "";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationPropertyMax()
        {
            //create an instance 
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //creat some some test data 
            string ManufacturerLocation = "llllllllllllllllllllllllllllllllllllllllllllllllll";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationPropertyMaxPlus1()
        {
            //create an instance 
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //creat some some test data 
            string ManufacturerLocation = "lllllllllllllllllllllllllllllllllllllllllllllllllll";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationPropertyExtremeMax()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to sotre the result of validation
            String Error = "";
            //create some test data
            string ManufacturerLocation = "";
            //pad the string with characters
            ManufacturerLocation = ManufacturerLocation.PadRight(500, 'a');
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //create some test data
            string ManufacturerName = "Apple";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NamePropertyMin()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string ManufacturerName = "a";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NamePropertyMinBlank()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string ManufacturerName = "";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NamePropertyMax()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string ManufacturerName = "llllllllllllllllllllllllllllllllllllllllllllllllll";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NamePropertyMaxPlus1()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string ManufacturerName = "lllllllllllllllllllllllllllllllllllllllllllllllllll";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NamePropertyExtremeMax()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to sotre the result of validation
            String Error = "";
            //create some test data
            string ManufacturerName = "";
            //pad the string with characters
            ManufacturerName = ManufacturerName.PadRight(500, 'a');
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string ManufacturerName = "apple@apple.com";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailPropertyBlank()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string EMail = "";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephonePropertyOK()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Telephone = "01234567891";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephonePropertyBlank()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            String Error = "";
            //create some test data
            string Telephone = "";
            //invoke the method
            Error = AManufacturer.Valid(ManufacturerName, ManufacturerLocation, YearStarted, EMail, Telephone);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
    }

}
