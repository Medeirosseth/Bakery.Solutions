using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
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

    public void CostOfBread_ReturnsTheTotalCostOfOneBread_int()
    {
      //Arrange
      int breadPurchased = 1;
      Bread newBread = new Bread(breadPurchased);
      //Act
      int BreadCostTotal = newBread.CostOfBread();
      //Assert
      Assert.AreEqual(5, BreadCostTotal );

    }

        [TestMethod]

    public void CostOfBread_ReturnsTheTotalCostOfthreeBreadLoafs_int()
    {
      //Arrange
      int breadPurchased = 3;
      Bread newBread = new Bread(breadPurchased);
      //Act
      int BreadCostTotal = newBread.CostOfBread();
      //Assert
      Assert.AreEqual(10, BreadCostTotal );

    }

  }
}