using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryBreadTests
  {
    [TestMethod]
    public void BakeryBread_CreatesAnInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadPurched_GetsQuanityOfBreadPurchased_int()
    {
      //Arrange
      int breadPurchased = 1;
      Bread newBread = new Bread(breadPurchased);
      //Act
      int breadPurchasedResult = newBread.BreadPurchased;
      //Assert
      Assert.AreEqual( breadPurchased, breadPurchasedResult );
    }
       [TestMethod]
    public void CostOfBread_ReturnsTheTotalCostOfOneAndTwoLoafs_int()
    {
      //Arrange
      int breadPurchased = 2;
      Bread newBread = new Bread(breadPurchased);
      //Act
      int BreadCostTotal = newBread.CostOfBread(breadPurchased);
      //Assert
      Assert.AreEqual(10, BreadCostTotal );
    }

        [TestMethod]
    public void CostOfBread_ReturnsTheTotalCostOfthreeBreadLoafs_int()
    {
      //Arrange
      int breadPurchased = 10;
      Bread newBread = new Bread(breadPurchased);
      //Act
      int BreadCostTotal = newBread.CostOfBread(breadPurchased);
      //Assert
      Assert.AreEqual(35, BreadCostTotal );
    }
  }
}