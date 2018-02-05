using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhonePalTest
{
    [TestClass]
    public class tstAccessory
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsAccessory AnAccessory = new clsAccessory();
            //test to see that it exists
            Assert.IsNotNull(AnAccessory);
        }

        [TestMethod]
        public void ActivePropertyOk()
        {
            //create an instance of the class we want to create 
            clsAccessory AnAccessory = new clsAccessory();
            //create some test data to assign to property
            Boolean TestData = true;
            //assign the data to the property 
            AnAccessory.Active = TestData;
            //test to see the two values are the same 
            Assert.AreEqual(AnAccessory.Active, TestData);
        }



    }
}
