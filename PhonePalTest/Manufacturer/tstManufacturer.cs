using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace PhonePalTest
{
    [TestClass]
    public class tstManufacturer
    {
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
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeManufacturer = "Apple";
            //invoke the method
            OK = AManufacturer.Valid(SomeManufacturer);
            //test to see if the result is correct
            Assert.IsTrue(OK);
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
            //boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeManufacturer = "Apple";
            //invoke the method
            OK = AManufacturer.Valid(SomeManufacturer);
            //test to see if the result is correct
            Assert.IsTrue(OK);

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
            //create some test data
            string TestData = "Leeds";
            //assign the data to the property
            AManufacturer.Location = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AManufacturer.Location, TestData);
        }

        [TestMethod]
        public void LocationPropertyMin()
        {
            //create an instance
            clsManufacturer AManufacturer = new clsManufacturer();
            //create some test data
            string TestData = "L";
            //assign the data to th property 
            AManufacturer.Location = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AManufacturer.Location, TestData);
        }
        [TestMethod]
        public void LoctionPropertyBlank()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeManufacturer = "";
            //invoke the method
            OK = AManufacturer.Valid(SomeManufacturer);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LocationPropertyMax()
        {
            //create an instance 
            clsManufacturer AManufacturer = new clsManufacturer();
            //creat some some test data 
            string TestData = "llllllllllllllllllllllllllllllllllllllllllllllllll";
            //assign the data to the property
            AManufacturer.Location = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AManufacturer.Location, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance 
            clsManufacturer AManufacturer = new clsManufacturer();
            //create some test data
            string TestData = "Apple";
            //assign the data to the property
            AManufacturer.Name = TestData;
            //test to see if the values are the same
            Assert.AreEqual(AManufacturer.Name, TestData);
        }

        [TestMethod]
        public void NamePropertyMin()
        {
            //create an instance 
            clsManufacturer AManufacturer = new clsManufacturer();
            //create some test data
            string TestData = "A";
            //assign the data to the property
            AManufacturer.Name = TestData;
            //test to see if the values are the same
            Assert.AreEqual(AManufacturer.Name, TestData);
        }

        [TestMethod]
        public void NamePropertyMinBlank()
        {
            //create an instance of the class
            clsManufacturer AManufacturer = new clsManufacturer();
            //boolean to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeManufacturer = "";
            //invoke the method
            OK = AManufacturer.Valid(SomeManufacturer);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NamePropertyMax()
        {
            //create an instance 
            clsManufacturer AManufacturer = new clsManufacturer();
            //create some test data
            string TestData = "llllllllllllllllllllllllllllllllllllllllllllllllll";
            //assign the data to the property
            AManufacturer.Name = TestData;
            //test to see if the values are the same
            Assert.AreEqual(AManufacturer.Name, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance 
            clsManufacturer AManufacturer = new clsManufacturer();
            //create some test data
            string TestData = "Apple@Apple.com";
            //assign the data to the property
            AManufacturer.Email = TestData;
            //test to see if the values are the same
            Assert.AreEqual(AManufacturer.Email, TestData);
        }

        [TestMethod]
        public void TelephonePropertyOK()
        {
            //create an instance 
            clsManufacturer AManufacturer = new clsManufacturer();
            //create some test data
            string TestData = "01234567891";
            //assign the data to the property
            AManufacturer.Telephone = TestData;
            //test to see if the values are the same
            Assert.AreEqual(AManufacturer.Telephone, TestData);
        }
    }

}
