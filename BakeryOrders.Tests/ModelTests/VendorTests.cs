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

  //   [TestMethod]
  //   public void GetAll_ReturnsAllVendorObjects_VendorList()
  //   {
  //     //Arrange
  //     string name01 = "Work";
  //     string name02 = "School";
  //     Vendor newVendor1 = new Vendor(name01);
  //     Vendor newVendor2 = new Vendor(name02);
  //     List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

  //     //Act
  //     List<Vendor> result = Vendor.GetAll();

  //     //Assert
  //     CollectionAssert.AreEqual(newList, result);
  //   }    
  //   [TestMethod]
  //   public void Find_ReturnsCorrectVendor_Vendor()
  //   {
  //     //Arrange
  //     string name01 = "Work";
  //     string name02 = "School";
  //     Vendor newVendor1 = new Vendor(name01);
  //     Vendor newVendor2 = new Vendor(name02);

  //     //Act
  //     Vendor result = Vendor.Find(2);

  //     //Assert
  //     Assert.AreEqual(newVendor2, result);
  //   }    
  //   [TestMethod]
  //   public void AddItem_AssociatesItemWithVendor_ItemList()
  //   {
  //     //Arrange
  //     string description = "Walk the dog.";
  //     Item newItem = new Item(description);
  //     List<Item> newList = new List<Item> { newItem };
  //     string name = "Work";
  //     Vendor newVendor = new Vendor(name);
  //     newVendor.AddItem(newItem);

  //     //Act
  //     List<Item> result = newVendor.Items;

  //     //Assert
  //     CollectionAssert.AreEqual(newList, result);
    // }    
  }
}