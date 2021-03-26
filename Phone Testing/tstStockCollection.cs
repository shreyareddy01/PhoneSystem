using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phone_Testing;
using System.Collections.Generic;


namespace Phone_Testing
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {//create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Active = true;
            TestItem.StockId = 1;
            TestItem.DateOfOrder = DateTime.Now.Date;
                TestItem.ShipmentDate= DateTime.Now.Date;
            TestItem.SupplierID = 34;
            TestItem.NumberOfOrder = 46;
            TestItem.NumberShipped = 46;
            TestItem.Cost = 1690;
            TestItem.Productname = "Chocolate";
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void CountStockOK()
        {
            //Create the instance of class
            clsStockCollection AllStock = new clsStockCollection();
            Int32 Somecount = 0;
            AllStock.Count = Somecount;
            Assert.AreEqual(AllStock.Count, Somecount);
        }
        [TestMethod]
        public void ThisOrderStockOK()
        {
            //Create the instance of class
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.Active = true;
            TestStock.StockId = 1;
            TestStock.DateOfOrder = DateTime.Now.Date;
            TestStock.ShipmentDate = DateTime.Now.Date;
            TestStock.SupplierID = 34;
            TestStock.NumberOfOrder = 46;
            TestStock.NumberShipped = 46;
            TestStock.Cost = 1690;
            TestStock.Productname = "Chocolate";
            AllStock.ThisOrder = TestStock;
            Assert.AreEqual(AllStock.ThisOrder, TestStock);
        }
    }

    internal class List<T>
    {
        internal void Add(clsStock testItem)
        {
            throw new NotImplementedException();
        }
    }
}
