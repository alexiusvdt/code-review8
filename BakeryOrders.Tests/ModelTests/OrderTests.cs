using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrders.Models;
using System.Collections.Generic;
using System;

namespace BakeryOrders.Tests
{

  [TestClass]
  //idisposable extends Ordertest class and provides the interface for clearing between tests
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Margots market", "50 loaves", "march 10", 40 );
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDetails_ReturnsDetails_String()
    {
      string details = "50 loaves";
      string title = "Margots market";
      string date = "march 10";
      decimal price = 40;
      Order newOrder = new Order(title, details, date, price);
      string result1 = newOrder.Details;
      string result2 = newOrder.Title;
      string result3 = newOrder.Date;
      decimal result4 = newOrder.Price;
      Assert.AreEqual(details, result1);
      Assert.AreEqual(title, result2);
      Assert.AreEqual(date, result3);
      Assert.AreEqual(price, result4);
    }

    [TestMethod]
    public void SetDetails_SetDetails_String()
    {
      string details = "50 loaves";
      string title = "Margots market";
      string date = "march 10";
      decimal price = 40;
      Order newOrder = new Order(title, details, date, price);
      string updatedDetails = "20 pastries";
      newOrder.Details = updatedDetails;
      string result = newOrder.Details;
      Assert.AreEqual(updatedDetails, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string details1 = "50 loaves";
      string title1 = "Margots market";
      string date1 = "march 10";
      decimal price1 = 40.00M;
      string details2 = "20 loaves";
      string title2 = "Amy's Atrium";
      string date2 = "march 12";
      decimal price2 = 62.12M;
      Order newOrder1 = new Order(title1, details1, date1, price1);
      Order newOrder2 = new Order(title2, details2, date2, price2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
      public void GetId_InstantiatesIdAndReturns_Int()
      {
        string details = "50 loaves";
        string title = "Margots market";
        string date = "march 10";
        decimal price = 40.18M;
        Order newOrder = new Order(title, details, date, price);
        int result = newOrder.Id;
        Assert.AreEqual(1, result);
      }
      
    //   [TestMethod]
    //   public void Find_ReturnsCorrectOrder_Order()
    //   {
    //     //Arrange
    //     string Details01 = "Walk the dog";
    //     string Details02 = "Wash the dishes";
    //     Order newOrder1 = new Order(Details01);
    //     Order newOrder2 = new Order(Details02);

    //     //Act
    //     Order result = Order.Find(2);

    //     //Assert
    //     Assert.AreEqual(newOrder2, result);
    //   }
    }
}

