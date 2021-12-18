using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable 
  {

    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test Order", "description", 4, "");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string Title = "Title";
      Order newOrder = new Order(Title, "description", 4, "");
      string result = newOrder.Title;
      Assert.AreEqual(Title, result);

    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string Title = "title";
      string Description = "Description";
      Order newOrder = new Order(Title, Description, 4, "");
      string result = newOrder.Description;
      Assert.AreEqual(Description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPrice_String()
    {
      string Title = "title";
      string Description = "Description";
      int Price = 1;
      Order newOrder = new Order(Title, Description, Price, "");
      int result = newOrder.Price;
      Assert.AreEqual(Price, result);
    }

    [TestMethod]
    public void GetDate_ReturnDate_String()
    {
      string Title = "title";
      string Description = "Description";
      int Price = 1;
      string Date = "date";
      Order newOrder = new Order(Title, Description, Price, Date);
      int result = newOrder.Price;
      Assert.AreEqual(Price, result);
    }

    [TestMethod]
    public void GetAll_ReturnEmptyList_ItemList()
    {
      List<Order> newOrder = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrder, result);
    
    }

    [TestMethod]
    public void GetAll_ReturnOrders_OrderList()
    {
    string Title = "title";
      string Description = "Description";
      int Price = 1;
      string Date = "Date";
      string Title1 = "title1";
      string Description1 = "Description1";
      int Price1 = 2;
      string Date1 = "Date1";
      Order newOrder = new Order(Title, Description, Price, Date);
      Order newOrder1 = new Order(Title1, Description1, Price1, Date1);
      List<Order> orderList = new List<Order> {newOrder,newOrder1};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(orderList, result);
    }

    }

  }
