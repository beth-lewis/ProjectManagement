using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhonePalClassLibrary;

namespace PhonePalTest
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // creates an instance of the class
            clsStaff AStaff = new clsStaff();
            // test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]

        public void ActivePropertyOK()
        {
            // create an instance of the class
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            Boolean TestData = true;
            // assign the data to the property
            AStaff.Active = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AStaff.Active, TestData);
        }

        [TestMethod]

        public void AdminNoPropertyOK()
        {
            // create an instance of the class
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AStaff.AdminNo = TestData;
            // test to see the two values are the same
            Assert.AreEqual(AStaff.AdminNo, TestData);
        }

        [TestMethod]

        public void StaffNoPropertyOK()
        {
            // create an instance of the class
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AStaff.StaffNo = TestData;
            // test to see the two values are the same
            Assert.AreEqual(AStaff.StaffNo, TestData);
        }

        [TestMethod]

        public void FirstNamePropertyOK()
        {
            // create an instance of the class
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "Tom";
            // assign the data to the property
            AStaff.FirstName = TestData;
            // test to see the two values are the same
            Assert.AreEqual(AStaff.FirstName, TestData);
        }

        [TestMethod]

        public void SurnamePropertyOK()
        {
            // create an instance of the class
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "Jones";
            // assign the data to the property
            AStaff.Surname = TestData;
            // test to see the two values are the same
            Assert.AreEqual(AStaff.Surname, TestData);
        }

        [TestMethod]

        public void AddressLn1PropertyOK()
        {
            // create an instance of the class
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "153 Narborough Road";
            // assign the data to the property
            AStaff.AddressLn1 = TestData;
            // test to see the two values are the same
            Assert.AreEqual(AStaff.AddressLn1, TestData);
        }

        [TestMethod]

        public void AddressLn2PropertyOK()
        {
            // create an instance of the class
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "Leicester";
            // assign the data to the property
            AStaff.AddressLn2 = TestData;
            // test to see the two values are the same
            Assert.AreEqual(AStaff.AddressLn2, TestData);
        }

        [TestMethod]

        public void PostcodePropertyOK()
        {
            // create an instance of the class
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "LE30QW";
            // assign the data to the property
            AStaff.Postcode = TestData;
            // test to see the two values are the same
            Assert.AreEqual(AStaff.Postcode, TestData);
        }

        [TestMethod]

        public void EmailPropertyOK()
        {
            // create an instance of the class
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "tomJones@gmail";
            // assign the data to the property
            AStaff.Email = TestData;
            // test to see the two values are the same
            Assert.AreEqual(AStaff.Email, TestData);
        }

        [TestMethod]

        public void TelephoneNoPropertyOK()
        {
            // create an instance of the class
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "12345678901";
            // assign the data to the property
            AStaff.TelephoneNo = TestData;
            // test to see the two values are the same
            Assert.AreEqual(AStaff.TelephoneNo, TestData);
        }

    }
}
