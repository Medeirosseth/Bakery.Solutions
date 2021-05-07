using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryPastry.Models;

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
        int pastriesPurchased = 123;
        Pastry newPastry = new Pastry(pastriesPurchased);
        //Act
        int PastryCostTotal = newPastry.CostOfPastry();
        //Assert
        Assert.AreEqual(5, PastryCostTotal);
      } 
  }
}