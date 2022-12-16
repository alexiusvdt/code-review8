using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrders.Models;
using System.Collections.Generic;
using System;

namespace BakeryOrders.Tests
{

  [TestClass]
  //idisposable extends Ordertest class and provides the interface for clearing between tests
  public class OrderTests 
  {
    // public void Dispose()
    // {
    //   Order.ClearAll();
    // }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("bread");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDetails_ReturnsDetails_String()
    {
      string details = "Seven items, 400$";
      Order newOrder = new Order(details);
      string result = newOrder.Details;
      Assert.AreEqual(details, result);
    }

    [TestMethod]
    public void SetDetails_SetDetails_String()
    {
      string details = "50 breads";
      Order newOrder = new Order(details);
      string updatedDetails = "20 pastries";
      newOrder.Details = updatedDetails;
      string result = newOrder.Details;
      Assert.AreEqual(updatedDetails, result);
    }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_OrderList()
    // {
    //   // Arrange
    //   List<Order> newList = new List<Order> {};

    //   // Act
    //   List<Order> result = Order.GetAll();

    //   // Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
    // [TestMethod]
    // public void GetAll_ReturnsOrders_OrderList()
    // {
    //   //Arrange
    //   string Details01 = "Walk the dog";
    //   string Details02 = "Wash the dishes";
    //   Order newOrder1 = new Order(Details01);
    //   Order newOrder2 = new Order(Details02);
    //   List<Order> newList = new List<Order> { newOrder1, newOrder2 };

    //   //Act
    //   List<Order> result = Order.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    //   public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    //   {
    //     //Arrange
    //     string Details = "Walk the dog.";
    //     Order newOrder = new Order(Details);

    //     //Act
    //     int result = newOrder.Id;

    //     //Assert
    //     Assert.AreEqual(1, result);
    //   }
      
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

