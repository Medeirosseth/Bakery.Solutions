using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace BakeryPastry.Tests
{
  [TestClass]
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
        int PastryCostTotal = newPastry.CostOfPastry(pastriesPurchased);
        //Assert
        Assert.AreEqual(4, PastryCostTotal);
      } 

      [TestMethod]

      public void CostOfPastry_ReturnCostOfThreePastries_int()
      {
        //Arrange
        int pastriesPurchased = 6;
        Pastry newPastry = new Pastry(pastriesPurchased);
        //Act
        int PastryCostTotal = newPastry.CostOfPastry(pastriesPurchased);
        //Assert
        Assert.AreEqual(10, PastryCostTotal);
      }

      [TestMethod]

      public void CostOfPastry_ReturnCostOfPastryThatIncludesAddTheRemainderAfterThreeModulo()
      {
        //Arrange
        int pastriesPurchased = 10;
        Pastry newPastry = new Pastry(pastriesPurchased);
        //Act
        int PastryCostTotal = newPastry.CostOfPastry(pastriesPurchased);
        //Assert
        Assert.AreEqual(17, PastryCostTotal);
      }
  }
}