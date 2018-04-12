using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace PhonePalTest.Manufacturer
{
    [TestClass]
    public class tstManufacturerCollection
    {
        [TestMethod]
        public void InstanceOKCollection()
        {
            //create an instance of the class
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //test to see if it exists
            Assert.IsNotNull(AllManufacturers);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 1;
            //assign the data to the property
            AllManufacturers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllManufacturers.Count, SomeCount);
        }

        [TestMethod]
        public void AllManufacturersOK()
        {
            //create an instance of the class
            clsManufacturerCollection Manufacturers = new clsManufacturerCollection();
            //create some test data to assign to the property
            List<clsManufacturer> TestList = new List<clsManufacturer>();
            //add an item to the list
            //create an item of the test data
            clsManufacturer TestItem = new clsManufacturer();
            //set its properties
            TestItem.ManufacturerNo = 1;
            TestItem.Name = "Apple";
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            Manufacturers.AllManufacturers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Manufacturers.AllManufacturers, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class
            clsManufacturerCollection Manufacturers = new clsManufacturerCollection();
            //create some test data to assign to the property
            List<clsManufacturer> TestList = new List<clsManufacturer>();
            //add an item to the list
            //create an item of the test data
            clsManufacturer TestItem = new clsManufacturer();
            //set its properties
            TestItem.ManufacturerNo = 1;
            TestItem.Name = "Apple";
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            Manufacturers.AllManufacturers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Manufacturers.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoManufacturersPresent()
        {
            //create an instance of the class
            clsManufacturerCollection Manufacturers = new clsManufacturerCollection();
            //test to see that the two values are the same
            Assert.AreEqual(Manufacturers.Count, 2);
        }
    }
}