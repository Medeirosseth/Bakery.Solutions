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
    public void CostOfBread_ReturnsTheTotalCostOfOneAndTwoLoafs_int()
    {
      //Arrange
      int breadPurchased = 2;
      Bread newBread = new Bread(breadPurchased);
      //Act
      int BreadCostTotal = newBread.CostOfBread();
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
      int BreadCostTotal = newBread.CostOfBread();
      //Assert
      Assert.AreEqual(35, BreadCostTotal );
    }
  }

  public class BakeryPastryTests
  {
      [TestMethod]
    public void BakeryPastry_CreatsAnInstanceOfPastry_int()
    {
    
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

      [TestMethod]
    public void PastriesPurchased_CreatsAnInstanceOfPastry_int()
    {
      //Arrange
      int pastriesPurchased = 1;
      Pastry newPastry = new Pastry(pastriesPurchased);
      //Act
      int pastriesPurchasedResult = newPastry.PastriesPurchased;
      //Assert
      Assert.AreEqual(pastriesPurchasedResult, pastriesPurchased);
    }  

      [TestMethod]

      public void CostOfPastry_ReturnCostOfOneAndTwoPastriesPurchased_Int()
      {
        //Arrange
        int pastriesPurchased = 2;
        Pastry newPastry = new Pastry(pastriesPurchased);
        //Act
        int PastryCostTotal = newPastry.CostOfPastry();
        //Assert
        Assert.AreEqual(PastryCostTotal, pastriesPurchased);
      } 
  }


}