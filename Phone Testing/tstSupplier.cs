using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Phone_Testing
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(AnSupplier);

        }

        [TestMethod]
        public void ActiveSupplierOk()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the Supplier
            Boolean TestData = true;
            //assign the data to the Supplier
            AnSupplier.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.Active, TestData);
        }
        [TestMethod]
        public void AddSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the Supplier
            Boolean TestData = true;
            //assign the data to the Supplier
            AnSupplier.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.Active, TestData);
        }
        public void SupplierNameOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the Supplier
            string TestData = "Some SupplierName";
            //assign the data to the Supplier
            AnSupplier.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierName, TestData);
        }
        public void TownSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the Supplier
            string TestData = "London";
            //assign the data to the Supplier
            AnSupplier.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.Town, TestData);
        }

    }
}
