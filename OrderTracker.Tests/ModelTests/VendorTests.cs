using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable 
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Vendor", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetNameAndDescription_ReturnNameAndDescription_StringString()
    {
      string description = "no";
      string name = "go";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name,result);
    }

    [TestMethod]
    public void GetId_ReturnID_int()
    {
      string description = "no";
      string name = "go";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1,result);
    }

    [TestMethod]
    public void GetAll_ReturnVendorObjects_VendorList()
    {
      string description = "description";
      string description1 = "description1";
      string name = "name";
      string name1 = "name1";
      Vendor newVendor = new Vendor(name, description);
      Vendor newVendor1 = new Vendor(name1, description1);
      List<Vendor> newList = new List<Vendor> { newVendor, newVendor1 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnVendor_Vendor()
    {
      string name = "name";
      string name1 = "name1";
      string description = "description";
      string description1 = "description1";
      Vendor newVendor = new Vendor(name, description);
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor result = Vendor.Find(1);
      Assert.AreEqual(newVendor1, result);
    }

    [TestMethod]
    public void AddOrder_AddsOrderToVendor_OrderList()
    {
      string description = "description";
      string name = "name";
      int price = 2;
      string date = "date";
      Order newOrder = new Order(name, date, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string vendorDescription = "description";
      string vendorName = "name";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);
      List<Vendor> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}