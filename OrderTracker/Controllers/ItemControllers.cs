using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName,string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      Console.WriteLine( newVendor);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      Vendor vendors = Vendor.Find(vendorId);
      Dictionary<string, object> vendorOrders = new Dictionary<string, object>();
      List<Order> orders = vendors.Orders;
      vendorOrders.Add("vendors", vendors);
      vendorOrders.Add("orders", orders);
      return View(vendorOrders);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor singleVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      singleVendor.AddOrder(newOrder);
      List<Order> vendorOrders = singleVendor.Orders;
      model.Add("Orders", vendorOrders);
      model.Add("vendor", singleVendor);
      return View("Show", model);
    }

  }
}
