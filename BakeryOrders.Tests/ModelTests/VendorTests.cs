using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrders.Models;
using System.Collections.Generic;
using System;

namespace BakeryOrders.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    //clear all instances between tests
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOf_Vendor()
    {
      Vendor newVendor = new Vendor("Margot's Marketplace", "Cafe and Market");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void CreatesNameAndDetails_String()
    {
      string name = "Margot's Marketplace";
      string description = "Cafe and Market";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      string result1 = newVendor.Description;
      Assert.AreEqual(name, result);
      Assert.AreEqual(description, result1);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Margot's Marketplace";
      string description = "Cafe and Market";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }   

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "Margot's Marketplace";
      string description1 = "Cafe and Market";
      string name2 = "Teddy's Taqueria";
      string description2 = "Food Cart";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }    

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Margot's Marketplace";
      string description1 = "Cafe and Market";
      string name2 = "Teddy's Taqueria";
      string description2 = "Food Cart";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }    

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string name = "Margot's Marketplace";
      string description = "Cafe and Market";
      Vendor newVendor = new Vendor(name, description);
      string details = "50 loaves";
      string title = "Margots market";
      string date = "march 10";
      decimal price = 40;
      Order newOrder = new Order(title, details, date, price);
      List<Order> newList = new List<Order> { newOrder };
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }    
  }
}