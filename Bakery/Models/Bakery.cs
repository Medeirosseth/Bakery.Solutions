using System;
namespace Bakery.Models

{

  public class Bread
  {
    
  
    public int BreadPurchased { get; set; }
    public Bread(int breadPurchased)
    {
      BreadPurchased = breadPurchased;

    }
        public int CostOfBread()
    {
     if (BreadPurchased < 3 ) 
     {
       int BreadCostTotal = (BreadPurchased * 5);
       return BreadCostTotal;
     }
     else
     {
       return BreadPurchased;
     }
    }
  }
}